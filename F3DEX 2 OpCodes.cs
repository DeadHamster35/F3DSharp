using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F3DSharp
{
    public class F3DEX2_OpCodes
    {

        public static UInt32 G_NOOP			    = 0x00000000;
        public static UInt32 G_RDPHALF_2		= 0xf1000000;
        public static UInt32 G_SETOTHERMODE_H	= 0xe3000000;
        public static UInt32 G_SETOTHERMODE_L	= 0xe2000000;
        public static UInt32 G_RDPHALF_1		= 0xe1000000;
        public static UInt32 G_SPNOOP		    = 0xe0000000;
        public static UInt32 G_ENDDL		    = 0xdf000000;
        public static UInt32 G_DL			    = 0xde000000;
        public static UInt32 G_LOAD_UCODE	    = 0xdd000000;
        public static UInt32 G_MOVEMEM		    = 0xdc000000;
        public static UInt32 G_MOVEWORD		    = 0xdb000000;
        public static UInt32 G_MTX			    = 0xda000000;
        public static UInt32 G_GEOMETRYMODE	    = 0xd9000000;
        public static UInt32 G_POPMTX		    = 0xd8000000;
        public static UInt32 G_TEXTURE		    = 0xd7000000;
        public static UInt32 G_DMA_IO		    = 0xd6000000;
        public static UInt32 G_SPECIAL_1	    = 0xd5000000;
        public static UInt32 G_SPECIAL_2	    = 0xd4000000;
        public static UInt32 G_SPECIAL_3	    = 0xd3000000;

        public static UInt32 G_VTX			    = 0x01000000;
        public static UInt32 G_MODIFYVTX	    = 0x02000000;
        public static UInt32 G_CULLDL		    = 0x03000000;
        public static UInt32 G_BRANCH_Z		    = 0x04000000;
        public static UInt32 G_TRI1			    = 0x05000000;
        public static UInt32 G_TRI2			    = 0x06000000;
        public static UInt32 G_QUAD			    = 0x07000000;
        public static UInt32 G_LINE3D		    = 0x08000000;


        public static UInt32 G_DPNOOP = 0xC0000000; //similar to noop but stalls rdp instead of rsp
        public static UInt32 G_TEXRECT = 0xE4000000; //draw a 2d textured rectangle
        public static UInt32 G_TEXRECTFLIP = 0xE5000000; //same as above but flipped...
        public static UInt32 G_RDPLOADSYNC = 0xE6000000; //force rdp to wait for texture load
        public static UInt32 G_RDPPIPESYNC = 0xE7000000; //wait for rdp's current primitive to finish rendering before updating rdp attributes
        public static UInt32 G_RDPTILESYNC = 0xE8000000; //wait for rdp's current primitive to finish rendering before updating tile descriptor attributes
        public static UInt32 G_RDPFULLSYNC = 0xE9000000; //generate an interrupt when rdp has finished rendering
        public static UInt32 G_SETKEYGB = 0xEA000000; //set up green and blue components of chroma key
        public static UInt32 G_SETKEYR = 0xEB000000; //set up red component of chroma key
        public static UInt32 G_SETCONVERT = 0xEC000000; //set up YUV to RGB conversion matrix
        public static UInt32 G_SETSCISSOR = 0xED000000; //set scissoring rectangle(???)
        public static UInt32 G_SETPRIMDEPTH = 0xEE000000; //set Z value of the current primitive
        public static UInt32 G_RDPSETOTHERMODE = 0xEF000000; //set the full rdp other mode word
        public static UInt32 G_LOADTLUT = 0xF0000000; //load a color palette for indexed textures
        public static UInt32 G_SETTILESIZE = 0xF2000000; //set the texture's coordinates and size
        public static UInt32 G_LOADBLOCK = 0xF3000000; //load texture into tmem
        public static UInt32 G_LOADTILE = 0xF4000000; //load texture into tmem
        public static UInt32 G_SETTILE = 0xF5000000; //set tile descriptor attributes
        public static UInt32 G_FILLRECT = 0xF6000000; //draw a rectangle on the screen
        public static UInt32 G_SETFILLCOLOR = 0xF7000000; //set fill color
        public static UInt32 G_SETFOGCOLOR = 0xF8000000; //set fog color and alpha
        public static UInt32 G_SETBLENDCOLOR = 0xF9000000; //set rdp blender register color
        public static UInt32 G_SETPRIMCOLOR = 0xFA000000; //set rdp primitive color register, min LOD level, and LOD fraction
        public static UInt32 G_SETENVCOLOR = 0xFB000000; //set combiner environment color
        public static UInt32 G_SETCOMBINE = 0xFC000000; //set combiner settings
        public static UInt32 G_SETTIMG = 0xFD000000; //set texture format and memory location
        public static UInt32 G_SETZIMG = 0xFE000000; //set depth buffer memory location
        public static UInt32 G_SETCIMG = 0xFF000000; //set color buffer memory location
                                             ////////////////////////////////////////////////////
                                             //tile descriptor names
                                             ////////////////////////////////////////////////////
        public static UInt32 G_TX_LOADTILE = 7;
        public static UInt32 G_TX_RENDERTILE = 0;
        ////////////////////////////////////////////////////
        //some offsets to use when shifting data into place
        //to make the code more readable
        ////////////////////////////////////////////////////
        public static UInt32 SHFT_PIXEL_FORMAT = 19; //for FD/F5
        public static UInt32 SHFT_TILEDESCRIPTOR = 24; //for F5/F4/F3/F2/F0
                                               ////////////////////////////////////////////////////
                                               //color format publicants
                                               ////////////////////////////////////////////////////
        public static UInt32 PIXELFORMAT_I4 = 0x10; //f ffii = 1 0000, 4 bit greyscale
        public static UInt32 PIXELFORMAT_I8 = 0x11; //f ffii = 1 0001, 8 bit greyscale
        public static UInt32 PIXELFORMAT_IA4 = 0x0C; //f ffii = 0 1100, 4 bit greyscale + alpha
        public static UInt32 PIXELFORMAT_IA8 = 0x0D; //f ffii = 0 1101, 8 bit greyscale + alpha
        public static UInt32 PIXELFORMAT_IA16 = 0x0E; //f ffii = 0 1110, 16 bit greyscale + alpha
        public static UInt32 PIXELFORMAT_CI4 = 0x08; //f ffii = 0 1000, 4 bit color indexed
        public static UInt32 PIXELFORMAT_CI8 = 0x09; //f ffii = 0 1001, 8 bit color indexed
        public static UInt32 PIXELFORMAT_YUV16 = 0x06; //f ffii = 0 0110, 16 bit YUV
        public static UInt32 PIXELFORMAT_RGBA16 = 0x02; //f ffii = 0 0010, 16 bit RGB + alpha
        public static UInt32 PIXELFORMAT_RGBA32 = 0x00; //f ffii = 0 0000, 32 bit RGB + alpha
    }
}
