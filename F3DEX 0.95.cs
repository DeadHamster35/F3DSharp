using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace F3DSharp
{
    public class F3DEX095
    {


        public enum ImageFormats : byte
        {
            G_IM_FMT_RGBA = 0,
            G_IM_FMT_YUV = 1,
            G_IM_FMT_CI = 2,
            G_IM_FMT_IA = 3,
            G_IM_FMT_I = 4
        }
        public enum BitSizes : byte
        {
            G_IM_SIZ_4b = 0,
            G_IM_SIZ_8b = 1,
            G_IM_SIZ_16b = 2,
            G_IM_SIZ_32b = 3,
            G_IM_SIZ_DD = 5
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

        public byte[] gsSP1Triangle_w1(uint[] VertIndexes)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Convert.ToUInt32((((VertIndexes[2] * 2) & 0xF) << 16) | (((VertIndexes[1] * 2) & 0xF) << 8) | ((VertIndexes[0] * 2) & 0xF)))
                ));

            return memoryStream.ToArray();
        }

        public byte[] gsSP1Triangle(uint[] VertIndexes)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(F3DEX095_OpCodes.G_TRI1))
                );

            binaryWriter.Write(
                gsSP1Triangle_w1(VertIndexes)
                );

            return memoryStream.ToArray();
        }

        public byte[] gsSP2Triangles(uint[] VertIndexesA, uint[] VertIndexesB)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);


            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Convert.ToUInt32(F3DEX095_OpCodes.G_TRI2 | BitConverter.ToUInt32(BigEndian(gsSP1Triangle_w1(VertIndexesB)), 0)))
                ));

            binaryWriter.Write(
                gsSP1Triangle_w1(VertIndexesB)
                );



            return memoryStream.ToArray();
        }

        public byte[] gsSPDisplayList(uint Address)
        {
            return BigEndian(
                BitConverter.GetBytes(F3DEX095_OpCodes.G_DL | Address)
                );
        }

        public byte[] gsSPEndDisplayList()
        {
            return BigEndian(
                BitConverter.GetBytes(F3DEX095_OpCodes.G_ENDDL)
                );
        }


        public byte[] gsDma1p(UInt32 Command, UInt32 S, UInt32 L, UInt32 P)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);


            binaryWriter.Write(BigEndian(
            BitConverter.GetBytes(Convert.ToUInt32(Command | (P & 0xF) << 16) | (L & 0xFF))
            ));

            binaryWriter.Write(BigEndian(
            BitConverter.GetBytes(S)
            ));

            return memoryStream.ToArray();
        }

        public byte[] gsSPVertex(UInt32 Address, UInt32 Count, UInt32 Index)
        {
            return gsDma1p(F3DEX095_OpCodes.G_VTX, Address, ((Count) << 10) | ((Count * 0x10) - 1), (Index * 2));
        }

        public byte[] gsDPSetTile(ImageFormats Format, BitSizes Size, UInt32 Line, UInt32 TMem, UInt32 Tile, UInt32 Palette, UInt32 CMT, UInt32 MaskT, UInt32 ShiftT, UInt32 CMS, UInt32 MaskS, UInt32 ShiftS)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Convert.ToUInt32(F3DEX095_OpCodes.G_SETTILE | (((uint)Format & 0x7) << 21) | ((uint)Size & 0x3) << 19) | ((Line & 0x1FF) << 9) | (TMem & 0x1FF))
                ));

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Convert.ToUInt32(((Tile & 0x7) << 24) | ((Palette & 0xF) << 20) | ((CMT & 0x3) << 18) | ((MaskT & 0xF) << 14) |
                ((ShiftT & 0xF) << 10) | ((CMS & 0x3) << 8) | ((MaskS & 0xF) << 4) | ((ShiftS & 0xF))))
                ));

            return memoryStream.ToArray();

        }
        

        public byte[] gsDPTileSync()
        {
            return BigEndian(
                BitConverter.GetBytes(F3DEX095_OpCodes.G_RDPTILESYNC)
                );
        }
        public byte[] gsDPLoadSync()
        {
            return BigEndian(
                BitConverter.GetBytes(F3DEX095_OpCodes.G_RDPLOADSYNC)
                );
        }

        public byte[] gsDPLoadBlock(UInt32 Tile, UInt32 ULS, UInt32 ULT, UInt32 LRS, UInt32 DXT)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Convert.ToUInt32(F3DEX095_OpCodes.G_LOADBLOCK | ((ULS & 0xFFF) << 12) | (ULT & 0xFFF)))
                ));

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Convert.ToUInt32(((Tile & 0x7) << 24) | ((Math.Min(LRS, 2047) & 0xFFF) << 12) | (DXT & 0xFFF)))
                ));

            return memoryStream.ToArray();
        }

        public byte[] gsDPLoadTileGeneric(UInt32 Command, UInt32 Tile, UInt32 ULS, UInt32 ULT, UInt32 LRS, UInt32 LRT)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);


            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Command | ((ULS & 0xFFF) << 12) | ((ULT & 0xFFF) << 12))
                ));

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes( ((Tile & 0x7) << 24) | ((LRS & 0xFFF) << 12) | (LRT & 0xFFF) )
                )) ;

            return memoryStream.ToArray();
        }

        public byte[] gsDPSetTileSize(UInt32 Tile, UInt32 ULS, UInt32 ULT, UInt32 LRS, UInt32 LRT)
        {
            return gsDPLoadTileGeneric(F3DEX095_OpCodes.G_SETTILESIZE, Tile, ULS, ULT, LRS, LRT);
        }



        public byte[] gsSetImage(UInt32 Command, ImageFormats Format, BitSizes Size, uint Width, UInt32 Address)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(BigEndian(
            BitConverter.GetBytes(Convert.ToUInt32(Command | (((uint)Format & 0x7) << 21) | (((uint)Size & 0x3) << 19) | (Width & 0xFFF) - 1))
            ));

            binaryWriter.Write(BigEndian(
            BitConverter.GetBytes(Address)
            ));


            return memoryStream.ToArray();
        }

        public byte[] gsDPSetColorImage(ImageFormats Format, BitSizes Size, uint Width, UInt32 Address)
        {
            return gsSetImage(F3DEX095_OpCodes.G_SETCIMG, Format, Size, Width, Address);
        }
        public byte[] gsDPSetTextureImage(ImageFormats Format, BitSizes Size, uint Width, UInt32 Address)
        {
            return gsSetImage(F3DEX095_OpCodes.G_SETTIMG, Format, Size, Width, Address);
        }
        
        public byte[] gsNinSetupTileDescription(UInt32 TextureAddress, ImageFormats TextureFormat, BitSizes Size, uint Width, uint Height, uint TextureMemory, uint Tile, uint CS, uint MS, uint SS, uint CT, uint MT, uint ST)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
            
            binaryWriter.Write(
                gsDPTileSync()
                );
            
            binaryWriter.Write(
                gsDPSetTile(TextureFormat, Size,  ((Width * F3DEX095_Parameters.G_IM_ArrayLineBytes[(int)Size]) + 7) >> 3, TextureMemory, Tile, 0, CT, MT, ST, CS, MS, SS)
            );

            binaryWriter.Write(
                gsDPSetTileSize(Tile, 0, 0, (Width - 1) << (int)F3DEX095_Parameters.G_TEXTURE_IMAGE_FRAC, (Height - 1) << (int)F3DEX095_Parameters.G_TEXTURE_IMAGE_FRAC)
            );
            
            return memoryStream.ToArray();
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
