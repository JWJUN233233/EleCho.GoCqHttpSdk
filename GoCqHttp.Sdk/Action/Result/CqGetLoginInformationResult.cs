﻿using EleCho.GoCqHttpSdk.Action.Result.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleCho.GoCqHttpSdk.Action.Result
{
    public class CqGetLoginInformationActionResult : CqActionResult
    {
        public long UserId { get; set; }
        public string Nickname { get; set; } = null!;

        internal override void ReadDataModel(CqActionResultDataModel? model)
        {
            if (model is not CqGetLoginInformationActionResultDataModel _model)
                throw new Exception();

            UserId = _model.user_id;
            Nickname = _model.nickname;
        }
    }
}