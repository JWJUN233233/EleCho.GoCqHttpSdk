﻿namespace NullLib.GoCqHttpSdk.Message.DataModel
{
    internal class CqForwardNodeMsgDataModel
    {
        public CqForwardNodeMsgDataModel() { }
        public CqForwardNodeMsgDataModel(int? id, string? name, long? uin, CqMsg[]? content, CqMsg[]? seq)
        {
            this.id = id;
            this.name = name;
            this.uin = uin;
            this.content = content;
            this.seq = seq;
        }

        public int? id { get; set; }
        public string? name { get; set; }
        public long? uin { get; set; }
        public CqMsg[]? content { get; set; }
        public CqMsg[]? seq { get; set; }
    }
}
