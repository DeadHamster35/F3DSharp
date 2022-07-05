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

        public byte[] BigEndian(Double Value)
        {
            byte[] Input = BitConverter.GetBytes(Value);
            Array.Reverse(Input);
            return Input;
        }
        public byte[] BigEndian(Single Value)
        {
            byte[] Input = BitConverter.GetBytes(Value);
            Array.Reverse(Input);
            return Input;
        }
        public byte[] BigEndian(UInt16 Value)
        {
            byte[] Input = BitConverter.GetBytes(Value);
            Array.Reverse(Input);
            return Input;
        }
        public byte[] BigEndian(UInt32 Value)
        {
            byte[] Input = BitConverter.GetBytes(Value);
            Array.Reverse(Input);
            return Input;
        }
        public byte[] BigEndian(Int16 Value)
        {
            byte[] Input = BitConverter.GetBytes(Value);
            Array.Reverse(Input);
            return Input;
        }
        public byte[] BigEndian(Int32 Value)
        {
            byte[] Input = BitConverter.GetBytes(Value);
            Array.Reverse(Input);
            return Input;
        }
        public byte[] BigEndian(Int64 Value)
        {
            byte[] Input = BitConverter.GetBytes(Value);
            Array.Reverse(Input);
            return Input;
        }
        public byte[] BigEndian(UInt64 Value)
        {
            byte[] Input = BitConverter.GetBytes(Value);
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
        public UInt32 TXL2WORDS_4b(UInt32 Txls)
        {
            return Math.Max(1, ((Txls) / 16));
        }
        public UInt32 CALCDXT_4b(UInt32 Width)
        {
            return (((1 << 11) + TXL2WORDS_4b(Width) - 1) / (TXL2WORDS_4b(Width)));
        }
        /*
#define TXL2WORDS(txls, b_txl)	MAX(1, ((txls)*(b_txl)/8))
#define CALC_DXT(width, b_txl)	\
        (((1 << G_TX_DXT_FRAC) + TXL2WORDS(width, b_txl) - 1) / \
					TXL2WORDS(width, b_txl))

#define TXL2WORDS_4b(txls)	MAX(1, ((txls)/16))
#define CALC_DXT_4b(width)	\
		(((1 << G_TX_DXT_FRAC) + TXL2WORDS_4b(width) - 1) / \
					TXL2WORDS_4b(width))
        */

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
                BitConverter.GetBytes(Convert.ToUInt32((((VertIndexes[2] * 2) & 0xFF) << 16) | (((VertIndexes[1] * 2) & 0xFF) << 8) | ((VertIndexes[0] * 2) & 0xFF)))
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
                BitConverter.GetBytes(Convert.ToUInt32(F3DEX095_OpCodes.G_TRI2 | BitConverter.ToUInt32(BigEndian(gsSP1Triangle_w1(VertIndexesA)), 0)))
                ));

            binaryWriter.Write(
                gsSP1Triangle_w1(VertIndexesB)
                );



            return memoryStream.ToArray();
        }

        public byte[] gsSPDisplayList(uint Address)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);


            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(F3DEX095_OpCodes.G_DL)
                ));

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Address)
                ));

            return memoryStream.ToArray();

        }

        public byte[] gsSPEndDisplayList()
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);


            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(F3DEX095_OpCodes.G_ENDDL)
                ));

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(0)
                ));

            return memoryStream.ToArray();

        }


        public byte[] gsDma1p(UInt32 Command, UInt32 S, UInt32 L, UInt32 P)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);


            binaryWriter.Write(BigEndian(
            BitConverter.GetBytes(Convert.ToUInt32(Command | (P & 0xFF) << 16) | (L & 0xFFFF))
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

        public byte[] gsDPSetTile(UInt32 Format, UInt32 Size, UInt32 Line, UInt32 TMem, UInt32 Tile, UInt32 Palette, UInt32 CMT, UInt32 MaskT, UInt32 ShiftT, UInt32 CMS, UInt32 MaskS, UInt32 ShiftS)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Convert.ToUInt32(F3DEX095_OpCodes.G_SETTILE | ((Format & 0x7) << 21) | ((Size & 0x3) << 19) | ((Line & 0x1FF) << 9) | (TMem & 0x1FF)))
                ));

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Convert.ToUInt32(((Tile & 0x7) << 24) | ((Palette & 0xF) << 20) | ((CMT & 0x3) << 18) | ((MaskT & 0xF) << 14) |
                ((ShiftT & 0xF) << 10) | ((CMS & 0x3) << 8) | ((MaskS & 0xF) << 4) | ((ShiftS & 0xF))))
                ));

            return memoryStream.ToArray();

        }

        public byte[] gsSPTexture(UInt32 S, UInt32 T, UInt32 Level, UInt32 Tile, UInt32 OnFlag)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(F3DEX095_OpCodes.G_TEXTURE | ((Level & 0x7) << 11) | ((Tile & 0x7) << 8) | (OnFlag & 0xFF))
                ));
            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Convert.ToUInt32((S & 0xFFFF) << 16) | (T & 0xFFFF))
                ));

            return memoryStream.ToArray();
        }

        public byte[] gsDPLoadTLUTCmd(UInt32 Tile, UInt32 Count)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(F3DEX095_OpCodes.G_LOADTLUT)
                ));

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes((Tile & 0x07) << 24 | (Count & 0x3FF) << 14)
                ));

            return memoryStream.ToArray();
        }
        /*
         * 
         * #define gsDPLoadTLUT_pal256(dram)					\
 									\
	gsDPSetTextureImage(G_IM_FMT_RGBA, G_IM_SIZ_16b, 1, dram),	\
	gsDPTileSync(),							\
	gsDPSetTile(0, 0, 0, 256,					\
		G_TX_LOADTILE, 0 , 0, 0, 0, 0, 0, 0),			\
	gsDPLoadSync(),							\
	gsDPLoadTLUTCmd(G_TX_LOADTILE, 255),				\
	gsDPPipeSync()

        */


        public byte[] gsDPLoadTLUT_pal256(UInt32 Palette, UInt32 DRAM)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(gsDPSetTextureImage(F3DEX095_Parameters.G_IM_FMT_RGBA, F3DEX095_Parameters.G_IM_SIZ_16b, 1, DRAM));
            binaryWriter.Write(gsDPTileSync());
            binaryWriter.Write(gsDPSetTile(0, 0, 0, 256, F3DEX095_OpCodes.G_TX_LOADTILE, 0, 0, 0, 0, 0, 0, 0));
            binaryWriter.Write(gsDPLoadSync());
            binaryWriter.Write(gsDPLoadTLUTCmd(F3DEX095_OpCodes.G_TX_LOADTILE, 255));
            binaryWriter.Write(gsDPPipeSync());

            return memoryStream.ToArray();
        }

        public byte[] gsDPLoadTLUT_pal16(UInt32 Palette, UInt32 DRAM)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(gsDPSetTextureImage(F3DEX095_Parameters.G_IM_FMT_RGBA, F3DEX095_Parameters.G_IM_SIZ_16b, 1, DRAM));
            binaryWriter.Write(gsDPTileSync());
            binaryWriter.Write(gsDPSetTile(0, 0, 0, (256 + (((Palette) & 0x0F) * 16)), F3DEX095_OpCodes.G_TX_LOADTILE, 0, 0, 0, 0, 0, 0, 0));
            binaryWriter.Write(gsDPLoadSync());
            binaryWriter.Write(gsDPLoadTLUTCmd(F3DEX095_OpCodes.G_TX_LOADTILE, 15));
            binaryWriter.Write(gsDPPipeSync());

            return memoryStream.ToArray();
        }
        public byte[] gsDPSetTextureLUT(UInt32 Type)
        {
            return gsSPSetOtherMode(F3DEX095_OpCodes.G_SETOTHERMODE_H, Convert.ToUInt32(F3DEX095_Parameters.G_MDSFT_TEXTLUT), 2, Type);
        }

        public byte[] gsSPSetOtherMode(UInt32 Command, UInt32 Soft, UInt32 Len, UInt32 Data)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Command | ((Soft & 0xFF) << 8) | (Len & 0xFF))
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

            binaryWriter.Write(0);

            return memoryStream.ToArray();
        }

        public byte[] gsDPSetRenderMode(UInt32 ModeA, UInt32 ModeB)
        {
            return gsSPSetOtherMode(F3DEX095_OpCodes.G_SETOTHERMODE_L, Convert.ToUInt32(F3DEX095_Parameters.G_MDSFT_RENDERMODE), 29, ModeA | ModeB);
        }
        
        public byte[] gsDPSetCombineLERP(UInt32[] GCCA, UInt32[] GCCB)
        {

            //UInt32 a0, UInt32 b0, UInt32 c0, UInt32 d0, UInt32 Aa0, UInt32 Ab0, UInt32 Ac0, UInt32 Ad0 ----GCCA
            //UInt32 a1, UInt32 b1, UInt32 c1, UInt32 d1, UInt32 Aa1, UInt32 Ab1, UInt32 Ac1, UInt32 Ad1 ----GCCB
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(F3DEX095_OpCodes.G_SETCOMBINE | Convert.ToUInt32((GCCc0w0(GCCA[0], GCCA[2], GCCA[4], GCCA[6]) | GCCc1w0(GCCB[0], GCCB[2])) & 0xFFFFFF))
                ));

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Convert.ToUInt32(GCCc0w1(GCCA[1], GCCA[3], GCCA[5], GCCA[7]) | GCCc1w1(GCCB[1], GCCB[4], GCCB[6], GCCB[3], GCCB[5], GCCB[5])))
                ));

            return memoryStream.ToArray();

        }

        public byte[] gsDPSetCombineMode(UInt32[] ModeA, UInt32[] ModeB)
        {
            return gsDPSetCombineLERP(ModeA, ModeB);
        }

        public byte[] gsDPTileSync()
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(F3DEX095_OpCodes.G_RDPTILESYNC)
                ));
            binaryWriter.Write(0);

            return memoryStream.ToArray();
        }
        public byte[] gsDPLoadSync()
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(F3DEX095_OpCodes.G_RDPLOADSYNC)
                ));
            binaryWriter.Write(0);

            return memoryStream.ToArray();
        }



        public byte[] gsSPClearGeometryMode(UInt32 Mode)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Convert.ToUInt32(F3DEX095_OpCodes.G_CLEARGEOMETRYMODE))
                ));
            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Convert.ToUInt32(Mode))
                ));

            return memoryStream.ToArray();
        }

        public byte[] gsSPSetGeometryMode(UInt32 Mode)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Convert.ToUInt32(F3DEX095_OpCodes.G_SETGEOMETRYMODE))
                ));
            binaryWriter.Write(BigEndian(
                BitConverter.GetBytes(Convert.ToUInt32(Mode))
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
                BitConverter.GetBytes(((Tile & 0x7) << 24) | ((LRS & 0xFFF) << 12) | (LRT & 0xFFF))
                ));

            return memoryStream.ToArray();
        }

        public byte[] gsDPSetTileSize(UInt32 Tile, UInt32 ULS, UInt32 ULT, UInt32 LRS, UInt32 LRT)
        {
            return gsDPLoadTileGeneric(F3DEX095_OpCodes.G_SETTILESIZE, Tile, ULS, ULT, LRS, LRT);
        }



        public byte[] gsSetImage(UInt32 Command, UInt32 Format, UInt32 Size, uint Width, UInt32 Address)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(BigEndian(
            BitConverter.GetBytes(Convert.ToUInt32(Command | ((Format & 0x7) << 21) | ((Size & 0x3) << 19) | ((Width - 1) & 0xFFF)))
            ));

            binaryWriter.Write(BigEndian(
            BitConverter.GetBytes(Address)
            ));


            return memoryStream.ToArray();
        }

        public byte[] gsDPSetColorImage(UInt32 Format, UInt32 Size, uint Width, UInt32 Address)
        {
            return gsSetImage(F3DEX095_OpCodes.G_SETCIMG, Format, Size, Width, Address);
        }
        public byte[] gsDPSetTextureImage(UInt32 Format, UInt32 Size, uint Width, UInt32 Address)
        {
            return gsSetImage(F3DEX095_OpCodes.G_SETTIMG, Format, Size, Width, Address);
        }

        public byte[] gsNinSetupTileDescription(UInt32 TextureFormat, UInt32 Size, uint Width, uint Height, uint TextureMemory, uint Tile, uint CS, uint MS, uint SS, uint CT, uint MT, uint ST)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write(
                gsDPTileSync()
                );

            binaryWriter.Write(
                gsDPSetTile(TextureFormat, Size, ((Width * F3DEX095_Parameters.G_IM_ArrayLineBytes[(int)Size]) + 7) >> 3, TextureMemory, Tile, 0, CT, MT, ST, CS, MS, SS)
            );

            binaryWriter.Write(
                gsDPSetTileSize(Tile, 0, 0, (Width - 1) << (int)F3DEX095_Parameters.G_TEXTURE_IMAGE_FRAC, (Height - 1) << (int)F3DEX095_Parameters.G_TEXTURE_IMAGE_FRAC)
            );

            return memoryStream.ToArray();
        }
        public byte[] gsNinLoadTextureImage(UInt32 TextureAddress, UInt32 TextureFormat, UInt32 Size, uint Width, uint Height, uint TextureMemory, uint Tile)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            UInt32[] ByteSize = { 0, 1, 2, 4 };
            binaryWriter.Write(
                gsDPSetTextureImage(TextureFormat, Size, 1, TextureAddress)
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
                gsDPLoadBlock(Tile, 0, 0, ((Width * Height) - 1), CALCDXT(Width, ByteSize[Size]))
                );

            return memoryStream.ToArray();
        }
        public byte[] gsDPLoadTextureBlock(UInt32 TextureAddress, UInt32 TextureFormat, UInt32 Size, uint Width, uint Height, uint PaletteBanks, uint CS, uint MS, uint SS, uint CT, uint MT, uint ST)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
            UInt32[] INCRSize = { 3, 1, 0, 0 };
            Int32[] ShiftSize = { 2, 1, 0, 0 };
            UInt32[] LoadBlockSize = { 2, 2, 2, 4 };
            UInt32[] ByteSize = { 0, 1, 2, 4 };
            binaryWriter.Write(gsDPSetTextureImage(TextureFormat, LoadBlockSize[Size], 1, TextureAddress));
            binaryWriter.Write(gsDPSetTile(TextureFormat, LoadBlockSize[Size], 0, 0, 7, 0, CT, MT, ST, CS, MS, SS));
            binaryWriter.Write(gsDPLoadSync());
            binaryWriter.Write(gsDPLoadBlock(7, 0, 0, (((Width * Height) + INCRSize[Size]) >> ShiftSize[Size]) - 1, CALCDXT(Width, ByteSize[Size])));
            binaryWriter.Write(gsDPPipeSync());
            binaryWriter.Write(gsDPSetTile(TextureFormat, Size, ((((Width) * ByteSize[Size]) + 7) >> 3), 0, 0, PaletteBanks, CT, MT, ST, CS, MS, SS));
            binaryWriter.Write(gsDPSetTileSize(0, 0, 0,
                ((Width) - 1) << Convert.ToInt32(F3DEX095_Parameters.G_TEXTURE_IMAGE_FRAC),
                ((Height) - 1) << Convert.ToInt32(F3DEX095_Parameters.G_TEXTURE_IMAGE_FRAC)));

            return memoryStream.ToArray();
        }


        public byte[] gsDPLoadTextureBlock_4b(UInt32 TextureAddress, UInt32 TextureFormat, uint Width, uint Height, uint PaletteBanks, uint CS, uint MS, uint SS, uint CT, uint MT, uint ST)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
            UInt32[] INCRSize = { 3, 1, 0, 0 };
            Int32[] ShiftSize = { 2, 1, 0, 0 };
            UInt32[] LoadBlockSize = { 2, 2, 2, 4 };
            UInt32[] ByteSize = { 0, 1, 2, 4 };

            binaryWriter.Write(gsDPSetTextureImage(TextureFormat, F3DEX095_Parameters.G_IM_SIZ_16b, 1, TextureAddress));
            binaryWriter.Write(gsDPSetTile(TextureFormat, F3DEX095_Parameters.G_IM_SIZ_16b, 0, 0, 7, 0, CT, MT, ST, CS, MS, SS));
            binaryWriter.Write(gsDPLoadSync());
            binaryWriter.Write(gsDPLoadBlock(7, 0, 0, (((Width * Height) + 3) >> 2) - 1, CALCDXT_4b(Width)));
            binaryWriter.Write(gsDPPipeSync());
            binaryWriter.Write(gsDPSetTile(TextureFormat, F3DEX095_Parameters.G_IM_SIZ_4b, ((((Width) >> 1) + 7) >> 3), 
                0, F3DEX095_OpCodes.G_TX_RENDERTILE, PaletteBanks, CT, MT, ST, CS, MS, SS));
            binaryWriter.Write(gsDPSetTileSize(F3DEX095_OpCodes.G_TX_RENDERTILE, 0, 0,
                ((Width) - 1) << Convert.ToInt32(F3DEX095_Parameters.G_TEXTURE_IMAGE_FRAC),
                ((Height) - 1) << Convert.ToInt32(F3DEX095_Parameters.G_TEXTURE_IMAGE_FRAC)));

            return memoryStream.ToArray();
        }

        public byte[] gsDPLoadTile(UInt32 Tile, UInt32 ULS, UInt32 ULT, UInt32 LRS, UInt32 LRT)
        {
            return gsDPLoadTileGeneric(F3DEX095_OpCodes.G_LOADTILE, Tile, ULS, ULT, LRS, LRT);
        }

        public byte[] gsDPLoadTextureTile_4b(UInt32 TextureAddress, UInt32 TextureFormat, UInt32 TWidth, UInt32 THeight, UInt32 ULS, UInt32 ULT, UInt32 LRS, UInt32 LRT, UInt32 PAL, UInt32 CMS, UInt32 CMT, UInt32 MaskS, UInt32 MaskT, UInt32 ShiftS, UInt32 ShiftT)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
            UInt32[] INCRSize = { 3, 1, 0, 0 };
            Int32[] ShiftSize = { 2, 1, 0, 0 };
            UInt32[] LoadBlockSize = { 2, 2, 2, 4 };
            UInt32[] ByteSize = { 0, 1, 2, 4 };

            binaryWriter.Write(gsDPSetTextureImage(TextureFormat, F3DEX095_Parameters.G_IM_SIZ_8b, ((TWidth) >> 1), TextureAddress));

            binaryWriter.Write(gsDPSetTile(TextureFormat, F3DEX095_Parameters.G_IM_SIZ_8b,
                (((((LRS) - (ULS) + 1) >> 1) + 7) >> 3), 0, F3DEX095_OpCodes.G_TX_LOADTILE, 0, CMT, MaskT, ShiftT, CMS, MaskS, ShiftS));

            binaryWriter.Write(gsDPLoadSync());

            binaryWriter.Write(gsDPLoadTile(F3DEX095_OpCodes.G_TX_LOADTILE,
                (ULS << 1),
                (ULT << 2),
                (LRS << 1),
                (LRT << 2)));

            binaryWriter.Write(gsDPPipeSync());
            binaryWriter.Write(gsDPSetTile(TextureFormat, F3DEX095_Parameters.G_IM_SIZ_4b, (((((LRS) - (ULS) + 1) >> 1) + 7) >> 3), 0,
                F3DEX095_OpCodes.G_TX_RENDERTILE, PAL, CMT, MaskT, ShiftT, CMS, MaskS, ShiftS));

            binaryWriter.Write(gsDPSetTileSize(F3DEX095_OpCodes.G_TX_RENDERTILE,
                (ULS << 2),
                (ULT << 2),
                (LRS << 2),
                (LRT << 2)));


            return memoryStream.ToArray();
        }
        /* 
        #define	gDPLoadTextureBlock(pkt, timg, fmt, siz, width, height,		\
		        pal, cms, cmt, masks, maskt, shifts, shiftt)		\
        {									\
	        gDPSetTextureImage(pkt, fmt, siz##_LOAD_BLOCK, 1, timg);	\
	        gDPSetTile(pkt, fmt, siz##_LOAD_BLOCK, 0, 0, G_TX_LOADTILE, 	\
		        0 , cmt, maskt, shiftt, cms, masks, shifts);		\
	        gDPLoadSync(pkt);						\
	        gDPLoadBlock(pkt, G_TX_LOADTILE, 0, 0, 				\
		        (((width)*(height) + siz##_INCR) >> siz##_SHIFT) -1,	\
		        CALC_DXT(width, siz##_BYTES)); 				\
	        gDPPipeSync(pkt);						\
	        gDPSetTile(pkt, fmt, siz,					\
		        (((width) * siz##_LINE_BYTES)+7)>>3, 0,			\
		        G_TX_RENDERTILE, pal, cmt, maskt, shiftt, cms, masks,	\
		        shifts);						\
	        gDPSetTileSize(pkt, G_TX_RENDERTILE, 0, 0,			\
		        ((width)-1) << G_TEXTURE_IMAGE_FRAC,			\
		        ((height)-1) << G_TEXTURE_IMAGE_FRAC)			\
}

        */
    }
}
