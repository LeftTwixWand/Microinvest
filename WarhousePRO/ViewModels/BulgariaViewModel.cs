using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhousePRO.ViewModels
{
    public class BulgariaViewModel : MainViewModel
    {
        internal override void Initialize()
        {
            Debug.WriteLine("BulgariaViewModel.Initialize");
        }

        internal override void ButtonClick()
        {
           Debug.WriteLine("BulgariaViewModel.ButtonClick");
        }
    }
}
