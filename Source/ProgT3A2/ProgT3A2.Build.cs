// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ProgT3A2 : ModuleRules
{
	public ProgT3A2(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ProgT3A2",
			"ProgT3A2/Variant_Platforming",
			"ProgT3A2/Variant_Platforming/Animation",
			"ProgT3A2/Variant_Combat",
			"ProgT3A2/Variant_Combat/AI",
			"ProgT3A2/Variant_Combat/Animation",
			"ProgT3A2/Variant_Combat/Gameplay",
			"ProgT3A2/Variant_Combat/Interfaces",
			"ProgT3A2/Variant_Combat/UI",
			"ProgT3A2/Variant_SideScrolling",
			"ProgT3A2/Variant_SideScrolling/AI",
			"ProgT3A2/Variant_SideScrolling/Gameplay",
			"ProgT3A2/Variant_SideScrolling/Interfaces",
			"ProgT3A2/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
