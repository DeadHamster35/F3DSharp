using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace F3DSharp
{
    public class F3DEX095
    {


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

        public UInt32 GCCc0w0(UInt32 saRGB0, UInt32 mRGB0, UInt32 saA0, UInt32 mA0)
        {
            return Convert.ToUInt32(Convert.ToUInt32((saRGB0 & 0xF) << 20) | Convert.ToUInt32((mRGB0 & 0x1F) << 15) | Convert.ToUInt32((saA0 & 0x7) << 12) | Convert.ToUInt32((mA0 & 0x7) << 9));
        }

        public UInt32 GCCc1w0(UInt32 saRGB1, UInt32 mRGB1)                        
        {
            return Convert.ToUInt32(Convert.ToUInt32((saRGB1 & 0xF) << 5) | Convert.ToUInt32(mRGB1 & 0x1F));
        }

        public UInt32 GCCc0w1(UInt32 sbRGB0, UInt32 aRGB0, UInt32 sbA0, UInt32 aA0)
        {
            return Convert.ToUInt32(Convert.ToUInt32((sbRGB0 & 0xF) << 28) | Convert.ToUInt32((aRGB0 & 0x7) << 15) | Convert.ToUInt32((sbA0 & 0x7) << 12) | Convert.ToUInt32((aA0 & 0x7) << 9));
        }

        public UInt32 GCCc1w1(UInt32 sbRGB1, UInt32 saA1, UInt32 mA1, UInt32 aRGB1, UInt32 sbA1, UInt32 aA1)
        {
            return Convert.ToUInt32(Convert.ToUInt32((sbRGB1 & 0xF) << 24) | Convert.ToUInt32((saA1 & 0x7) << 21) | Convert.ToUInt32((mA1 & 0x7) << 18) | Convert.ToUInt32((aRGB1 & 0x7) << 6) | Convert.ToUInt32((sbA1 & 0x7) << 3) | Convert.ToUInt32(aA1 & 0x7));
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
        
        public byte[] gsDPSetTile(F3DEX095_Parameters.ImageFormats Format, F3DEX095_Parameters.BitSizes Size, UInt32 Line, UInt32 TMem, UInt32 Tile, UInt32 Palette, UInt32 CMT, UInt32 MaskT, UInt32 ShiftT, UInt32 CMS, UInt32 MaskS, UInt32 ShiftS)
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

        public byte[] gsSPTexture( UInt32 S, UInt32 T, UInt32 Level, UInt32 Tile, UInt32 OnFlag)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(F3DEX095_OpCodes.G_TEXTURE | Convert.ToUInt32((Level & 0x7) << 11) | Convert.ToUInt32((Tile & 0x7) << 8) | Convert.ToUInt32((OnFlag & 0xFF) << 11) )
                ));
            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Convert.ToUInt32( ( S & 0xFFFF) << 16) | (T & 0xFFFF))
                ));

            return memoryStream.ToArray();
        }

        public byte[] gsSPSetOtherMode(UInt32 Command, UInt32 Soft, UInt32 Len, UInt32 Data)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Command | Convert.ToUInt32(((32 - (Soft) - (Len)) & 0xF) << 8) | Convert.ToUInt32((Len - 1) & 0xF))
                ));

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Data)
                ));

            return memoryStream.ToArray();
        }

        public byte[] gsDPPipeSync()
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(BigEndian(
                    BitConverter.GetBytes(Convert.ToUInt32(F3DEX095_OpCodes.G_RDPPIPESYNC))
                ));

            return memoryStream.ToArray();
        }

        public byte[] gsDPSetRenderMode(UInt32 ModeA, UInt32 ModeB)
        {
            return gsSPSetOtherMode(F3DEX095_OpCodes.G_SETOTHERMODE_L, F3DEX095_Parameters.G_MDSFT_RENDERMODE, 29, ModeA | ModeB);
        }

        public byte[] gsDPSetCombineLERP(UInt32[] GCCA, UInt32[] GCCB)
        {

            //UInt32 a0, UInt32 b0, UInt32 c0, UInt32 d0, UInt32 Aa0, UInt32 Ab0, UInt32 Ac0, UInt32 Ad0 ----GCCA
            //UInt32 a1, UInt32 b1, UInt32 c1, UInt32 d1, UInt32 Aa1, UInt32 Ab1, UInt32 Ac1, UInt32 Ad1 ----GCCB
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
            F3DEX095_Parameters Parameters = new F3DEX095_Parameters();
            
            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(F3DEX095_OpCodes.G_SETCOMBINE | Convert.ToUInt32( (GCCc0w0(Parameters.ColorCombineModes[GCCA[0]], Parameters.ColorCombineModes[GCCA[2]], Parameters.AlphaCombineModes[GCCA[4]], Parameters.AlphaCombineModes[GCCA[6]] ) | GCCc1w0(Parameters.ColorCombineModes[GCCB[0]], Parameters.ColorCombineModes[GCCB[2]])) & 0xFFFFFF ) )
                ));

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Convert.ToUInt32( GCCc0w1(Parameters.ColorCombineModes[GCCA[1]], Parameters.ColorCombineModes[GCCA[3]], Parameters.AlphaCombineModes[GCCA[5]], Parameters.AlphaCombineModes[GCCA[7]]) | GCCc1w1( Parameters.ColorCombineModes[GCCB[1]], Parameters.ColorCombineModes[GCCB[4]], Parameters.ColorCombineModes[GCCB[6]], Parameters.ColorCombineModes[GCCB[3]], Parameters.ColorCombineModes[GCCB[5]], Parameters.ColorCombineModes[GCCB[5]]) ) )
                ));

            return memoryStream.ToArray();

        }

        public byte[] gsDPSetCombineMode(UInt32[] ModeA, UInt32[] ModeB)
        {
            return gsDPSetCombineLERP(ModeA, ModeB);
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

        public byte[] gsSPClearGeometryMode(UInt32 Mode)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Convert.ToUInt32(F3DEX095_OpCodes.G_SETGEOMETRYMODE | Mode) )
                ));

            return memoryStream.ToArray();
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



        public byte[] gsSetImage(UInt32 Command, F3DEX095_Parameters.ImageFormats Format, F3DEX095_Parameters.BitSizes Size, uint Width, UInt32 Address)
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

        public byte[] gsDPSetColorImage(F3DEX095_Parameters.ImageFormats Format, F3DEX095_Parameters.BitSizes Size, uint Width, UInt32 Address)
        {
            return gsSetImage(F3DEX095_OpCodes.G_SETCIMG, Format, Size, Width, Address);
        }
        public byte[] gsDPSetTextureImage(F3DEX095_Parameters.ImageFormats Format, F3DEX095_Parameters.BitSizes Size, uint Width, UInt32 Address)
        {
            return gsSetImage(F3DEX095_OpCodes.G_SETTIMG, Format, Size, Width, Address);
        }
        
        public byte[] gsNinSetupTileDescription(UInt32 TextureAddress, F3DEX095_Parameters.ImageFormats TextureFormat, F3DEX095_Parameters.BitSizes Size, uint Width, uint Height, uint TextureMemory, uint Tile, uint CS, uint MS, uint SS, uint CT, uint MT, uint ST)
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
        public byte[] gsNinLoadTextureImage(UInt32 TextureAddress, F3DEX095_Parameters.ImageFormats TextureFormat, F3DEX095_Parameters.BitSizes Size, uint Width, uint Height, uint TextureMemory, uint Tile)
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
