 namespace ZkData
{
	public static class GlobalConst
	{
		public const double EloWeightMalusFactor = -50;
		public const int InfluenceSystemBuyPrice = 45;
		public const int InfluenceSystemSellPrice = 8;
		public const int MaxClanSkilledSize =10;
		public const int ClanLeaveLimit = 4;
		public const int PlanetwarsColonizationCredits = 1000;
		public const int PlanetwarsInvadingShipBonus = 30;
		public const int PlanetwarsInvadingShipLostMalus = -10;
		public const int XpForMissionOrBots = 25;
		public const int XpForMissionOrBotsVictory = 50;
		public const double EloWeightMax = 6;
		public const double EloWeightLearnFactor = 20;
		public const string AuthServiceUri = "net.tcp://localhost:8202";
		public const string LoginCookieName = "zk_login";
		public const string LimitedModeCookieName = "zk_limited";
		public const string MissionScriptFileName = "_missionScript.txt";
		public const string MissionServiceUri = "http://zero-k.info/missions/MissionService.svc";
		public const string MissionSlotsFileName = "_missionSlots.xml";
		public const string NightwatchName = "Nightwatch";
		public const string PasswordHashCookieName = "zk_passwordHash";
		public const string LobbyAccessCookieName = "zk_lobby";

    public static bool IsZkMod(string name)
    {
      if (string.IsNullOrEmpty(name)) return false;
      return name.Contains("Zero-K");
    }

		public const int DefaultDropshipCapacity = 3;
		public const int DefaultDropshipProduction = 1;
	}
  
}