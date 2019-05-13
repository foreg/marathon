using Marathon.Panels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon
{
    public class PanelsManageer
    {
        List<BaseUserControl> TopPanels { get; set; } = new List<BaseUserControl>();
        List<BaseUserControl> CenterPanels { get; set; } = new List<BaseUserControl>();
        List<BaseUserControl> BottomPanels { get; set; } = new List<BaseUserControl>();

        public void InitTop(params BaseUserControl[] topPanels)
        {
            TopPanels.AddRange(topPanels);
        }

        public void InitCenter(params BaseUserControl[] centerPanels)
        {
            CenterPanels.AddRange(centerPanels);
        }

        public void InitBottom(params BaseUserControl[] bottomPanels)
        {
            BottomPanels.AddRange(bottomPanels);
        }

        public void BringToFront(Type topPanel = null, Type centerPanel = null, Type bottomPanel = null)
        {
            if (topPanel != null)
            {
                var panel = TopPanels.Find(p => p.GetType() == topPanel);
                panel.Init();
                panel.BringToFront();
            }
            if (centerPanel != null)
            {
                var panel = CenterPanels.Find(p => p.GetType() == centerPanel);
                var loadingPanel = CenterPanels.Find(p => p.GetType() == typeof(LoadingPanel));
                loadingPanel.BringToFront();
                panel.Init();
                panel.BringToFront();
            }
            if (bottomPanel != null)
            {
                var panel = BottomPanels.Find(p => p.GetType() == bottomPanel);
                panel.Init();
                panel.BringToFront();
            }
        }
    }
}
