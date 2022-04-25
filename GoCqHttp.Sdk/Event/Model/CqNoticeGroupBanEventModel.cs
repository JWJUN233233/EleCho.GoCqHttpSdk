﻿namespace NullLib.GoCqHttpSdk.Event
{
    public class CqNoticeGroupBanEventModel : CqNoticeEventModel
    {
        public override string notice_type => "group_ban";

        /// <summary>
        /// <see cref="CqNoticeGroupBanType"/>
        /// </summary>
        public string sub_type { get; set; }

        public long group_id { get; set; }
        public long operator_id { get; set; }
        public long user_id { get; set; }
        public long duration { get; set; }
    }
}
