using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
 
using System.Windows.Forms;
using MultiMonitorHelper.DisplayModels.Win7;
using MultiMonitorHelper.DisplayModels.Win7.Enum;
using MultiMonitorHelper.DisplayModels.Win7.Struct;

namespace Winotate
{
 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
           
            DisplayConfigRotation displayConfigRotation = (DisplayConfigRotation)Enum.Parse(typeof(DisplayConfigRotation), comRotate.Text);


            int numPathArrayElements;
            int numModeInfoArrayElements;

            const QueryDisplayFlags pathType = QueryDisplayFlags.OnlyActivePaths;

            // query active paths from the current computer.
            // note that 0 is equal to SUCCESS!
            // TODO; HARDCODE MAGIC VALUES AWAY.
            if (CCDWrapper.GetDisplayConfigBufferSizes(pathType, out numPathArrayElements,
                                                       out numModeInfoArrayElements) == 0)
            {
                var pathInfoArray = new DisplayConfigPathInfo[numPathArrayElements];
                var modeInfoArray = new DisplayConfigModeInfo[numModeInfoArrayElements];

                // TODO; FALLBACK MECHANISM THAT HANDLES DIFFERENT VALUES FOR ZERO.
                if (CCDWrapper.QueryDisplayConfig(
                    pathType,
                    ref numPathArrayElements, pathInfoArray,
                    ref numModeInfoArrayElements,
                    modeInfoArray, IntPtr.Zero) == 0)
                {

                    pathInfoArray[0].targetInfo.rotation = displayConfigRotation;
                    CCDWrapper.SetDisplayConfig(numPathArrayElements, pathInfoArray, numModeInfoArrayElements,
                                                modeInfoArray, SdcFlags.Apply | SdcFlags.UseSuppliedDisplayConfig);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comRotate.Items.Add("1");
            comRotate.Items.Add("2");
            comRotate.Items.Add("3");
            comRotate.Items.Add("4");
                }
    }
}
