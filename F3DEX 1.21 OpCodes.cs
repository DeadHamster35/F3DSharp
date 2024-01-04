using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F3DSharp
{
    public class F3DEX121_OpCodes
    {
        public static UInt32 G_SPNOOP = 0x00000000; //no op, do nothing
        public static UInt32 G_MTX = 0x01000000; //apply transformation matrix
        public static UInt32 G_MOVEMEM = 0x03000000; //copy memory from segment ram to dmem(?)
        public static UInt32 G_VTX = 0x04000000; //fill vertex buffer
        public static UInt32 G_DL = 0x06000000; //start or branch display list
        public static UInt32 G_SPRITE2D_BASE = 0x09000000; //for rendering sprites i guess?
        public static UInt32 G_LOAD_UCODE = 0xAF000000; //load new microcode into the rsp (address loaded with B4 FIRST)
        public static UInt32 G_BRANCH_Z = 0xB0000000; //branch display list if specified vertex's Z is <= to target Z
        public static UInt32 G_TRI2 = 0xB1000000; //render 2 triangles
        public static UInt32 G_MODIFYVTX = 0xB2000000; //change a value in a vertex at the specified offset in the vertex buffer
        public static UInt32 G_RDPHALF_2 = 0xB3000000; //set the lower half of the generic rdp word, calls b4
        public static UInt32 G_RDPHALF_1 = 0xB4000000; //set the higher half of the generic rdp word, calls b3
        public static UInt32 G_QUAD = 0xB5000000; //render 2 triangles, this is line3d in later f3dex1 versions but NOT in mk64s...
        public static UInt32 G_CLEARGEOMETRYMODE = 0xB6000000; //clears rsp geometry mode flags
        public static UInt32 G_SETGEOMETRYMODE = 0xB7000000; //sets rsp geometry mode flags
        public static UInt32 G_ENDDL = 0xB8000000; //self explanatory, ends the display list
        public static UInt32 G_SETOTHERMODE_L = 0xB9000000; //sets low half of the rdp other mode word
        public static UInt32 G_SETOTHERMODE_H = 0xBA000000; //sets high half of the rdp other mode word
        public static UInt32 G_TEXTURE = 0xBB000000; //set texture scale
        public static UInt32 G_MOVEWORD = 0xBC000000; //set the value at the specified dmem address to a new one
        public static UInt32 G_POPMTX = 0xBD000000; //pops a matrix from the matrix stack
        public static UInt32 G_SPRITE2D_DRAW = 0xBD000000; //draw a sprite
        public static UInt32 G_CULLDL = 0xBE000000; //sets up bounding volume for frustrum culling of display list (maybe???) based on specified vertices
        public static UInt32 G_SPRITE2D_SCALEFLIP = 0xBE000000; //scale and flip a sprite
        public static UInt32 G_TRI1 = 0xBF000000; //render 1 triangle
        public static UInt32 G_NOOP = 0xC0000000; //similar to noop but stalls rdp instead of rsp
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
