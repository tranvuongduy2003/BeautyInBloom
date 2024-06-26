﻿using BeautyInBloom.Models.Enums;
using Microsoft.AspNetCore.Mvc;

namespace BeautyInBloom.API.Authorization;

public class ClaimRequirementAttribute : TypeFilterAttribute
{
    public ClaimRequirementAttribute(EFunctionCode functionId, ECommandCode commandId)
        : base(typeof(ClaimRequirementFilter))
    {
        Arguments = new object[] { functionId, commandId };
    }
}