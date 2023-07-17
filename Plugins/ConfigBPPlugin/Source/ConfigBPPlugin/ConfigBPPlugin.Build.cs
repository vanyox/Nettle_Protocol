// Copyright 2017-2022 HowToCompute. All Rights Reserved.

using UnrealBuildTool;

public class ConfigBPPlugin : ModuleRules
{
	public ConfigBPPlugin(ReadOnlyTargetRules Target) : base(Target)
	{
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
			}
			);

        // Force IWYU
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

    }
}
