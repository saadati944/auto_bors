using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_bors.xpathes
{
    class mofid_easytrader
    {
        public string login_url = @"https://d.easytrader.emofid.com/";
        public string buy_button = "//*[@id=\"root\"]/main/div[3]/div/div/as-split/as-split-area/app-layout-selector/app-layout2/as-split/as-split-area[2]/div/div[1]/div/button[1]";
        public string sell_button = "//*[@id=\"root\"]/main/div[3]/div/div/as-split/as-split-area/app-layout-selector/app-layout2/as-split/as-split-area[2]/div/div[1]/div/button[2]";
    }
}
