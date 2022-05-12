﻿using NullLib.GoCqHttpSdk.Message.DataModel;
using NullLib.GoCqHttpSdk.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullLib.GoCqHttpSdk.Message
{
    public class CqForwardMsg : CqMsg
    {
        public override string Type => Consts.MsgType.Forward;

        public string Id { get; set; }

        internal CqForwardMsg() { }
        public CqForwardMsg(string id) => Id = id;

        internal override object GetDataModel() => new CqForwardMsgDataModel(Id);
        internal override void ReadDataModel(object model)
        {
            var m = model as CqForwardMsgDataModel;
            if (m == null)
                throw new ArgumentException();

            Id = m.id;
        }
    }
}
