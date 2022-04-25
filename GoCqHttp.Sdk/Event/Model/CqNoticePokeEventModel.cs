﻿namespace NullLib.GoCqHttpSdk.Event
{
    public class CqNoticePokeEventModel : CqNoticeNotifyEventModel
    {
        public override string sub_type => "poke";

        public long group_id { get; set; }
        public long self_id { get; set; }
        public long sender_id { get; set; }
        public long user_id { get; set; }
        public long target_id { get; set; }
    }
}
