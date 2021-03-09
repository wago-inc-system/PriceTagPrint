﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PriceTagPrint.Common
{
    public static class TorihikisakiId
    {
        public const string YASUSAKI = "1";
        public const string YAMANAKA = "2";
        public const string MARUYOSI = "3";
        public const string OKINAWA_SANKI = "4";
    }
    public class Torihikisaki
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Torihikisaki(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }

    public class TorihikisakiList
    {
        public List<Torihikisaki> list;
        public TorihikisakiList()
        {
            Create();
        }

        private void Create()
        {
            list = new List<Torihikisaki>()
            {
                new Torihikisaki(TorihikisakiId.YASUSAKI, "ヤスサキ"),
                new Torihikisaki(TorihikisakiId.YAMANAKA, "ヤマナカ"),
                new Torihikisaki(TorihikisakiId.MARUYOSI, "マルヨシ"),
                new Torihikisaki(TorihikisakiId.OKINAWA_SANKI, "沖縄三喜マルエー"),
            };
        }
    }
}
