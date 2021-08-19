using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace F3DSharp
{
    public class F3DEX095
    {

        private const UInt32 gDrawTri1 = 0xBF000000;
        private const UInt32 gDrawTri2 = 0xB1000000;
        private const UInt32 gLoadVert = 0x04000000;
        private const UInt32 gDisplayList = 0x06000000;
        private const UInt32 gEndDisplayList = 0xB8000000;
        private const UInt32 gLoadBlock = 0xF3000000;
        private const UInt32 gSetTile = 0xF5000000;
        private const UInt32 gSetTImage = 0xFD000000;
        private const UInt32 gSetCImage = 0xFF000000;
        private const UInt32 gRDPTileSync = 0xE8000000;
        private const UInt32 gRDPLoadSync = 0xE8000000;

        public enum ImageFormats : byte
        {
            G_IM_FMT_RGBA = 0,
            G_IM_FMT_YUV = 1,
            G_IM_FMT_CI = 2,
            G_IM_FMT_IA = 3,
            G_IM_FMT_I = 4,
        }
        public enum BitSizes : byte
        {
            Bit4 = 0,
            Bit8 = 1,
            Bit16 = 2,
            Bit32 = 3
        }


        public uint[] GetIndexes(int IndexA, int IndexB, int IndexC)
        {
            return new uint[] { Convert.ToUInt32(IndexA), Convert.ToUInt32(IndexB), Convert.ToUInt32(IndexC) };
        }
        public byte[] BigEndian(byte[] Input)
        {
            Array.Reverse(Input);
            return Input;
        }
        public UInt32 TXL2WORDS(UInt32 Txls, UInt32 BTxl)
        {
            return Math.Max(1, ((Txls) * (BTxl) / 8));
        }
        public UInt32 CALCDXT(UInt32 Width, UInt32 BTxl)
        {
            return (((1 << 11) + TXL2WORDS(Width, BTxl) - 1) / (TXL2WORDS(Width, BTxl)));
        }



        public byte[] gsSP1Triangle(uint[] VertIndexes)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(gDrawTri1))
                );

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Convert.ToUInt32((VertIndexes[2] * 2 << 16) | (VertIndexes[1] * 2 << 8) | (VertIndexes[0] * 2))))
                );

            return memoryStream.ToArray();
        }

        public byte[] gsSP2Triangles(uint[] VertIndexesA, uint[] VertIndexesB)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);


            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Convert.ToUInt32(gDrawTri2 | (VertIndexesA[2] * 2 << 16) | (VertIndexesA[1] * 2 << 8) | (VertIndexesA[0] * 2))))
                );

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Convert.ToUInt32((VertIndexesB[2] * 2 << 16) | (VertIndexesB[1] * 2 << 8) | (VertIndexesB[0] * 2))))
                );

            return memoryStream.ToArray();
        }

        public byte[] gsSPDisplayList(uint Address)
        {
            return BigEndian(
                BitConverter.GetBytes(gDisplayList | Address)
                );
        }

        public byte[] gsSPEndDisplayList()
        {
            return BigEndian(
                BitConverter.GetBytes(gEndDisplayList)
                );
        }


        public byte[] gsSPVertex(uint Address, uint Count, uint Index)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);


            binaryWriter.Write(BigEndian(
            BitConverter.GetBytes(Convert.ToUInt32(gLoadVert | (Index * 2) << 16) | (Count << 10) | ((0x10 * Count) - 1))
            ));

            binaryWriter.Write(BigEndian(
            BitConverter.GetBytes(Address)
            ));

            return memoryStream.ToArray();
        }

        public byte[] gsDPSetTile(ImageFormats Format, BitSizes Size, UInt32 Line, UInt32 TMem, UInt32 Tile, UInt32 Palette, UInt32 CMT, UInt32 MaskT, UInt32 ShiftT, UInt32 CMS, UInt32 MaskS, UInt32 ShiftS)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Convert.ToUInt32(gSetTile | (((uint)Format & 0x7) << 21) | ((uint)Size & 0x3) << 19) | ((Line & 0x1FF) << 9) | (TMem & 0x1FF))
                ));

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Convert.ToUInt32(((Tile & 0x03) << 24) | ((Palette & 0x7) << 20) | ((CMT & 0x03) << 18) | ((MaskT & 0x7) << 14) |
                ((ShiftT & 0x7) << 10) | ((CMS & 0x03) << 8) | ((MaskS & 0x7) << 4) | ((ShiftS & 0x7))))
                ));

            return memoryStream.ToArray();

        }
        public byte[] gsDPTileSync()
        {
            return BigEndian(
                BitConverter.GetBytes(gRDPTileSync)
                );
        }
        public byte[] gsDPLoadSync()
        {
            return BigEndian(
                BitConverter.GetBytes(gRDPLoadSync)
                );
        }

        public byte[] gsDPLoadBlock(UInt32 Tile, UInt32 ULS, UInt32 ULT, UInt32 LRS, UInt32 DXT)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Convert.ToUInt32(gLoadBlock | ((ULS & 0xFFF) << 12) | (ULT & 0xFFF)))
                ));

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Convert.ToUInt32(((Tile & 0x03) << 24) | ((Math.Min(LRS, 2047) & 0xFFF) << 12) | (DXT & 0xFFF)))
                ));

            return memoryStream.ToArray();
        }

        public byte[] gsSetImage(UInt32 Command, ImageFormats Format, BitSizes Size, uint Width, UInt32 Address)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(BigEndian(
            BitConverter.GetBytes(Convert.ToUInt32(Command | ((uint)Format << 21) | ((uint)Size << 19) | Width - 1))
            ));

            binaryWriter.Write(BigEndian(
            BitConverter.GetBytes(Address)
            ));


            return memoryStream.ToArray();
        }

        public byte[] gsDPSetColorImage(ImageFormats Format, BitSizes Size, uint Width, UInt32 Address)
        {
            return gsSetImage(gSetCImage, Format, Size, Width, Address);
        }
        public byte[] gsDPSetTextureImage(ImageFormats Format, BitSizes Size, uint Width, UInt32 Address)
        {
            return gsSetImage(gSetTImage, Format, Size, Width, Address);
        }


        public byte[] gsNinLoadTextureImage(UInt32 TextureAddress, ImageFormats TextureFormat, BitSizes Size, uint Width, uint Height, uint TextureMemory, uint Tile)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(
                gsDPSetTextureImage(TextureFormat, Size, Width, TextureAddress)
                );

            binaryWriter.Write(
                gsDPTileSync()
                ); ;

            binaryWriter.Write(
                gsDPSetTile(TextureFormat, Size, 0, TextureMemory, Tile, 0, 0, 0, 0, 0, 0, 0)
                );

            binaryWriter.Write(
                gsDPLoadSync()
                ); ;

            binaryWriter.Write(
                gsDPLoadBlock(Tile, 0, 0, ((Width * Height) - 1), CALCDXT(Width, (uint)Size))
                );

            return memoryStream.ToArray();
        }
    }
}
