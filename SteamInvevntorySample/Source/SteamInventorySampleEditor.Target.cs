// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class SteamInventorySampleEditorTarget : TargetRules
{
	public SteamInventorySampleEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

        bOverrideBuildEnvironment = true;
        DefaultBuildSettings = BuildSettingsVersion.Latest;

        ExtraModuleNames.AddRange( new string[] { "SteamInventorySample" } );
	}
}
