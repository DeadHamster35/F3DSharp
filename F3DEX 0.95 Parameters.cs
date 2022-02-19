using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F3DSharp
{
    public class F3DEX095_Parameters
    {

        public static UInt32 G_IM_SIZ_4b = 0;
        public static UInt32 G_IM_SIZ_8b = 1;
        public static UInt32 G_IM_SIZ_16b = 2;
        public static UInt32 G_IM_SIZ_32b = 3;
        public static UInt32 G_IM_SIZ_DD = 5;
        public static UInt32[] BitSizes = new UInt32[] { G_IM_SIZ_4b, G_IM_SIZ_8b, G_IM_SIZ_16b, G_IM_SIZ_32b, G_IM_SIZ_DD };
        public static string[] BitSizeNames = new string[] { "G_IM_SIZ_4b", "G_IM_SIZ_8b", "G_IM_SIZ_16b", "G_IM_SIZ_32b", };

        public static UInt32 G_IM_FMT_RGBA = 0;
        public static UInt32 G_IM_FMT_YUV = 1;
        public static UInt32 G_IM_FMT_CI = 2;
        public static UInt32 G_IM_FMT_IA = 3;
        public static UInt32 G_IM_FMT_I = 4;
        public static UInt32[] TextureFormats = new UInt32[] { G_IM_FMT_RGBA, G_IM_FMT_YUV, G_IM_FMT_CI, G_IM_FMT_IA, G_IM_FMT_I };
        public static string[] TextureFormatNames = new string[] { "G_IM_FMT_RGBA", "G_IM_FMT_YUV", "G_IM_FMT_CI", "G_IM_FMT_IA", "G_IM_FMT_I" };
        
        public static UInt32 G_TX_NOMIRROR = 0;
        public static UInt32 G_TX_WRAP = 0;
        public static UInt32 G_TX_MIRROR = 1;
        public static UInt32 G_TX_CLAMP = 2;
        public static UInt32 G_TX_NOMASK = 0;
        public static UInt32 G_TX_NOLOD = 0;

        public static UInt32[] TextureModes = new UInt32[] { G_TX_NOMIRROR, G_TX_WRAP, G_TX_MIRROR, G_TX_CLAMP, (G_TX_MIRROR | G_TX_CLAMP) };
        public static string[] TextureModeNames = new string[] { "G_TX_NOMIRROR", "G_TX_WRAP", "G_TX_MIRROR", "G_TX_CLAMP", "G_TX_MIRRORCLAMP" };



        public static string[] GCCModeNames = new string[]
        {
            "G_CC_PRIMITIVE",
            "G_CC_SHADE",
            "G_CC_MODULATEI",
            "G_CC_MODULATEIA",
            "G_CC_MODULATEIDECALA",
            "G_CC_MODULATERGB",
            "G_CC_MODULATERGBA",
            "G_CC_MODULATERGBDECALA",
            "G_CC_MODULATEI_PRIM",
            "G_CC_MODULATEIA_PRIM",
            "G_CC_MODULATEIDECALA_PRIM",
            "G_CC_MODULATERGB_PRIM",
            "G_CC_MODULATERGBA_PRIM",
            "G_CC_MODULATERGBDECALA_PRIM",
            "G_CC_DECALRGB",
            "G_CC_DECALRGBA",
            "G_CC_BLENDI",
            "G_CC_BLENDIA",
            "G_CC_BLENDIDECALA",
            "G_CC_BLENDRGBA",
            "G_CC_BLENDRGBDECALA",
            "G_CC_ADDRGB",
            "G_CC_ADDRGBDECALA",
            "G_CC_REFLECTRGB",
            "G_CC_REFLECTRGBDECALA",
            "G_CC_HILITERGB",
            "G_CC_HILITERGBA",
            "G_CC_HILITERGBDECALA",
            "G_CC_SHADEDECALA",
            "G_CC_BLENDPE",
            "G_CC_BLENDPEDECALA"
        };



        public static string[] RenderModeNames = new string[]
        {
            "G_RM_AA_ZB_OPA_SURF",
            "G_RM_AA_ZB_OPA_SURF2",
            "G_RM_AA_ZB_XLU_SURF",
            "G_RM_AA_ZB_XLU_SURF2",
            "G_RM_AA_ZB_OPA_DECAL",
            "G_RM_AA_ZB_OPA_DECAL2",
            "G_RM_AA_ZB_XLU_DECAL",
            "G_RM_AA_ZB_XLU_DECAL2",
            "G_RM_AA_ZB_OPA_INTER",
            "G_RM_AA_ZB_OPA_INTER2",
            "G_RM_AA_ZB_XLU_INTER",
            "G_RM_AA_ZB_XLU_INTER2",
            "G_RM_AA_ZB_XLU_LINE",
            "G_RM_AA_ZB_XLU_LINE2",
            "G_RM_AA_ZB_DEC_LINE",
            "G_RM_AA_ZB_DEC_LINE2",
            "G_RM_AA_ZB_TEX_EDGE",
            "G_RM_AA_ZB_TEX_EDGE2",
            "G_RM_AA_ZB_TEX_INTER",
            "G_RM_AA_ZB_TEX_INTER2",
            "G_RM_AA_ZB_SUB_SURF",
            "G_RM_AA_ZB_SUB_SURF2",
            "G_RM_AA_ZB_PCL_SURF",
            "G_RM_AA_ZB_PCL_SURF2",
            "G_RM_AA_ZB_OPA_TERR",
            "G_RM_AA_ZB_OPA_TERR2",
            "G_RM_AA_ZB_TEX_TERR",
            "G_RM_AA_ZB_TEX_TERR2",
            "G_RM_AA_ZB_SUB_TERR",
            "G_RM_AA_ZB_SUB_TERR2",
        };

        public static string[] ColorCombineNames = new string[]
        {
            "COMBINED",
            "TEXEL0",
            "TEXEL1",
            "PRIMITIVE",
            "SHADE",
            "ENVIRONMENT",
            "CENTER",
             "SCALE",
             "COMBINED_ALPHA",
             "TEXEL0_ALPHA",
            "TEXEL1_ALPHA",
            "PRIMITIVE_ALPHA",
            "SHADE_ALPHA",
            "ENV_ALPHA",
             "LOD_FRACTION",
            "PRIM_LOD_FRAC",
            "NOISE",
            "K4",
            "K5",
            "1",
            "0"
        };




        public static string[] GACModeNames = new string[]
        {
            "G_ACMUX_COMBINED",
            "G_ACMUX_TEXEL0",
            "G_ACMUX_TEXEL1",
            "G_ACMUX_PRIMITIVE",
            "G_ACMUX_SHADE",
            "G_ACMUX_ENVIRONMENT",
            "G_ACMUX_LOD_FRACTION",
            "G_ACMUX_PRIM_LOD_FRAC",
            "G_ACMUX_1",
            "G_ACMUX_0"
        };



        /* typical CC Cycle 1 modes*/

        public static int GCCKEY_COMBINED = 0;
        public static int GCCKEY_TEXEL0 = 1;
        public static int GCCKEY_TEXEL1 = 2;
        public static int GCCKEY_PRIMITIVE = 3;
        public static int GCCKEY_SHADE = 4;
        public static int GCCKEY_ENVIRONMENT = 5;
        public static int GCCKEY_CENTER = 6;
        public static int GCCKEY_SCALE = 7;
        public static int GCCKEY_COMBINED_ALPHA = 8;
        public static int GCCKEY_TEXEL0_ALPHA = 9;
        public static int GCCKEY_TEXEL1_ALPHA = 10;
        public static int GCCKEY_PRIMITIVE_ALPHA = 11;
        public static int GCCKEY_SHADE_ALPHA = 12;
        public static int GCCKEY_ENV_ALPHA = 13;
        public static int GCCKEY_LOD_FRACTION = 14;
        public static int GCCKEY_PRIM_LOD_FRAC = 15;
        public static int GCCKEY_NOISE = 16;
        public static int GCCKEY_K4 = 17;
        public static int GCCKEY_K5 = 18;
        public static int GCCKEY_1 = 19;
        public static int GCCKEY_0 = 20;





        /* Color combiner constants: */
        public static UInt32 G_CCMUX_COMBINED = 0;
        public static UInt32 G_CCMUX_TEXEL0 = 1;
        public static UInt32 G_CCMUX_TEXEL1 = 2;
        public static UInt32 G_CCMUX_PRIMITIVE = 3;
        public static UInt32 G_CCMUX_SHADE = 4;
        public static UInt32 G_CCMUX_ENVIRONMENT = 5;
        public static UInt32 G_CCMUX_CENTER = 6;
        public static UInt32 G_CCMUX_SCALE = 6;
        public static UInt32 G_CCMUX_COMBINED_ALPHA = 7;
        public static UInt32 G_CCMUX_TEXEL0_ALPHA = 8;
        public static UInt32 G_CCMUX_TEXEL1_ALPHA = 9;
        public static UInt32 G_CCMUX_PRIMITIVE_ALPHA = 10;
        public static UInt32 G_CCMUX_SHADE_ALPHA = 11;
        public static UInt32 G_CCMUX_ENV_ALPHA = 12;
        public static UInt32 G_CCMUX_LOD_FRACTION = 13;
        public static UInt32 G_CCMUX_PRIM_LOD_FRAC = 14;
        public static UInt32 G_CCMUX_NOISE = 7;
        public static UInt32 G_CCMUX_K4 = 7;
        public static UInt32 G_CCMUX_K5 = 15;
        public static UInt32 G_CCMUX_1 = 6;
        public static UInt32 G_CCMUX_0 = 31;

        /* Alpha combiner constants: */
        public static UInt32 G_ACMUX_COMBINED = 0;
        public static UInt32 G_ACMUX_TEXEL0 = 1;
        public static UInt32 G_ACMUX_TEXEL1 = 2;
        public static UInt32 G_ACMUX_PRIMITIVE = 3;
        public static UInt32 G_ACMUX_SHADE = 4;
        public static UInt32 G_ACMUX_ENVIRONMENT = 5;
        public static UInt32 G_ACMUX_LOD_FRACTION = 0;
        public static UInt32 G_ACMUX_PRIM_LOD_FRAC = 6;
        public static UInt32 G_ACMUX_1 = 6;
        public static UInt32 G_ACMUX_0 = 7;

        public static int GACKEY_COMBINED = 0;
        public static int GACKEY_TEXEL0 = 1;
        public static int GACKEY_TEXEL1 = 2;
        public static int GACKEY_PRIMITIVE = 3;
        public static int GACKEY_SHADE = 4;
        public static int GACKEY_ENVIRONMENT = 5;
        public static int GACKEY_LOD_FRACTION = 6;
        public static int GACKEY_PRIM_LOD_FRAC = 7;
        public static int GACKEY_1 = 8;
        public static int GACKEY_0 = 9;
        /*
 * G_SETOTHERMODE_L sft: shift count
 */
        public static Int32 G_MDSFT_ALPHACOMPARE = 0;
        public static Int32 G_MDSFT_ZSRCSEL = 2;
        public static Int32 G_MDSFT_RENDERMODE = 3;
        public static Int32 G_MDSFT_BLENDER = 16;

        /*
 * G_SETOTHERMODE_H sft: shift count
 */
        public static Int32 G_MDSFT_BLENDMASK = 0;
        public static Int32 G_MDSFT_ALPHADITHER = 4;
        public static Int32 G_MDSFT_RGBDITHER = 6;

        public static Int32 G_MDSFT_COMBKEY = 8;
        public static Int32 G_MDSFT_TEXTCONV = 9;
        public static Int32 G_MDSFT_TEXTFILT = 12;
        public static Int32 G_MDSFT_TEXTLUT = 14;
        public static Int32 G_MDSFT_TEXTLOD = 16;
        public static Int32 G_MDSFT_TEXTDETAIL = 17;
        public static Int32 G_MDSFT_TEXTPERSP = 19;
        public static Int32 G_MDSFT_CYCLETYPE = 20;
        public static Int32 G_MDSFT_COLORDITHER = 22;
        public static Int32 G_MDSFT_PIPELINE = 23;
        /* G_SETOTHERMODE_L gSetRenderMode */
        public static UInt32 AA_EN = 0x8;
        public static UInt32 Z_CMP = 0x10;
        public static UInt32 Z_UPD = 0x20;
        public static UInt32 IM_RD = 0x40;
        public static UInt32 CLR_ON_CVG = 0x80;
        public static UInt32 CVG_DST_CLAMP = 0;
        public static UInt32 CVG_DST_WRAP = 0x100;
        public static UInt32 CVG_DST_FULL = 0x200;
        public static UInt32 CVG_DST_SAVE = 0x300;
        public static UInt32 ZMODE_OPA = 0;
        public static UInt32 ZMODE_INTER = 0x400;
        public static UInt32 ZMODE_XLU = 0x800;
        public static UInt32 ZMODE_DEC = 0xc00;
        public static UInt32 CVG_X_ALPHA = 0x1000;
        public static UInt32 ALPHA_CVG_SEL = 0x2000;
        public static UInt32 FORCE_BL = 0x4000;
        public static UInt32 TEX_EDGE = 0x0000;

        public static UInt32 G_BL_CLR_IN = 0;
        public static UInt32 G_BL_CLR_MEM = 1;
        public static UInt32 G_BL_CLR_BL = 2;
        public static UInt32 G_BL_CLR_FOG = 3;
        public static UInt32 G_BL_1MA = 0;
        public static UInt32 G_BL_A_MEM = 1;
        public static UInt32 G_BL_A_IN = 0;
        public static UInt32 G_BL_A_FOG = 1;
        public static UInt32 G_BL_A_SHADE = 2;
        public static UInt32 G_BL_1 = 2;
        public static UInt32 G_BL_0 = 3;
        public static UInt32 G_ZBUFFER = 0x00000001;
        public static UInt32 G_SHADE = 0x00000004;
        public static UInt32 G_TEXTURE_ENABLE = 0x00000002;	/* Microcode use only */
        public static UInt32 G_SHADING_SMOOTH = 0x00000200;	/* flat or smooth shaded */
        public static UInt32 G_CULL_FRONT = 0x00001000;
        public static UInt32 G_CULL_BACK = 0x00002000;
        public static UInt32 G_CULL_BOTH = 0x00003000;	/* To make code cleaner */
        public static UInt32 G_FOG = 0x00010000;
        public static UInt32 G_LIGHTING = 0x00020000;
        public static UInt32 G_TEXTURE_GEN = 0x00040000;
        public static UInt32 G_TEXTURE_GEN_LINEAR = 0x00080000;
        public static UInt32 G_LOD = 0x00100000;	/* NOT IMPLEMENTED */
        public static UInt32 G_CLIPPING = 0x00800000;




        public static UInt32[] ColorCombineModes = new UInt32[]
        {
            G_CCMUX_COMBINED,
            G_CCMUX_TEXEL0,
            G_CCMUX_TEXEL1,
            G_CCMUX_PRIMITIVE,
            G_CCMUX_SHADE,
            G_CCMUX_ENVIRONMENT,
            G_CCMUX_CENTER,
            G_CCMUX_SCALE,
            G_CCMUX_COMBINED_ALPHA,
            G_CCMUX_TEXEL0_ALPHA,
            G_CCMUX_TEXEL1_ALPHA,
            G_CCMUX_PRIMITIVE_ALPHA,
            G_CCMUX_SHADE_ALPHA,
            G_CCMUX_ENV_ALPHA,
            G_CCMUX_LOD_FRACTION,
            G_CCMUX_PRIM_LOD_FRAC,
            G_CCMUX_NOISE,
            G_CCMUX_K4,
            G_CCMUX_K5,
            G_CCMUX_1,
            G_CCMUX_0
        };



        public static UInt32[] G_CC_PRIMITIVE = new UInt32[] { ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_PRIMITIVE], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_PRIMITIVE] };
        public static UInt32[] G_CC_SHADE = new UInt32[] {      ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_SHADE] };
        public static UInt32[] G_CC_MODULATEI = new UInt32[] {      ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_SHADE] };
        public static UInt32[] G_CC_MODULATEIA = new UInt32[] {     ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_0] };
        public static UInt32[] G_CC_MODULATEIDECALA = new UInt32[] {    ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_TEXEL0] };
        public static UInt32[] G_CC_MODULATERGB = G_CC_MODULATEI ;
        public static UInt32[] G_CC_MODULATERGBA = G_CC_MODULATEIA;
        public static UInt32[] G_CC_MODULATERGBDECALA = G_CC_MODULATEIDECALA;
        public static UInt32[] G_CC_MODULATEI_PRIM = new UInt32[] { ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_PRIMITIVE], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_PRIMITIVE] };
        public static UInt32[] G_CC_MODULATEIA_PRIM = new UInt32[] {    ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_PRIMITIVE], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_PRIMITIVE], ColorCombineModes[GCCKEY_0] };
        public static UInt32[] G_CC_MODULATEIDECALA_PRIM = new UInt32[] {   ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_PRIMITIVE], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_TEXEL0] };
        public static UInt32[] G_CC_MODULATERGB_PRIM = G_CC_MODULATEI_PRIM;
        public static UInt32[] G_CC_MODULATERGBA_PRIM = G_CC_MODULATEIA_PRIM;
        public static UInt32[] G_CC_MODULATERGBDECALA_PRIM = G_CC_MODULATEIDECALA_PRIM;
        public static UInt32[] G_CC_DECALRGB = new UInt32[] {       ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_SHADE] };
        public static UInt32[] G_CC_DECALRGBA = new UInt32[] {      ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_TEXEL0] };
        public static UInt32[] G_CC_BLENDI = new UInt32[] {     ColorCombineModes[GCCKEY_ENVIRONMENT], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_SHADE] };
        public static UInt32[] G_CC_BLENDIA = new UInt32[] {        ColorCombineModes[GCCKEY_ENVIRONMENT], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_0] };
        public static UInt32[] G_CC_BLENDIDECALA = new UInt32[] {   ColorCombineModes[GCCKEY_ENVIRONMENT], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_TEXEL0] };
        public static UInt32[] G_CC_BLENDRGBA = new UInt32[] {      ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_TEXEL0_ALPHA], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_SHADE] };
        public static UInt32[] G_CC_BLENDRGBDECALA = new UInt32[] { ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_TEXEL0_ALPHA], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_TEXEL0] };
        public static UInt32[] G_CC_ADDRGB = new UInt32[] {     ColorCombineModes[GCCKEY_1], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_SHADE] };
        public static UInt32[] G_CC_ADDRGBDECALA = new UInt32[] {   ColorCombineModes[GCCKEY_1], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_TEXEL0] };
        public static UInt32[] G_CC_REFLECTRGB = new UInt32[] {     ColorCombineModes[GCCKEY_ENVIRONMENT], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_SHADE] };
        public static UInt32[] G_CC_REFLECTRGBDECALA = new UInt32[] {   ColorCombineModes[GCCKEY_ENVIRONMENT], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_TEXEL0] };
        public static UInt32[] G_CC_HILITERGB = new UInt32[] {      ColorCombineModes[GCCKEY_PRIMITIVE], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_SHADE] };
        public static UInt32[] G_CC_HILITERGBA = new UInt32[] {     ColorCombineModes[GCCKEY_PRIMITIVE], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_PRIMITIVE], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_SHADE] };
        public static UInt32[] G_CC_HILITERGBDECALA = new UInt32[] {    ColorCombineModes[GCCKEY_PRIMITIVE], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_TEXEL0] };
        public static UInt32[] G_CC_SHADEDECALA = new UInt32[] {    ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_TEXEL0] };
        public static UInt32[] G_CC_BLENDPE = new UInt32[] {        ColorCombineModes[GCCKEY_PRIMITIVE], ColorCombineModes[GCCKEY_ENVIRONMENT], ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_ENVIRONMENT], ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_SHADE], ColorCombineModes[GCCKEY_0] };
        public static UInt32[] G_CC_BLENDPEDECALA = new UInt32[] {  ColorCombineModes[GCCKEY_PRIMITIVE], ColorCombineModes[GCCKEY_ENVIRONMENT], ColorCombineModes[GCCKEY_TEXEL0], ColorCombineModes[GCCKEY_ENVIRONMENT], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_0], ColorCombineModes[GCCKEY_TEXEL0] };

        public static UInt32[][] GCCModes = new UInt32[][] 
        {
            G_CC_PRIMITIVE,
            G_CC_SHADE,
            G_CC_MODULATEI,
            G_CC_MODULATEIA,
            G_CC_MODULATEIDECALA,
            G_CC_MODULATERGB,
            G_CC_MODULATERGBA,
            G_CC_MODULATERGBDECALA,
            G_CC_MODULATEI_PRIM,
            G_CC_MODULATEIA_PRIM,
            G_CC_MODULATEIDECALA_PRIM,
            G_CC_MODULATERGB_PRIM,
            G_CC_MODULATERGBA_PRIM,
            G_CC_MODULATERGBDECALA_PRIM,
            G_CC_DECALRGB,
            G_CC_DECALRGBA,
            G_CC_BLENDI,
            G_CC_BLENDIA,
            G_CC_BLENDIDECALA,
            G_CC_BLENDRGBA,
            G_CC_BLENDRGBDECALA,
            G_CC_ADDRGB,
            G_CC_ADDRGBDECALA,
            G_CC_REFLECTRGB,
            G_CC_REFLECTRGBDECALA,
            G_CC_HILITERGB,
            G_CC_HILITERGBA,
            G_CC_HILITERGBDECALA,
            G_CC_SHADEDECALA,
            G_CC_BLENDPE,
            G_CC_BLENDPEDECALA
        };





        public static UInt32[] GACModes = new UInt32[]
        {
            G_ACMUX_COMBINED,
            G_ACMUX_TEXEL0,
            G_ACMUX_TEXEL1,
            G_ACMUX_PRIMITIVE,
            G_ACMUX_SHADE,
            G_ACMUX_ENVIRONMENT,
            G_ACMUX_LOD_FRACTION,
            G_ACMUX_PRIM_LOD_FRAC,
            G_ACMUX_1,
            G_ACMUX_0
        };



        public static UInt32 G_IM_SIZ_4b_BYTES = 0;
        public static UInt32 G_IM_SIZ_4b_TILE_BYTES = G_IM_SIZ_4b_BYTES;
        public static UInt32 G_IM_SIZ_4b_LINE_BYTES = G_IM_SIZ_4b_BYTES;

        public static UInt32 G_IM_SIZ_8b_BYTES = 1;
        public static UInt32 G_IM_SIZ_8b_TILE_BYTES = G_IM_SIZ_8b_BYTES;
        public static UInt32 G_IM_SIZ_8b_LINE_BYTES = G_IM_SIZ_8b_BYTES;

        public static UInt32 G_IM_SIZ_16b_BYTES = 2;
        public static UInt32 G_IM_SIZ_16b_TILE_BYTES = G_IM_SIZ_16b_BYTES;
        public static UInt32 G_IM_SIZ_16b_LINE_BYTES = G_IM_SIZ_16b_BYTES;

        public static UInt32 G_IM_SIZ_32b_BYTES = 4;
        public static UInt32 G_IM_SIZ_32b_TILE_BYTES = 2;
        public static UInt32 G_IM_SIZ_32b_LINE_BYTES = 2;

        public static UInt32 G_IM_SIZ_4b_LOAD_BLOCK = G_IM_SIZ_16b;
        public static UInt32 G_IM_SIZ_8b_LOAD_BLOCK = G_IM_SIZ_16b;
        public static UInt32 G_IM_SIZ_16b_LOAD_BLOCK = G_IM_SIZ_16b;
        public static UInt32 G_IM_SIZ_32b_LOAD_BLOCK = G_IM_SIZ_32b;

        public static UInt32 G_IM_SIZ_4b_SHIFT = 2;
        public static UInt32 G_IM_SIZ_8b_SHIFT = 1;
        public static UInt32 G_IM_SIZ_16b_SHIFT = 0;
        public static UInt32 G_IM_SIZ_32b_SHIFT = 0;

        public static UInt32 G_IM_SIZ_4b_INCR = 3;
        public static UInt32 G_IM_SIZ_8b_INCR = 1;
        public static UInt32 G_IM_SIZ_16b_INCR = 0;
        public static UInt32 G_IM_SIZ_32b_INCR = 0;

        public static UInt32[] G_IM_ArrayLineBytes = { G_IM_SIZ_4b_LINE_BYTES, G_IM_SIZ_8b_LINE_BYTES, G_IM_SIZ_16b_LINE_BYTES, G_IM_SIZ_32b_LINE_BYTES };

        public static UInt32 G_TEXTURE_IMAGE_FRAC   = 2;
        public static UInt32 G_TEXTURE_SCALE_FRAC   = 16;
        public static UInt32 G_SCALE_FRAC           = 8;
        public static UInt32 G_ROTATE_FRAC          = 16;




        /* G_SETOTHERMODE_H gPipelineMode */
        public static UInt32 G_PM_1PRIMITIVE = Convert.ToUInt32(1 << G_MDSFT_PIPELINE);
        public static UInt32 G_PM_NPRIMITIVE = Convert.ToUInt32(0 << G_MDSFT_PIPELINE);

        /* G_SETOTHERMODE_H gSetCycleType */
        public static UInt32 G_CYC_1CYCLE = Convert.ToUInt32(0 << G_MDSFT_CYCLETYPE);
        public static UInt32 G_CYC_2CYCLE = Convert.ToUInt32(1 << G_MDSFT_CYCLETYPE);
        public static UInt32 G_CYC_COPY = Convert.ToUInt32(2 << G_MDSFT_CYCLETYPE);
        public static UInt32 G_CYC_FILL = Convert.ToUInt32(3 << G_MDSFT_CYCLETYPE);

                /* G_SETOTHERMODE_H gSetTexturePersp */
        public static UInt32 G_TP_NONE = Convert.ToUInt32(0 << G_MDSFT_TEXTPERSP);
        public static UInt32 G_TP_PERSP = Convert.ToUInt32(1 << G_MDSFT_TEXTPERSP);

        /* G_SETOTHERMODE_H gSetTextureDetail */
        public static UInt32 G_TD_CLAMP = Convert.ToUInt32(0 << G_MDSFT_TEXTDETAIL);
        public static UInt32 G_TD_SHARPEN = Convert.ToUInt32(1 << G_MDSFT_TEXTDETAIL);
        public static UInt32 G_TD_DETAIL = Convert.ToUInt32(2 << G_MDSFT_TEXTDETAIL);

                /* G_SETOTHERMODE_H gSetTextureLOD */
        public static UInt32 G_TL_TILE = Convert.ToUInt32(0 << G_MDSFT_TEXTLOD);
        public static UInt32 G_TL_LOD = Convert.ToUInt32(1 << G_MDSFT_TEXTLOD);

                /* G_SETOTHERMODE_H gSetTextureLUT */
        public static UInt32 G_TT_NONE = Convert.ToUInt32(0 << G_MDSFT_TEXTLUT);
        public static UInt32 G_TT_RGBA16 = Convert.ToUInt32(2 << G_MDSFT_TEXTLUT);
        public static UInt32 G_TT_IA16 = Convert.ToUInt32(3 << G_MDSFT_TEXTLUT);

                /* G_SETOTHERMODE_H gSetTextureFilter */
        public static UInt32 G_TF_POINT = Convert.ToUInt32(0 << G_MDSFT_TEXTFILT);
        public static UInt32 G_TF_AVERAGE = Convert.ToUInt32(3 << G_MDSFT_TEXTFILT);
        public static UInt32 G_TF_BILERP = Convert.ToUInt32(2 << G_MDSFT_TEXTFILT);

                /* G_SETOTHERMODE_H gSetTextureConvert */
        public static UInt32 G_TC_CONV = Convert.ToUInt32(0 << G_MDSFT_TEXTCONV);
        public static UInt32 G_TC_FILTCONV = Convert.ToUInt32(5 << G_MDSFT_TEXTCONV);
        public static UInt32 G_TC_FILT = Convert.ToUInt32(6 << G_MDSFT_TEXTCONV);

                /* G_SETOTHERMODE_H gSetCombineKey */
        public static UInt32 G_CK_NONE = Convert.ToUInt32(0 << G_MDSFT_COMBKEY);
        public static UInt32 G_CK_KEY = Convert.ToUInt32(1 << G_MDSFT_COMBKEY);

                /* G_SETOTHERMODE_H gSetColorDither */
        public static UInt32 G_CD_MAGICSQ = Convert.ToUInt32(0 << G_MDSFT_RGBDITHER);
        public static UInt32 G_CD_BAYER = Convert.ToUInt32(1 << G_MDSFT_RGBDITHER);
        public static UInt32 G_CD_NOISE = Convert.ToUInt32(2 << G_MDSFT_RGBDITHER);




        public static UInt32 G_CD_ENABLE = Convert.ToUInt32(1 << G_MDSFT_COLORDITHER);
        public static UInt32 G_CD_DISABLE = Convert.ToUInt32(0 << G_MDSFT_COLORDITHER);
        

        /* G_SETOTHERMODE_H gSetAlphaDither */
        public static UInt32 G_AD_PATTERN = Convert.ToUInt32(0 << G_MDSFT_ALPHADITHER);
        public static UInt32 G_AD_NOTPATTERN = Convert.ToUInt32(1 << G_MDSFT_ALPHADITHER);
        public static UInt32 G_AD_NOISE = Convert.ToUInt32 (2 << G_MDSFT_ALPHADITHER);
        public static UInt32 G_AD_DISABLE = Convert.ToUInt32 (3 << G_MDSFT_ALPHADITHER);

        /* G_SETOTHERMODE_L gSetAlphaCompare */
        public static UInt32 G_AC_NONE = Convert.ToUInt32 (0 << G_MDSFT_ALPHACOMPARE);
        public static UInt32 G_AC_THRESHOLD = Convert.ToUInt32 (1 << G_MDSFT_ALPHACOMPARE);
        public static UInt32 G_AC_DITHER = Convert.ToUInt32 (3 << G_MDSFT_ALPHACOMPARE);

        /* G_SETOTHERMODE_L gSetDepthSource */
        public static UInt32 G_ZS_PIXEL = Convert.ToUInt32 (0 << G_MDSFT_ZSRCSEL);
        public static UInt32 G_ZS_PRIM = Convert.ToUInt32 (1 << G_MDSFT_ZSRCSEL);



        public static UInt32 GBL_c1(UInt32 m1a, UInt32 m1b, UInt32 m2a, UInt32 m2b)
        {
            return (Convert.ToUInt32((m1a) << 30 | (m1b) << 26 | (m2a) << 22 | (m2b) << 18) );
        }
        public static UInt32 GBL_c2(UInt32 m1a, UInt32 m1b, UInt32 m2a, UInt32 m2b)
        {
            return (Convert.ToUInt32((m1a) << 28 | (m1b) << 24 | (m2a) << 20 | (m2b) << 16) );
        }

        public static UInt32 RM_AA_ZB_OPA_SURF(UInt32 clk)
        {
            
            if (clk == 1)
            {
                return AA_EN | Z_CMP | Z_UPD | IM_RD | CVG_DST_CLAMP |
            ZMODE_OPA | ALPHA_CVG_SEL | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);   
            }
            else
            {
                return AA_EN | Z_CMP | Z_UPD | IM_RD | CVG_DST_CLAMP |
            ZMODE_OPA | ALPHA_CVG_SEL | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
        }

        public static UInt32 RM_RA_ZB_OPA_SURF(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | Z_CMP | Z_UPD | CVG_DST_CLAMP |
                ZMODE_OPA | ALPHA_CVG_SEL | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
            else
            {
                return AA_EN | Z_CMP | Z_UPD | CVG_DST_CLAMP |
                ZMODE_OPA | ALPHA_CVG_SEL | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
        }

        public static UInt32 RM_AA_ZB_XLU_SURF(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | Z_CMP | IM_RD | CVG_DST_WRAP | CLR_ON_CVG |
                FORCE_BL | ZMODE_XLU | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
            else
            {
                return AA_EN | Z_CMP | IM_RD | CVG_DST_WRAP | CLR_ON_CVG |
                FORCE_BL | ZMODE_XLU | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
        }

        public static UInt32 RM_AA_ZB_OPA_DECAL(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | Z_CMP | IM_RD | CVG_DST_WRAP | ALPHA_CVG_SEL |
                ZMODE_DEC | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
            else
            {
                return AA_EN | Z_CMP | IM_RD | CVG_DST_WRAP | ALPHA_CVG_SEL |
                ZMODE_DEC | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
        }

        public static UInt32 RM_RA_ZB_OPA_DECAL(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | Z_CMP | CVG_DST_WRAP | ALPHA_CVG_SEL |
                ZMODE_DEC | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
            else
            {
                return AA_EN | Z_CMP | CVG_DST_WRAP | ALPHA_CVG_SEL |
                ZMODE_DEC | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
        }

        public static UInt32 RM_AA_ZB_XLU_DECAL(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | Z_CMP | IM_RD | CVG_DST_WRAP | CLR_ON_CVG |
                FORCE_BL | ZMODE_DEC | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
            else
            {
                return AA_EN | Z_CMP | IM_RD | CVG_DST_WRAP | CLR_ON_CVG |
                FORCE_BL | ZMODE_DEC | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
        }
        public static UInt32 RM_AA_ZB_OPA_INTER(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | Z_CMP | Z_UPD | IM_RD | CVG_DST_CLAMP |
                ALPHA_CVG_SEL | ZMODE_INTER | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
            else
            {
                return AA_EN | Z_CMP | Z_UPD | IM_RD | CVG_DST_CLAMP |
                ALPHA_CVG_SEL | ZMODE_INTER | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
        }
        public static UInt32 RM_RA_ZB_OPA_INTER(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | Z_CMP | Z_UPD | IM_RD | CVG_DST_CLAMP |
                ALPHA_CVG_SEL | ZMODE_INTER | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
            else
            {
                return AA_EN | Z_CMP | Z_UPD | IM_RD | CVG_DST_CLAMP |
                ALPHA_CVG_SEL | ZMODE_INTER | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
        }

        public static UInt32 RM_AA_ZB_XLU_INTER(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | Z_CMP | IM_RD | CVG_DST_WRAP | CLR_ON_CVG |
                FORCE_BL | ZMODE_INTER | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
            else
            {
                return AA_EN | Z_CMP | IM_RD | CVG_DST_WRAP | CLR_ON_CVG |
                FORCE_BL | ZMODE_INTER | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
        }

        public static UInt32 RM_AA_ZB_XLU_LINE(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | Z_CMP | IM_RD | CVG_DST_CLAMP | CVG_X_ALPHA |
                ALPHA_CVG_SEL | FORCE_BL | ZMODE_XLU | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
            else
            {
                return AA_EN | Z_CMP | IM_RD | CVG_DST_CLAMP | CVG_X_ALPHA |
                ALPHA_CVG_SEL | FORCE_BL | ZMODE_XLU | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
        }

        public static UInt32 RM_AA_ZB_DEC_LINE(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | Z_CMP | IM_RD | CVG_DST_SAVE | CVG_X_ALPHA |
                ALPHA_CVG_SEL | FORCE_BL | ZMODE_DEC | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
            else
            {
                return AA_EN | Z_CMP | IM_RD | CVG_DST_SAVE | CVG_X_ALPHA |
                ALPHA_CVG_SEL | FORCE_BL | ZMODE_DEC | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
        }

        public static UInt32 RM_AA_ZB_TEX_EDGE(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | Z_CMP | Z_UPD | IM_RD | CVG_DST_CLAMP |
                CVG_X_ALPHA | ALPHA_CVG_SEL | ZMODE_OPA | TEX_EDGE | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
            else
            {
                return AA_EN | Z_CMP | Z_UPD | IM_RD | CVG_DST_CLAMP |
                CVG_X_ALPHA | ALPHA_CVG_SEL | ZMODE_OPA | TEX_EDGE | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
        }

        public static UInt32 RM_AA_ZB_TEX_INTER(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | Z_CMP | Z_UPD | IM_RD | CVG_DST_CLAMP |
                CVG_X_ALPHA | ALPHA_CVG_SEL | ZMODE_INTER | TEX_EDGE | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
            else
            {
                return AA_EN | Z_CMP | Z_UPD | IM_RD | CVG_DST_CLAMP |
                CVG_X_ALPHA | ALPHA_CVG_SEL | ZMODE_INTER | TEX_EDGE | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
        }

        public static UInt32 RM_AA_ZB_SUB_SURF(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | Z_CMP | Z_UPD | IM_RD | CVG_DST_FULL |
                ZMODE_OPA | ALPHA_CVG_SEL | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
            else
            {
                return AA_EN | Z_CMP | Z_UPD | IM_RD | CVG_DST_FULL |
                ZMODE_OPA | ALPHA_CVG_SEL | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
        }

        public static UInt32 RM_AA_ZB_PCL_SURF(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | Z_CMP | Z_UPD | IM_RD | CVG_DST_CLAMP |
                ZMODE_OPA | G_AC_DITHER | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
            else
            {
                return AA_EN | Z_CMP | Z_UPD | IM_RD | CVG_DST_CLAMP |
                ZMODE_OPA | G_AC_DITHER | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
        }

        public static UInt32 RM_AA_ZB_OPA_TERR(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | Z_CMP | Z_UPD | IM_RD | CVG_DST_CLAMP |
                ZMODE_OPA | ALPHA_CVG_SEL | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
            else
            {
                return AA_EN | Z_CMP | Z_UPD | IM_RD | CVG_DST_CLAMP |
                ZMODE_OPA | ALPHA_CVG_SEL | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
        }
        public static UInt32 RM_AA_ZB_TEX_TERR(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | Z_CMP | Z_UPD | IM_RD | CVG_DST_CLAMP |
                CVG_X_ALPHA | ALPHA_CVG_SEL | ZMODE_OPA | TEX_EDGE | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
            else
            {
                return AA_EN | Z_CMP | Z_UPD | IM_RD | CVG_DST_CLAMP |
                CVG_X_ALPHA | ALPHA_CVG_SEL | ZMODE_OPA | TEX_EDGE | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
        }

        public static UInt32 RM_AA_ZB_SUB_TERR(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | Z_CMP | Z_UPD | IM_RD | CVG_DST_FULL |
                ZMODE_OPA | ALPHA_CVG_SEL | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
            else
            {
                return AA_EN | Z_CMP | Z_UPD | IM_RD | CVG_DST_FULL |
                ZMODE_OPA | ALPHA_CVG_SEL | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
        }

        public static UInt32 RM_AA_OPA_SURF(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | IM_RD | CVG_DST_CLAMP |
                ZMODE_OPA | ALPHA_CVG_SEL | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
            else
            {
                return AA_EN | IM_RD | CVG_DST_CLAMP |
                ZMODE_OPA | ALPHA_CVG_SEL | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
        }
        public static UInt32 RM_RA_OPA_SURF(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | CVG_DST_CLAMP |
                ZMODE_OPA | ALPHA_CVG_SEL | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
            else
            {
                return AA_EN | CVG_DST_CLAMP |
                ZMODE_OPA | ALPHA_CVG_SEL | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
        }
        public static UInt32 RM_AA_XLU_SURF(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | IM_RD | CVG_DST_WRAP | CLR_ON_CVG | FORCE_BL |
                ZMODE_OPA | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
            else
            {
                return AA_EN | IM_RD | CVG_DST_WRAP | CLR_ON_CVG | FORCE_BL |
                ZMODE_OPA | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
        }
        public static UInt32 RM_AA_XLU_LINE(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | IM_RD | CVG_DST_CLAMP | CVG_X_ALPHA |
                ALPHA_CVG_SEL | FORCE_BL | ZMODE_OPA | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
            else
            {
                return AA_EN | IM_RD | CVG_DST_CLAMP | CVG_X_ALPHA |
                ALPHA_CVG_SEL | FORCE_BL | ZMODE_OPA | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
        }
        public static UInt32 RM_AA_DEC_LINE(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | IM_RD | CVG_DST_FULL | CVG_X_ALPHA |
                ALPHA_CVG_SEL | FORCE_BL | ZMODE_OPA | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
            else
            {
                return AA_EN | IM_RD | CVG_DST_FULL | CVG_X_ALPHA |
                ALPHA_CVG_SEL | FORCE_BL | ZMODE_OPA | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
        }
        public static UInt32 RM_AA_TEX_EDGE(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | IM_RD | CVG_DST_CLAMP |
                CVG_X_ALPHA | ALPHA_CVG_SEL | ZMODE_OPA | TEX_EDGE | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
            else
            {
                return AA_EN | IM_RD | CVG_DST_CLAMP |
                CVG_X_ALPHA | ALPHA_CVG_SEL | ZMODE_OPA | TEX_EDGE | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
        }
        public static UInt32 RM_AA_SUB_SURF(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | IM_RD | CVG_DST_FULL |
                ZMODE_OPA | ALPHA_CVG_SEL | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
            else
            {
                return AA_EN | IM_RD | CVG_DST_FULL |
                ZMODE_OPA | ALPHA_CVG_SEL | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
        }
        public static UInt32 RM_AA_PCL_SURF(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | IM_RD | CVG_DST_CLAMP |
                ZMODE_OPA | G_AC_DITHER | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
            else
            {
                return AA_EN | IM_RD | CVG_DST_CLAMP |
                ZMODE_OPA | G_AC_DITHER | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
        }
        //
        //
        //
        //
        public static UInt32 RM_AA_OPA_TERR(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | IM_RD | CVG_DST_CLAMP |
                ZMODE_OPA | ALPHA_CVG_SEL | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
            else
            {
                return AA_EN | IM_RD | CVG_DST_CLAMP |
                ZMODE_OPA | ALPHA_CVG_SEL | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
        }
        public static UInt32 RM_AA_TEX_TERR(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | IM_RD | CVG_DST_CLAMP |
                CVG_X_ALPHA | ALPHA_CVG_SEL | ZMODE_OPA | TEX_EDGE | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
            else
            {
                return AA_EN | IM_RD | CVG_DST_CLAMP |
                CVG_X_ALPHA | ALPHA_CVG_SEL | ZMODE_OPA | TEX_EDGE | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
        }
        public static UInt32 RM_AA_SUB_TERR(UInt32 clk)
        {
            if (clk == 1)
            {
                return AA_EN | IM_RD | CVG_DST_FULL |
                ZMODE_OPA | ALPHA_CVG_SEL | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
            else
            {
                return AA_EN | IM_RD | CVG_DST_FULL |
                ZMODE_OPA | ALPHA_CVG_SEL | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
        }
        public static UInt32 RM_ZB_OPA_SURF(UInt32 clk)
        {
            if (clk == 1)
            {
                return Z_CMP | Z_UPD | CVG_DST_FULL | ALPHA_CVG_SEL |
                ZMODE_OPA | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
            else
            {
                return Z_CMP | Z_UPD | CVG_DST_FULL | ALPHA_CVG_SEL |
                ZMODE_OPA | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
        }
        public static UInt32 RM_ZB_XLU_SURF(UInt32 clk)
        {
            if (clk == 1)
            {
                return Z_CMP | IM_RD | CVG_DST_FULL | FORCE_BL | ZMODE_XLU | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
            else
            {
                return Z_CMP | IM_RD | CVG_DST_FULL | FORCE_BL | ZMODE_XLU | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
        }
        public static UInt32 RM_ZB_OPA_DECAL(UInt32 clk)
        {
            if (clk == 1)
            {
                return Z_CMP | CVG_DST_FULL | ALPHA_CVG_SEL | ZMODE_DEC | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
            else
            {
                return Z_CMP | CVG_DST_FULL | ALPHA_CVG_SEL | ZMODE_DEC | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_A_MEM);
            }
        }
        public static UInt32 RM_ZB_XLU_DECAL(UInt32 clk)
        {
            if (clk == 1)
            {
                return Z_CMP | IM_RD | CVG_DST_FULL | FORCE_BL | ZMODE_DEC | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
            else
            {
                return Z_CMP | IM_RD | CVG_DST_FULL | FORCE_BL | ZMODE_DEC | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
        }
        public static UInt32 RM_ZB_CLD_SURF(UInt32 clk)
        {
            if (clk == 1)
            {
                return Z_CMP | IM_RD | CVG_DST_SAVE | FORCE_BL | ZMODE_XLU | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
            else
            {
                return Z_CMP | IM_RD | CVG_DST_SAVE | FORCE_BL | ZMODE_XLU | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
        }
        public static UInt32 RM_ZB_OVL_SURF(UInt32 clk)
        {
            if (clk == 1)
            {
                return Z_CMP | IM_RD | CVG_DST_SAVE | FORCE_BL | ZMODE_DEC | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
            else
            {
                return Z_CMP | IM_RD | CVG_DST_SAVE | FORCE_BL | ZMODE_DEC | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
        }
        public static UInt32 RM_ZB_PCL_SURF(UInt32 clk)
        {
            if (clk == 1)
            {
                return Z_CMP | Z_UPD | CVG_DST_FULL | ZMODE_OPA |
                G_AC_DITHER | GBL_c1(G_BL_CLR_IN, G_BL_0, G_BL_CLR_IN, G_BL_1);
            }
            else
            {
                return Z_CMP | Z_UPD | CVG_DST_FULL | ZMODE_OPA |
                G_AC_DITHER | GBL_c2(G_BL_CLR_IN, G_BL_0, G_BL_CLR_IN, G_BL_1);
            }
        }
        public static UInt32 RM_OPA_SURF(UInt32 clk)
        {
            if (clk == 1)
            {
                return CVG_DST_CLAMP | FORCE_BL | ZMODE_OPA | GBL_c1(G_BL_CLR_IN, G_BL_0, G_BL_CLR_IN, G_BL_1);
            }
            else
            {
                return CVG_DST_CLAMP | FORCE_BL | ZMODE_OPA | GBL_c2(G_BL_CLR_IN, G_BL_0, G_BL_CLR_IN, G_BL_1);
            }
        }
        public static UInt32 RM_XLU_SURF(UInt32 clk)
        {
            if (clk == 1)
            {
                return IM_RD | CVG_DST_FULL | FORCE_BL | ZMODE_OPA | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
            else
            {
                return IM_RD | CVG_DST_FULL | FORCE_BL | ZMODE_OPA | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
        }
        public static UInt32 RM_TEX_EDGE(UInt32 clk)
        {
            if (clk == 1)
            {
                return CVG_DST_CLAMP | CVG_X_ALPHA | ALPHA_CVG_SEL | FORCE_BL |
                ZMODE_OPA | TEX_EDGE | AA_EN | GBL_c1(G_BL_CLR_IN, G_BL_0, G_BL_CLR_IN, G_BL_1);
            }
            else
            {
                return CVG_DST_CLAMP | CVG_X_ALPHA | ALPHA_CVG_SEL | FORCE_BL |
                ZMODE_OPA | TEX_EDGE | AA_EN | GBL_c2(G_BL_CLR_IN, G_BL_0, G_BL_CLR_IN, G_BL_1);
            }
        }
        public static UInt32 RM_CLD_SURF(UInt32 clk)
        {
            if (clk == 1)
            {
                return IM_RD | CVG_DST_SAVE | FORCE_BL | ZMODE_OPA | GBL_c1(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
            else
            {
                return IM_RD | CVG_DST_SAVE | FORCE_BL | ZMODE_OPA | GBL_c2(G_BL_CLR_IN, G_BL_A_IN, G_BL_CLR_MEM, G_BL_1MA);
            }
        }
        public static UInt32 RM_PCL_SURF(UInt32 clk)
        {
            if (clk == 1)
            {
                return CVG_DST_FULL | FORCE_BL | ZMODE_OPA |
                G_AC_DITHER | GBL_c1(G_BL_CLR_IN, G_BL_0, G_BL_CLR_IN, G_BL_1);
            }
            else
            {
                return CVG_DST_FULL | FORCE_BL | ZMODE_OPA |
                G_AC_DITHER | GBL_c2(G_BL_CLR_IN, G_BL_0, G_BL_CLR_IN, G_BL_1);
            }
        }
        
        public static UInt32 RM_ADD(UInt32 clk)
        {
            if (clk == 1)
            {
                return IM_RD | CVG_DST_SAVE | FORCE_BL | ZMODE_OPA | GBL_c1(G_BL_CLR_IN, G_BL_A_FOG, G_BL_CLR_MEM, G_BL_1);
            }
            else
            {
                return IM_RD | CVG_DST_SAVE | FORCE_BL | ZMODE_OPA | GBL_c2(G_BL_CLR_IN, G_BL_A_FOG, G_BL_CLR_MEM, G_BL_1);
            }
        }
        public static UInt32 RM_NOOP(UInt32 clk)
        {
            if (clk == 1)
            {
                return  GBL_c1(0, 0, 0, 0);
            }
            else
            {
                return GBL_c2(0, 0, 0, 0);
            }
        }

        public static UInt32 RM_VISCVG(UInt32 clk)
        {
            if (clk == 1)
            {
                return IM_RD | FORCE_BL | GBL_c1(G_BL_CLR_IN, G_BL_0, G_BL_CLR_BL, G_BL_A_MEM);
            }
            else
            {
                return IM_RD | FORCE_BL | GBL_c2(G_BL_CLR_IN, G_BL_0, G_BL_CLR_BL, G_BL_A_MEM);
            }
        }
        public static UInt32 RM_OPA_CI(UInt32 clk)
        {
            if (clk == 1)
            {
                return CVG_DST_CLAMP | ZMODE_OPA | GBL_c1(G_BL_CLR_IN, G_BL_0, G_BL_CLR_IN, G_BL_1);
            }
            else
            {
                return CVG_DST_CLAMP | ZMODE_OPA | GBL_c2(G_BL_CLR_IN, G_BL_0, G_BL_CLR_IN, G_BL_1);
            }
        }

        public static UInt32 G_RM_AA_ZB_OPA_SURF = RM_AA_ZB_OPA_SURF(1);
        public static UInt32 G_RM_AA_ZB_OPA_SURF2 = RM_AA_ZB_OPA_SURF(2);
        public static UInt32 G_RM_AA_ZB_XLU_SURF = RM_AA_ZB_XLU_SURF(1);
        public static UInt32 G_RM_AA_ZB_XLU_SURF2 = RM_AA_ZB_XLU_SURF(2);
        public static UInt32 G_RM_AA_ZB_OPA_DECAL = RM_AA_ZB_OPA_DECAL(1);
        public static UInt32 G_RM_AA_ZB_OPA_DECAL2 = RM_AA_ZB_OPA_DECAL(2);
        public static UInt32 G_RM_AA_ZB_XLU_DECAL = RM_AA_ZB_XLU_DECAL(1);
        public static UInt32 G_RM_AA_ZB_XLU_DECAL2 = RM_AA_ZB_XLU_DECAL(2);
        public static UInt32 G_RM_AA_ZB_OPA_INTER = RM_AA_ZB_OPA_INTER(1);
        public static UInt32 G_RM_AA_ZB_OPA_INTER2 = RM_AA_ZB_OPA_INTER(2);
        public static UInt32 G_RM_AA_ZB_XLU_INTER = RM_AA_ZB_XLU_INTER(1);
        public static UInt32 G_RM_AA_ZB_XLU_INTER2 = RM_AA_ZB_XLU_INTER(2);
        public static UInt32 G_RM_AA_ZB_XLU_LINE = RM_AA_ZB_XLU_LINE(1);
        public static UInt32 G_RM_AA_ZB_XLU_LINE2 = RM_AA_ZB_XLU_LINE(2);
        public static UInt32 G_RM_AA_ZB_DEC_LINE = RM_AA_ZB_DEC_LINE(1);
        public static UInt32 G_RM_AA_ZB_DEC_LINE2 = RM_AA_ZB_DEC_LINE(2);
        public static UInt32 G_RM_AA_ZB_TEX_EDGE = RM_AA_ZB_TEX_EDGE(1);
        public static UInt32 G_RM_AA_ZB_TEX_EDGE2 = RM_AA_ZB_TEX_EDGE(2);
        public static UInt32 G_RM_AA_ZB_TEX_INTER = RM_AA_ZB_TEX_INTER(1);
        public static UInt32 G_RM_AA_ZB_TEX_INTER2 = RM_AA_ZB_TEX_INTER(2);
        public static UInt32 G_RM_AA_ZB_SUB_SURF = RM_AA_ZB_SUB_SURF(1);
        public static UInt32 G_RM_AA_ZB_SUB_SURF2 = RM_AA_ZB_SUB_SURF(2);
        public static UInt32 G_RM_AA_ZB_PCL_SURF = RM_AA_ZB_PCL_SURF(1);
        public static UInt32 G_RM_AA_ZB_PCL_SURF2 = RM_AA_ZB_PCL_SURF(2);
        public static UInt32 G_RM_AA_ZB_OPA_TERR = RM_AA_ZB_OPA_TERR(1);
        public static UInt32 G_RM_AA_ZB_OPA_TERR2 = RM_AA_ZB_OPA_TERR(2);
        public static UInt32 G_RM_AA_ZB_TEX_TERR = RM_AA_ZB_TEX_TERR(1);
        public static UInt32 G_RM_AA_ZB_TEX_TERR2 = RM_AA_ZB_TEX_TERR(2);
        public static UInt32 G_RM_AA_ZB_SUB_TERR = RM_AA_ZB_SUB_TERR(1);
        public static UInt32 G_RM_AA_ZB_SUB_TERR2 = RM_AA_ZB_SUB_TERR(2);

        public static UInt32[] RenderModes = new UInt32[]
        {
            G_RM_AA_ZB_OPA_SURF,
            G_RM_AA_ZB_OPA_SURF2,
            G_RM_AA_ZB_XLU_SURF,
            G_RM_AA_ZB_XLU_SURF2,
            G_RM_AA_ZB_OPA_DECAL,
            G_RM_AA_ZB_OPA_DECAL2,
            G_RM_AA_ZB_XLU_DECAL,
            G_RM_AA_ZB_XLU_DECAL2,
            G_RM_AA_ZB_OPA_INTER,
            G_RM_AA_ZB_OPA_INTER2,
            G_RM_AA_ZB_XLU_INTER,
            G_RM_AA_ZB_XLU_INTER2,
            G_RM_AA_ZB_XLU_LINE,
            G_RM_AA_ZB_XLU_LINE2,
            G_RM_AA_ZB_DEC_LINE,
            G_RM_AA_ZB_DEC_LINE2,
            G_RM_AA_ZB_TEX_EDGE,
            G_RM_AA_ZB_TEX_EDGE2,
            G_RM_AA_ZB_TEX_INTER,
            G_RM_AA_ZB_TEX_INTER2,
            G_RM_AA_ZB_SUB_SURF,
            G_RM_AA_ZB_SUB_SURF2,
            G_RM_AA_ZB_PCL_SURF,
            G_RM_AA_ZB_PCL_SURF2,
            G_RM_AA_ZB_OPA_TERR,
            G_RM_AA_ZB_OPA_TERR2,
            G_RM_AA_ZB_TEX_TERR,
            G_RM_AA_ZB_TEX_TERR2,
            G_RM_AA_ZB_SUB_TERR,
            G_RM_AA_ZB_SUB_TERR2,
        };



        public static UInt32 G_RM_RA_ZB_OPA_SURF = RM_RA_ZB_OPA_SURF(1);
        public static UInt32 G_RM_RA_ZB_OPA_SURF2 = RM_RA_ZB_OPA_SURF(2);
        public static UInt32 G_RM_RA_ZB_OPA_DECAL = RM_RA_ZB_OPA_DECAL(1);
        public static UInt32 G_RM_RA_ZB_OPA_DECAL2 = RM_RA_ZB_OPA_DECAL(2);
        public static UInt32 G_RM_RA_ZB_OPA_INTER = RM_RA_ZB_OPA_INTER(1);
        public static UInt32 G_RM_RA_ZB_OPA_INTER2 = RM_RA_ZB_OPA_INTER(2);

        public static UInt32 G_RM_AA_OPA_SURF = RM_AA_OPA_SURF(1);
        public static UInt32 G_RM_AA_OPA_SURF2 = RM_AA_OPA_SURF(2);
        public static UInt32 G_RM_AA_XLU_SURF = RM_AA_XLU_SURF(1);
        public static UInt32 G_RM_AA_XLU_SURF2 = RM_AA_XLU_SURF(2);
        public static UInt32 G_RM_AA_XLU_LINE = RM_AA_XLU_LINE(1);
        public static UInt32 G_RM_AA_XLU_LINE2 = RM_AA_XLU_LINE(2);
        public static UInt32 G_RM_AA_DEC_LINE = RM_AA_DEC_LINE(1);
        public static UInt32 G_RM_AA_DEC_LINE2 = RM_AA_DEC_LINE(2);
        public static UInt32 G_RM_AA_TEX_EDGE = RM_AA_TEX_EDGE(1);
        public static UInt32 G_RM_AA_TEX_EDGE2 = RM_AA_TEX_EDGE(2);
        public static UInt32 G_RM_AA_SUB_SURF = RM_AA_SUB_SURF(1);
        public static UInt32 G_RM_AA_SUB_SURF2 = RM_AA_SUB_SURF(2);
        public static UInt32 G_RM_AA_PCL_SURF = RM_AA_PCL_SURF(1);
        public static UInt32 G_RM_AA_PCL_SURF2 = RM_AA_PCL_SURF(2);
        public static UInt32 G_RM_AA_OPA_TERR = RM_AA_OPA_TERR(1);
        public static UInt32 G_RM_AA_OPA_TERR2 = RM_AA_OPA_TERR(2);
        public static UInt32 G_RM_AA_TEX_TERR = RM_AA_TEX_TERR(1);
        public static UInt32 G_RM_AA_TEX_TERR2 = RM_AA_TEX_TERR(2);
        public static UInt32 G_RM_AA_SUB_TERR = RM_AA_SUB_TERR(1);
        public static UInt32 G_RM_AA_SUB_TERR2 = RM_AA_SUB_TERR(2);

        public static UInt32 G_RM_RA_OPA_SURF = RM_RA_OPA_SURF(1);
        public static UInt32 G_RM_RA_OPA_SURF2 = RM_RA_OPA_SURF(2);

        public static UInt32 G_RM_ZB_OPA_SURF = RM_ZB_OPA_SURF(1);
        public static UInt32 G_RM_ZB_OPA_SURF2 = RM_ZB_OPA_SURF(2);
        public static UInt32 G_RM_ZB_XLU_SURF = RM_ZB_XLU_SURF(1);
        public static UInt32 G_RM_ZB_XLU_SURF2 = RM_ZB_XLU_SURF(2);
        public static UInt32 G_RM_ZB_OPA_DECAL = RM_ZB_OPA_DECAL(1);
        public static UInt32 G_RM_ZB_OPA_DECAL2 = RM_ZB_OPA_DECAL(2);
        public static UInt32 G_RM_ZB_XLU_DECAL = RM_ZB_XLU_DECAL(1);
        public static UInt32 G_RM_ZB_XLU_DECAL2 = RM_ZB_XLU_DECAL(2);
        public static UInt32 G_RM_ZB_CLD_SURF = RM_ZB_CLD_SURF(1);
        public static UInt32 G_RM_ZB_CLD_SURF2 = RM_ZB_CLD_SURF(2);
        public static UInt32 G_RM_ZB_OVL_SURF = RM_ZB_OVL_SURF(1);
        public static UInt32 G_RM_ZB_OVL_SURF2 = RM_ZB_OVL_SURF(2);
        public static UInt32 G_RM_ZB_PCL_SURF = RM_ZB_PCL_SURF(1);
        public static UInt32 G_RM_ZB_PCL_SURF2 = RM_ZB_PCL_SURF(2);

        public static UInt32 G_RM_OPA_SURF = RM_OPA_SURF(1);
        public static UInt32 G_RM_OPA_SURF2 = RM_OPA_SURF(2);
        public static UInt32 G_RM_XLU_SURF = RM_XLU_SURF(1);
        public static UInt32 G_RM_XLU_SURF2 = RM_XLU_SURF(2);
        public static UInt32 G_RM_CLD_SURF = RM_CLD_SURF(1);
        public static UInt32 G_RM_CLD_SURF2 = RM_CLD_SURF(2);
        public static UInt32 G_RM_TEX_EDGE = RM_TEX_EDGE(1);
        public static UInt32 G_RM_TEX_EDGE2 = RM_TEX_EDGE(2);
        public static UInt32 G_RM_PCL_SURF = RM_PCL_SURF(1);
        public static UInt32 G_RM_PCL_SURF2 = RM_PCL_SURF(2);
        
        public static UInt32 G_RM_ADD = RM_ADD(1);
        public static UInt32 G_RM_ADD2 = RM_ADD(2);
        public static UInt32 G_RM_NOOP = RM_NOOP(1);
        public static UInt32 G_RM_NOOP2 = RM_NOOP(2);
        public static UInt32 G_RM_VISCVG = RM_VISCVG(1);
        public static UInt32 G_RM_VISCVG2 = RM_VISCVG(2);
        public static UInt32 G_RM_OPA_CI = RM_OPA_CI(1);
        public static UInt32 G_RM_OPA_CI2 = RM_OPA_CI(2);











        public static UInt32[] GeometryModes = new UInt32[]
        {
            G_ZBUFFER,
            G_SHADE,
            G_SHADING_SMOOTH,
            G_CULL_FRONT,
            G_CULL_BACK,
            G_CULL_BOTH,
            G_FOG,
            G_LIGHTING,
            G_TEXTURE_GEN,
            G_TEXTURE_GEN_LINEAR,
            G_LOD,
            G_CLIPPING
        };
        public static UInt32 AllGeometryModes =
            G_ZBUFFER |
            G_SHADE |
            G_SHADING_SMOOTH |
            G_CULL_BOTH |
            G_FOG |
            G_LIGHTING |
            G_TEXTURE_GEN |
            G_TEXTURE_GEN_LINEAR |
            G_LOD |
            G_CLIPPING;

        public static string[] GeometryModeNames = new string[]
        {
            "G_ZBUFFER",
            "G_SHADE",
            "G_SHADING_SMOOTH",
            "G_CULL_FRONT",
            "G_CULL_BACK",
            "G_CULL_BOTH",
            "G_FOG",
            "G_LIGHTING",
            "G_TEXTURE_GEN",
            "G_TEXTURE_GEN_LINEAR",
            "G_LOD",
            "G_CLIPPING"
        };
    }
}
