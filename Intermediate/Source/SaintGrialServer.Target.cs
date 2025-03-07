using UnrealBuildTool;

public class SaintGrialServerTarget : TargetRules
{
	public SaintGrialServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("SaintGrial");
	}
}
