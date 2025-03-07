using UnrealBuildTool;

public class SaintGrialEditorTarget : TargetRules
{
	public SaintGrialEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("SaintGrial");
	}
}
