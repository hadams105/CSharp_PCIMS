using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCIMS_Software.ControlTemplates.Base
{
	[Serializable]
	public class Base_UserControl : UserControl
	{
		public Base_UserControl()
		{
			Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
		}

		public void AdjustControlSize()
		{
			Dock = DockStyle.Fill;
		}
	}
}
