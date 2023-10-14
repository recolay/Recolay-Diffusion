using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stable_Diffusion_Recolay
{
    public partial class FaProm : Form
    {
        public FaProm()
        {
            InitializeComponent();
            L1.Hide();
            L2.Hide();
            P1.Hide();
            P2.Hide();
            P3.Hide();
            P4.Hide();
            P5.Hide();
            P6.Hide();
            P7.Hide();
            P8.Hide();
            P9.Hide();
            P10.Hide();
            P1.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Clipboard.SetText("The text you want to copy");
        }

        private void FaProm_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("1mechanical girl,ultra realistic details, portrait, global illumination, shadows, octane render, 8k, ultra sharp,intricate, ornaments detailed, cold colors, metal, egypician detail, highly intricate details, realistic light, trending on cgsociety, glowing eyes, facing camera, neon details, machanical limbs,blood vessels connected to tubes,mechanical vertebra attaching to back,mechanical cervial attaching to neck,sitting,wires and cables connecting to head\r\nNegative prompt: NSFW,3d, cartoon, lowres, bad anatomy, bad hands, text, error, missing fingers, extra digit, fewer digits, cropped, worst quality, low quality, normal quality, jpeg artifacts, signature, watermark, username, blurry, artist name, young, loli, elf, 3d, illustration  ng_deepnegative_v1_75t\r\nSteps: 30, ENSD: 31337, Size: 512x768, Seed: 587662610, Model: GhostMix-V2.0-fp16-BakedVAE, Sampler: DPM++ 2M Karras, CFG scale: 5, Model hash: 0f5ef4c164, Hires steps: 20, Hires upscale: 2, Hires upscaler: 4x-UltraSharp, Denoising strength: 0.5");
            L1.Show();
            L2.Show();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("((Best quality)), ((masterpiece)), abandoned brutalist architecture of Pripyat, rainy day, thunder, thunderbolt, hyper realistic DSLR photo, Nikon D5 <lora:add_detail:1>,black,dark,mist,horror\r\nNegative prompt: ng_deepnegative_v1_75t,easynegative,(worst quality:2), (low quality:2), (normal quality:1.8), lowres, ((monochrome)), ((grayscale)),sketch,ugly,morbid, deformed,logo,text, bad anatomy,bad proportions,disfigured,extra arms, extra legs, fused fingers,extra digits, fewer digits, mutated hands, poorly drawn hands,bad hands, (loli, young, child, infant, teenager:1.5), ((((turned on lights))))\r\nSteps: 30, ENSD: 31337, Size: 512x768, Seed: 1115696394, Model: GhostMix-V2.0-fp16-BakedVAE, Sampler: DPM++ 2M Karras, CFG scale: 7, Model hash: e3edb8a26f, Hires upscale: 2, Hires upscaler: R-ESRGAN 4x+, Denoising strength: 0.5");
            L1.Show();
            L2.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("(masterpiece, best quality:1.4),(absurdres, highres, ultra detailed:1.2), (1 handsome man:1.4),(using dark magic:1.4),purple magic,playful illustrations, fractal art,imaginative overlays, artistic fusion,fantastical scenes, evocative narratives, striking visuals, upper body,<lora:kVoidEnergy-000001:0.8> ,<lora:LowRA:0.4>\r\nNegative prompt: (worst quality, low quality:2), NSFW,monochrome, zombie,overexposure, watermark,text,bad anatomy,bad hand,((extra hands)),extra fingers,too many fingers,fused fingers,bad arm,distorted arm,extra arms,fused arms,extra legs,missing leg,disembodied leg,extra nipples, detached arm, liquid hand,inverted hand,disembodied limb, oversized head,extra body,extra navel,easynegative,(hair between eyes),sketch, duplicate, ugly, huge eyes, text, logo, worst face, (bad and mutated hands:1.3),  (blurry:2.0), horror, geometry, bad_prompt, (bad hands), (missing fingers), multiple limbs, bad anatomy, (interlocked fingers:1.2), Ugly Fingers, (extra digit and hands and fingers and legs and arms:1.4), (deformed fingers:1.2), (long fingers:1.2),(bad-artist-anime), bad-artist, bad hand, extra legs ,(ng_deepnegative_v1_75t),((hands on head))\r\nSteps: 30, ENSD: 31337, Size: 512x768, Seed: 584098645, Model: GhostMix-V2.0-fp16-BakedVAE, Sampler: DPM++ 2M Karras, CFG scale: 7, Model hash: e3edb8a26f, Hires steps: 20, Hires upscale: 2, Hires upscaler: R-ESRGAN 4x+ Anime6B, Denoising strength: 0.5");
            L1.Show();
            L2.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            P1.Hide();
            P2.Hide();
            P3.Hide();
            P4.Hide();
            P5.Hide();
            P6.Hide();
            P7.Hide();
            P8.Hide();
            P9.Hide();
            P10.Hide();
            P1.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            P1.Hide();
            P2.Hide();
            P3.Hide();
            P4.Hide();
            P5.Hide();
            P6.Hide();
            P7.Hide();
            P8.Hide();
            P9.Hide();
            P10.Hide();
            P2.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            P1.Hide();
            P2.Hide();
            P3.Hide();
            P4.Hide();
            P5.Hide();
            P6.Hide();
            P7.Hide();
            P8.Hide();
            P9.Hide();
            P10.Hide();
            P3.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            //p4
            P1.Hide();
            P2.Hide();
            P3.Hide();
            P4.Hide();
            P5.Hide();
            P6.Hide();
            P7.Hide();
            P8.Hide();
            P9.Hide();
            P10.Hide();
            P4.Show();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            //p5
            P1.Hide();
            P2.Hide();
            P3.Hide();
            P4.Hide();
            P5.Hide();
            P6.Hide();
            P7.Hide();
            P8.Hide();
            P9.Hide();
            P10.Hide();
            P5.Show();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            //p6
            P1.Hide();
            P2.Hide();
            P3.Hide();
            P4.Hide();
            P5.Hide();
            P6.Hide();
            P7.Hide();
            P8.Hide();
            P9.Hide();
            P10.Hide();
            P6.Show();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            //p7
            P1.Hide();
            P2.Hide();
            P3.Hide();
            P4.Hide();
            P5.Hide();
            P6.Hide();
            P7.Hide();
            P8.Hide();
            P9.Hide();
            P10.Hide();
            P7.Show();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            //p8
            P1.Hide();
            P2.Hide();
            P3.Hide();
            P4.Hide();
            P5.Hide();
            P6.Hide();
            P7.Hide();
            P8.Hide();
            P9.Hide();
            P10.Hide();
            P8.Show();
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            //p9
            P1.Hide();
            P2.Hide();
            P3.Hide();
            P4.Hide();
            P5.Hide();
            P6.Hide();
            P7.Hide();
            P8.Hide();
            P9.Hide();
            P10.Hide();
            P9.Show();
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            //p10
            P1.Hide();
            P2.Hide();
            P3.Hide();
            P4.Hide();
            P5.Hide();
            P6.Hide();
            P7.Hide();
            P8.Hide();
            P9.Hide();
            P10.Hide();
            P10.Show();
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("1mechanical girl,ultra realistic details, (portrait), global illumination, shadows, octane render, 8k, ultra sharp,intricate, ornaments detailed, cold colors, metal, egypician detail, highly intricate details, realistic light, trending on cgsociety, glowing eyes, facing camera, neon details, machanical limbs,blood vessels connected to tubes,mechanical vertebra attaching to back,mechanical cervial attaching to neck,sitting,wires and cables connecting to head, <lora:IvoryGoldAIv2:1>\r\nNegative prompt: NSFW,3d, cartoon, lowres, bad anatomy, bad hands, text, error, missing fingers, extra digit, fewer digits, cropped, worst quality, low quality, normal quality, jpeg artifacts, signature, watermark, username, blurry, artist name, young, loli, elf, 3d, illustration  ng_deepnegative_v1_75t\r\nSteps: 30, ENSD: 31337, Size: 512x768, Seed: 2387473085, Model: GhostMix-V2.0-fp16-BakedVAE, Sampler: DPM++ 2M Karras, CFG scale: 5, Model hash: e3edb8a26f, Hires steps: 20, Hires upscale: 2, Hires upscaler: 4x-UltraSharp, Denoising strength: 0.5");
            L1.Show();
            L2.Show();
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("1mechanical man,((ultra realistic details)), portrait,octane render, 8k, ultra sharp,intricate,  illumination,, metal, chinese style,chinese dragon, egypician detail, highly intricate details, realistic light, shadows, ornaments detailed, cold colors trending on cgsociety, glowing eyes, facing camera, neon details, machanical limbs,blood vessels connected to tubes,mechanical vertebra attaching to back,mechanical cervial attaching to neck,sitting,wires and cables connecting to head\r\nNegative prompt: NSFW,3d, cartoon, lowres, bad anatomy, bad hands, text, error, missing fingers, extra digit, fewer digits, cropped, worst quality, low quality, normal quality, jpeg artifacts, signature, watermark, username, blurry, artist name, young, loli, elf, 3d, illustration  ng_deepnegative_v1_75t\r\nSteps: 30, ENSD: 31337, Size: 512x768, Seed: 1379341466, Model: GhostMix-V2.0-fp16-BakedVAE, Sampler: DPM++ 2M Karras, CFG scale: 5, Model hash: 0f5ef4c164, Hires steps: 20, Hires upscale: 2, Hires upscaler: 4x-UltraSharp, Denoising strength: 0.5");
            L1.Show();
            L2.Show();
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("(masterpiece, top quality, best quality, official art, beautiful and aesthetic:1.2), (1girl), extreme detailed,(fractal art:1.3),colorful,highest detailed\r\nNegative prompt: (worst quality, low quality:2), monochrome, zombie,overexposure, watermark,text,bad anatomy,bad hand,extra hands,extra fingers,too many fingers,fused fingers,bad arm,distorted arm,extra arms,fused arms,extra legs,missing leg,disembodied leg,extra nipples, detached arm, liquid hand,inverted hand,disembodied limb, small breasts, loli, oversized head,extra body,completely nude, extra navel,easynegative,(hair between eyes),sketch, duplicate, ugly, huge eyes, text, logo, worst face, (bad and mutated hands:1.3),  (blurry:2.0), horror, geometry, bad_prompt, (bad hands), (missing fingers), multiple limbs, bad anatomy, (interlocked fingers:1.2), Ugly Fingers, (extra digit and hands and fingers and legs and arms:1.4), ((2girl)), (deformed fingers:1.2), (long fingers:1.2),(bad-artist-anime), bad-artist, bad hand, extra legs ,(ng_deepnegative_v1_75t)\r\nSteps: 30, ENSD: 31337, Size: 512x768, Seed: 2473653543, Model: GhostMix-V2.0-fp16-BakedVAE, Sampler: DPM++ 2M Karras, CFG scale: 7, Clip skip: 2, Model hash: 0f5ef4c164, Hires steps: 20, Hires upscale: 2, Hires upscaler: R-ESRGAN 4x+ Anime6B, Denoising strength: 0.5");
            L1.Show();
            L2.Show();
        }

        private void guna2Button22_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("1mechanical girl,((ultra realistic details)), portrait, detailed face,global illumination, shadows, octane render, 8k, ultra sharp,metal,intricate,  ornaments detailed, cold colors, egypician detail, highly intricate details, realistic light, trending on cgsociety, glowing eyes, facing camera, neon details, machanical limbs,blood vessels connected to tubes,mechanical cervial attaching to neck,wires and cables connecting to head,blood,from side\r\nNegative prompt: NSFW,3d, cartoon, lowres, bad anatomy, bad hands, text, error, missing fingers, extra digit, fewer digits, cropped, worst quality, low quality, normal quality, jpeg artifacts, signature, watermark, username, blurry, artist name, young, loli, elf, 3d, illustration  ng_deepnegative_v1_75t  EasyNegative\r\nSteps: 30, ENSD: 31337, Size: 512x768, Seed: 808625613, Model: GhostMix-V2.0-fp16-BakedVAE, Sampler: DPM++ 2M Karras, CFG scale: 5, Clip skip: 2, Model hash: 0f5ef4c164, Hires steps: 20, Hires upscale: 2, Hires upscaler: 4x-UltraSharp, Denoising strength: 0.5");
            L1.Show();
            L2.Show();
        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("1mechanical girl,((ultra realistic details)), portrait, global illumination, shadows, octane render, 8k, ultra sharp,metal,intricate, ornaments detailed, cold colors, egypician detail, highly intricate details, realistic light, trending on cgsociety, glowing eyes, facing camera, neon details, machanical limbs,blood vessels connected to tubes,mechanical vertebra attaching to back,mechanical cervial attaching to neck,sitting,wires and cables connecting to head\r\nNegative prompt: NSFW,3d, cartoon, lowres, bad anatomy, bad hands, text, error, missing fingers, extra digit, fewer digits, cropped, worst quality, low quality, normal quality, jpeg artifacts, signature, watermark, username, blurry, artist name, young, loli, elf, 3d, illustration  ng_deepnegative_v1_75t\r\nSteps: 30, ENSD: 31337, Size: 512x768, Seed: 4006085557, Model: GhostMix-V2.0-fp16-BakedVAE, Sampler: DPM++ 2M Karras, CFG scale: 5, Model hash: 0f5ef4c164, Hires steps: 20, Hires upscale: 2, Hires upscaler: 4x-UltraSharp, Denoising strength: 0.5");
            L1.Show();
            L2.Show();
        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("(masterpiece, top quality, best quality, official art, beautiful and aesthetic:1.2), (1girl), extreme detailed,(fractal art:1.3),colorful,highest detailed\r\nNegative prompt: (worst quality, low quality:2), monochrome, zombie,overexposure, watermark,text,bad anatomy,bad hand,extra hands,extra fingers,too many fingers,fused fingers,bad arm,distorted arm,extra arms,fused arms,extra legs,missing leg,disembodied leg,extra nipples, detached arm, liquid hand,inverted hand,disembodied limb, small breasts, loli, oversized head,extra body,completely nude, extra navel,easynegative,(hair between eyes),sketch, duplicate, ugly, huge eyes, text, logo, worst face, (bad and mutated hands:1.3),  (blurry:2.0), horror, geometry, bad_prompt, (bad hands), (missing fingers), multiple limbs, bad anatomy, (interlocked fingers:1.2), Ugly Fingers, (extra digit and hands and fingers and legs and arms:1.4), ((2girl)), (deformed fingers:1.2), (long fingers:1.2),(bad-artist-anime), bad-artist, bad hand, extra legs ,(ng_deepnegative_v1_75t)\r\nSteps: 30, ENSD: 31337, Size: 512x768, Seed: 1015468391, Model: GhostMix-V2.0-fp16-BakedVAE, Sampler: DPM++ 2M Karras, CFG scale: 6, Clip skip: 2, Model hash: 0f5ef4c164, Hires steps: 20, Hires upscale: 2, Hires upscaler: R-ESRGAN 4x+ Anime6B, Denoising strength: 0.5");
            L1.Show();
            L2.Show();
        }

        private void guna2Button25_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("cgmech, (realistic)\r\nsolo, white mecha robot, cape, science fiction, torn clothes, glowing, standing, robot joints, mecha, armor, cowboy shot, (floating cape), intense sunlight, silver dragonborn, outdoors, landscape, nature\r\n, ((masterpiece, best quality)),  <lora:cgmechmix_offset:1><lora:more_details:0.3>  <lora:Niji:0.5><lora:dragonborn_offset:0.7>\r\n, volumetrics dtx, (film grain, blurry background, blurry foreground, bokeh, depth of field, motion blur:1.3)\r\nNegative prompt: BadDream, FastNegativeV2\r\nSteps: 30, Niji: 492d6878f85a, Size: 512x832, Seed: 951655291, Model: DreamShaper8_pruned, Version: v1.4.1, Sampler: DPM++ 2M SDE Karras, CFG scale: 8, Clip skip: 2, Model hash: 879db523c3, Hires steps: 30, more_details: 3b8aa1d351ef, Hires upscale: 2.3, Hires upscaler: 8x_NMKD-Superscale_150000_G, \"cgmechmix_offset: 5e66c6a56945, dragonborn_offset: 35d2c1e89ddb\", Denoising strength: 0.45");
            L1.Show();
            L2.Show();
        }

        private void guna2Button24_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("(anime coloring, anime screencap, ghibli, mappa, anime style), 1girl, hatsune miku, white gown, angel, angel wings, golden halo, dark background, upper body, (closed mouth:1.2), looking at viewer, arms behind back, blue theme, stars, starry night\r\nNegative prompt: BadDream, FastNegativeV2\r\nSteps: 20, Size: 512x704, Seed: 2067885436, Model: DreamShaper8_pruned, Version: v1.4.1, Sampler: DPM++ SDE Karras, CFG scale: 8, Clip skip: 2, Model hash: 879db523c3, Hires steps: 12, (closed mouth: 1.2), looking at viewer, arms behind back, blue theme, stars, starry night\", Hires upscale: 2, Hires upscaler: 8x_NMKD-Superscale_150000_G, ADetailer model: face_yolov8n.pt, ADetailer prompt: \"(anime coloring, anime screencap, ghibli, mappa, anime style), 1girl, hatsune miku, white gown, angel, angel wings, golden halo, dark background, upper body, (UnrealisticDream: 1.3)\", ADetailer version: 23.6.1.post0, Denoising strength: 0.4, ADetailer mask blur: 4, ADetailer model 2nd: hand_yolov8n.pt, ADetailer confidence: 0.3, ADetailer dilate/erode: 4, ADetailer mask blur 2nd: 4, ADetailer confidence 2nd: 0.3, ADetailer inpaint padding: 0, ADetailer negative prompt: \"BadDream, FastNegativeV2\", ADetailer dilate/erode 2nd: 4, ADetailer denoising strength: 0.4, ADetailer inpaint only masked: True, ADetailer inpaint padding 2nd: 32, ADetailer negative prompt 2nd: \"BadDream, ADetailer denoising strength 2nd: 0.3, ADetailer inpaint only masked 2nd: True");
            L1.Show();
            L2.Show();
        }

        private void guna2Button23_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("masterpiece, (photorealistic:1.4), best quality, beautiful lighting, (ulzzang-6500:0.5), lucy \\(cyberpunk\\), 1girl, white hair, against railing, arm rest, bangs, bare shoulders, belt, black belt, black leotard, black pants, blurry, bob cut, breasts, building, cityscape, clothing cutout, (cropped jacket), cyberpunk, depth of field, from side, gradient eyes, grey eyes, grey hair, white jacket, leotard, lips, long sleeves, looking afar, looking ahead, (mechanical parts), medium breasts, multicolored eyes, multicolored hair, night, night sky, off shoulder, open clothes, open jacket, outdoors, pants, parted lips, railing, red eyeliner, science fiction, short hair with long locks, short shorts, shorts, sidelocks, sky, solo, standing, teeth, thigh cutout, upper teeth only, white jacket, white shorts, cyberpunk \\(series\\), cyberpunk edgerunners, RAW photo, 8k uhd, film grain, cosplay, white wig, night, neon lights,,,, <lora:lucy_offset:1.21>\r\nNegative prompt: BadDream, (UnrealisticDream:1.3)\r\nSteps: 30, Size: 512x640, Seed: 1584580292, Model: DreamShaper8_pruned, Version: v1.4.1, Sampler: DPM++ SDE Karras, CFG scale: 9, Clip skip: 2, Model hash: 879db523c3, Hires steps: 15, lucy_offset: 1.21>\", \"lucy_offset: f7a664103d28\", (ulzzang-6500: 0.5), lucy \\\\(cyberpunk\\\\), 1girl, white hair, against railing, arm rest, bangs, bare shoulders, belt, black belt, black leotard, black pants, blurry, bob cut, breasts, building, cityscape, clothing cutout, (cropped jacket), cyberpunk, depth of field, from side, gradient eyes, grey eyes, grey hair, white jacket, leotard, lips, long sleeves, looking afar, looking ahead, (mechanical parts), medium breasts, multicolored eyes, multicolored hair, night, night sky, off shoulder, open clothes, open jacket, outdoors, pants, parted lips, railing, red eyeliner, science fiction, short hair with long locks, short shorts, shorts, sidelocks, sky, solo, standing, teeth, thigh cutout, upper teeth only, white jacket, white shorts, cyberpunk \\\\(series\\\\), cyberpunk edgerunners, RAW photo, 8k uhd, film grain, cosplay, white wig, night, neon lights,,,, Hires upscale: 2.65, Hires upscaler: 8x_NMKD-Superscale_150000_G, (photorealistic: 1.4), best quality, beautiful lighting, ADetailer model: face_yolov8n.pt, ADetailer prompt: \"masterpiece, (UnrealisticDream: 1.3)\", ADetailer version: 23.6.1.post0, Denoising strength: 0.4, ADetailer mask blur: 5, ADetailer confidence: 0.2, ADetailer dilate/erode: 4, ADetailer inpaint padding: 0, ADetailer negative prompt: \"BadDream, ADetailer denoising strength: 0.37, ADetailer inpaint only masked: True");
            L1.Show();
            L2.Show();
        }

        private void guna2Button28_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("(masterpiece), (extremely intricate), fantasy, (((realistic portrait of an evil hermit, male, villain, anti hero, evil face, masculine face, medium hair, Maroon hair, wicked, cruel, sinister, malicious, ruthless, masculine, athletic))), (((dark bloody clothing, intricate details on clothing))), (perfect composition:1.4), aspect ratio 1:1, beach, deviantart hd, artstation hd, concept art, detailed face and body, award-winning photography, margins, detailed face, professional oil painting by Ed Blinkey, Atey Ghailan, Jeremy Mann, Greg Manchess, Alex Gray, trending on ArtStation, trending on CGSociety, intricate, high detail, sharp focus, dramatic, award winning matte drawing cinematic lighting octane render unreal engine volumetrics dtx\r\nNegative prompt: UnrealisticDream, (BadDream)\r\nSteps: 30, Size: 344x512, Seed: 3091544718, Model: DreamShaper8_pruned, Version: v1.4.1, Sampler: DPM++ SDE Karras, CFG scale: 12, Clip skip: 2, Model hash: 879db523c3, Hires steps: 25, Hires upscale: 2, Hires upscaler: Latent (bicubic antialiased), Denoising strength: 0.6");
            L1.Show();
            L2.Show();
        }

        private void guna2Button27_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("Portrait photo of muscular bearded guy in a worn mech suit, ((light bokeh)), intricate, (steel metal [rust]), elegant, sharp focus, photo by greg rutkowski, soft lighting, vibrant colors, (masterpiece), ((streets)), (detailed face:1.2), (glowing blue eyes:1.1) <lora:FilmVelvia3:0.4>  <lora:more_details:0.6>\r\nNegative prompt: BadDream, (UnrealisticDream:1.3)\r\nSteps: 30, Size: 512x832, Seed: 5775692, Model: DreamShaper8_pruned, Version: v1.4.1, Sampler: DPM++ 2M SDE Karras, CFG scale: 9, Clip skip: 2, Model hash: 879db523c3, Hires steps: 20, \"FilmVelvia3: 6e93473d6228, more_details: 3b8aa1d351ef\", Hires upscale: 2.3, Hires upscaler: 8x_NMKD-Superscale_150000_G, Denoising strength: 0.46");
            L1.Show();
            L2.Show();
        }

        private void guna2Button26_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("black humanoid made of rock, upper body, barechested, male,  ((masterpiece, best quality)),  <lora:more_details:0.3>, cracked skin, white electricity coming through cracks, muscular male, (dragonborn:0.6), white hair\r\noutdoors, detailed background <lora:dragonborn_offset:0.6> <lora:r1ge - AnimeRage:1> <lora:Cracked Skin:1.2>\r\n, depth of field\r\nNegative prompt: BadDream, UnrealisticDream, orange\r\nSteps: 20, Size: 512x768, Seed: 1650465323, Model: DreamShaper8_pruned, Version: v1.4.1, Sampler: DPM++ 2M SDE Karras, CFG scale: 8, Clip skip: 2, Model hash: 879db523c3, Hires steps: 20, Cracked Skin: 37a7cea146ca\", \"more_details: 3b8aa1d351ef, Hires upscale: 2, Hires upscaler: 8x_NMKD-Superscale_150000_G, r1ge - AnimeRage: d4fd87d54db1, dragonborn_offset: 35d2c1e89ddb, Denoising strength: 0.45");
            L1.Show();
            L2.Show();
        }

        private void guna2Button31_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("(realistic, photorealistic), dark skinned woman, (Zoe Saldana:0.6), landscape, movie screenshot, sharp details, the expanse scifi spacescape ceres colony, intricate, highly detailed, rich color, smooth, sharp focus, Unreal Engine 5, 8K, (blurry background, film grain, cinema shot, depht blur, volumetric dtx) <lora:star_trek_offset:0.7>\r\nNegative prompt: BadDream, (UnrealisticDream:1.3)\r\nSteps: 30, Size: 512x768, Seed: 47552444, Model: DreamShaper8_pruned, Version: v1.4.1, Sampler: DPM++ SDE Karras, CFG scale: 8, Clip skip: 2, Model hash: 879db523c3, Hires steps: 20, (Zoe Saldana: 0.6), landscape, movie screenshot, sharp details, the expanse scifi spacescape ceres colony, intricate, highly detailed, rich color, smooth, sharp focus, Unreal Engine 5, 8K, (blurry background, film grain, cinema shot, depht blur, Hires upscale: 2.4, Hires upscaler: 8x_NMKD-Superscale_150000_G, ADetailer model: face_yolov8n.pt, ADetailer prompt: \"(realistic, photorealistic), dark skinned woman, star_trek_offset: 0.7>\", \"star_trek_offset: 11da9f4c8234\", (UnrealisticDream: 1.3), FastNegativeV2\", ADetailer version: 23.6.1.post0, Denoising strength: 0.55, ADetailer mask blur: 5, ADetailer model 2nd: hand_yolov8n.pt, ADetailer confidence: 0.2, ADetailer prompt 2nd: female hand, ADetailer dilate/erode: 4, ADetailer mask blur 2nd: 4, ADetailer confidence 2nd: 0.3, ADetailer inpaint padding: 0, ADetailer negative prompt: \"BadDream, ADetailer dilate/erode 2nd: 4, ADetailer denoising strength: 0.37, ADetailer inpaint only masked: True, ADetailer inpaint padding 2nd: 0, ADetailer negative prompt 2nd: \"BadDream, ADetailer denoising strength 2nd: 0.37, ADetailer inpaint only masked 2nd: True");
            L1.Show();
            L2.Show();
        }

        private void guna2Button30_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("(8k, best quality, masterpiece:1.2),(best quality:1.0), (ultra highres:1.0), watercolor, a beautiful woman, shoulder, hair ribbons, by agnes cecile, half body portrait, extremely luminous bright design, pastel colors, (ink:1.3), autumn lights\r\nNegative prompt: BadDream\r\nSteps: 20, Size: 512x640, Seed: 1547547180, Model: DreamShaper8_pruned, Version: v1.4.1, Sampler: DPM++ SDE Karras, CFG scale: 7, Clip skip: 2, Model hash: 879db523c3, Hires steps: 10, Hires upscale: 2, Hires upscaler: Latent, Denoising strength: 0.6");
            L1.Show();
            L2.Show();
        }

        private void guna2Button29_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("black dragonborn, solo, red eyes, male, upper body, male focus, horns, cape, armor, glowing, glowing eyes\r\n, volumetrics dtx, (film grain, blurry background, blurry foreground, bokeh, depth of field, motion blur, realistic:1.3)\r\n, ((masterpiece, best quality)), art by greg rutkowski  <lora:dragonborn_offset:1>\r\nNegative prompt: BadDream, FastNegativeV2\r\nSteps: 20, Size: 512x704, Seed: 4161553119, Model: DreamShaper8_pruned, Version: v1.4.1, Sampler: DPM++ SDE Karras, CFG scale: 8, Clip skip: 2, Model hash: 879db523c3, Hires steps: 20, Hires upscale: 2, Hires upscaler: 8x_NMKD-Superscale_150000_G, \"dragonborn_offset: 35d2c1e89ddb\", Denoising strength: 0.45");
            L1.Show();
            L2.Show();
        }

        private void guna2Button34_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("fashion photography portrait of indian girl with blue hair, in lush jungle with flowers, 3d render, cgi, symetrical, octane render, 35mm, bokeh, 9:16, (intricate details:1.12), hdr, (intricate details, hyperdetailed:1.15), (natural skin texture, hyperrealism, soft light, sharp:1.2), detailed, sunlight passing through foliage, india\r\nNegative prompt: BadDream, UnrealisticDream\r\nSteps: 30, Size: 512x768, Seed: 3889919804, Model: DreamShaper8_pruned, Version: v1.4.1, Sampler: DPM++ SDE Karras, CFG scale: 9, Clip skip: 2, Model hash: 879db523c3, Hires steps: 15, Hires upscale: 2, Hires upscaler: 8x_NMKD-Superscale_150000_G, Denoising strength: 0.4");
            L1.Show();
            L2.Show();
        }

        private void guna2Button33_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("demon woman wearing a christmas sweater, upper body, art by gerald brom <lora:more_details:0.4>\r\nNegative prompt: cleavage, BadDream\r\nSteps: 25, Size: 512x640, Seed: 2816015735, Model: DreamShaper8_pruned, Version: v1.4.1, Sampler: DPM++ SDE Karras, CFG scale: 9, Clip skip: 2, Model hash: 879db523c3, Hires steps: 20, \"more_details: 3b8aa1d351ef\", Hires upscale: 1.5, Hires upscaler: 8x_NMKD-Superscale_150000_G, Denoising strength: 0.5");
            L1.Show();
            L2.Show();
        }

        private void guna2Button32_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("8k portrait of beautiful cyborg with brown hair, intricate, elegant, highly detailed, majestic, digital photography, art by artgerm and ruan jia and greg rutkowski surreal painting gold butterfly filigree, broken glass, (masterpiece, sidelighting, finely detailed beautiful eyes: 1.2), hdr, (detailed background window to a new dimension, plants and flowers:0.7) <lora:more_details:0.5> infinity, infinite symbol,\r\nNegative prompt: BadDream, FastNegativeV2\r\nSteps: 28, Size: 512x768, Seed: 132340247, Model: DreamShaper8_pruned, model: control_sd15_hed [fef5e48e], weight: 1, Version: v1.4.1, Sampler: DPM++ SDE Karras, CFG scale: 7, Clip skip: 2, Model hash: 879db523c3, Hires steps: 25, resize mode: Crop and Resize, control mode: Balanced, \"more_details: 3b8aa1d351ef\", \"preprocessor: none, Hires sampler: DPM++ 2M SDE Karras, Hires upscale: 2.15, pixel perfect: False, Hires upscaler: Latent (bicubic antialiased), ADetailer model: face_yolov8n.pt, starting/ending: (0, 0.95), ADetailer prompt: \"8k portrait of beautiful cyborg with brown hair, intricate, elegant, highly detailed, majestic, digital photography, art by artgerm and ruan jia and greg rutkowski surreal painting gold butterfly filigree, broken glass, (masterpiece, sidelighting, ADetailer version: 23.6.1.post0, Denoising strength: 0.46, ADetailer mask blur: 4, preprocessor params: (512, 64, 64)\", ADetailer confidence: 0.3, ADetailer dilate/erode: 4, ADetailer inpaint padding: 32, ADetailer negative prompt: \"BadDream, UnrealisticDream, FastNegativeV2\", ADetailer denoising strength: 0.4, ADetailer inpaint only masked: True, finely detailed beautiful eyes: 1.2), hdr\"");
            L1.Show();
            L2.Show();
        }

        private void guna2Button37_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("((best quality)), ((masterpiece)), (detailed), woman standing before fire, (Jason Benjamin:1.2), (Artstation contest winner:1.1), (fantasy art:1.3), (portrait armored astronaut girl:1.2), (Peter Mohrbacher:1.1), (unreal engine:1.1), (Hearthstone card game artwork:1.1), spiked metal armor, (dynamic composition:1.3), (8k resolution:1.2)\r\nNegative prompt: 3d, cartoon, anime, sketches, (worst quality, bad quality, child, cropped:1.4) ((monochrome)), ((grayscale)),  (bad-hands-5:1.0), (badhandv4:1.0), (easynegative:0.8),  (bad-artist-anime:0.8), (bad-artist:0.8), (bad_prompt:0.8), (bad-picture-chill-75v:0.8), (bad_prompt_version2:0.8),  (bad_quality:0.8)\r\nSteps: 30, ENSD: 31337, Size: 512x768, Seed: 108597497, Model: rev_1.2.2, Sampler: DPM++ 2M Karras, CFG scale: 8.5, Clip skip: 2, Model hash: 66d6caba66, Hires steps: 36, Hires upscale: 2, Hires upscaler: 4x_foolhardy_Remacri, Denoising strength: 0.55");
            L1.Show();
            L2.Show();
        }

        private void guna2Button36_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("((best quality)), ((masterpiece)), (detailed), close-up person, long hair, (fantasy art:1.3), cute cyborg girl, highly detailed face, (render of April:1.1), beautiful artwork illustration, (portrait composition:1.3), (8k resolution:1.2)\r\nNegative prompt: 3d, cartoon, anime, sketches, (worst quality, bad quality, child, cropped:1.4) ((monochrome)), ((grayscale)),  (bad-hands-5:1.0), (badhandv4:1.0), (easynegative:0.8),  (bad-artist-anime:0.8), (bad-artist:0.8), (bad_prompt:0.8), (bad-picture-chill-75v:0.8), (bad_prompt_version2:0.8),  (bad_quality:0.8)\r\nSteps: 30, ENSD: 31337, Size: 512x768, Seed: 3276234046, Model: rev_1.2.2, Sampler: DPM++ 2M Karras, CFG scale: 8.5, Clip skip: 2, Model hash: 66d6caba66, Hires steps: 36, Hires upscale: 2, Hires upscaler: 4x_foolhardy_Remacri, Denoising strength: 0.55");
            L1.Show();
            L2.Show();
        }

        private void guna2Button35_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("((best quality)), ((masterpiece)), (detailed), fierce anime woman, wielding katana, battle-ready stance, intricate armor, flowing hair, (Japanese animation style:1.3), (Masashi Kishimoto:1.1), (Tite Kubo:1.1), intense gaze, dynamic background, vibrant colors, (action-packed composition:1.3), (8k resolution:1.2)\r\nNegative prompt: 3d, cartoon, anime, sketches, (worst quality, bad quality, child, cropped:1.4) ((monochrome)), ((grayscale)),  (bad-hands-5:1.0), (badhandv4:1.0), (easynegative:0.8),  (bad-artist-anime:0.8), (bad-artist:0.8), (bad_prompt:0.8), (bad-picture-chill-75v:0.8), (bad_prompt_version2:0.8),  (bad_quality:0.8)\r\nSteps: 30, ENSD: 31337, Size: 512x768, Seed: 995647460, Model: rev_1.2.2, Sampler: DPM++ 2M Karras, CFG scale: 8.5, Clip skip: 2, Model hash: 66d6caba66, Hires steps: 36, Hires upscale: 2, Hires upscaler: 4x_foolhardy_Remacri, Denoising strength: 0.55");
            L1.Show();
            L2.Show();
        }

        private void guna2Button40_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("((best quality)), ((masterpiece)), (detailed), woman with green hair, holding a sword, (Artgerm inspired:1.2), (pixiv contest winner:1.1), (octopus goddess:1.3), (Berserk art style:1.2), close-up portrait, goddess skull, (Senna from League of Legends:1.1), (Tatsumaki with green curly hair:1.2), card game illustration, thick brush, HD anime wallpaper, (Akali from League of Legends:1.1), 8k resolution\r\nNegative prompt: 3d, cartoon, anime, sketches, (worst quality, bad quality, child, cropped:1.4) ((monochrome)), ((grayscale)),  (bad-hands-5:1.0), (badhandv4:1.0), (easynegative:0.8),  (bad-artist-anime:0.8), (bad-artist:0.8), (bad_prompt:0.8), (bad-picture-chill-75v:0.8), (bad_prompt_version2:0.8),  (bad_quality:0.8)\r\nSteps: 30, ENSD: 31337, Size: 512x768, Seed: 2937362614, Model: rev_1.2.2, Sampler: DPM++ 2M Karras, CFG scale: 8.5, Clip skip: 2, Model hash: 66d6caba66, Hires steps: 36, Hires upscale: 2, Hires upscaler: 4x_foolhardy_Remacri, Denoising strength: 0.55");
            L1.Show();
            L2.Show();
        }

        private void guna2Button39_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("((best quality)), ((masterpiece)), ((realistic)), vintage Afro-Caribbean woman, elegant attire, 1950s fashion, radiant smile, confident stance, cultural pride, (oil painting:1.2), (Lois Mailou Jones:1.1), (Kadir Nelson:1.1), vivid colors, nostalgic background, authentic vintage feel, (portrait composition:1.3), (high-resolution:1.2)\r\nNegative prompt: 3d, cartoon, anime, sketches, (worst quality, bad quality, child, cropped:1.4) ((monochrome)), ((grayscale)),  (bad-hands-5:1.0), (badhandv4:1.0), (easynegative:0.8),  (bad-artist-anime:0.8), (bad-artist:0.8), (bad_prompt:0.8), (bad-picture-chill-75v:0.8), (bad_prompt_version2:0.8),  (bad_quality:0.8)\r\nSteps: 30, ENSD: 31337, Size: 512x768, Seed: 3653604530, Model: rev_1.2.2, Sampler: DPM++ 2M Karras, CFG scale: 8.5, Clip skip: 2, Model hash: 66d6caba66, Hires steps: 36, Hires upscale: 2, Hires upscaler: 4x_foolhardy_Remacri, Denoising strength: 0.55");
            L1.Show();
            L2.Show();
        }

        private void guna2Button38_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("((best quality)), ((masterpiece)), (detailed), beautiful face, female warrior, (defiance512:1.2), big eyes, heavy black iron armor, detailed helmet, intense gaze, battle-ready, contrasting soft skin, (lighting:1.2), close-up portrait, 4:3 aspect ratio\r\nNegative prompt: 3d, cartoon, anime, sketches, (worst quality, bad quality, child, cropped:1.4) ((monochrome)), ((grayscale)),  (bad-hands-5:1.0), (badhandv4:1.0), (easynegative:0.8),  (bad-artist-anime:0.8), (bad-artist:0.8), (bad_prompt:0.8), (bad-picture-chill-75v:0.8), (bad_prompt_version2:0.8),  (bad_quality:0.8)\r\nSteps: 30, ENSD: 31337, Size: 512x768, Seed: 1328103044, Model: rev_1.2.2, Sampler: DPM++ 2M Karras, CFG scale: 8.5, Clip skip: 2, Model hash: 66d6caba66, Hires steps: 36, Hires upscale: 2, Hires upscaler: 4x_foolhardy_Remacri, Denoising strength: 0.55");
            L1.Show();
            L2.Show();
        }

        private void guna2Button43_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("pretty 1girl, absurdres, 8k uhd, platinum blonde hair, bob cut, medium breasts, black tshirt, denim shorts, garden background, flowers, magnolias, apple tree, close up portrait\r\nNegative prompt: 3d, cartoon, anime, sketches, (worst quality, bad quality, child, cropped:1.4) ((monochrome)), ((grayscale)),  (bad-hands-5:1.0), (badhandv4:1.0), (easynegative:0.8),  (bad-artist-anime:0.8), (bad-artist:0.8), (bad_prompt:0.8), (bad-picture-chill-75v:0.8), (bad_prompt_version2:0.8),  (bad_quality:0.8)\r\nSteps: 30, ENSD: 31337, Size: 512x768, Seed: 1514816117, Model: rev_1.2.2, Sampler: DPM++ 2M Karras, CFG scale: 8.5, Clip skip: 2, Model hash: 66d6caba66, Hires steps: 36, Hires upscale: 2, Hires upscaler: 4x_foolhardy_Remacri, Denoising strength: 0.55");
            L1.Show();
            L2.Show();
        }

        private void guna2Button42_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("((best quality)), ((masterpiece)), (detailed), (realistic), male warrior, muscular physique, tribal attire, face paint, wielding spear, (jungle:1.3), dense foliage, exotic plants, dappled sunlight, (hyperrealistic:1.2), oil painting, (Frank Frazetta:1.1), DeviantArt influence, dynamic action pose, (intense expression:1.2), (portrait shot:1.1), 8k resolution\r\nNegative prompt: 3d, cartoon, anime, sketches, (worst quality, bad quality, child, cropped:1.4) ((monochrome)), ((grayscale)),  (bad-hands-5:1.0), (badhandv4:1.0), (easynegative:0.8),  (bad-artist-anime:0.8), (bad-artist:0.8), (bad_prompt:0.8), (bad-picture-chill-75v:0.8), (bad_prompt_version2:0.8),  (bad_quality:0.8)\r\nSteps: 30, ENSD: 31337, Size: 512x768, Seed: 387766904, Model: rev_1.2.2, Sampler: DPM++ 2M Karras, CFG scale: 8.5, Clip skip: 2, Model hash: 66d6caba66, Hires steps: 36, Hires upscale: 2, Hires upscaler: 4x_foolhardy_Remacri, Denoising strength: 0.55");
            L1.Show();
            L2.Show();
        }

        private void guna2Button41_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText("fighting , glowing eyes, short hair,torn tight supersuit, in a destroyed city, smoke and fire, glowing power aura, dynamic pose, dynamic view\r\nNegative prompt: 3d, cartoon, anime, sketches, (worst quality, bad quality, child, cropped:1.4) ((monochrome)), ((grayscale)),  (bad-hands-5:1.0), (badhandv4:1.0), (easynegative:0.8),  (bad-artist-anime:0.8), (bad-artist:0.8), (bad_prompt:0.8), (bad-picture-chill-75v:0.8), (bad_prompt_version2:0.8),  (bad_quality:0.8)\r\nSteps: 30, ENSD: 31337, Size: 512x768, Seed: 3061578913, Model: rev_1.2.2, Sampler: DPM++ 2M Karras, CFG scale: 8.5, Clip skip: 2, Model hash: 66d6caba66, Hires steps: 36, Hires upscale: 2, Hires upscaler: 4x_foolhardy_Remacri, Denoising strength: 0.55");
            L1.Show();
            L2.Show();
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText(".");
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            L1.Hide();
            L2.Hide();
            Clipboard.SetText(".");
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://recolay.com/");
        }

        private void guna2Button44_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://civitai.com/");
        }
    }
}
