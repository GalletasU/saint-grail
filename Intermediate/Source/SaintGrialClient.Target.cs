using UnrealBuildTool;

public class SaintGrialClientTarget : TargetRules
{
	public SaintGrialClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("SaintGrial");
	}
}
