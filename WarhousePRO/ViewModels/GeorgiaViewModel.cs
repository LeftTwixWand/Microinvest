using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhousePRO.ViewModels
{
    public class GeorgiaViewModel : MainViewModel
    {
        internal override void Initialize()
        {
            base.Initialize();
            Debug.WriteLine("GeorgiaService");
        }

        internal override void ButtonClick()
        {
            MenuBarItem = "Georgia";
        }
    }
}
