﻿using Volo.Abp.Settings;

namespace Streamlife.Mvp.Cms.Settings
{
    public class CmsSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(CmsSettings.MySetting1));
        }
    }
}
