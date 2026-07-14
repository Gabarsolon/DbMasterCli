using System;

namespace FifaLibrary
{
	// Token: 0x02000066 RID: 102
	public class TI
	{
		// Token: 0x060008C8 RID: 2248 RVA: 0x00033FD0 File Offset: 0x000321D0
		public static bool InitTIAsFIFA12(DbFile fifaDbFile)
		{
			bool flag = true;
			TI.dcplayernames = fifaDbFile.GetTableIndex(TI.t_dcplayernames);
			TI.version = fifaDbFile.GetTableIndex(TI.t_version);
			TI.transactionhistory = fifaDbFile.GetTableIndex(TI.t_transactionhistory);
			TI.trainingteamplayers = fifaDbFile.GetTableIndex(TI.t_trainingteamplayers);
			TI.trainingteamplayernames = fifaDbFile.GetTableIndex(TI.t_trainingteamplayernames);
			TI.trainingteamplayerlinks = fifaDbFile.GetTableIndex(TI.t_trainingteamplayerlinks);
			TI.temp_teamplayerlinks = fifaDbFile.GetTableIndex(TI.t_temp_teamplayerlinks);
			TI.temp_teams = fifaDbFile.GetTableIndex(TI.t_temp_teams);
			TI.temp_formations = fifaDbFile.GetTableIndex(TI.t_temp_formations);
			TI.temp_players = fifaDbFile.GetTableIndex(TI.t_temp_players);
			TI.temp_arenaplayer = fifaDbFile.GetTableIndex(TI.t_temp_arenaplayer);
			TI.temp_arenaplayername = fifaDbFile.GetTableIndex(TI.t_temp_arenaplayername);
			TI.temp_arenateam = fifaDbFile.GetTableIndex(TI.t_temp_arenateam);
			TI.temp_arenateamplayerlinks = fifaDbFile.GetTableIndex(TI.t_temp_arenateamplayerlinks);
			TI.teams = fifaDbFile.GetTableIndex(TI.t_teams);
			TI.teamstadiumlinks = fifaDbFile.GetTableIndex(TI.t_teamstadiumlinks);
			TI.teamplayerlinks = fifaDbFile.GetTableIndex(TI.t_teamplayerlinks);
			TI.teamkits = fifaDbFile.GetTableIndex(TI.t_teamkits);
			TI.teamballs = fifaDbFile.GetTableIndex(TI.t_teamballs);
			TI.stadiums = fifaDbFile.GetTableIndex(TI.t_stadiums);
			TI.rowteamnationlinks = fifaDbFile.GetTableIndex(TI.t_rowteamnationlinks);
			TI.rivals = fifaDbFile.GetTableIndex(TI.t_rivals);
			TI.referee = fifaDbFile.GetTableIndex(TI.t_referee);
			TI.players = fifaDbFile.GetTableIndex(TI.t_players);
			TI.playernames = fifaDbFile.GetTableIndex(TI.t_playernames);
			TI.playerloans = fifaDbFile.GetTableIndex(TI.t_playerloans);
			TI.playerboots = fifaDbFile.GetTableIndex(TI.t_playerboots);
			TI.player_grudgelove = fifaDbFile.GetTableIndex(TI.t_player_grudgelove);
			TI.physio = fifaDbFile.GetTableIndex(TI.t_physio);
			TI.nations = fifaDbFile.GetTableIndex(TI.t_nations);
			TI.manager = fifaDbFile.GetTableIndex(TI.t_manager);
			TI.leagueteamlinks = fifaDbFile.GetTableIndex(TI.t_leagueteamlinks);
			TI.leagues = fifaDbFile.GetTableIndex(TI.t_leagues);
			TI.leaguerefereelinks = fifaDbFile.GetTableIndex(TI.t_leaguerefereelinks);
			TI.formupdate = fifaDbFile.GetTableIndex(TI.t_formupdate);
			TI.formations = fifaDbFile.GetTableIndex(TI.t_formations);
			TI.fieldpositionboundingboxes = fifaDbFile.GetTableIndex(TI.t_fieldpositionboundingboxes);
			TI.editedplayernames = fifaDbFile.GetTableIndex(TI.t_editedplayernames);
			TI.dna = fifaDbFile.GetTableIndex(TI.t_dna);
			TI.audionation = fifaDbFile.GetTableIndex(TI.t_audionation);
			TI.NoAttendance = fifaDbFile.GetTableIndex(TI.t_NoAttendance);
			TI.MatchIntensity = fifaDbFile.GetTableIndex(TI.t_MatchIntensity);
			TI.BigAttendance = fifaDbFile.GetTableIndex(TI.t_BigAttendance);
			TI.career_managerawards = fifaDbFile.GetTableIndex(TI.t_career_managerawards);
			TI.career_teamofweek = fifaDbFile.GetTableIndex(TI.t_career_teamofweek);
			TI.career_playerawards = fifaDbFile.GetTableIndex(TI.t_career_playerawards);
			TI.career_calendar = fifaDbFile.GetTableIndex(TI.t_career_calendar);
			TI.career_suspensions = fifaDbFile.GetTableIndex(TI.t_career_suspensions);
			TI.career_squadranking = fifaDbFile.GetTableIndex(TI.t_career_squadranking);
			TI.career_playermatchratinghistory = fifaDbFile.GetTableIndex(TI.t_career_playermatchratinghistory);
			TI.career_fixtureinfo = fifaDbFile.GetTableIndex(TI.t_career_fixtureinfo);
			TI.career_extraplayerinfo = fifaDbFile.GetTableIndex(TI.t_career_extraplayerinfo);
			TI.cmeventhistory = fifaDbFile.GetTableIndex(TI.t_cmeventhistory);
			TI.career_boardoutcomes = fifaDbFile.GetTableIndex(TI.t_career_boardoutcomes);
			TI.career_users = fifaDbFile.GetTableIndex(TI.t_career_users);
			TI.career_trophies = fifaDbFile.GetTableIndex(TI.t_career_trophies);
			TI.career_managerpref = fifaDbFile.GetTableIndex(TI.t_career_managerpref);
			TI.career_managerinfo = fifaDbFile.GetTableIndex(TI.t_career_managerinfo);
			TI.career_managerhistory = fifaDbFile.GetTableIndex(TI.t_career_managerhistory);
			TI.career_leagueballs = fifaDbFile.GetTableIndex(TI.t_career_leagueballs);
			TI.career_competitionprogress = fifaDbFile.GetTableIndex(TI.t_career_competitionprogress);
			TI.clubcommentarynames = fifaDbFile.GetTableIndex(TI.t_clubcommentarynames);
			TI.commentarynames = fifaDbFile.GetTableIndex(TI.t_commentarynames);
			TI.createplayer = fifaDbFile.GetTableIndex(TI.t_createplayer);
			TI.createplayerpositiontemplates = fifaDbFile.GetTableIndex(TI.t_createplayerpositiontemplates);
			TI.createplayerviews = fifaDbFile.GetTableIndex(TI.t_createplayerviews);
			TI.cz_assets = fifaDbFile.GetTableIndex(TI.t_cz_assets);
			TI.cz_teams = fifaDbFile.GetTableIndex(TI.t_cz_teams);
			TI.cz_teamkits = fifaDbFile.GetTableIndex(TI.t_cz_teamkits);
			TI.cz_players = fifaDbFile.GetTableIndex(TI.t_cz_players);
			TI.cz_leagues = fifaDbFile.GetTableIndex(TI.t_cz_leagues);
			TI.balls = fifaDbFile.GetTableIndex(TI.t_balls);
			TI.teamstadiumlinkscache = fifaDbFile.GetTableIndex(TI.t_teamstadiumlinkscache);
			TI.dlcboots = fifaDbFile.GetTableIndex(TI.t_dlcboots);
			TI.dlcballs = fifaDbFile.GetTableIndex(TI.t_dlcballs);
			TI.eatrax = fifaDbFile.GetTableIndex(TI.t_eatrax);
			TI.songplaylistlinks = fifaDbFile.GetTableIndex(TI.t_songplaylistlinks);
			TI.celebrations = fifaDbFile.GetTableIndex(TI.t_celebrations);
			TI.videos = fifaDbFile.GetTableIndex(TI.t_videos);
			TI.fifaGameSettings = fifaDbFile.GetTableIndex(TI.t_fifaGameSettings);
			TI.mls_fixtures = fifaDbFile.GetTableIndex(TI.t_mls_fixtures);
			TI.team_lookup = fifaDbFile.GetTableIndex(TI.t_team_lookup);
			TI.player_stats = fifaDbFile.GetTableIndex(TI.t_player_stats);
			TI.customformations = fifaDbFile.GetTableIndex(TI.t_customformations);
			TI.teamformationteamstylelinks = fifaDbFile.GetTableIndex(TI.t_teamformationteamstylelinks);
			TI.customteamstyles = fifaDbFile.GetTableIndex(TI.t_customteamstyles);
			TI.career_news = fifaDbFile.GetTableIndex(TI.t_career_news);
			TI.career_newspicweights = fifaDbFile.GetTableIndex(TI.t_career_newspicweights);
			TI.career_newsban = fifaDbFile.GetTableIndex(TI.t_career_newsban);
			TI.persistent_events = fifaDbFile.GetTableIndex(TI.t_persistent_events);
			TI.career_playasplayer = fifaDbFile.GetTableIndex(TI.t_career_playasplayer);
			TI.career_playerbonusper = fifaDbFile.GetTableIndex(TI.t_career_playerbonusper);
			TI.career_playasplayerhistory = fifaDbFile.GetTableIndex(TI.t_career_playasplayerhistory);
			TI.career_growthcurveinfo = fifaDbFile.GetTableIndex(TI.t_career_growthcurveinfo);
			TI.player_career = fifaDbFile.GetTableIndex(TI.t_player_career);
			TI.player_growth_experience_points = fifaDbFile.GetTableIndex(TI.t_player_growth_experience_points);
			TI.experiencepoints = fifaDbFile.GetTableIndex(TI.t_experiencepoints);
			TI.career_playergrowthuserseason = fifaDbFile.GetTableIndex(TI.t_career_playergrowthuserseason);
			TI.career_playergrowthupdates = fifaDbFile.GetTableIndex(TI.t_career_playergrowthupdates);
			TI.career_playergrowthhistory = fifaDbFile.GetTableIndex(TI.t_career_playergrowthhistory);
			TI.career_matchexperience = fifaDbFile.GetTableIndex(TI.t_career_matchexperience);
			TI.specialteams = fifaDbFile.GetTableIndex(TI.t_specialteams);
			TI.stadiumassignments = fifaDbFile.GetTableIndex(TI.t_stadiumassignments);
			TI.factory_teams = fifaDbFile.GetTableIndex(TI.t_factory_teams);
			TI.temp_arenacreateplayer = fifaDbFile.GetTableIndex(TI.t_temp_arenacreateplayer);
			TI.temp_createplayer = fifaDbFile.GetTableIndex(TI.t_temp_createplayer);
			TI.usability_functions = fifaDbFile.GetTableIndex(TI.t_usability_functions);
			TI.usability = fifaDbFile.GetTableIndex(TI.t_usability);
			TI.virtualleagues = fifaDbFile.GetTableIndex(TI.t_virtualleagues);
			TI.career_blacklist = fifaDbFile.GetTableIndex(TI.t_career_blacklist);
			TI.career_transferoffer = fifaDbFile.GetTableIndex(TI.t_career_transferoffer);
			TI.career_transferlist = fifaDbFile.GetTableIndex(TI.t_career_transferlist);
			TI.career_playercontract = fifaDbFile.GetTableIndex(TI.t_career_playercontract);
			TI.career_loanbuy = fifaDbFile.GetTableIndex(TI.t_career_loanbuy);
			TI.career_commonnames = fifaDbFile.GetTableIndex(TI.t_career_commonnames);
			TI.career_youthplayers = fifaDbFile.GetTableIndex(TI.t_career_youthplayers);
			TI.career_youthplayerhistory = fifaDbFile.GetTableIndex(TI.t_career_youthplayershistory);
			TI.career_youthplayerattributes = fifaDbFile.GetTableIndex(TI.t_career_youthplayersattributes);
			TI.career_scouts = fifaDbFile.GetTableIndex(TI.t_career_scouts);
			TI.career_scoutmission = fifaDbFile.GetTableIndex(TI.t_career_scoutmission);
			TI.career_namesgroups = fifaDbFile.GetTableIndex(TI.t_career_namesgroups);
			TI.career_lastnames = fifaDbFile.GetTableIndex(TI.t_career_lastnames);
			TI.career_firstnames = fifaDbFile.GetTableIndex(TI.t_career_firstnames);
			return flag;
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00034790 File Offset: 0x00032990
		public static bool InitTIAsFIFA13(DbFile fifaDbFile)
		{
			bool flag = true;
			TI.fixtures = fifaDbFile.GetTableIndex(TI.t_fixtures);
			TI.player_stats = fifaDbFile.GetTableIndex(TI.t_player_stats);
			TI.team_lookup = fifaDbFile.GetTableIndex(TI.t_team_lookup);
			TI.assetcryptokeys = fifaDbFile.GetTableIndex(TI.t_assetcryptokeys);
			TI.version = fifaDbFile.GetTableIndex(TI.t_version);
			TI.transactionhistory = fifaDbFile.GetTableIndex(TI.t_transactionhistory);
			TI.trainingteamplayers = fifaDbFile.GetTableIndex(TI.t_trainingteamplayers);
			TI.trainingteamplayernames = fifaDbFile.GetTableIndex(TI.t_trainingteamplayernames);
			TI.trainingteamplayerlinks = fifaDbFile.GetTableIndex(TI.t_trainingteamplayerlinks);
			TI.temp_teams = fifaDbFile.GetTableIndex(TI.t_temp_teams);
			TI.temp_teamplayerlinks = fifaDbFile.GetTableIndex(TI.t_temp_teamplayerlinks);
			TI.temp_players = fifaDbFile.GetTableIndex(TI.t_temp_players);
			TI.temp_formations = fifaDbFile.GetTableIndex(TI.t_temp_formations);
			TI.temp_arenateamplayerlinks = fifaDbFile.GetTableIndex(TI.t_temp_arenateamplayerlinks);
			TI.temp_arenateam = fifaDbFile.GetTableIndex(TI.t_temp_arenateam);
			TI.temp_arenaplayername = fifaDbFile.GetTableIndex(TI.t_temp_arenaplayername);
			TI.temp_arenaplayer = fifaDbFile.GetTableIndex(TI.t_temp_arenaplayer);
			TI.teamstadiumlinks = fifaDbFile.GetTableIndex(TI.t_teamstadiumlinks);
			TI.teams = fifaDbFile.GetTableIndex(TI.t_teams);
			TI.teamplayerlinks = fifaDbFile.GetTableIndex(TI.t_teamplayerlinks);
			TI.teamkits = fifaDbFile.GetTableIndex(TI.t_teamkits);
			TI.teamformdiff = fifaDbFile.GetTableIndex(TI.t_teamformdiff);
			TI.teamballs = fifaDbFile.GetTableIndex(TI.t_teamballs);
			TI.stories = fifaDbFile.GetTableIndex(TI.t_stories);
			TI.starratingboundaries = fifaDbFile.GetTableIndex(TI.t_starratingboundaries);
			TI.stadiums = fifaDbFile.GetTableIndex(TI.t_stadiums);
			TI.shoecolors = fifaDbFile.GetTableIndex(TI.t_shoecolors);
			TI.rowteamnationlinks = fifaDbFile.GetTableIndex(TI.t_rowteamnationlinks);
			TI.rivals = fifaDbFile.GetTableIndex(TI.t_rivals);
			TI.restrictedplayers = fifaDbFile.GetTableIndex(TI.t_restrictedplayers);
			TI.referee = fifaDbFile.GetTableIndex(TI.t_referee);
			TI.previousteam = fifaDbFile.GetTableIndex(TI.t_previousteam);
			TI.players = fifaDbFile.GetTableIndex(TI.t_players);
			TI.playernames = fifaDbFile.GetTableIndex(TI.t_playernames);
			TI.playerloans = fifaDbFile.GetTableIndex(TI.t_playerloans);
			TI.playerformdiff = fifaDbFile.GetTableIndex(TI.t_playerformdiff);
			TI.playerboots = fifaDbFile.GetTableIndex(TI.t_playerboots);
			TI.player_grudgelove = fifaDbFile.GetTableIndex(TI.t_player_grudgelove);
			TI.physio = fifaDbFile.GetTableIndex(TI.t_physio);
			TI.nations = fifaDbFile.GetTableIndex(TI.t_nations);
			TI.manager = fifaDbFile.GetTableIndex(TI.t_manager);
			TI.leagueteamlinks = fifaDbFile.GetTableIndex(TI.t_leagueteamlinks);
			TI.leagues = fifaDbFile.GetTableIndex(TI.t_leagues);
			TI.leaguerefereelinks = fifaDbFile.GetTableIndex(TI.t_leaguerefereelinks);
			TI.formupdate = fifaDbFile.GetTableIndex(TI.t_formupdate);
			TI.formations = fifaDbFile.GetTableIndex(TI.t_formations);
			TI.fieldpositionboundingboxes = fifaDbFile.GetTableIndex(TI.t_fieldpositionboundingboxes);
			TI.editedplayernames = fifaDbFile.GetTableIndex(TI.t_editedplayernames);
			TI.dna = fifaDbFile.GetTableIndex(TI.t_dna);
			TI.dcplayernames = fifaDbFile.GetTableIndex(TI.t_dcplayernames);
			TI.customformations = fifaDbFile.GetTableIndex(TI.t_customformations);
			TI.competition = fifaDbFile.GetTableIndex(TI.t_competition);
			TI.career_lastnames = fifaDbFile.GetTableIndex(TI.t_career_lastnames);
			TI.career_firstnames = fifaDbFile.GetTableIndex(TI.t_career_firstnames);
			TI.career_commonnames = fifaDbFile.GetTableIndex(TI.t_career_commonnames);
			TI.attributeprefpositionformula = fifaDbFile.GetTableIndex(TI.t_attributeprefpositionformula);
			TI.audionation = fifaDbFile.GetTableIndex(TI.t_audionation);
			TI.NoAttendance = fifaDbFile.GetTableIndex(TI.t_NoAttendance);
			TI.MatchIntensity = fifaDbFile.GetTableIndex(TI.t_MatchIntensity);
			TI.BigAttendance = fifaDbFile.GetTableIndex(TI.t_BigAttendance);
			TI.audiostadium = fifaDbFile.GetTableIndex(TI.t_audiostadium);
			TI.career_managerawards = fifaDbFile.GetTableIndex(TI.t_career_managerawards);
			TI.career_teamofweek = fifaDbFile.GetTableIndex(TI.t_career_teamofweek);
			TI.career_playerawards = fifaDbFile.GetTableIndex(TI.t_career_playerawards);
			TI.career_calendar = fifaDbFile.GetTableIndex(TI.t_career_calendar);
			TI.career_squadranking = fifaDbFile.GetTableIndex(TI.t_career_squadranking);
			TI.career_playermatchratinghistory = fifaDbFile.GetTableIndex(TI.t_career_playermatchratinghistory);
			TI.career_fixtureinfo = fifaDbFile.GetTableIndex(TI.t_career_fixtureinfo);
			TI.career_clinchedobjectives = fifaDbFile.GetTableIndex(TI.t_career_clinchedobjectives);
			TI.cmeventhistory = fifaDbFile.GetTableIndex(TI.t_cmeventhistory);
			TI.cmteameventhistory = fifaDbFile.GetTableIndex(TI.t_cmteameventhistory);
			TI.career_boardoutcomes = fifaDbFile.GetTableIndex(TI.t_career_boardoutcomes);
			TI.career_users = fifaDbFile.GetTableIndex(TI.t_career_users);
			TI.career_trophies = fifaDbFile.GetTableIndex(TI.t_career_trophies);
			TI.career_managerpref = fifaDbFile.GetTableIndex(TI.t_career_managerpref);
			TI.career_managerinfo = fifaDbFile.GetTableIndex(TI.t_career_managerinfo);
			TI.career_managerhistory = fifaDbFile.GetTableIndex(TI.t_career_managerhistory);
			TI.career_leagueballs = fifaDbFile.GetTableIndex(TI.t_career_leagueballs);
			TI.career_competitionprogress = fifaDbFile.GetTableIndex(TI.t_career_competitionprogress);
			TI.clubcommentarynames = fifaDbFile.GetTableIndex(TI.t_clubcommentarynames);
			TI.createplayerviews = fifaDbFile.GetTableIndex(TI.t_createplayerviews);
			TI.createplayerpositiontemplates = fifaDbFile.GetTableIndex(TI.t_createplayerpositiontemplates);
			TI.createplayer = fifaDbFile.GetTableIndex(TI.t_createplayer);
			TI.commentarynames = fifaDbFile.GetTableIndex(TI.t_commentarynames);
			TI.cz_assets = fifaDbFile.GetTableIndex(TI.t_cz_assets);
			TI.cz_teams = fifaDbFile.GetTableIndex(TI.t_cz_teams);
			TI.cz_teamkits = fifaDbFile.GetTableIndex(TI.t_cz_teamkits);
			TI.cz_players = fifaDbFile.GetTableIndex(TI.t_cz_players);
			TI.cz_leagues = fifaDbFile.GetTableIndex(TI.t_cz_leagues);
			TI.dlcballs = fifaDbFile.GetTableIndex(TI.t_dlcballs);
			TI.teamstadiumlinkscache = fifaDbFile.GetTableIndex(TI.t_teamstadiumlinkscache);
			TI.dlcboots = fifaDbFile.GetTableIndex(TI.t_dlcboots);
			TI.eatrax = fifaDbFile.GetTableIndex(TI.t_eatrax);
			TI.songplaylistlinks = fifaDbFile.GetTableIndex(TI.t_songplaylistlinks);
			TI.celebrations = fifaDbFile.GetTableIndex(TI.t_celebrations);
			TI.videos = fifaDbFile.GetTableIndex(TI.t_videos);
			TI.fce_activeteams = fifaDbFile.GetTableIndex(TI.t_fce_activeteams);
			TI.fce_weathersettings = fifaDbFile.GetTableIndex(TI.t_fce_weathersettings);
			TI.fce_statistics = fifaDbFile.GetTableIndex(TI.t_fce_statistics);
			TI.fce_standings = fifaDbFile.GetTableIndex(TI.t_fce_standings);
			TI.fce_stageadvance = fifaDbFile.GetTableIndex(TI.t_fce_stageadvance);
			TI.fce_settings = fifaDbFile.GetTableIndex(TI.t_fce_settings);
			TI.fce_scriptfunctions = fifaDbFile.GetTableIndex(TI.t_fce_scriptfunctions);
			TI.fce_scheduleinfo = fifaDbFile.GetTableIndex(TI.t_fce_scheduleinfo);
			TI.fce_fixtures = fifaDbFile.GetTableIndex(TI.t_fce_fixtures);
			TI.fce_competitionteams = fifaDbFile.GetTableIndex(TI.t_fce_competitionteams);
			TI.fce_competitioninfo = fifaDbFile.GetTableIndex(TI.t_fce_competitioninfo);
			TI.fce_compavgs = fifaDbFile.GetTableIndex(TI.t_fce_compavgs);
			TI.fce_advancement = fifaDbFile.GetTableIndex(TI.t_fce_advancement);
			TI.fifaGameSettings = fifaDbFile.GetTableIndex(TI.t_fifaGameSettings);
			TI.mls_fixtures = fifaDbFile.GetTableIndex(TI.t_mls_fixtures);
			TI.customteamstyles = fifaDbFile.GetTableIndex(TI.t_customteamstyles);
			TI.teamformationteamstylelinks = fifaDbFile.GetTableIndex(TI.t_teamformationteamstylelinks);
			TI.career_news = fifaDbFile.GetTableIndex(TI.t_career_news);
			TI.career_newspicweights = fifaDbFile.GetTableIndex(TI.t_career_newspicweights);
			TI.career_newsban = fifaDbFile.GetTableIndex(TI.t_career_newsban);
			TI.persistent_events = fifaDbFile.GetTableIndex(TI.t_persistent_events);
			TI.career_playasplayer = fifaDbFile.GetTableIndex(TI.t_career_playasplayer);
			TI.career_playerbonusper = fifaDbFile.GetTableIndex(TI.t_career_playerbonusper);
			TI.career_playasplayerhistory = fifaDbFile.GetTableIndex(TI.t_career_playasplayerhistory);
			TI.career_growthcurveinfo = fifaDbFile.GetTableIndex(TI.t_career_growthcurveinfo);
			TI.player_growth_experience_points = fifaDbFile.GetTableIndex(TI.t_player_growth_experience_points);
			TI.player_career = fifaDbFile.GetTableIndex(TI.t_player_career);
			TI.experiencepoints = fifaDbFile.GetTableIndex(TI.t_experiencepoints);
			TI.career_playergrowthuserseason = fifaDbFile.GetTableIndex(TI.t_career_playergrowthuserseason);
			TI.career_playergrowthupdates = fifaDbFile.GetTableIndex(TI.t_career_playergrowthupdates);
			TI.career_playergrowthhistory = fifaDbFile.GetTableIndex(TI.t_career_playergrowthhistory);
			TI.finalstadiums = fifaDbFile.GetTableIndex(TI.t_finalstadiums);
			TI.tourn_team_manager = fifaDbFile.GetTableIndex(TI.t_tourn_team_manager);
			TI.tourn_settings = fifaDbFile.GetTableIndex(TI.t_tourn_settings);
			TI.tourn_rtsg = fifaDbFile.GetTableIndex(TI.t_tourn_rtsg);
			TI.tourn_manager_settings = fifaDbFile.GetTableIndex(TI.t_tourn_manager_settings);
			TI.tourn_licensed_stages = fifaDbFile.GetTableIndex(TI.t_tourn_licensed_stages);
			TI.tourn_licensed = fifaDbFile.GetTableIndex(TI.t_tourn_licensed);
			TI.specialteams = fifaDbFile.GetTableIndex(TI.t_specialteams);
			TI.stadiumassignments = fifaDbFile.GetTableIndex(TI.t_stadiumassignments);
			TI.factory_teams = fifaDbFile.GetTableIndex(TI.t_factory_teams);
			TI.temp_createplayer = fifaDbFile.GetTableIndex(TI.t_temp_createplayer);
			TI.temp_arenacreateplayer = fifaDbFile.GetTableIndex(TI.t_temp_arenacreateplayer);
			TI.career_blacklist = fifaDbFile.GetTableIndex(TI.t_career_blacklist);
			TI.career_transferoffer = fifaDbFile.GetTableIndex(TI.t_career_transferoffer);
			TI.career_transferlist = fifaDbFile.GetTableIndex(TI.t_career_transferlist);
			TI.career_playercontract = fifaDbFile.GetTableIndex(TI.t_career_playercontract);
			TI.career_loanbuy = fifaDbFile.GetTableIndex(TI.t_career_loanbuy);
			TI.achievements = fifaDbFile.GetTableIndex(TI.t_achievements);
			TI.fifaUnlockables = fifaDbFile.GetTableIndex(TI.t_fifaUnlockables);
			TI.usability = fifaDbFile.GetTableIndex(TI.t_usability);
			TI.usability_functions = fifaDbFile.GetTableIndex(TI.t_usability_functions);
			TI.virtualleagues = fifaDbFile.GetTableIndex(TI.t_virtualleagues);
			TI.career_namesgroups = fifaDbFile.GetTableIndex(TI.t_career_namesgroups);
			TI.career_youthplayers = fifaDbFile.GetTableIndex(TI.t_career_youthplayers);
			TI.career_youthplayerhistory = fifaDbFile.GetTableIndex(TI.t_career_youthplayerhistory);
			TI.career_youthplayerattributes = fifaDbFile.GetTableIndex(TI.t_career_youthplayerattributes);
			TI.career_scouts = fifaDbFile.GetTableIndex(TI.t_career_scouts);
			TI.career_scoutmission = fifaDbFile.GetTableIndex(TI.t_career_scoutmission);
			TI.career_regenplayerattributes = fifaDbFile.GetTableIndex(TI.t_career_regenplayerattributes);
			return flag;
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00035160 File Offset: 0x00033360
		public static bool InitTIAsFIFA14(DbFile fifaDbFile)
		{
			bool flag = true;
			TI.BigAttendance = fifaDbFile.GetTableIndex(TI.t_BigAttendance);
			TI.MatchIntensity = fifaDbFile.GetTableIndex(TI.t_MatchIntensity);
			TI.NoAttendance = fifaDbFile.GetTableIndex(TI.t_NoAttendance);
			TI.assetcryptokeys = fifaDbFile.GetTableIndex(TI.t_assetcryptokeys);
			TI.attributeprefpositionformula = fifaDbFile.GetTableIndex(TI.t_attributeprefpositionformula);
			TI.audionation = fifaDbFile.GetTableIndex(TI.t_audionation);
			TI.audiostadium = fifaDbFile.GetTableIndex(TI.t_audiostadium);
			TI.career_blacklist = fifaDbFile.GetTableIndex(TI.t_career_blacklist);
			TI.career_boardoutcomes = fifaDbFile.GetTableIndex(TI.t_career_boardoutcomes);
			TI.career_calendar = fifaDbFile.GetTableIndex(TI.t_career_calendar);
			TI.career_clinchedobjectives = fifaDbFile.GetTableIndex(TI.t_career_clinchedobjectives);
			TI.career_commonnames = fifaDbFile.GetTableIndex(TI.t_career_commonnames);
			TI.career_competitionprogress = fifaDbFile.GetTableIndex(TI.t_career_competitionprogress);
			TI.career_firstnames = fifaDbFile.GetTableIndex(TI.t_career_firstnames);
			TI.career_growthcurveinfo = fifaDbFile.GetTableIndex(TI.t_career_growthcurveinfo);
			TI.career_lastnames = fifaDbFile.GetTableIndex(TI.t_career_lastnames);
			TI.career_leagueballs = fifaDbFile.GetTableIndex(TI.t_career_leagueballs);
			TI.career_loanbuy = fifaDbFile.GetTableIndex(TI.t_career_loanbuy);
			TI.career_managerawards = fifaDbFile.GetTableIndex(TI.t_career_managerawards);
			TI.career_managerhistory = fifaDbFile.GetTableIndex(TI.t_career_managerhistory);
			TI.career_managerinfo = fifaDbFile.GetTableIndex(TI.t_career_managerinfo);
			TI.career_managerpref = fifaDbFile.GetTableIndex(TI.t_career_managerpref);
			TI.career_namesgroups = fifaDbFile.GetTableIndex(TI.t_career_namesgroups);
			TI.career_news = fifaDbFile.GetTableIndex(TI.t_career_news);
			TI.career_newsban = fifaDbFile.GetTableIndex(TI.t_career_newsban);
			TI.career_newspicweights = fifaDbFile.GetTableIndex(TI.t_career_newspicweights);
			TI.career_playasplayer = fifaDbFile.GetTableIndex(TI.t_career_playasplayer);
			TI.career_playasplayerhistory = fifaDbFile.GetTableIndex(TI.t_career_playasplayerhistory);
			TI.career_playerawards = fifaDbFile.GetTableIndex(TI.t_career_playerawards);
			TI.career_playerbonusper = fifaDbFile.GetTableIndex(TI.t_career_playerbonusper);
			TI.career_playercontract = fifaDbFile.GetTableIndex(TI.t_career_playercontract);
			TI.career_playergrowthhistory = fifaDbFile.GetTableIndex(TI.t_career_playergrowthhistory);
			TI.career_playergrowthupdates = fifaDbFile.GetTableIndex(TI.t_career_playergrowthupdates);
			TI.career_playergrowthuserseason = fifaDbFile.GetTableIndex(TI.t_career_playergrowthuserseason);
			TI.career_playermatchratinghistory = fifaDbFile.GetTableIndex(TI.t_career_playermatchratinghistory);
			TI.career_precontract = fifaDbFile.GetTableIndex(TI.t_career_precontract);
			TI.career_regenplayerattributes = fifaDbFile.GetTableIndex(TI.t_career_regenplayerattributes);
			TI.career_scoutmission = fifaDbFile.GetTableIndex(TI.t_career_scoutmission);
			TI.career_scouts = fifaDbFile.GetTableIndex(TI.t_career_scouts);
			TI.career_squadranking = fifaDbFile.GetTableIndex(TI.t_career_squadranking);
			TI.career_teamofweek = fifaDbFile.GetTableIndex(TI.t_career_teamofweek);
			TI.career_transferlist = fifaDbFile.GetTableIndex(TI.t_career_transferlist);
			TI.career_transferoffer = fifaDbFile.GetTableIndex(TI.t_career_transferoffer);
			TI.career_trophies = fifaDbFile.GetTableIndex(TI.t_career_trophies);
			TI.career_users = fifaDbFile.GetTableIndex(TI.t_career_users);
			TI.career_youthplayerattributes = fifaDbFile.GetTableIndex(TI.t_career_youthplayerattributes);
			TI.career_youthplayerhistory = fifaDbFile.GetTableIndex(TI.t_career_youthplayerhistory);
			TI.career_youthplayers = fifaDbFile.GetTableIndex(TI.t_career_youthplayers);
			TI.celebrations = fifaDbFile.GetTableIndex(TI.t_celebrations);
			TI.clubcommentarynames = fifaDbFile.GetTableIndex(TI.t_clubcommentarynames);
			TI.cmeventhistory = fifaDbFile.GetTableIndex(TI.t_cmeventhistory);
			TI.cmteameventhistory = fifaDbFile.GetTableIndex(TI.t_cmteameventhistory);
			TI.commentarynames = fifaDbFile.GetTableIndex(TI.t_commentarynames);
			TI.competition = fifaDbFile.GetTableIndex(TI.t_competition);
			TI.createplayer = fifaDbFile.GetTableIndex(TI.t_createplayer);
			TI.createplayerpositiontemplates = fifaDbFile.GetTableIndex(TI.t_createplayerpositiontemplates);
			TI.createplayerviews = fifaDbFile.GetTableIndex(TI.t_createplayerviews);
			TI.customformations = fifaDbFile.GetTableIndex(TI.t_customformations);
			TI.customteamstyles = fifaDbFile.GetTableIndex(TI.t_customteamstyles);
			TI.cz_assets = fifaDbFile.GetTableIndex(TI.t_cz_assets);
			TI.cz_leagues = fifaDbFile.GetTableIndex(TI.t_cz_leagues);
			TI.cz_players = fifaDbFile.GetTableIndex(TI.t_cz_players);
			TI.cz_teamkits = fifaDbFile.GetTableIndex(TI.t_cz_teamkits);
			TI.cz_teams = fifaDbFile.GetTableIndex(TI.t_cz_teams);
			TI.dcplayernames = fifaDbFile.GetTableIndex(TI.t_dcplayernames);
			TI.dlcballs = fifaDbFile.GetTableIndex(TI.t_dlcballs);
			TI.dlcboots = fifaDbFile.GetTableIndex(TI.t_dlcboots);
			TI.dna = fifaDbFile.GetTableIndex(TI.t_dna);
			TI.eatrax = fifaDbFile.GetTableIndex(TI.t_eatrax);
			TI.editedplayernames = fifaDbFile.GetTableIndex(TI.t_editedplayernames);
			TI.factory_teams = fifaDbFile.GetTableIndex(TI.t_factory_teams);
			TI.fieldpositionboundingboxes = fifaDbFile.GetTableIndex(TI.t_fieldpositionboundingboxes);
			TI.fifaGameSettings = fifaDbFile.GetTableIndex(TI.t_fifaGameSettings);
			TI.fixtures = fifaDbFile.GetTableIndex(TI.t_fixtures);
			TI.formations = fifaDbFile.GetTableIndex(TI.t_formations);
			TI.leaguerefereelinks = fifaDbFile.GetTableIndex(TI.t_leaguerefereelinks);
			TI.leagues = fifaDbFile.GetTableIndex(TI.t_leagues);
			TI.leagueteamlinks = fifaDbFile.GetTableIndex(TI.t_leagueteamlinks);
			TI.manager = fifaDbFile.GetTableIndex(TI.t_manager);
			TI.mls_fixtures = fifaDbFile.GetTableIndex(TI.t_mls_fixtures);
			TI.nations = fifaDbFile.GetTableIndex(TI.t_nations);
			TI.persistent_events = fifaDbFile.GetTableIndex(TI.t_persistent_events);
			TI.physio = fifaDbFile.GetTableIndex(TI.t_physio);
			TI.player_grudgelove = fifaDbFile.GetTableIndex(TI.t_player_grudgelove);
			TI.player_stats = fifaDbFile.GetTableIndex(TI.t_player_stats);
			TI.playerboots = fifaDbFile.GetTableIndex(TI.t_playerboots);
			TI.playerformdiff = fifaDbFile.GetTableIndex(TI.t_playerformdiff);
			TI.playerloans = fifaDbFile.GetTableIndex(TI.t_playerloans);
			TI.playernames = fifaDbFile.GetTableIndex(TI.t_playernames);
			TI.players = fifaDbFile.GetTableIndex(TI.t_players);
			TI.previousteam = fifaDbFile.GetTableIndex(TI.t_previousteam);
			TI.referee = fifaDbFile.GetTableIndex(TI.t_referee);
			TI.restrictedplayers = fifaDbFile.GetTableIndex(TI.t_restrictedplayers);
			TI.rivals = fifaDbFile.GetTableIndex(TI.t_rivals);
			TI.rowteamnationlinks = fifaDbFile.GetTableIndex(TI.t_rowteamnationlinks);
			TI.shoecolors = fifaDbFile.GetTableIndex(TI.t_shoecolors);
			TI.songplaylistlinks = fifaDbFile.GetTableIndex(TI.t_songplaylistlinks);
			TI.stadiumassignments = fifaDbFile.GetTableIndex(TI.t_stadiumassignments);
			TI.stadiums = fifaDbFile.GetTableIndex(TI.t_stadiums);
			TI.starratingboundaries = fifaDbFile.GetTableIndex(TI.t_starratingboundaries);
			TI.stories = fifaDbFile.GetTableIndex(TI.t_stories);
			TI.team_lookup = fifaDbFile.GetTableIndex(TI.t_team_lookup);
			TI.teamballs = fifaDbFile.GetTableIndex(TI.t_teamballs);
			TI.teamformationteamstylelinks = fifaDbFile.GetTableIndex(TI.t_teamformationteamstylelinks);
			TI.teamformdiff = fifaDbFile.GetTableIndex(TI.t_teamformdiff);
			TI.teamkits = fifaDbFile.GetTableIndex(TI.t_teamkits);
			TI.teamplayerlinks = fifaDbFile.GetTableIndex(TI.t_teamplayerlinks);
			TI.teams = fifaDbFile.GetTableIndex(TI.t_teams);
			TI.teamstadiumlinks = fifaDbFile.GetTableIndex(TI.t_teamstadiumlinks);
			TI.teamstadiumlinkscache = fifaDbFile.GetTableIndex(TI.t_teamstadiumlinkscache);
			TI.temp_arenacreateplayer = fifaDbFile.GetTableIndex(TI.t_temp_arenacreateplayer);
			TI.temp_arenaplayer = fifaDbFile.GetTableIndex(TI.t_temp_arenaplayer);
			TI.temp_arenaplayername = fifaDbFile.GetTableIndex(TI.t_temp_arenaplayername);
			TI.temp_arenateam = fifaDbFile.GetTableIndex(TI.t_temp_arenateam);
			TI.temp_arenateamplayerlinks = fifaDbFile.GetTableIndex(TI.t_temp_arenateamplayerlinks);
			TI.temp_createplayer = fifaDbFile.GetTableIndex(TI.t_temp_createplayer);
			TI.temp_formations = fifaDbFile.GetTableIndex(TI.t_temp_formations);
			TI.temp_players = fifaDbFile.GetTableIndex(TI.t_temp_players);
			TI.temp_teamplayerlinks = fifaDbFile.GetTableIndex(TI.t_temp_teamplayerlinks);
			TI.temp_teams = fifaDbFile.GetTableIndex(TI.t_temp_teams);
			TI.trainingteamplayerlinks = fifaDbFile.GetTableIndex(TI.t_trainingteamplayerlinks);
			TI.trainingteamplayernames = fifaDbFile.GetTableIndex(TI.t_trainingteamplayernames);
			TI.trainingteamplayers = fifaDbFile.GetTableIndex(TI.t_trainingteamplayers);
			TI.transactionhistory = fifaDbFile.GetTableIndex(TI.t_transactionhistory);
			TI.version = fifaDbFile.GetTableIndex(TI.t_version);
			TI.videos = fifaDbFile.GetTableIndex(TI.t_videos);
			return flag;
		}

		// Token: 0x04000395 RID: 917
		private static string t_balls = "balls";

		// Token: 0x04000396 RID: 918
		private static string t_career_extraplayerinfo = "career_extraplayerinfo";

		// Token: 0x04000397 RID: 919
		private static string t_career_matchexperience = "career_matchexperience";

		// Token: 0x04000398 RID: 920
		private static string t_career_suspensions = "career_suspensions";

		// Token: 0x04000399 RID: 921
		private static string t_career_youthplayersattributes = "career_youthplayerattributes";

		// Token: 0x0400039A RID: 922
		private static string t_career_youthplayershistory = "career_youthplayerhistory";

		// Token: 0x0400039B RID: 923
		private static string t_formupdate = "formupdate";

		// Token: 0x0400039C RID: 924
		private static string t_career_fixtureinfo = "career_fixtureinfo";

		// Token: 0x0400039D RID: 925
		private static string t_fce_activeteams = "fce_activeteams";

		// Token: 0x0400039E RID: 926
		private static string t_fce_weathersettings = "fce_weathersettings";

		// Token: 0x0400039F RID: 927
		private static string t_fce_statistics = "fce_statistics";

		// Token: 0x040003A0 RID: 928
		private static string t_fce_standings = "fce_standings";

		// Token: 0x040003A1 RID: 929
		private static string t_fce_stageadvance = "fce_stageadvance";

		// Token: 0x040003A2 RID: 930
		private static string t_fce_settings = "fce_settings";

		// Token: 0x040003A3 RID: 931
		private static string t_fce_scriptfunctions = "fce_scriptfunctions";

		// Token: 0x040003A4 RID: 932
		private static string t_fce_scheduleinfo = "fce_scheduleinfo";

		// Token: 0x040003A5 RID: 933
		private static string t_fce_fixtures = "fce_fixtures";

		// Token: 0x040003A6 RID: 934
		private static string t_fce_competitionteams = "fce_competitionteams";

		// Token: 0x040003A7 RID: 935
		private static string t_fce_competitioninfo = "fce_competitioninfo";

		// Token: 0x040003A8 RID: 936
		private static string t_fce_compavgs = "fce_compavgs";

		// Token: 0x040003A9 RID: 937
		private static string t_fce_advancement = "fce_advancement";

		// Token: 0x040003AA RID: 938
		private static string t_player_growth_experience_points = "player_growth_experience_points";

		// Token: 0x040003AB RID: 939
		private static string t_player_career = "player_career";

		// Token: 0x040003AC RID: 940
		private static string t_experiencepoints = "experiencepoints";

		// Token: 0x040003AD RID: 941
		private static string t_finalstadiums = "finalstadiums";

		// Token: 0x040003AE RID: 942
		private static string t_tourn_team_manager = "tourn_team_manager";

		// Token: 0x040003AF RID: 943
		private static string t_tourn_settings = "tourn_settings";

		// Token: 0x040003B0 RID: 944
		private static string t_tourn_rtsg = "tourn_rtsg";

		// Token: 0x040003B1 RID: 945
		private static string t_tourn_manager_settings = "tourn_manager_settings";

		// Token: 0x040003B2 RID: 946
		private static string t_tourn_licensed_stages = "tourn_licensed_stages";

		// Token: 0x040003B3 RID: 947
		private static string t_tourn_licensed = "tourn_licensed";

		// Token: 0x040003B4 RID: 948
		private static string t_specialteams = "specialteams";

		// Token: 0x040003B5 RID: 949
		private static string t_achievements = "achievements";

		// Token: 0x040003B6 RID: 950
		private static string t_fifaUnlockables = "fifaUnlockables";

		// Token: 0x040003B7 RID: 951
		private static string t_usability = "usability";

		// Token: 0x040003B8 RID: 952
		private static string t_usability_functions = "usability_functions";

		// Token: 0x040003B9 RID: 953
		private static string t_virtualleagues = "virtualleagues";

		// Token: 0x040003BA RID: 954
		private static string t_BigAttendance = "BigAttendance";

		// Token: 0x040003BB RID: 955
		private static string t_MatchIntensity = "MatchIntensity";

		// Token: 0x040003BC RID: 956
		private static string t_NoAttendance = "NoAttendance";

		// Token: 0x040003BD RID: 957
		private static string t_assetcryptokeys = "assetcryptokeys";

		// Token: 0x040003BE RID: 958
		private static string t_attributeprefpositionformula = "attributeprefpositionformula";

		// Token: 0x040003BF RID: 959
		private static string t_audionation = "audionation";

		// Token: 0x040003C0 RID: 960
		private static string t_audiostadium = "audiostadium";

		// Token: 0x040003C1 RID: 961
		private static string t_career_blacklist = "career_blacklist";

		// Token: 0x040003C2 RID: 962
		private static string t_career_boardoutcomes = "career_boardoutcomes";

		// Token: 0x040003C3 RID: 963
		private static string t_career_calendar = "career_calendar";

		// Token: 0x040003C4 RID: 964
		private static string t_career_clinchedobjectives = "career_clinchedobjectives";

		// Token: 0x040003C5 RID: 965
		private static string t_career_commonnames = "career_commonnames";

		// Token: 0x040003C6 RID: 966
		private static string t_career_competitionprogress = "career_competitionprogress";

		// Token: 0x040003C7 RID: 967
		private static string t_career_firstnames = "career_firstnames";

		// Token: 0x040003C8 RID: 968
		private static string t_career_growthcurveinfo = "career_growthcurveinfo";

		// Token: 0x040003C9 RID: 969
		private static string t_career_lastnames = "career_lastnames";

		// Token: 0x040003CA RID: 970
		private static string t_career_leagueballs = "career_leagueballs";

		// Token: 0x040003CB RID: 971
		private static string t_career_loanbuy = "career_loanbuy";

		// Token: 0x040003CC RID: 972
		private static string t_career_managerawards = "career_managerawards";

		// Token: 0x040003CD RID: 973
		private static string t_career_managerhistory = "career_managerhistory";

		// Token: 0x040003CE RID: 974
		private static string t_career_managerinfo = "career_managerinfo";

		// Token: 0x040003CF RID: 975
		private static string t_career_managerpref = "career_managerpref";

		// Token: 0x040003D0 RID: 976
		private static string t_career_namesgroups = "career_namesgroups";

		// Token: 0x040003D1 RID: 977
		private static string t_career_news = "career_news";

		// Token: 0x040003D2 RID: 978
		private static string t_career_newsban = "career_newsban";

		// Token: 0x040003D3 RID: 979
		private static string t_career_newspicweights = "career_newspicweights";

		// Token: 0x040003D4 RID: 980
		private static string t_career_playasplayer = "career_playasplayer";

		// Token: 0x040003D5 RID: 981
		private static string t_career_playasplayerhistory = "career_playasplayerhistory";

		// Token: 0x040003D6 RID: 982
		private static string t_career_playerawards = "career_playerawards";

		// Token: 0x040003D7 RID: 983
		private static string t_career_playerbonusper = "career_playerbonusper";

		// Token: 0x040003D8 RID: 984
		private static string t_career_playercontract = "career_playercontract";

		// Token: 0x040003D9 RID: 985
		private static string t_career_playergrowthhistory = "career_playergrowthhistory";

		// Token: 0x040003DA RID: 986
		private static string t_career_playergrowthupdates = "career_playergrowthupdates";

		// Token: 0x040003DB RID: 987
		private static string t_career_playergrowthuserseason = "career_playergrowthuserseason";

		// Token: 0x040003DC RID: 988
		private static string t_career_playermatchratinghistory = "career_playermatchratinghistory";

		// Token: 0x040003DD RID: 989
		private static string t_career_precontract = "career_precontract";

		// Token: 0x040003DE RID: 990
		private static string t_career_regenplayerattributes = "career_regenplayerattributes";

		// Token: 0x040003DF RID: 991
		private static string t_career_scoutmission = "career_scoutmission";

		// Token: 0x040003E0 RID: 992
		private static string t_career_scouts = "career_scouts";

		// Token: 0x040003E1 RID: 993
		private static string t_career_squadranking = "career_squadranking";

		// Token: 0x040003E2 RID: 994
		private static string t_career_teamofweek = "career_teamofweek";

		// Token: 0x040003E3 RID: 995
		private static string t_career_transferlist = "career_transferlist";

		// Token: 0x040003E4 RID: 996
		private static string t_career_transferoffer = "career_transferoffer";

		// Token: 0x040003E5 RID: 997
		private static string t_career_trophies = "career_trophies";

		// Token: 0x040003E6 RID: 998
		private static string t_career_users = "career_users";

		// Token: 0x040003E7 RID: 999
		private static string t_career_youthplayerattributes = "career_youthplayerattributes";

		// Token: 0x040003E8 RID: 1000
		private static string t_career_youthplayerhistory = "career_youthplayerhistory";

		// Token: 0x040003E9 RID: 1001
		private static string t_career_youthplayers = "career_youthplayers";

		// Token: 0x040003EA RID: 1002
		private static string t_celebrations = "celebrations";

		// Token: 0x040003EB RID: 1003
		private static string t_clubcommentarynames = "clubcommentarynames";

		// Token: 0x040003EC RID: 1004
		private static string t_cmeventhistory = "cmeventhistory";

		// Token: 0x040003ED RID: 1005
		private static string t_cmteameventhistory = "cmteameventhistory";

		// Token: 0x040003EE RID: 1006
		private static string t_commentarynames = "commentarynames";

		// Token: 0x040003EF RID: 1007
		private static string t_competition = "competition";

		// Token: 0x040003F0 RID: 1008
		private static string t_createplayer = "createplayer";

		// Token: 0x040003F1 RID: 1009
		private static string t_createplayerpositiontemplates = "createplayerpositiontemplates";

		// Token: 0x040003F2 RID: 1010
		private static string t_createplayerviews = "createplayerviews";

		// Token: 0x040003F3 RID: 1011
		private static string t_customformations = "customformations";

		// Token: 0x040003F4 RID: 1012
		private static string t_customteamstyles = "customteamstyles";

		// Token: 0x040003F5 RID: 1013
		private static string t_cz_assets = "cz_assets";

		// Token: 0x040003F6 RID: 1014
		private static string t_cz_leagues = "cz_leagues";

		// Token: 0x040003F7 RID: 1015
		private static string t_cz_players = "cz_players";

		// Token: 0x040003F8 RID: 1016
		private static string t_cz_teamkits = "cz_teamkits";

		// Token: 0x040003F9 RID: 1017
		private static string t_cz_teams = "cz_teams";

		// Token: 0x040003FA RID: 1018
		private static string t_dcplayernames = "dcplayernames";

		// Token: 0x040003FB RID: 1019
		private static string t_dlcballs = "dlcballs";

		// Token: 0x040003FC RID: 1020
		private static string t_dlcboots = "dlcboots";

		// Token: 0x040003FD RID: 1021
		private static string t_dna = "dna";

		// Token: 0x040003FE RID: 1022
		private static string t_eatrax = "eatrax";

		// Token: 0x040003FF RID: 1023
		private static string t_editedplayernames = "editedplayernames";

		// Token: 0x04000400 RID: 1024
		private static string t_factory_teams = "factory_teams";

		// Token: 0x04000401 RID: 1025
		private static string t_fieldpositionboundingboxes = "fieldpositionboundingboxes";

		// Token: 0x04000402 RID: 1026
		private static string t_fifaGameSettings = "fifaGameSettings";

		// Token: 0x04000403 RID: 1027
		private static string t_fixtures = "fixtures";

		// Token: 0x04000404 RID: 1028
		private static string t_formations = "formations";

		// Token: 0x04000405 RID: 1029
		private static string t_leaguerefereelinks = "leaguerefereelinks";

		// Token: 0x04000406 RID: 1030
		private static string t_leagues = "leagues";

		// Token: 0x04000407 RID: 1031
		private static string t_leagueteamlinks = "leagueteamlinks";

		// Token: 0x04000408 RID: 1032
		private static string t_manager = "manager";

		// Token: 0x04000409 RID: 1033
		private static string t_mls_fixtures = "mls_fixtures";

		// Token: 0x0400040A RID: 1034
		private static string t_nations = "nations";

		// Token: 0x0400040B RID: 1035
		private static string t_persistent_events = "persistent_events";

		// Token: 0x0400040C RID: 1036
		private static string t_physio = "physio";

		// Token: 0x0400040D RID: 1037
		private static string t_player_grudgelove = "player_grudgelove";

		// Token: 0x0400040E RID: 1038
		private static string t_player_stats = "player_stats";

		// Token: 0x0400040F RID: 1039
		private static string t_playerboots = "playerboots";

		// Token: 0x04000410 RID: 1040
		private static string t_playerformdiff = "playerformdiff";

		// Token: 0x04000411 RID: 1041
		private static string t_playerloans = "playerloans";

		// Token: 0x04000412 RID: 1042
		private static string t_playernames = "playernames";

		// Token: 0x04000413 RID: 1043
		private static string t_players = "players";

		// Token: 0x04000414 RID: 1044
		private static string t_previousteam = "previousteam";

		// Token: 0x04000415 RID: 1045
		private static string t_referee = "referee";

		// Token: 0x04000416 RID: 1046
		private static string t_restrictedplayers = "restrictedplayers";

		// Token: 0x04000417 RID: 1047
		private static string t_rivals = "rivals";

		// Token: 0x04000418 RID: 1048
		private static string t_rowteamnationlinks = "rowteamnationlinks";

		// Token: 0x04000419 RID: 1049
		private static string t_shoecolors = "shoecolors";

		// Token: 0x0400041A RID: 1050
		private static string t_songplaylistlinks = "songplaylistlinks";

		// Token: 0x0400041B RID: 1051
		private static string t_stadiumassignments = "stadiumassignments";

		// Token: 0x0400041C RID: 1052
		private static string t_stadiums = "stadiums";

		// Token: 0x0400041D RID: 1053
		private static string t_starratingboundaries = "starratingboundaries";

		// Token: 0x0400041E RID: 1054
		private static string t_stories = "stories";

		// Token: 0x0400041F RID: 1055
		private static string t_team_lookup = "team_lookup";

		// Token: 0x04000420 RID: 1056
		private static string t_teamballs = "teamballs";

		// Token: 0x04000421 RID: 1057
		private static string t_teamformationteamstylelinks = "teamformationteamstylelinks";

		// Token: 0x04000422 RID: 1058
		private static string t_teamformdiff = "teamformdiff";

		// Token: 0x04000423 RID: 1059
		private static string t_teamkits = "teamkits";

		// Token: 0x04000424 RID: 1060
		private static string t_teamplayerlinks = "teamplayerlinks";

		// Token: 0x04000425 RID: 1061
		private static string t_teams = "teams";

		// Token: 0x04000426 RID: 1062
		private static string t_teamstadiumlinks = "teamstadiumlinks";

		// Token: 0x04000427 RID: 1063
		private static string t_teamstadiumlinkscache = "teamstadiumlinkscache";

		// Token: 0x04000428 RID: 1064
		private static string t_temp_arenacreateplayer = "temp_arenacreateplayer";

		// Token: 0x04000429 RID: 1065
		private static string t_temp_arenaplayer = "temp_arenaplayer";

		// Token: 0x0400042A RID: 1066
		private static string t_temp_arenaplayername = "temp_arenaplayername";

		// Token: 0x0400042B RID: 1067
		private static string t_temp_arenateam = "temp_arenateam";

		// Token: 0x0400042C RID: 1068
		private static string t_temp_arenateamplayerlinks = "temp_arenateamplayerlinks";

		// Token: 0x0400042D RID: 1069
		private static string t_temp_createplayer = "temp_createplayer";

		// Token: 0x0400042E RID: 1070
		private static string t_temp_formations = "temp_formations";

		// Token: 0x0400042F RID: 1071
		private static string t_temp_players = "temp_players";

		// Token: 0x04000430 RID: 1072
		private static string t_temp_teamplayerlinks = "temp_teamplayerlinks";

		// Token: 0x04000431 RID: 1073
		private static string t_temp_teams = "temp_teams";

		// Token: 0x04000432 RID: 1074
		private static string t_trainingteamplayerlinks = "trainingteamplayerlinks";

		// Token: 0x04000433 RID: 1075
		private static string t_trainingteamplayernames = "trainingteamplayernames";

		// Token: 0x04000434 RID: 1076
		private static string t_trainingteamplayers = "trainingteamplayers";

		// Token: 0x04000435 RID: 1077
		private static string t_transactionhistory = "transactionhistory";

		// Token: 0x04000436 RID: 1078
		private static string t_version = "version";

		// Token: 0x04000437 RID: 1079
		private static string t_videos = "videos";

		// Token: 0x04000438 RID: 1080
		public static int lang = 0;

		// Token: 0x04000439 RID: 1081
		public static int balls;

		// Token: 0x0400043A RID: 1082
		public static int career_extraplayerinfo;

		// Token: 0x0400043B RID: 1083
		public static int career_matchexperience;

		// Token: 0x0400043C RID: 1084
		public static int career_suspensions;

		// Token: 0x0400043D RID: 1085
		public static int formupdate;

		// Token: 0x0400043E RID: 1086
		public static int career_fixtureinfo;

		// Token: 0x0400043F RID: 1087
		public static int fce_activeteams;

		// Token: 0x04000440 RID: 1088
		public static int fce_weathersettings;

		// Token: 0x04000441 RID: 1089
		public static int fce_statistics;

		// Token: 0x04000442 RID: 1090
		public static int fce_standings;

		// Token: 0x04000443 RID: 1091
		public static int fce_stageadvance;

		// Token: 0x04000444 RID: 1092
		public static int fce_settings;

		// Token: 0x04000445 RID: 1093
		public static int fce_scriptfunctions;

		// Token: 0x04000446 RID: 1094
		public static int fce_scheduleinfo;

		// Token: 0x04000447 RID: 1095
		public static int fce_fixtures;

		// Token: 0x04000448 RID: 1096
		public static int fce_competitionteams;

		// Token: 0x04000449 RID: 1097
		public static int fce_competitioninfo;

		// Token: 0x0400044A RID: 1098
		public static int fce_compavgs;

		// Token: 0x0400044B RID: 1099
		public static int fce_advancement;

		// Token: 0x0400044C RID: 1100
		public static int player_growth_experience_points;

		// Token: 0x0400044D RID: 1101
		public static int player_career;

		// Token: 0x0400044E RID: 1102
		public static int experiencepoints;

		// Token: 0x0400044F RID: 1103
		public static int finalstadiums;

		// Token: 0x04000450 RID: 1104
		public static int tourn_team_manager;

		// Token: 0x04000451 RID: 1105
		public static int tourn_settings;

		// Token: 0x04000452 RID: 1106
		public static int tourn_rtsg;

		// Token: 0x04000453 RID: 1107
		public static int tourn_manager_settings;

		// Token: 0x04000454 RID: 1108
		public static int tourn_licensed_stages;

		// Token: 0x04000455 RID: 1109
		public static int tourn_licensed;

		// Token: 0x04000456 RID: 1110
		public static int specialteams;

		// Token: 0x04000457 RID: 1111
		public static int achievements;

		// Token: 0x04000458 RID: 1112
		public static int fifaUnlockables;

		// Token: 0x04000459 RID: 1113
		public static int usability;

		// Token: 0x0400045A RID: 1114
		public static int usability_functions;

		// Token: 0x0400045B RID: 1115
		public static int virtualleagues;

		// Token: 0x0400045C RID: 1116
		public static int BigAttendance;

		// Token: 0x0400045D RID: 1117
		public static int MatchIntensity;

		// Token: 0x0400045E RID: 1118
		public static int NoAttendance;

		// Token: 0x0400045F RID: 1119
		public static int assetcryptokeys;

		// Token: 0x04000460 RID: 1120
		public static int attributeprefpositionformula;

		// Token: 0x04000461 RID: 1121
		public static int audionation;

		// Token: 0x04000462 RID: 1122
		public static int audiostadium;

		// Token: 0x04000463 RID: 1123
		public static int career_blacklist;

		// Token: 0x04000464 RID: 1124
		public static int career_boardoutcomes;

		// Token: 0x04000465 RID: 1125
		public static int career_calendar;

		// Token: 0x04000466 RID: 1126
		public static int career_clinchedobjectives;

		// Token: 0x04000467 RID: 1127
		public static int career_commonnames;

		// Token: 0x04000468 RID: 1128
		public static int career_competitionprogress;

		// Token: 0x04000469 RID: 1129
		public static int career_firstnames;

		// Token: 0x0400046A RID: 1130
		public static int career_growthcurveinfo;

		// Token: 0x0400046B RID: 1131
		public static int career_lastnames;

		// Token: 0x0400046C RID: 1132
		public static int career_leagueballs;

		// Token: 0x0400046D RID: 1133
		public static int career_loanbuy;

		// Token: 0x0400046E RID: 1134
		public static int career_managerawards;

		// Token: 0x0400046F RID: 1135
		public static int career_managerhistory;

		// Token: 0x04000470 RID: 1136
		public static int career_managerinfo;

		// Token: 0x04000471 RID: 1137
		public static int career_managerpref;

		// Token: 0x04000472 RID: 1138
		public static int career_namesgroups;

		// Token: 0x04000473 RID: 1139
		public static int career_news;

		// Token: 0x04000474 RID: 1140
		public static int career_newsban;

		// Token: 0x04000475 RID: 1141
		public static int career_newspicweights;

		// Token: 0x04000476 RID: 1142
		public static int career_playasplayer;

		// Token: 0x04000477 RID: 1143
		public static int career_playasplayerhistory;

		// Token: 0x04000478 RID: 1144
		public static int career_playerawards;

		// Token: 0x04000479 RID: 1145
		public static int career_playerbonusper;

		// Token: 0x0400047A RID: 1146
		public static int career_playercontract;

		// Token: 0x0400047B RID: 1147
		public static int career_playergrowthhistory;

		// Token: 0x0400047C RID: 1148
		public static int career_playergrowthupdates;

		// Token: 0x0400047D RID: 1149
		public static int career_playergrowthuserseason;

		// Token: 0x0400047E RID: 1150
		public static int career_playermatchratinghistory;

		// Token: 0x0400047F RID: 1151
		public static int career_precontract;

		// Token: 0x04000480 RID: 1152
		public static int career_regenplayerattributes;

		// Token: 0x04000481 RID: 1153
		public static int career_scoutmission;

		// Token: 0x04000482 RID: 1154
		public static int career_scouts;

		// Token: 0x04000483 RID: 1155
		public static int career_squadranking;

		// Token: 0x04000484 RID: 1156
		public static int career_teamofweek;

		// Token: 0x04000485 RID: 1157
		public static int career_transferlist;

		// Token: 0x04000486 RID: 1158
		public static int career_transferoffer;

		// Token: 0x04000487 RID: 1159
		public static int career_trophies;

		// Token: 0x04000488 RID: 1160
		public static int career_users;

		// Token: 0x04000489 RID: 1161
		public static int career_youthplayerattributes;

		// Token: 0x0400048A RID: 1162
		public static int career_youthplayerhistory;

		// Token: 0x0400048B RID: 1163
		public static int career_youthplayers;

		// Token: 0x0400048C RID: 1164
		public static int celebrations;

		// Token: 0x0400048D RID: 1165
		public static int clubcommentarynames;

		// Token: 0x0400048E RID: 1166
		public static int cmeventhistory;

		// Token: 0x0400048F RID: 1167
		public static int cmteameventhistory;

		// Token: 0x04000490 RID: 1168
		public static int commentarynames;

		// Token: 0x04000491 RID: 1169
		public static int competition;

		// Token: 0x04000492 RID: 1170
		public static int createplayer;

		// Token: 0x04000493 RID: 1171
		public static int createplayerpositiontemplates;

		// Token: 0x04000494 RID: 1172
		public static int createplayerviews;

		// Token: 0x04000495 RID: 1173
		public static int customformations;

		// Token: 0x04000496 RID: 1174
		public static int customteamstyles;

		// Token: 0x04000497 RID: 1175
		public static int cz_assets;

		// Token: 0x04000498 RID: 1176
		public static int cz_leagues;

		// Token: 0x04000499 RID: 1177
		public static int cz_players;

		// Token: 0x0400049A RID: 1178
		public static int cz_teamkits;

		// Token: 0x0400049B RID: 1179
		public static int cz_teams;

		// Token: 0x0400049C RID: 1180
		public static int dcplayernames;

		// Token: 0x0400049D RID: 1181
		public static int dlcballs;

		// Token: 0x0400049E RID: 1182
		public static int dlcboots;

		// Token: 0x0400049F RID: 1183
		public static int dna;

		// Token: 0x040004A0 RID: 1184
		public static int eatrax;

		// Token: 0x040004A1 RID: 1185
		public static int editedplayernames;

		// Token: 0x040004A2 RID: 1186
		public static int factory_teams;

		// Token: 0x040004A3 RID: 1187
		public static int fieldpositionboundingboxes;

		// Token: 0x040004A4 RID: 1188
		public static int fifaGameSettings;

		// Token: 0x040004A5 RID: 1189
		public static int fixtures;

		// Token: 0x040004A6 RID: 1190
		public static int formations;

		// Token: 0x040004A7 RID: 1191
		public static int leaguerefereelinks;

		// Token: 0x040004A8 RID: 1192
		public static int leagues;

		// Token: 0x040004A9 RID: 1193
		public static int leagueteamlinks;

		// Token: 0x040004AA RID: 1194
		public static int manager;

		// Token: 0x040004AB RID: 1195
		public static int mls_fixtures;

		// Token: 0x040004AC RID: 1196
		public static int nations;

		// Token: 0x040004AD RID: 1197
		public static int persistent_events;

		// Token: 0x040004AE RID: 1198
		public static int physio;

		// Token: 0x040004AF RID: 1199
		public static int player_grudgelove;

		// Token: 0x040004B0 RID: 1200
		public static int player_stats;

		// Token: 0x040004B1 RID: 1201
		public static int playerboots;

		// Token: 0x040004B2 RID: 1202
		public static int playerformdiff;

		// Token: 0x040004B3 RID: 1203
		public static int playerloans;

		// Token: 0x040004B4 RID: 1204
		public static int playernames;

		// Token: 0x040004B5 RID: 1205
		public static int players;

		// Token: 0x040004B6 RID: 1206
		public static int previousteam;

		// Token: 0x040004B7 RID: 1207
		public static int referee;

		// Token: 0x040004B8 RID: 1208
		public static int restrictedplayers;

		// Token: 0x040004B9 RID: 1209
		public static int rivals;

		// Token: 0x040004BA RID: 1210
		public static int rowteamnationlinks;

		// Token: 0x040004BB RID: 1211
		public static int shoecolors;

		// Token: 0x040004BC RID: 1212
		public static int songplaylistlinks;

		// Token: 0x040004BD RID: 1213
		public static int stadiumassignments;

		// Token: 0x040004BE RID: 1214
		public static int stadiums;

		// Token: 0x040004BF RID: 1215
		public static int starratingboundaries;

		// Token: 0x040004C0 RID: 1216
		public static int stories;

		// Token: 0x040004C1 RID: 1217
		public static int team_lookup;

		// Token: 0x040004C2 RID: 1218
		public static int teamballs;

		// Token: 0x040004C3 RID: 1219
		public static int teamformationteamstylelinks;

		// Token: 0x040004C4 RID: 1220
		public static int teamformdiff;

		// Token: 0x040004C5 RID: 1221
		public static int teamkits;

		// Token: 0x040004C6 RID: 1222
		public static int teamplayerlinks;

		// Token: 0x040004C7 RID: 1223
		public static int teams;

		// Token: 0x040004C8 RID: 1224
		public static int teamstadiumlinks;

		// Token: 0x040004C9 RID: 1225
		public static int teamstadiumlinkscache;

		// Token: 0x040004CA RID: 1226
		public static int temp_arenacreateplayer;

		// Token: 0x040004CB RID: 1227
		public static int temp_arenaplayer;

		// Token: 0x040004CC RID: 1228
		public static int temp_arenaplayername;

		// Token: 0x040004CD RID: 1229
		public static int temp_arenateam;

		// Token: 0x040004CE RID: 1230
		public static int temp_arenateamplayerlinks;

		// Token: 0x040004CF RID: 1231
		public static int temp_createplayer;

		// Token: 0x040004D0 RID: 1232
		public static int temp_formations;

		// Token: 0x040004D1 RID: 1233
		public static int temp_players;

		// Token: 0x040004D2 RID: 1234
		public static int temp_teamplayerlinks;

		// Token: 0x040004D3 RID: 1235
		public static int temp_teams;

		// Token: 0x040004D4 RID: 1236
		public static int trainingteamplayerlinks;

		// Token: 0x040004D5 RID: 1237
		public static int trainingteamplayernames;

		// Token: 0x040004D6 RID: 1238
		public static int trainingteamplayers;

		// Token: 0x040004D7 RID: 1239
		public static int transactionhistory;

		// Token: 0x040004D8 RID: 1240
		public static int version;

		// Token: 0x040004D9 RID: 1241
		public static int videos;
	}
}
