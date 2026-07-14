using System;

namespace FifaLibrary
{
	// Token: 0x02000067 RID: 103
	public class FI
	{
		// Token: 0x060008CD RID: 2253 RVA: 0x00035FC9 File Offset: 0x000341C9
		public static void InitFIAsFIFA12()
		{
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00035FCC File Offset: 0x000341CC
		public static void InitFIAsFIFA13()
		{
			FI.language_hashid = 0;
			FI.language_stringid = 1;
			FI.language_sourcetext = 0;
			FI.fixtures_fixturedate = 8;
			FI.fixtures_fixtureid = 13;
			FI.fixtures_textid_gameotw = 2;
			FI.fixtures_hometeamid = 0;
			FI.fixtures_hometeamskill = 1;
			FI.fixtures_legno = 3;
			FI.fixtures_awayteamskill = 4;
			FI.fixtures_stageofcompetition = 5;
			FI.fixtures_competitionid = 6;
			FI.fixtures_stadiumid = 7;
			FI.fixtures_currawayprevscore = 9;
			FI.fixtures_drawmode = 10;
			FI.fixtures_competitiontype = 11;
			FI.fixtures_matchimportance = 12;
			FI.fixtures_multipleleg = 14;
			FI.fixtures_livegametype = 15;
			FI.fixtures_currhomeprevscore = 16;
			FI.fixtures_fixturetime = 17;
			FI.fixtures_awayteamid = 18;
			FI.player_stats_rt = 23;
			FI.player_stats_frmcode = 27;
			FI.player_stats_goals = 0;
			FI.player_stats_goals_cup = 10;
			FI.player_stats_goals_conceded = 19;
			FI.player_stats_injury_duration = 21;
			FI.player_stats_momentum_value = 1;
			FI.player_stats_saves = 2;
			FI.player_stats_red_cards_international = 3;
			FI.player_stats_gk_shots_on_target = 4;
			FI.player_stats_appearances_cup = 5;
			FI.player_stats_frm = 6;
			FI.player_stats_total_reds = 7;
			FI.player_stats_games_played_at_position = 8;
			FI.player_stats_match_rating = 9;
			FI.player_stats_injury_end_date = 11;
			FI.player_stats_red_cards = 12;
			FI.player_stats_appearances = 13;
			FI.player_stats_suspended = 14;
			FI.player_stats_shots_on_goal = 15;
			FI.player_stats_suspended_international = 16;
			FI.player_stats_assists = 17;
			FI.player_stats_man_of_the_match = 18;
			FI.player_stats_teamid = 20;
			FI.player_stats_rating = 22;
			FI.player_stats_yellow_cards = 24;
			FI.player_stats_total_yellows = 25;
			FI.player_stats_transfer_done = 26;
			FI.player_stats_playerid = 28;
			FI.player_stats_injury_type = 29;
			FI.player_stats_clean_sheets = 30;
			FI.player_stats_morale = 31;
			FI.player_stats_yellow_cards_international = 32;
			FI.player_stats_fatigue = 33;
			FI.team_lookup_move_from_tsgt = 3;
			FI.team_lookup_rtsgt = 10;
			FI.team_lookup_final_ranking = 17;
			FI.team_lookup_away_num_wins = 0;
			FI.team_lookup_num_goals_for = 1;
			FI.team_lookup_away_num_losses = 2;
			FI.team_lookup_num_draws = 4;
			FI.team_lookup_num_wins = 5;
			FI.team_lookup_goals_for_home = 6;
			FI.team_lookup_goals_for_away = 7;
			FI.team_lookup_goals_against_home = 8;
			FI.team_lookup_goals_against_away = 9;
			FI.team_lookup_num_yellow_cards = 11;
			FI.team_lookup_num_losses = 12;
			FI.team_lookup_teamid = 13;
			FI.team_lookup_outcome = 14;
			FI.team_lookup_away_num_draws = 15;
			FI.team_lookup_points = 16;
			FI.team_lookup_played = 18;
			FI.team_lookup_num_goals_against = 19;
			FI.team_lookup_num_clean_sheets = 20;
			FI.team_lookup_num_red_cards = 21;
			FI.team_lookup_goal_diff = 22;
			FI.assetcryptokeys_key = 0;
			FI.assetcryptokeys_keyid = 1;
			FI.assetcryptokeys_artificialkey = 0;
			FI.version_exportdate = 1;
			FI.version_schema = 0;
			FI.version_isonline = 0;
			FI.version_minor = 2;
			FI.version_artificialkey = 3;
			FI.version_major = 4;
			FI.transactionhistory_movedto = 0;
			FI.transactionhistory_teamid = 1;
			FI.transactionhistory_playerid = 2;
			FI.trainingteamplayers_birthdate = 41;
			FI.trainingteamplayers_playerjointeamdate = 71;
			FI.trainingteamplayers_shoetypecode = 40;
			FI.trainingteamplayers_haircolorcode = 0;
			FI.trainingteamplayers_facialhairtypecode = 1;
			FI.trainingteamplayers_curve = 2;
			FI.trainingteamplayers_jerseystylecode = 3;
			FI.trainingteamplayers_agility = 4;
			FI.trainingteamplayers_accessorycode4 = 5;
			FI.trainingteamplayers_gksavetype = 6;
			FI.trainingteamplayers_positioning = 7;
			FI.trainingteamplayers_hairtypecode = 8;
			FI.trainingteamplayers_standingtackle = 9;
			FI.trainingteamplayers_faceposercode = 10;
			FI.trainingteamplayers_preferredposition3 = 11;
			FI.trainingteamplayers_longpassing = 12;
			FI.trainingteamplayers_penalties = 13;
			FI.trainingteamplayers_animfreekickstartposcode = 14;
			FI.trainingteamplayers_animpenaltieskickstylecode = 15;
			FI.trainingteamplayers_isretiring = 16;
			FI.trainingteamplayers_longshots = 17;
			FI.trainingteamplayers_gkdiving = 18;
			FI.trainingteamplayers_interceptions = 19;
			FI.trainingteamplayers_shoecolorcode2 = 20;
			FI.trainingteamplayers_crossing = 21;
			FI.trainingteamplayers_potential = 22;
			FI.trainingteamplayers_gkreflexes = 23;
			FI.trainingteamplayers_finishingcode1 = 24;
			FI.trainingteamplayers_reactions = 25;
			FI.trainingteamplayers_vision = 26;
			FI.trainingteamplayers_contractvaliduntil = 27;
			FI.trainingteamplayers_finishing = 28;
			FI.trainingteamplayers_dribbling = 29;
			FI.trainingteamplayers_slidingtackle = 30;
			FI.trainingteamplayers_accessorycode3 = 31;
			FI.trainingteamplayers_accessorycolourcode1 = 32;
			FI.trainingteamplayers_headtypecode = 33;
			FI.trainingteamplayers_firstnameid = 34;
			FI.trainingteamplayers_sprintspeed = 35;
			FI.trainingteamplayers_height = 36;
			FI.trainingteamplayers_hasseasonaljersey = 37;
			FI.trainingteamplayers_preferredposition2 = 38;
			FI.trainingteamplayers_strength = 39;
			FI.trainingteamplayers_preferredposition1 = 42;
			FI.trainingteamplayers_ballcontrol = 43;
			FI.trainingteamplayers_shotpower = 44;
			FI.trainingteamplayers_trait1 = 45;
			FI.trainingteamplayers_socklengthcode = 46;
			FI.trainingteamplayers_weight = 47;
			FI.trainingteamplayers_hashighqualityhead = 48;
			FI.trainingteamplayers_gkglovetypecode = 49;
			FI.trainingteamplayers_balance = 50;
			FI.trainingteamplayers_gkkicking = 51;
			FI.trainingteamplayers_lastnameid = 52;
			FI.trainingteamplayers_internationalrep = 53;
			FI.trainingteamplayers_animpenaltiesmotionstylecode = 54;
			FI.trainingteamplayers_shortpassing = 55;
			FI.trainingteamplayers_freekickaccuracy = 56;
			FI.trainingteamplayers_skillmoves = 57;
			FI.trainingteamplayers_usercaneditname = 58;
			FI.trainingteamplayers_attackingworkrate = 59;
			FI.trainingteamplayers_finishingcode2 = 60;
			FI.trainingteamplayers_aggression = 61;
			FI.trainingteamplayers_acceleration = 62;
			FI.trainingteamplayers_headingaccuracy = 63;
			FI.trainingteamplayers_eyebrowcode = 64;
			FI.trainingteamplayers_runningcode2 = 65;
			FI.trainingteamplayers_gkhandling = 66;
			FI.trainingteamplayers_eyecolorcode = 67;
			FI.trainingteamplayers_jerseysleevelengthcode = 68;
			FI.trainingteamplayers_accessorycolourcode3 = 69;
			FI.trainingteamplayers_accessorycode1 = 70;
			FI.trainingteamplayers_headclasscode = 72;
			FI.trainingteamplayers_defensiveworkrate = 73;
			FI.trainingteamplayers_nationality = 74;
			FI.trainingteamplayers_preferredfoot = 75;
			FI.trainingteamplayers_sideburnscode = 76;
			FI.trainingteamplayers_weakfootabilitytypecode = 77;
			FI.trainingteamplayers_jumping = 78;
			FI.trainingteamplayers_skintypecode = 79;
			FI.trainingteamplayers_gkkickstyle = 80;
			FI.trainingteamplayers_stamina = 81;
			FI.trainingteamplayers_playerid = 82;
			FI.trainingteamplayers_marking = 83;
			FI.trainingteamplayers_accessorycolourcode4 = 84;
			FI.trainingteamplayers_gkpositioning = 85;
			FI.trainingteamplayers_trait2 = 86;
			FI.trainingteamplayers_skintonecode = 87;
			FI.trainingteamplayers_shortstyle = 88;
			FI.trainingteamplayers_overallrating = 89;
			FI.trainingteamplayers_jerseyfit = 90;
			FI.trainingteamplayers_accessorycode2 = 91;
			FI.trainingteamplayers_shoedesigncode = 92;
			FI.trainingteamplayers_playerjerseynameid = 93;
			FI.trainingteamplayers_shoecolorcode1 = 94;
			FI.trainingteamplayers_commonnameid = 95;
			FI.trainingteamplayers_bodytypecode = 96;
			FI.trainingteamplayers_animpenaltiesstartposcode = 97;
			FI.trainingteamplayers_runningcode1 = 98;
			FI.trainingteamplayers_preferredposition4 = 99;
			FI.trainingteamplayers_volleys = 100;
			FI.trainingteamplayers_accessorycolourcode2 = 101;
			FI.trainingteamplayers_facialhaircolorcode = 102;
			FI.trainingteamplayernames_name = 0;
			FI.trainingteamplayernames_commentaryid = 1;
			FI.trainingteamplayernames_nameid = 0;
			FI.trainingteamplayerlinks_jerseynumber = 0;
			FI.trainingteamplayerlinks_position = 1;
			FI.trainingteamplayerlinks_playerid = 2;
			FI.temp_teams_assetid = 14;
			FI.temp_teams_balltype = 1;
			FI.temp_teams_teamcolor1g = 3;
			FI.temp_teams_teamcolor1r = 6;
			FI.temp_teams_teamcolor2b = 9;
			FI.temp_teams_teamcolor2r = 17;
			FI.temp_teams_teamcolor3r = 27;
			FI.temp_teams_teamcolor1b = 29;
			FI.temp_teams_latitude = 32;
			FI.temp_teams_teamcolor3g = 36;
			FI.temp_teams_teamcolor2g = 48;
			FI.temp_teams_teamname = 0;
			FI.temp_teams_adboardid = 56;
			FI.temp_teams_teamcolor3b = 59;
			FI.temp_teams_defmentality = 0;
			FI.temp_teams_powid = 2;
			FI.temp_teams_physioid_secondary = 4;
			FI.temp_teams_domesticprestige = 5;
			FI.temp_teams_genericint2 = 7;
			FI.temp_teams_jerseytype = 8;
			FI.temp_teams_rivalteam = 10;
			FI.temp_teams_midfieldrating = 11;
			FI.temp_teams_matchdayoverallrating = 12;
			FI.temp_teams_matchdaymidfieldrating = 13;
			FI.temp_teams_attackrating = 15;
			FI.temp_teams_physioid_primary = 16;
			FI.temp_teams_longitude = 18;
			FI.temp_teams_buspassing = 19;
			FI.temp_teams_matchdaydefenserating = 20;
			FI.temp_teams_defenserating = 21;
			FI.temp_teams_defteamwidth = 22;
			FI.temp_teams_longkicktakerid = 23;
			FI.temp_teams_bodytypeid = 24;
			FI.temp_teams_rightcornerkicktakerid = 25;
			FI.temp_teams_suitvariationid = 26;
			FI.temp_teams_defaggression = 28;
			FI.temp_teams_ethnicity = 30;
			FI.temp_teams_leftcornerkicktakerid = 31;
			FI.temp_teams_teamid = 33;
			FI.temp_teams_fancrowdhairskintexturecode = 34;
			FI.temp_teams_suittypeid = 35;
			FI.temp_teams_numtransfersin = 37;
			FI.temp_teams_captainid = 38;
			FI.temp_teams_personalityid = 39;
			FI.temp_teams_genericbanner = 40;
			FI.temp_teams_buspositioning = 41;
			FI.temp_teams_stafftracksuitcolorcode = 42;
			FI.temp_teams_ccpositioning = 43;
			FI.temp_teams_busbuildupspeed = 44;
			FI.temp_teams_transferbudget = 45;
			FI.temp_teams_ccshooting = 46;
			FI.temp_teams_overallrating = 47;
			FI.temp_teams_ccpassing = 49;
			FI.temp_teams_utcoffset = 50;
			FI.temp_teams_penaltytakerid = 51;
			FI.temp_teams_freekicktakerid = 52;
			FI.temp_teams_defdefenderline = 53;
			FI.temp_teams_internationalprestige = 54;
			FI.temp_teams_form = 55;
			FI.temp_teams_genericint1 = 57;
			FI.temp_teams_cccrossing = 58;
			FI.temp_teams_matchdayattackrating = 60;
			FI.temp_teamplayerlinks_leaguegoals = 3;
			FI.temp_teamplayerlinks_isamongtopscorers = 0;
			FI.temp_teamplayerlinks_yellows = 1;
			FI.temp_teamplayerlinks_isamongtopscorersinteam = 2;
			FI.temp_teamplayerlinks_jerseynumber = 4;
			FI.temp_teamplayerlinks_position = 5;
			FI.temp_teamplayerlinks_artificialkey = 6;
			FI.temp_teamplayerlinks_teamid = 7;
			FI.temp_teamplayerlinks_injury = 8;
			FI.temp_teamplayerlinks_leagueappearances = 9;
			FI.temp_teamplayerlinks_prevform = 10;
			FI.temp_teamplayerlinks_istopscorer = 11;
			FI.temp_teamplayerlinks_playerid = 12;
			FI.temp_teamplayerlinks_form = 13;
			FI.temp_teamplayerlinks_reds = 14;
			FI.temp_players_birthdate = 41;
			FI.temp_players_playerjointeamdate = 71;
			FI.temp_players_shoetypecode = 40;
			FI.temp_players_haircolorcode = 0;
			FI.temp_players_facialhairtypecode = 1;
			FI.temp_players_curve = 2;
			FI.temp_players_jerseystylecode = 3;
			FI.temp_players_agility = 4;
			FI.temp_players_accessorycode4 = 5;
			FI.temp_players_gksavetype = 6;
			FI.temp_players_positioning = 7;
			FI.temp_players_hairtypecode = 8;
			FI.temp_players_standingtackle = 9;
			FI.temp_players_faceposercode = 10;
			FI.temp_players_preferredposition3 = 11;
			FI.temp_players_longpassing = 12;
			FI.temp_players_penalties = 13;
			FI.temp_players_animfreekickstartposcode = 14;
			FI.temp_players_animpenaltieskickstylecode = 15;
			FI.temp_players_isretiring = 16;
			FI.temp_players_longshots = 17;
			FI.temp_players_gkdiving = 18;
			FI.temp_players_interceptions = 19;
			FI.temp_players_shoecolorcode2 = 20;
			FI.temp_players_crossing = 21;
			FI.temp_players_potential = 22;
			FI.temp_players_gkreflexes = 23;
			FI.temp_players_finishingcode1 = 24;
			FI.temp_players_reactions = 25;
			FI.temp_players_vision = 26;
			FI.temp_players_contractvaliduntil = 27;
			FI.temp_players_finishing = 28;
			FI.temp_players_dribbling = 29;
			FI.temp_players_slidingtackle = 30;
			FI.temp_players_accessorycode3 = 31;
			FI.temp_players_accessorycolourcode1 = 32;
			FI.temp_players_headtypecode = 33;
			FI.temp_players_firstnameid = 34;
			FI.temp_players_sprintspeed = 35;
			FI.temp_players_height = 36;
			FI.temp_players_hasseasonaljersey = 37;
			FI.temp_players_preferredposition2 = 38;
			FI.temp_players_strength = 39;
			FI.temp_players_preferredposition1 = 42;
			FI.temp_players_ballcontrol = 43;
			FI.temp_players_shotpower = 44;
			FI.temp_players_trait1 = 45;
			FI.temp_players_socklengthcode = 46;
			FI.temp_players_weight = 47;
			FI.temp_players_hashighqualityhead = 48;
			FI.temp_players_gkglovetypecode = 49;
			FI.temp_players_balance = 50;
			FI.temp_players_gkkicking = 51;
			FI.temp_players_lastnameid = 52;
			FI.temp_players_internationalrep = 53;
			FI.temp_players_animpenaltiesmotionstylecode = 54;
			FI.temp_players_shortpassing = 55;
			FI.temp_players_freekickaccuracy = 56;
			FI.temp_players_skillmoves = 57;
			FI.temp_players_usercaneditname = 58;
			FI.temp_players_attackingworkrate = 59;
			FI.temp_players_finishingcode2 = 60;
			FI.temp_players_aggression = 61;
			FI.temp_players_acceleration = 62;
			FI.temp_players_headingaccuracy = 63;
			FI.temp_players_eyebrowcode = 64;
			FI.temp_players_runningcode2 = 65;
			FI.temp_players_gkhandling = 66;
			FI.temp_players_eyecolorcode = 67;
			FI.temp_players_jerseysleevelengthcode = 68;
			FI.temp_players_accessorycolourcode3 = 69;
			FI.temp_players_accessorycode1 = 70;
			FI.temp_players_headclasscode = 72;
			FI.temp_players_defensiveworkrate = 73;
			FI.temp_players_nationality = 74;
			FI.temp_players_preferredfoot = 75;
			FI.temp_players_sideburnscode = 76;
			FI.temp_players_weakfootabilitytypecode = 77;
			FI.temp_players_jumping = 78;
			FI.temp_players_skintypecode = 79;
			FI.temp_players_gkkickstyle = 80;
			FI.temp_players_stamina = 81;
			FI.temp_players_playerid = 82;
			FI.temp_players_marking = 83;
			FI.temp_players_accessorycolourcode4 = 84;
			FI.temp_players_gkpositioning = 85;
			FI.temp_players_trait2 = 86;
			FI.temp_players_skintonecode = 87;
			FI.temp_players_shortstyle = 88;
			FI.temp_players_overallrating = 89;
			FI.temp_players_jerseyfit = 90;
			FI.temp_players_accessorycode2 = 91;
			FI.temp_players_shoedesigncode = 92;
			FI.temp_players_playerjerseynameid = 93;
			FI.temp_players_shoecolorcode1 = 94;
			FI.temp_players_commonnameid = 95;
			FI.temp_players_bodytypecode = 96;
			FI.temp_players_animpenaltiesstartposcode = 97;
			FI.temp_players_runningcode1 = 98;
			FI.temp_players_preferredposition4 = 99;
			FI.temp_players_volleys = 100;
			FI.temp_players_accessorycolourcode2 = 101;
			FI.temp_players_facialhaircolorcode = 102;
			FI.temp_formations_offset6x = 0;
			FI.temp_formations_offset5y = 1;
			FI.temp_formations_offset10x = 2;
			FI.temp_formations_offset2x = 3;
			FI.temp_formations_defenders = 4;
			FI.temp_formations_offset2y = 5;
			FI.temp_formations_offset6y = 6;
			FI.temp_formations_offset7x = 7;
			FI.temp_formations_offset3x = 8;
			FI.temp_formations_offset8x = 9;
			FI.temp_formations_offset10y = 10;
			FI.temp_formations_offset3y = 11;
			FI.temp_formations_offset4x = 12;
			FI.temp_formations_offset7y = 13;
			FI.temp_formations_offset0x = 14;
			FI.temp_formations_offset8y = 15;
			FI.temp_formations_attackers = 16;
			FI.temp_formations_offset9x = 17;
			FI.temp_formations_midfielders = 18;
			FI.temp_formations_offset5x = 19;
			FI.temp_formations_offset0y = 20;
			FI.temp_formations_offset1x = 21;
			FI.temp_formations_offset4y = 22;
			FI.temp_formations_offset9y = 23;
			FI.temp_formations_offset1y = 24;
			FI.temp_formations_formationname = 0;
			FI.temp_formations_attackingdirection_0 = 0;
			FI.temp_formations_attackingrole_5 = 1;
			FI.temp_formations_position10 = 2;
			FI.temp_formations_attackingdirection_7 = 3;
			FI.temp_formations_defensivedirection_0 = 4;
			FI.temp_formations_defensivedirection_9 = 5;
			FI.temp_formations_defensivedirection_8 = 6;
			FI.temp_formations_attackingdirection_9 = 7;
			FI.temp_formations_position6 = 8;
			FI.temp_formations_attackingrole_4 = 9;
			FI.temp_formations_offensiverating = 10;
			FI.temp_formations_attackingrole_2 = 11;
			FI.temp_formations_attackingdirection_1 = 12;
			FI.temp_formations_position8 = 13;
			FI.temp_formations_defensiverole_4 = 14;
			FI.temp_formations_attackingdirection_10 = 15;
			FI.temp_formations_defensivedirection_6 = 16;
			FI.temp_formations_attackingdirection_8 = 17;
			FI.temp_formations_attackingrole_3 = 18;
			FI.temp_formations_defensiverole_3 = 19;
			FI.temp_formations_attackingrole_0 = 20;
			FI.temp_formations_defensivedirection_1 = 21;
			FI.temp_formations_attackingdirection_5 = 22;
			FI.temp_formations_defensivedirection_2 = 23;
			FI.temp_formations_attackingdirection_6 = 24;
			FI.temp_formations_position5 = 25;
			FI.temp_formations_attackingrole_7 = 26;
			FI.temp_formations_defensiverole_5 = 27;
			FI.temp_formations_defensivedirection_10 = 28;
			FI.temp_formations_defensivedirection_3 = 29;
			FI.temp_formations_defensivedirection_5 = 30;
			FI.temp_formations_issweeper = 31;
			FI.temp_formations_attackingdirection_2 = 32;
			FI.temp_formations_attackingdirection_4 = 33;
			FI.temp_formations_attackingrole_9 = 34;
			FI.temp_formations_defensiverole_2 = 35;
			FI.temp_formations_attackingdirection_3 = 36;
			FI.temp_formations_attackingrole_8 = 37;
			FI.temp_formations_attackingrole_1 = 38;
			FI.temp_formations_defensiverole_10 = 39;
			FI.temp_formations_defensiverole_1 = 40;
			FI.temp_formations_teamid = 41;
			FI.temp_formations_position2 = 42;
			FI.temp_formations_defensivedirection_4 = 43;
			FI.temp_formations_formationid = 44;
			FI.temp_formations_defensiverole_8 = 45;
			FI.temp_formations_attackingrole_6 = 46;
			FI.temp_formations_relativeformationid = 47;
			FI.temp_formations_defensiverole_0 = 48;
			FI.temp_formations_defensiverole_6 = 49;
			FI.temp_formations_position4 = 50;
			FI.temp_formations_attackingrole_10 = 51;
			FI.temp_formations_position3 = 52;
			FI.temp_formations_defensiverole_7 = 53;
			FI.temp_formations_formationfullnameid = 54;
			FI.temp_formations_defensiverole_9 = 55;
			FI.temp_formations_position0 = 56;
			FI.temp_formations_position9 = 57;
			FI.temp_formations_position7 = 58;
			FI.temp_formations_position1 = 59;
			FI.temp_formations_defensivedirection_7 = 60;
			FI.temp_arenateamplayerlinks_leaguegoals = 3;
			FI.temp_arenateamplayerlinks_isamongtopscorers = 0;
			FI.temp_arenateamplayerlinks_yellows = 1;
			FI.temp_arenateamplayerlinks_isamongtopscorersinteam = 2;
			FI.temp_arenateamplayerlinks_jerseynumber = 4;
			FI.temp_arenateamplayerlinks_position = 5;
			FI.temp_arenateamplayerlinks_artificialkey = 6;
			FI.temp_arenateamplayerlinks_teamid = 7;
			FI.temp_arenateamplayerlinks_injury = 8;
			FI.temp_arenateamplayerlinks_leagueappearances = 9;
			FI.temp_arenateamplayerlinks_prevform = 10;
			FI.temp_arenateamplayerlinks_istopscorer = 11;
			FI.temp_arenateamplayerlinks_playerid = 12;
			FI.temp_arenateamplayerlinks_form = 13;
			FI.temp_arenateamplayerlinks_reds = 14;
			FI.temp_arenateam_assetid = 14;
			FI.temp_arenateam_balltype = 1;
			FI.temp_arenateam_teamcolor1g = 3;
			FI.temp_arenateam_teamcolor1r = 6;
			FI.temp_arenateam_teamcolor2b = 9;
			FI.temp_arenateam_teamcolor2r = 17;
			FI.temp_arenateam_teamcolor3r = 27;
			FI.temp_arenateam_teamcolor1b = 29;
			FI.temp_arenateam_latitude = 32;
			FI.temp_arenateam_teamcolor3g = 36;
			FI.temp_arenateam_teamcolor2g = 48;
			FI.temp_arenateam_teamname = 0;
			FI.temp_arenateam_adboardid = 56;
			FI.temp_arenateam_teamcolor3b = 59;
			FI.temp_arenateam_defmentality = 0;
			FI.temp_arenateam_powid = 2;
			FI.temp_arenateam_physioid_secondary = 4;
			FI.temp_arenateam_domesticprestige = 5;
			FI.temp_arenateam_genericint2 = 7;
			FI.temp_arenateam_jerseytype = 8;
			FI.temp_arenateam_rivalteam = 10;
			FI.temp_arenateam_midfieldrating = 11;
			FI.temp_arenateam_matchdayoverallrating = 12;
			FI.temp_arenateam_matchdaymidfieldrating = 13;
			FI.temp_arenateam_attackrating = 15;
			FI.temp_arenateam_physioid_primary = 16;
			FI.temp_arenateam_longitude = 18;
			FI.temp_arenateam_buspassing = 19;
			FI.temp_arenateam_matchdaydefenserating = 20;
			FI.temp_arenateam_defenserating = 21;
			FI.temp_arenateam_defteamwidth = 22;
			FI.temp_arenateam_longkicktakerid = 23;
			FI.temp_arenateam_bodytypeid = 24;
			FI.temp_arenateam_rightcornerkicktakerid = 25;
			FI.temp_arenateam_suitvariationid = 26;
			FI.temp_arenateam_defaggression = 28;
			FI.temp_arenateam_ethnicity = 30;
			FI.temp_arenateam_leftcornerkicktakerid = 31;
			FI.temp_arenateam_teamid = 33;
			FI.temp_arenateam_fancrowdhairskintexturecode = 34;
			FI.temp_arenateam_suittypeid = 35;
			FI.temp_arenateam_numtransfersin = 37;
			FI.temp_arenateam_captainid = 38;
			FI.temp_arenateam_personalityid = 39;
			FI.temp_arenateam_genericbanner = 40;
			FI.temp_arenateam_buspositioning = 41;
			FI.temp_arenateam_stafftracksuitcolorcode = 42;
			FI.temp_arenateam_ccpositioning = 43;
			FI.temp_arenateam_busbuildupspeed = 44;
			FI.temp_arenateam_transferbudget = 45;
			FI.temp_arenateam_ccshooting = 46;
			FI.temp_arenateam_overallrating = 47;
			FI.temp_arenateam_ccpassing = 49;
			FI.temp_arenateam_utcoffset = 50;
			FI.temp_arenateam_penaltytakerid = 51;
			FI.temp_arenateam_freekicktakerid = 52;
			FI.temp_arenateam_defdefenderline = 53;
			FI.temp_arenateam_internationalprestige = 54;
			FI.temp_arenateam_form = 55;
			FI.temp_arenateam_genericint1 = 57;
			FI.temp_arenateam_cccrossing = 58;
			FI.temp_arenateam_matchdayattackrating = 60;
			FI.temp_arenaplayername_firstname = 0;
			FI.temp_arenaplayername_commonname = 1;
			FI.temp_arenaplayername_playerjerseyname = 2;
			FI.temp_arenaplayername_surname = 3;
			FI.temp_arenaplayername_playerid = 0;
			FI.temp_arenaplayer_birthdate = 41;
			FI.temp_arenaplayer_playerjointeamdate = 71;
			FI.temp_arenaplayer_shoetypecode = 40;
			FI.temp_arenaplayer_haircolorcode = 0;
			FI.temp_arenaplayer_facialhairtypecode = 1;
			FI.temp_arenaplayer_curve = 2;
			FI.temp_arenaplayer_jerseystylecode = 3;
			FI.temp_arenaplayer_agility = 4;
			FI.temp_arenaplayer_accessorycode4 = 5;
			FI.temp_arenaplayer_gksavetype = 6;
			FI.temp_arenaplayer_positioning = 7;
			FI.temp_arenaplayer_hairtypecode = 8;
			FI.temp_arenaplayer_standingtackle = 9;
			FI.temp_arenaplayer_faceposercode = 10;
			FI.temp_arenaplayer_preferredposition3 = 11;
			FI.temp_arenaplayer_longpassing = 12;
			FI.temp_arenaplayer_penalties = 13;
			FI.temp_arenaplayer_animfreekickstartposcode = 14;
			FI.temp_arenaplayer_animpenaltieskickstylecode = 15;
			FI.temp_arenaplayer_isretiring = 16;
			FI.temp_arenaplayer_longshots = 17;
			FI.temp_arenaplayer_gkdiving = 18;
			FI.temp_arenaplayer_interceptions = 19;
			FI.temp_arenaplayer_shoecolorcode2 = 20;
			FI.temp_arenaplayer_crossing = 21;
			FI.temp_arenaplayer_potential = 22;
			FI.temp_arenaplayer_gkreflexes = 23;
			FI.temp_arenaplayer_finishingcode1 = 24;
			FI.temp_arenaplayer_reactions = 25;
			FI.temp_arenaplayer_vision = 26;
			FI.temp_arenaplayer_contractvaliduntil = 27;
			FI.temp_arenaplayer_finishing = 28;
			FI.temp_arenaplayer_dribbling = 29;
			FI.temp_arenaplayer_slidingtackle = 30;
			FI.temp_arenaplayer_accessorycode3 = 31;
			FI.temp_arenaplayer_accessorycolourcode1 = 32;
			FI.temp_arenaplayer_headtypecode = 33;
			FI.temp_arenaplayer_firstnameid = 34;
			FI.temp_arenaplayer_sprintspeed = 35;
			FI.temp_arenaplayer_height = 36;
			FI.temp_arenaplayer_hasseasonaljersey = 37;
			FI.temp_arenaplayer_preferredposition2 = 38;
			FI.temp_arenaplayer_strength = 39;
			FI.temp_arenaplayer_preferredposition1 = 42;
			FI.temp_arenaplayer_ballcontrol = 43;
			FI.temp_arenaplayer_shotpower = 44;
			FI.temp_arenaplayer_trait1 = 45;
			FI.temp_arenaplayer_socklengthcode = 46;
			FI.temp_arenaplayer_weight = 47;
			FI.temp_arenaplayer_hashighqualityhead = 48;
			FI.temp_arenaplayer_gkglovetypecode = 49;
			FI.temp_arenaplayer_balance = 50;
			FI.temp_arenaplayer_gkkicking = 51;
			FI.temp_arenaplayer_lastnameid = 52;
			FI.temp_arenaplayer_internationalrep = 53;
			FI.temp_arenaplayer_animpenaltiesmotionstylecode = 54;
			FI.temp_arenaplayer_shortpassing = 55;
			FI.temp_arenaplayer_freekickaccuracy = 56;
			FI.temp_arenaplayer_skillmoves = 57;
			FI.temp_arenaplayer_usercaneditname = 58;
			FI.temp_arenaplayer_attackingworkrate = 59;
			FI.temp_arenaplayer_finishingcode2 = 60;
			FI.temp_arenaplayer_aggression = 61;
			FI.temp_arenaplayer_acceleration = 62;
			FI.temp_arenaplayer_headingaccuracy = 63;
			FI.temp_arenaplayer_eyebrowcode = 64;
			FI.temp_arenaplayer_runningcode2 = 65;
			FI.temp_arenaplayer_gkhandling = 66;
			FI.temp_arenaplayer_eyecolorcode = 67;
			FI.temp_arenaplayer_jerseysleevelengthcode = 68;
			FI.temp_arenaplayer_accessorycolourcode3 = 69;
			FI.temp_arenaplayer_accessorycode1 = 70;
			FI.temp_arenaplayer_headclasscode = 72;
			FI.temp_arenaplayer_defensiveworkrate = 73;
			FI.temp_arenaplayer_nationality = 74;
			FI.temp_arenaplayer_preferredfoot = 75;
			FI.temp_arenaplayer_sideburnscode = 76;
			FI.temp_arenaplayer_weakfootabilitytypecode = 77;
			FI.temp_arenaplayer_jumping = 78;
			FI.temp_arenaplayer_skintypecode = 79;
			FI.temp_arenaplayer_gkkickstyle = 80;
			FI.temp_arenaplayer_stamina = 81;
			FI.temp_arenaplayer_playerid = 82;
			FI.temp_arenaplayer_marking = 83;
			FI.temp_arenaplayer_accessorycolourcode4 = 84;
			FI.temp_arenaplayer_gkpositioning = 85;
			FI.temp_arenaplayer_trait2 = 86;
			FI.temp_arenaplayer_skintonecode = 87;
			FI.temp_arenaplayer_shortstyle = 88;
			FI.temp_arenaplayer_overallrating = 89;
			FI.temp_arenaplayer_jerseyfit = 90;
			FI.temp_arenaplayer_accessorycode2 = 91;
			FI.temp_arenaplayer_shoedesigncode = 92;
			FI.temp_arenaplayer_playerjerseynameid = 93;
			FI.temp_arenaplayer_shoecolorcode1 = 94;
			FI.temp_arenaplayer_commonnameid = 95;
			FI.temp_arenaplayer_bodytypecode = 96;
			FI.temp_arenaplayer_animpenaltiesstartposcode = 97;
			FI.temp_arenaplayer_runningcode1 = 98;
			FI.temp_arenaplayer_preferredposition4 = 99;
			FI.temp_arenaplayer_volleys = 100;
			FI.temp_arenaplayer_accessorycolourcode2 = 101;
			FI.temp_arenaplayer_facialhaircolorcode = 102;
			FI.teamstadiumlinks_stadiumid = 0;
			FI.teamstadiumlinks_teamid = 1;
			FI.teams_assetid = 14;
			FI.teams_balltype = 1;
			FI.teams_teamcolor1g = 3;
			FI.teams_teamcolor1r = 6;
			FI.teams_teamcolor2b = 9;
			FI.teams_teamcolor2r = 17;
			FI.teams_teamcolor3r = 27;
			FI.teams_teamcolor1b = 29;
			FI.teams_latitude = 32;
			FI.teams_teamcolor3g = 36;
			FI.teams_teamcolor2g = 48;
			FI.teams_teamname = 0;
			FI.teams_adboardid = 56;
			FI.teams_teamcolor3b = 59;
			FI.teams_defmentality = 0;
			FI.teams_powid = 2;
			FI.teams_physioid_secondary = 4;
			FI.teams_domesticprestige = 5;
			FI.teams_genericint2 = 7;
			FI.teams_jerseytype = 8;
			FI.teams_rivalteam = 10;
			FI.teams_midfieldrating = 11;
			FI.teams_matchdayoverallrating = 12;
			FI.teams_matchdaymidfieldrating = 13;
			FI.teams_attackrating = 15;
			FI.teams_physioid_primary = 16;
			FI.teams_longitude = 18;
			FI.teams_buspassing = 19;
			FI.teams_matchdaydefenserating = 20;
			FI.teams_defenserating = 21;
			FI.teams_defteamwidth = 22;
			FI.teams_longkicktakerid = 23;
			FI.teams_bodytypeid = 24;
			FI.teams_rightcornerkicktakerid = 25;
			FI.teams_suitvariationid = 26;
			FI.teams_defaggression = 28;
			FI.teams_ethnicity = 30;
			FI.teams_leftcornerkicktakerid = 31;
			FI.teams_teamid = 33;
			FI.teams_fancrowdhairskintexturecode = 34;
			FI.teams_suittypeid = 35;
			FI.teams_numtransfersin = 37;
			FI.teams_captainid = 38;
			FI.teams_personalityid = 39;
			FI.teams_genericbanner = 40;
			FI.teams_buspositioning = 41;
			FI.teams_stafftracksuitcolorcode = 42;
			FI.teams_ccpositioning = 43;
			FI.teams_busbuildupspeed = 44;
			FI.teams_transferbudget = 45;
			FI.teams_ccshooting = 46;
			FI.teams_overallrating = 47;
			FI.teams_ccpassing = 49;
			FI.teams_utcoffset = 50;
			FI.teams_penaltytakerid = 51;
			FI.teams_freekicktakerid = 52;
			FI.teams_defdefenderline = 53;
			FI.teams_internationalprestige = 54;
			FI.teams_form = 55;
			FI.teams_genericint1 = 57;
			FI.teams_cccrossing = 58;
			FI.teams_matchdayattackrating = 60;
			FI.teamplayerlinks_leaguegoals = 3;
			FI.teamplayerlinks_isamongtopscorers = 0;
			FI.teamplayerlinks_yellows = 1;
			FI.teamplayerlinks_isamongtopscorersinteam = 2;
			FI.teamplayerlinks_jerseynumber = 4;
			FI.teamplayerlinks_position = 5;
			FI.teamplayerlinks_artificialkey = 6;
			FI.teamplayerlinks_teamid = 7;
			FI.teamplayerlinks_injury = 8;
			FI.teamplayerlinks_leagueappearances = 9;
			FI.teamplayerlinks_prevform = 10;
			FI.teamplayerlinks_istopscorer = 11;
			FI.teamplayerlinks_playerid = 12;
			FI.teamplayerlinks_form = 13;
			FI.teamplayerlinks_reds = 14;
			FI.teamkits_shortsnumberplacementcode = 2;
			FI.teamkits_teamcolorsecb = 5;
			FI.teamkits_shortsrenderingdetailmaptype = 6;
			FI.teamkits_jerseyfrontnumberplacementcode = 7;
			FI.teamkits_teamcolorprimg = 9;
			FI.teamkits_numberfonttype = 10;
			FI.teamkits_teamcolortertb = 11;
			FI.teamkits_jerseynamefonttype = 12;
			FI.teamkits_jerseynamelayouttype = 13;
			FI.teamkits_shortsnumbercolor = 15;
			FI.teamkits_jerseyshapestyle = 16;
			FI.teamkits_jerseybacknameplacementcode = 17;
			FI.teamkits_teamcolorprimr = 18;
			FI.teamkits_jerseynamecolorg = 19;
			FI.teamkits_teamcolorsecg = 20;
			FI.teamkits_teamcolortertr = 22;
			FI.teamkits_renderingmaterialtype = 23;
			FI.teamkits_teamcolorsecr = 27;
			FI.teamkits_jerseycollargeometrytype = 28;
			FI.teamkits_jerseynamecolorr = 29;
			FI.teamkits_numbercolor = 30;
			FI.teamkits_teamcolorprimb = 31;
			FI.teamkits_jerseyrenderingdetailmaptype = 32;
			FI.teamkits_shortsnumberfonttype = 33;
			FI.teamkits_jerseynamecolorb = 34;
			FI.teamkits_teamcolortertg = 35;
			FI.teamkits_jerseybacknamefontcase = 0;
			FI.teamkits_teamkittypetechid = 1;
			FI.teamkits_powid = 3;
			FI.teamkits_isinheritbasedetailmap = 4;
			FI.teamkits_islocked = 8;
			FI.teamkits_teamkitid = 14;
			FI.teamkits_year = 21;
			FI.teamkits_teamtechid = 24;
			FI.teamkits_hasadvertisingkit = 25;
			FI.teamkits_dlc = 26;
			FI.teamformdiff_overallratingdiff = 2;
			FI.teamformdiff_olddefenserating = 0;
			FI.teamformdiff_newoverallrating = 1;
			FI.teamformdiff_oldoverallrating = 3;
			FI.teamformdiff_oldattackrating = 4;
			FI.teamformdiff_oldmidfieldrating = 5;
			FI.teamformdiff_newdefenserating = 6;
			FI.teamformdiff_teamid = 7;
			FI.teamformdiff_newattackrating = 8;
			FI.teamformdiff_newmidfieldrating = 9;
			FI.teamballs_ballid = 3;
			FI.teamballs_powid = 0;
			FI.teamballs_islicensed = 1;
			FI.teamballs_isavailableinstore = 2;
			FI.stories_target_fixture = 1;
			FI.stories_audioid = 0;
			FI.stories_entity_id = 2;
			FI.stories_chance = 3;
			FI.stories_priority = 4;
			FI.stories_entity_type = 5;
			FI.stories_storyid = 6;
			FI.starratingboundaries_stars = 0;
			FI.starratingboundaries_starratingfrom = 0;
			FI.starratingboundaries_starratingto = 1;
			FI.stadiums_yearbuilt = 9;
			FI.stadiums_name = 0;
			FI.stadiums_timeofday3 = 0;
			FI.stadiums_adboardsidelinedistance = 1;
			FI.stadiums_stadiumgloalnetdepth = 2;
			FI.stadiums_hometeamid = 3;
			FI.stadiums_managerhometoplefty = 4;
			FI.stadiums_capacity = 5;
			FI.stadiums_seatcolor = 6;
			FI.stadiums_managerawaytoplefty = 7;
			FI.stadiums_subsawaybotrightx = 8;
			FI.stadiums_sectionfacedbydefault = 10;
			FI.stadiums_subshomebotrightx = 11;
			FI.stadiums_policetypecode = 12;
			FI.stadiums_subsawaybotrighty = 13;
			FI.stadiums_timeofday4 = 14;
			FI.stadiums_subsawaytopleftx = 15;
			FI.stadiums_stadiumpitchlength = 16;
			FI.stadiums_stadiumgoalnetstyle = 17;
			FI.stadiums_subshomebotrighty = 18;
			FI.stadiums_upgradetier = 19;
			FI.stadiums_tod4weather = 20;
			FI.stadiums_countrycode = 21;
			FI.stadiums_stadiummowpattern_code = 22;
			FI.stadiums_subsawaytoplefty = 23;
			FI.stadiums_managerhomebotrightx = 24;
			FI.stadiums_stadiumid = 25;
			FI.stadiums_cameraheight = 26;
			FI.stadiums_managerawaytopleftx = 27;
			FI.stadiums_managerhomebotrighty = 28;
			FI.stadiums_stadiumgoalnettype = 29;
			FI.stadiums_stadiumpitchwidth = 30;
			FI.stadiums_stadiumtype = 31;
			FI.stadiums_managerhometopleftx = 32;
			FI.stadiums_stadiumgoalnettension = 33;
			FI.stadiums_tod1weather = 34;
			FI.stadiums_dlc = 35;
			FI.stadiums_tod2weather = 36;
			FI.stadiums_camerazoom = 37;
			FI.stadiums_adboardendlinedistance = 38;
			FI.stadiums_subshometoplefty = 39;
			FI.stadiums_iseditable = 40;
			FI.stadiums_isdynamic = 41;
			FI.stadiums_tod3weather = 42;
			FI.stadiums_upgradestyle = 43;
			FI.stadiums_genericrank = 44;
			FI.stadiums_timeofday1 = 45;
			FI.stadiums_timeofday2 = 46;
			FI.stadiums_stadiumgoalnetwidth = 47;
			FI.stadiums_managerawaybotrightx = 48;
			FI.stadiums_subshometopleftx = 49;
			FI.stadiums_stadiumgoalnetlength = 50;
			FI.stadiums_managerawaybotrighty = 51;
			FI.shoecolors_blue = 0;
			FI.shoecolors_green = 1;
			FI.shoecolors_red = 3;
			FI.shoecolors_colorid = 2;
			FI.rowteamnationlinks_nationid = 1;
			FI.rowteamnationlinks_teamid = 0;
			FI.rivals_rivaltype = 0;
			FI.rivals_teamid2 = 1;
			FI.rivals_teamid1 = 2;
			FI.restrictedplayers_fixtureid = 2;
			FI.restrictedplayers_reason = 0;
			FI.restrictedplayers_replacementplayerid = 1;
			FI.restrictedplayers_teamid = 3;
			FI.restrictedplayers_playerid = 4;
			FI.referee_birthdate = 13;
			FI.referee_firstname = 0;
			FI.referee_shoetypecode = 12;
			FI.referee_surname = 1;
			FI.referee_nationalitycode = 31;
			FI.referee_haircolorcode = 0;
			FI.referee_facialhairtypecode = 1;
			FI.referee_hairtypecode = 2;
			FI.referee_cardstrictness = 3;
			FI.referee_shoecolorcode2 = 4;
			FI.referee_stylecode = 5;
			FI.referee_proxyhaircolorid = 6;
			FI.referee_headtypecode = 7;
			FI.referee_foulstrictness = 8;
			FI.referee_height = 9;
			FI.referee_hairstateid = 10;
			FI.referee_leagueid = 11;
			FI.referee_sockheightcode = 14;
			FI.referee_weight = 15;
			FI.referee_proxyheadclass = 16;
			FI.referee_eyebrowcode = 17;
			FI.referee_eyecolorcode = 18;
			FI.referee_jerseysleevelengthcode = 19;
			FI.referee_hairlinecode = 20;
			FI.referee_headclasscode = 21;
			FI.referee_haireffecttypecode = 22;
			FI.referee_sideburnscode = 23;
			FI.referee_skintypecode = 24;
			FI.referee_hairpartcode = 25;
			FI.referee_sweatid = 26;
			FI.referee_skintonecode = 27;
			FI.referee_hairvariationid = 28;
			FI.referee_refereeid = 29;
			FI.referee_homecitycode = 30;
			FI.referee_shoedesigncode = 32;
			FI.referee_shoecolorcode1 = 33;
			FI.referee_bodytypecode = 34;
			FI.referee_wrinkleid = 35;
			FI.referee_facialhaircolorcode = 36;
			FI.previousteam_previousteamid = 0;
			FI.previousteam_playerid = 1;
			FI.players_birthdate = 41;
			FI.players_playerjointeamdate = 71;
			FI.players_shoetypecode = 40;
			FI.players_haircolorcode = 0;
			FI.players_facialhairtypecode = 1;
			FI.players_curve = 2;
			FI.players_jerseystylecode = 3;
			FI.players_agility = 4;
			FI.players_accessorycode4 = 5;
			FI.players_gksavetype = 6;
			FI.players_positioning = 7;
			FI.players_hairtypecode = 8;
			FI.players_standingtackle = 9;
			FI.players_faceposercode = 10;
			FI.players_preferredposition3 = 11;
			FI.players_longpassing = 12;
			FI.players_penalties = 13;
			FI.players_animfreekickstartposcode = 14;
			FI.players_animpenaltieskickstylecode = 15;
			FI.players_isretiring = 16;
			FI.players_longshots = 17;
			FI.players_gkdiving = 18;
			FI.players_interceptions = 19;
			FI.players_shoecolorcode2 = 20;
			FI.players_crossing = 21;
			FI.players_potential = 22;
			FI.players_gkreflexes = 23;
			FI.players_finishingcode1 = 24;
			FI.players_reactions = 25;
			FI.players_vision = 26;
			FI.players_contractvaliduntil = 27;
			FI.players_finishing = 28;
			FI.players_dribbling = 29;
			FI.players_slidingtackle = 30;
			FI.players_accessorycode3 = 31;
			FI.players_accessorycolourcode1 = 32;
			FI.players_headtypecode = 33;
			FI.players_firstnameid = 34;
			FI.players_sprintspeed = 35;
			FI.players_height = 36;
			FI.players_hasseasonaljersey = 37;
			FI.players_preferredposition2 = 38;
			FI.players_strength = 39;
			FI.players_preferredposition1 = 42;
			FI.players_ballcontrol = 43;
			FI.players_shotpower = 44;
			FI.players_trait1 = 45;
			FI.players_socklengthcode = 46;
			FI.players_weight = 47;
			FI.players_hashighqualityhead = 48;
			FI.players_gkglovetypecode = 49;
			FI.players_balance = 50;
			FI.players_gkkicking = 51;
			FI.players_lastnameid = 52;
			FI.players_internationalrep = 53;
			FI.players_animpenaltiesmotionstylecode = 54;
			FI.players_shortpassing = 55;
			FI.players_freekickaccuracy = 56;
			FI.players_skillmoves = 57;
			FI.players_usercaneditname = 58;
			FI.players_attackingworkrate = 59;
			FI.players_finishingcode2 = 60;
			FI.players_aggression = 61;
			FI.players_acceleration = 62;
			FI.players_headingaccuracy = 63;
			FI.players_eyebrowcode = 64;
			FI.players_runningcode2 = 65;
			FI.players_gkhandling = 66;
			FI.players_eyecolorcode = 67;
			FI.players_jerseysleevelengthcode = 68;
			FI.players_accessorycolourcode3 = 69;
			FI.players_accessorycode1 = 70;
			FI.players_headclasscode = 72;
			FI.players_defensiveworkrate = 73;
			FI.players_nationality = 74;
			FI.players_preferredfoot = 75;
			FI.players_sideburnscode = 76;
			FI.players_weakfootabilitytypecode = 77;
			FI.players_jumping = 78;
			FI.players_skintypecode = 79;
			FI.players_gkkickstyle = 80;
			FI.players_stamina = 81;
			FI.players_playerid = 82;
			FI.players_marking = 83;
			FI.players_accessorycolourcode4 = 84;
			FI.players_gkpositioning = 85;
			FI.players_trait2 = 86;
			FI.players_skintonecode = 87;
			FI.players_shortstyle = 88;
			FI.players_overallrating = 89;
			FI.players_jerseyfit = 90;
			FI.players_accessorycode2 = 91;
			FI.players_shoedesigncode = 92;
			FI.players_playerjerseynameid = 93;
			FI.players_shoecolorcode1 = 94;
			FI.players_commonnameid = 95;
			FI.players_bodytypecode = 96;
			FI.players_animpenaltiesstartposcode = 97;
			FI.players_runningcode1 = 98;
			FI.players_preferredposition4 = 99;
			FI.players_volleys = 100;
			FI.players_accessorycolourcode2 = 101;
			FI.players_facialhaircolorcode = 102;
			FI.playernames_name = 0;
			FI.playernames_commentaryid = 1;
			FI.playernames_nameid = 0;
			FI.playerloans_loandateend = 2;
			FI.playerloans_teamidloanedfrom = 0;
			FI.playerloans_playerid = 1;
			FI.playerformdiff_overallratingdiff = 1;
			FI.playerformdiff_newoverallrating = 0;
			FI.playerformdiff_oldoverallrating = 2;
			FI.playerformdiff_teamid = 3;
			FI.playerformdiff_playerid = 4;
			FI.playerboots_shoetype = 5;
			FI.playerboots_powid = 0;
			FI.playerboots_islocked = 1;
			FI.playerboots_islegacy = 2;
			FI.playerboots_shoecolor1 = 3;
			FI.playerboots_islicensed = 4;
			FI.playerboots_isavailableinstore = 6;
			FI.playerboots_isadidas = 7;
			FI.playerboots_shoedesign = 8;
			FI.playerboots_shoecolor2 = 9;
			FI.player_grudgelove_level_of_emotion = 0;
			FI.player_grudgelove_playerid = 1;
			FI.player_grudgelove_emotional_teamid = 2;
			FI.physio_birthdate = 4;
			FI.physio_firstname = 0;
			FI.physio_surname = 1;
			FI.physio_haircolorcode = 0;
			FI.physio_facialhairtypecode = 1;
			FI.physio_hairtypecode = 2;
			FI.physio_headtypecode = 3;
			FI.physio_eyebrowcode = 5;
			FI.physio_eyecolorcode = 6;
			FI.physio_physioid = 7;
			FI.physio_headclasscode = 8;
			FI.physio_haireffecttypecode = 9;
			FI.physio_skintonecode = 10;
			FI.physio_nationalitycode = 11;
			FI.physio_bodytypecode = 12;
			FI.physio_facialhaircolorcode = 13;
			FI.nations_nationname = 0;
			FI.nations_nationid = 4;
			FI.nations_confederation = 0;
			FI.nations_top_tier = 1;
			FI.nations_nationstartingfirstletter = 2;
			FI.nations_teamid = 3;
			FI.manager_firstname = 0;
			FI.manager_surname = 1;
			FI.manager_teamid = 0;
			FI.leagueteamlinks_teamshortform = 0;
			FI.leagueteamlinks_hasachievedobjective = 1;
			FI.leagueteamlinks_yettowin = 2;
			FI.leagueteamlinks_unbeatenallcomps = 3;
			FI.leagueteamlinks_unbeatenleague = 4;
			FI.leagueteamlinks_champion = 5;
			FI.leagueteamlinks_leagueid = 6;
			FI.leagueteamlinks_prevleagueid = 7;
			FI.leagueteamlinks_previousyeartableposition = 8;
			FI.leagueteamlinks_highestpossible = 9;
			FI.leagueteamlinks_teamform = 10;
			FI.leagueteamlinks_highestprobable = 11;
			FI.leagueteamlinks_artificialkey = 12;
			FI.leagueteamlinks_nummatchesplayed = 13;
			FI.leagueteamlinks_teamid = 14;
			FI.leagueteamlinks_gapresult = 15;
			FI.leagueteamlinks_grouping = 16;
			FI.leagueteamlinks_currenttableposition = 17;
			FI.leagueteamlinks_objective = 18;
			FI.leagueteamlinks_actualvsexpectations = 19;
			FI.leagueteamlinks_unbeatenhome = 20;
			FI.leagueteamlinks_lastgameresult = 21;
			FI.leagueteamlinks_unbeatenaway = 22;
			FI.leagueteamlinks_teamlongform = 23;
			FI.leagues_countryid = 1;
			FI.leagues_leaguename = 0;
			FI.leagues_level = 0;
			FI.leagues_leagueid = 2;
			FI.leagues_leaguetimeslice = 3;
			FI.leagues_iswithintransferwindow = 4;
			FI.leaguerefereelinks_leagueid = 0;
			FI.leaguerefereelinks_refereeid = 1;
			FI.formupdate_leagueid = 0;
			FI.formupdate_position = 1;
			FI.formupdate_teamid = 2;
			FI.formupdate_formaudio = 3;
			FI.formupdate_prevform = 4;
			FI.formupdate_playerid = 5;
			FI.formupdate_overallrating = 6;
			FI.formupdate_form = 7;
			FI.formations_offset6x = 0;
			FI.formations_offset5y = 1;
			FI.formations_offset10x = 2;
			FI.formations_offset2x = 3;
			FI.formations_defenders = 4;
			FI.formations_offset2y = 5;
			FI.formations_offset6y = 6;
			FI.formations_offset7x = 7;
			FI.formations_offset3x = 8;
			FI.formations_offset8x = 9;
			FI.formations_offset10y = 10;
			FI.formations_offset3y = 11;
			FI.formations_offset4x = 12;
			FI.formations_offset7y = 13;
			FI.formations_offset0x = 14;
			FI.formations_offset8y = 15;
			FI.formations_attackers = 16;
			FI.formations_offset9x = 17;
			FI.formations_midfielders = 18;
			FI.formations_offset5x = 19;
			FI.formations_offset0y = 20;
			FI.formations_offset1x = 21;
			FI.formations_offset4y = 22;
			FI.formations_offset9y = 23;
			FI.formations_offset1y = 24;
			FI.formations_formationname = 0;
			FI.formations_attackingdirection_0 = 0;
			FI.formations_attackingrole_5 = 1;
			FI.formations_position10 = 2;
			FI.formations_attackingdirection_7 = 3;
			FI.formations_defensivedirection_0 = 4;
			FI.formations_defensivedirection_9 = 5;
			FI.formations_defensivedirection_8 = 6;
			FI.formations_attackingdirection_9 = 7;
			FI.formations_position6 = 8;
			FI.formations_attackingrole_4 = 9;
			FI.formations_offensiverating = 10;
			FI.formations_attackingrole_2 = 11;
			FI.formations_attackingdirection_1 = 12;
			FI.formations_position8 = 13;
			FI.formations_defensiverole_4 = 14;
			FI.formations_attackingdirection_10 = 15;
			FI.formations_defensivedirection_6 = 16;
			FI.formations_attackingdirection_8 = 17;
			FI.formations_attackingrole_3 = 18;
			FI.formations_defensiverole_3 = 19;
			FI.formations_attackingrole_0 = 20;
			FI.formations_defensivedirection_1 = 21;
			FI.formations_attackingdirection_5 = 22;
			FI.formations_defensivedirection_2 = 23;
			FI.formations_attackingdirection_6 = 24;
			FI.formations_position5 = 25;
			FI.formations_attackingrole_7 = 26;
			FI.formations_defensiverole_5 = 27;
			FI.formations_defensivedirection_10 = 28;
			FI.formations_defensivedirection_3 = 29;
			FI.formations_defensivedirection_5 = 30;
			FI.formations_issweeper = 31;
			FI.formations_attackingdirection_2 = 32;
			FI.formations_attackingdirection_4 = 33;
			FI.formations_attackingrole_9 = 34;
			FI.formations_defensiverole_2 = 35;
			FI.formations_attackingdirection_3 = 36;
			FI.formations_attackingrole_8 = 37;
			FI.formations_attackingrole_1 = 38;
			FI.formations_defensiverole_10 = 39;
			FI.formations_defensiverole_1 = 40;
			FI.formations_teamid = 41;
			FI.formations_position2 = 42;
			FI.formations_defensivedirection_4 = 43;
			FI.formations_formationid = 44;
			FI.formations_defensiverole_8 = 45;
			FI.formations_attackingrole_6 = 46;
			FI.formations_relativeformationid = 47;
			FI.formations_defensiverole_0 = 48;
			FI.formations_defensiverole_6 = 49;
			FI.formations_position4 = 50;
			FI.formations_attackingrole_10 = 51;
			FI.formations_position3 = 52;
			FI.formations_defensiverole_7 = 53;
			FI.formations_formationfullnameid = 54;
			FI.formations_defensiverole_9 = 55;
			FI.formations_position0 = 56;
			FI.formations_position9 = 57;
			FI.formations_position7 = 58;
			FI.formations_position1 = 59;
			FI.formations_defensivedirection_7 = 60;
			FI.fieldpositionboundingboxes_pointy1 = 0;
			FI.fieldpositionboundingboxes_pointx1 = 1;
			FI.fieldpositionboundingboxes_pointy0 = 2;
			FI.fieldpositionboundingboxes_pointy3 = 3;
			FI.fieldpositionboundingboxes_pointy2 = 4;
			FI.fieldpositionboundingboxes_pointx0 = 5;
			FI.fieldpositionboundingboxes_pointx3 = 6;
			FI.fieldpositionboundingboxes_pointx2 = 7;
			FI.fieldpositionboundingboxes_positionid = 0;
			FI.editedplayernames_firstname = 0;
			FI.editedplayernames_commonname = 1;
			FI.editedplayernames_playerjerseyname = 2;
			FI.editedplayernames_surname = 3;
			FI.editedplayernames_playerid = 0;
			FI.dna_dna = 0;
			FI.dna_playerid = 0;
			FI.dcplayernames_name = 0;
			FI.dcplayernames_nameid = 0;
			FI.customformations_offset6x = 0;
			FI.customformations_offset5y = 1;
			FI.customformations_offset10x = 2;
			FI.customformations_offset2x = 3;
			FI.customformations_defenders = 4;
			FI.customformations_offset2y = 5;
			FI.customformations_offset6y = 6;
			FI.customformations_offset7x = 7;
			FI.customformations_offset3x = 8;
			FI.customformations_offset8x = 9;
			FI.customformations_offset10y = 10;
			FI.customformations_offset3y = 11;
			FI.customformations_offset4x = 12;
			FI.customformations_offset7y = 13;
			FI.customformations_offset0x = 14;
			FI.customformations_offset8y = 15;
			FI.customformations_attackers = 16;
			FI.customformations_offset9x = 17;
			FI.customformations_midfielders = 18;
			FI.customformations_offset5x = 19;
			FI.customformations_offset0y = 20;
			FI.customformations_offset1x = 21;
			FI.customformations_offset4y = 22;
			FI.customformations_offset9y = 23;
			FI.customformations_offset1y = 24;
			FI.customformations_formationname = 0;
			FI.customformations_attackingdirection_0 = 0;
			FI.customformations_attackingrole_5 = 1;
			FI.customformations_position10 = 2;
			FI.customformations_attackingdirection_7 = 3;
			FI.customformations_defensivedirection_0 = 4;
			FI.customformations_defensivedirection_9 = 5;
			FI.customformations_defensivedirection_8 = 6;
			FI.customformations_attackingdirection_9 = 7;
			FI.customformations_position6 = 8;
			FI.customformations_attackingrole_4 = 9;
			FI.customformations_offensiverating = 10;
			FI.customformations_attackingrole_2 = 11;
			FI.customformations_attackingdirection_1 = 12;
			FI.customformations_position8 = 13;
			FI.customformations_defensiverole_4 = 14;
			FI.customformations_attackingdirection_10 = 15;
			FI.customformations_defensivedirection_6 = 16;
			FI.customformations_attackingdirection_8 = 17;
			FI.customformations_attackingrole_3 = 18;
			FI.customformations_defensiverole_3 = 19;
			FI.customformations_attackingrole_0 = 20;
			FI.customformations_defensivedirection_1 = 21;
			FI.customformations_attackingdirection_5 = 22;
			FI.customformations_defensivedirection_2 = 23;
			FI.customformations_attackingdirection_6 = 24;
			FI.customformations_position5 = 25;
			FI.customformations_attackingrole_7 = 26;
			FI.customformations_defensiverole_5 = 27;
			FI.customformations_defensivedirection_10 = 28;
			FI.customformations_defensivedirection_3 = 29;
			FI.customformations_defensivedirection_5 = 30;
			FI.customformations_issweeper = 31;
			FI.customformations_attackingdirection_2 = 32;
			FI.customformations_attackingdirection_4 = 33;
			FI.customformations_attackingrole_9 = 34;
			FI.customformations_defensiverole_2 = 35;
			FI.customformations_attackingdirection_3 = 36;
			FI.customformations_attackingrole_8 = 37;
			FI.customformations_attackingrole_1 = 38;
			FI.customformations_defensiverole_10 = 39;
			FI.customformations_defensiverole_1 = 40;
			FI.customformations_teamid = 41;
			FI.customformations_position2 = 42;
			FI.customformations_defensivedirection_4 = 43;
			FI.customformations_formationid = 44;
			FI.customformations_defensiverole_8 = 45;
			FI.customformations_attackingrole_6 = 46;
			FI.customformations_relativeformationid = 47;
			FI.customformations_defensiverole_0 = 48;
			FI.customformations_defensiverole_6 = 49;
			FI.customformations_position4 = 50;
			FI.customformations_attackingrole_10 = 51;
			FI.customformations_position3 = 52;
			FI.customformations_defensiverole_7 = 53;
			FI.customformations_formationfullnameid = 54;
			FI.customformations_defensiverole_9 = 55;
			FI.customformations_position0 = 56;
			FI.customformations_position9 = 57;
			FI.customformations_position7 = 58;
			FI.customformations_position1 = 59;
			FI.customformations_defensivedirection_7 = 60;
			FI.competition_ballid = 1;
			FI.competition_competitionid = 0;
			FI.career_lastnames_lastname = 0;
			FI.career_lastnames_lastnameid = 0;
			FI.career_lastnames_groupid = 1;
			FI.career_firstnames_firstname = 0;
			FI.career_firstnames_firstnameid = 0;
			FI.career_firstnames_groupid = 1;
			FI.career_commonnames_firstname = 0;
			FI.career_commonnames_lastname = 1;
			FI.career_commonnames_commonnameid = 1;
			FI.career_commonnames_groupid = 0;
			FI.attributeprefpositionformula_attribute = 0;
			FI.attributeprefpositionformula_position = 1;
			FI.attributeprefpositionformula_percentage = 2;
			FI.audionation_nationid = 8;
			FI.audionation_PALanguageIndex = 0;
			FI.audionation_CrowdBedsRegionIndex = 1;
			FI.audionation_WhistlesRegionIndex = 2;
			FI.audionation_AmbienceRegionIndex = 3;
			FI.audionation_PlayerCallPatchBankIndex = 4;
			FI.audionation_HecklesRegionIndex = 5;
			FI.audionation_ChantRegionIndex = 6;
			FI.audionation_TeamCanWhistleIndex = 7;
			FI.audionation_ReactionsRegionIndex = 9;
			FI.NoAttendance_Max = 0;
			FI.NoAttendance_Emotion = 1;
			FI.NoAttendance_Min = 2;
			FI.MatchIntensity_ScoreDiff = 0;
			FI.MatchIntensity_time60 = 1;
			FI.MatchIntensity_time90 = 2;
			FI.MatchIntensity_time120 = 3;
			FI.MatchIntensity_time75 = 4;
			FI.MatchIntensity_time45 = 5;
			FI.MatchIntensity_time30 = 6;
			FI.MatchIntensity_time15 = 7;
			FI.BigAttendance_Max = 0;
			FI.BigAttendance_Emotion = 1;
			FI.BigAttendance_Min = 2;
			FI.audiostadium_stadiumid = 0;
			FI.audiostadium_audioindex = 1;
			FI.career_managerawards_count = 2;
			FI.career_managerawards_season = 0;
			FI.career_managerawards_compobjid = 1;
			FI.career_managerawards_artificialkey = 3;
			FI.career_managerawards_teamid = 4;
			FI.career_managerawards_typeid = 5;
			FI.career_teamofweek_artificialkey = 1;
			FI.career_teamofweek_matchrating = 0;
			FI.career_teamofweek_weekswon = 2;
			FI.career_teamofweek_month = 3;
			FI.career_teamofweek_playerid = 4;
			FI.career_playerawards_season = 0;
			FI.career_playerawards_compobjid = 1;
			FI.career_playerawards_count = 2;
			FI.career_playerawards_artificialkey = 3;
			FI.career_playerawards_teamid = 4;
			FI.career_playerawards_playerid = 5;
			FI.career_playerawards_typeid = 6;
			FI.career_calendar_transferwindowend1 = 0;
			FI.career_calendar_transferwindowstart1 = 1;
			FI.career_calendar_transferwindowend2 = 2;
			FI.career_calendar_setupdate = 3;
			FI.career_calendar_dateid = 4;
			FI.career_calendar_enddate = 5;
			FI.career_calendar_currdate = 6;
			FI.career_calendar_startdate = 7;
			FI.career_calendar_transferwindowstart2 = 8;
			FI.career_squadranking_curroverall = 0;
			FI.career_squadranking_playerid = 1;
			FI.career_squadranking_lastoverall = 2;
			FI.career_playermatchratinghistory_minsplayed = 3;
			FI.career_playermatchratinghistory_date = 0;
			FI.career_playermatchratinghistory_artificialkey = 1;
			FI.career_playermatchratinghistory_rating = 2;
			FI.career_playermatchratinghistory_playerid = 4;
			FI.career_fixtureinfo_homeprevscore = 0;
			FI.career_fixtureinfo_hometeamid = 1;
			FI.career_fixtureinfo_totalmatches = 2;
			FI.career_fixtureinfo_stagecompobjid = 3;
			FI.career_fixtureinfo_subsonbench = 4;
			FI.career_fixtureinfo_pitchwear = 5;
			FI.career_fixtureinfo_assetid = 6;
			FI.career_fixtureinfo_stadiumid = 7;
			FI.career_fixtureinfo_matchsituation = 8;
			FI.career_fixtureinfo_fixturedate = 9;
			FI.career_fixtureinfo_suspensioncompobjid = 10;
			FI.career_fixtureinfo_numgamesdoubleyellowbanmin = 11;
			FI.career_fixtureinfo_neutralstadium = 12;
			FI.career_fixtureinfo_compobjid = 13;
			FI.career_fixtureinfo_offsides = 14;
			FI.career_fixtureinfo_comptype = 15;
			FI.career_fixtureinfo_numgamesdoubleyellowbanmax = 16;
			FI.career_fixtureinfo_weathertype = 17;
			FI.career_fixtureinfo_subsavailable = 18;
			FI.career_fixtureinfo_matchimportance = 19;
			FI.career_fixtureinfo_awayprevscore = 20;
			FI.career_fixtureinfo_matchnumber = 21;
			FI.career_fixtureinfo_fixtureid = 22;
			FI.career_fixtureinfo_numyellowsforban = 23;
			FI.career_fixtureinfo_injuries = 24;
			FI.career_fixtureinfo_matchsetupflags = 25;
			FI.career_fixtureinfo_timeofday = 26;
			FI.career_fixtureinfo_fixturetime = 27;
			FI.career_fixtureinfo_numgamesyellowbanmax = 28;
			FI.career_fixtureinfo_awayteamid = 29;
			FI.career_fixtureinfo_bookings = 30;
			FI.career_fixtureinfo_numgamesredbanmax = 31;
			FI.career_fixtureinfo_numgamesyellowbanmin = 32;
			FI.career_fixtureinfo_userid = 33;
			FI.career_fixtureinfo_matchtype = 34;
			FI.career_fixtureinfo_numgamesredbanmin = 35;
			FI.career_fixtureinfo_fixtureinfoid = 36;
			FI.career_clinchedobjectives_predictedclinchfordrawflags = 0;
			FI.career_clinchedobjectives_clinchedobjectivesflags = 1;
			FI.career_clinchedobjectives_predictedclinchforwinflags = 2;
			FI.career_clinchedobjectives_teamid = 3;
			FI.career_clinchedobjectives_predictedclinchforlossflags = 4;
			FI.cmeventhistory_artificialkey = 0;
			FI.cmeventhistory_teamId = 1;
			FI.cmeventhistory_eventId = 2;
			FI.cmeventhistory_playerId = 3;
			FI.cmeventhistory_daysfromstart = 4;
			FI.cmteameventhistory_artificialkey = 0;
			FI.cmteameventhistory_teamId = 1;
			FI.cmteameventhistory_eventId = 2;
			FI.cmteameventhistory_daysfromstart = 3;
			FI.career_boardoutcomes_outcome3 = 0;
			FI.career_boardoutcomes_outcome4 = 1;
			FI.career_boardoutcomes_leagueid = 2;
			FI.career_boardoutcomes_outcome1 = 3;
			FI.career_boardoutcomes_outcome2 = 4;
			FI.career_boardoutcomes_outcome5 = 5;
			FI.career_users_firstname = 0;
			FI.career_users_surname = 1;
			FI.career_users_agentname = 2;
			FI.career_users_nationalityid = 9;
			FI.career_users_goalnews = 0;
			FI.career_users_playertype = 1;
			FI.career_users_nationalteamid = 2;
			FI.career_users_leagueseasonmessagesent = 3;
			FI.career_users_sponsorid = 4;
			FI.career_users_leagueid = 5;
			FI.career_users_clubteamid = 6;
			FI.career_users_wage = 7;
			FI.career_users_primarycompobjid = 8;
			FI.career_users_seasoncount = 10;
			FI.career_users_usertype = 11;
			FI.career_users_userid = 12;
			FI.career_trophies_season = 0;
			FI.career_trophies_flags = 1;
			FI.career_trophies_userid = 2;
			FI.career_managerpref_currency = 0;
			FI.career_managerpref_matchdifficulty = 1;
			FI.career_managerpref_playasaiteam = 2;
			FI.career_managerpref_bonuspercentage = 3;
			FI.career_managerpref_boardfinancialstrictness = 4;
			FI.career_managerpref_usedsquad = 5;
			FI.career_managerpref_stadiumid = 6;
			FI.career_managerpref_halflength = 7;
			FI.career_managerpref_managerprefid = 8;
			FI.career_managerpref_wagebudget = 9;
			FI.career_managerpref_boardaidifficulty = 10;
			FI.career_managerpref_startofseasontransferbudget = 11;
			FI.career_managerpref_transferbudget = 12;
			FI.career_managerpref_startofseasonwagebudget = 13;
			FI.career_managerpref_startofseasonplayerwages = 14;
			FI.career_managerinfo_biglossoppscore = 2;
			FI.career_managerinfo_bigwinoppscore = 6;
			FI.career_managerinfo_biglossuserscore = 8;
			FI.career_managerinfo_bigwinuserscore = 12;
			FI.career_managerinfo_seasonobjective3 = 0;
			FI.career_managerinfo_bigwindate = 1;
			FI.career_managerinfo_bigwinoppteamid = 3;
			FI.career_managerinfo_biglossdate = 4;
			FI.career_managerinfo_seasonobjectiveresult1 = 5;
			FI.career_managerinfo_seasonobjectiveresult2 = 7;
			FI.career_managerinfo_totalearnings = 9;
			FI.career_managerinfo_clubteamid = 10;
			FI.career_managerinfo_biglossuserteamid = 11;
			FI.career_managerinfo_wage = 13;
			FI.career_managerinfo_bigwinuserteamid = 14;
			FI.career_managerinfo_losingstreak = 15;
			FI.career_managerinfo_seasonobjectiveresult3 = 16;
			FI.career_managerinfo_playersreleasedthisseason = 17;
			FI.career_managerinfo_biglossoppteamid = 18;
			FI.career_managerinfo_seasonobjective1 = 19;
			FI.career_managerinfo_internationalteamid = 20;
			FI.career_managerinfo_managerreputation = 21;
			FI.career_managerinfo_seasonobjective2 = 22;
			FI.career_managerinfo_boardconfidence = 23;
			FI.career_managerinfo_userid = 24;
			FI.career_managerhistory_draws = 2;
			FI.career_managerhistory_losses = 3;
			FI.career_managerhistory_wins = 9;
			FI.career_managerhistory_games_played = 14;
			FI.career_managerhistory_bigbuyplayername = 0;
			FI.career_managerhistory_bigsellplayername = 1;
			FI.career_managerhistory_leagueobjectiveresult = 0;
			FI.career_managerhistory_continentalcuptrophies = 1;
			FI.career_managerhistory_season = 4;
			FI.career_managerhistory_bigsellamount = 5;
			FI.career_managerhistory_leaguetrophies = 6;
			FI.career_managerhistory_domestic_cup_result = 7;
			FI.career_managerhistory_domesticcuptrophies = 8;
			FI.career_managerhistory_leagueid = 10;
			FI.career_managerhistory_bigbuyamount = 11;
			FI.career_managerhistory_leagueobjective = 12;
			FI.career_managerhistory_domestic_cup_objective = 13;
			FI.career_managerhistory_europe_cup_objective = 15;
			FI.career_managerhistory_artificialkey = 16;
			FI.career_managerhistory_teamid = 17;
			FI.career_managerhistory_goals_for = 18;
			FI.career_managerhistory_points = 19;
			FI.career_managerhistory_tableposition = 20;
			FI.career_managerhistory_forfeits = 21;
			FI.career_managerhistory_goals_against = 22;
			FI.career_managerhistory_europe_cup_result = 23;
			FI.career_leagueballs_balltype = 0;
			FI.career_leagueballs_leagueid = 1;
			FI.career_competitionprogress_compshortname = 0;
			FI.career_competitionprogress_artificialkey = 4;
			FI.career_competitionprogress_cup_objective_result = 0;
			FI.career_competitionprogress_stageid = 1;
			FI.career_competitionprogress_season = 2;
			FI.career_competitionprogress_compobjid = 3;
			FI.career_competitionprogress_teamid = 5;
			FI.career_competitionprogress_hasteamwon = 6;
			FI.clubcommentarynames_commentaryid = 0;
			FI.clubcommentarynames_commentarystartingletter = 1;
			FI.createplayerviews_attributeid = 1;
			FI.createplayerviews_mainviewid = 0;
			FI.createplayerpositiontemplates_attributeid = 2;
			FI.createplayerpositiontemplates_attributevalue = 0;
			FI.createplayerpositiontemplates_positionid = 1;
			FI.createplayer_cpmorphcomposite_noseprofile_protrusion_lsx = 0;
			FI.createplayer_cpmorphcomposite_eyedetail1_folds_lsy = 1;
			FI.createplayer_cpmorphcomposite_mouthposition_protrusion_rsx = 2;
			FI.createplayer_cpmorphcomposite_nostrildetail_height_lsy = 3;
			FI.createplayer_cpmorphcomposite_browshape_protrusion_rsx = 4;
			FI.createplayer_cpmorphcomposite_browshape_tilt_lsy = 5;
			FI.createplayer_cpmorphcomposite_earplacement_height_lsy = 6;
			FI.createplayer_cpmorphcomposite_cheekplacement_position_lsy = 7;
			FI.createplayer_cpmorphcomposite_eyeshape_shape_rsx = 8;
			FI.createplayer_cpmorphcomposite_lips_upperlip_shape_lsx = 9;
			FI.createplayer_cpmorphcomposite_eyeshape_height_lsy = 10;
			FI.createplayer_cpmorphcomposite_mouthposition_bite_rsy = 11;
			FI.createplayer_cpmorphcomposite_cheekstyle_blemishes_rsx = 12;
			FI.createplayer_cpmorphcomposite_nostrils_height_lsy = 13;
			FI.createplayer_cpmorphcomposite_mouthblemishes_lsx = 14;
			FI.createplayer_cpmorphcomposite_earstyle_lobe_lsx = 15;
			FI.createplayer_skincolor = 2;
			FI.createplayer_cpmorphcomposite_mouthposition_width_lsx = 16;
			FI.createplayer_cpmorphcomposite_eyeshape_tilt_rsy = 17;
			FI.createplayer_cpmorphcomposite_noseprofile_tipshape_rsy = 18;
			FI.createplayer_cpmorphcomposite_browplacement_thickness_rsy = 19;
			FI.createplayer_cpmorphcomposite_noseplacement_position_lsy = 20;
			FI.createplayer_cpmorphcomposite_eyeshape_seperation_lsx = 21;
			FI.createplayer_cpmorphcomposite_noseprofile_tipprotrusion_rsx = 22;
			FI.createplayer_cpmorphcomposite_cheekplacement_width_lsx = 23;
			FI.createplayer_cpmorphcomposite_laughlinedarkness_lsx = 24;
			FI.createplayer_cpmorphcomposite_jaw_position_lsy = 25;
			FI.createplayer_cpmorphcomposite_browplacement_protrusion_rsx = 26;
			FI.createplayer_cpmorphcomposite_eyedetail2_lowerlid_lsx = 27;
			FI.createplayer_cpmorphcomposite_lips_upperlip_thickness_lsy = 28;
			FI.createplayer_cpmorphcomposite_noseprofile_shape_lsy = 29;
			FI.createplayer_cpmorphcomposite_lips_lowerlip_thickness_rsy = 30;
			FI.createplayer_cpmorhpcomposite_chin_width_lsx = 31;
			FI.createplayer_cpmorphcomposite_nosestyle_nosestyle_lsx = 32;
			FI.createplayer_personaid = 5;
			FI.createplayer_cpmorphcomposite_mouthposition_position_lsy = 33;
			FI.createplayer_cpmorphcomposite_earplacement_protrusion_lsx = 34;
			FI.createplayer_cpmorphcomposite_dimpledarkness_lsx = 35;
			FI.createplayer_cpmorphcomposite_noseplacement_width_rsx = 36;
			FI.createplayer_cpmorphcomposite_eyedetail2_protrusion_rsy = 37;
			FI.createplayer_cpmorphcomposite_lipstyle_corners_lipdimple_rsx = 38;
			FI.createplayer_cpmorphcomposite_lips_lowerlip_thickness_rsx = 39;
			FI.createplayer_cpmorphcomposite_browplacement_position_lsy = 40;
			FI.createplayer_cpmorhpcomposite_chin_postion_lsy = 41;
			FI.createplayer_cpmorphcomposite_lipstyle_corners_updown_lsy = 42;
			FI.createplayer_cpmorphcomposite_eyedetail1_protrusion_rsx = 43;
			FI.createplayer_cpmorphcomposite_browshape_seperation_lsx = 44;
			FI.createplayer_cpmorphcomposite_jaw_bulk_rsx = 45;
			FI.createplayer_cpmorphcomposite_noseplacement_width_lsx = 46;
			FI.createplayer_cpmorphcomposite_eyedetail1_symmetry_lsx = 47;
			FI.createplayer_cpmorphcomposite_nostrils_width_lsx = 48;
			FI.createplayer_cpmorphcomposite_eyedetail2_upperlid_lsy = 49;
			FI.createplayer_cpmorphcomposite_lipstyle_corners_leftright_lsx = 50;
			FI.createplayer_cpmorphcomposite_browplacement_tilt_lsx = 51;
			FI.createplayer_cpmorphcomposite_jaw_width_lsx = 52;
			FI.createplayer_cpmorphcomposite_browshape_thickness_rsy = 53;
			FI.createplayer_cpmorhpcomposite_chin_protrusion_rsx = 54;
			FI.createplayer_cpmorphcomposite_noseplacement_position_rsy = 55;
			FI.createplayer_cpmorphcomposite_nostrildetail_width_lsx = 56;
			FI.createplayer_cpmorphcomposite_cheekstyle_style_lsx = 57;
			FI.createplayer_cpmorhpcomposite_chin_deatil_rsy = 58;
			FI.createplayer_cpattributename_hair_style = 4;
			FI.createplayer_create_originalplayerid = 0;
			FI.createplayer_create_playerid = 1;
			FI.createplayer_cpattributename_hair_colour = 3;
			FI.createplayer_celebrationid = 6;
			FI.createplayer_cpattributename_brow_style = 7;
			FI.createplayer_cpattributename_eye_colour = 8;
			FI.createplayer_create_artificialkey = 9;
			FI.createplayer_commentaryid = 10;
			FI.createplayer_cpattributename_facial_hair_style = 11;
			FI.createplayer_cpattributename_brow_colour = 12;
			FI.createplayer_cpattributename_facial_hair_colour = 13;
			FI.commentarynames_commentarystring = 0;
			FI.commentarynames_commentaryid = 0;
			FI.commentarynames_commentarystartingletter = 1;
			FI.commentarynames_commentarypreview = 2;
			FI.cz_assets_crestid = 0;
			FI.cz_assets_dbid = 2;
			FI.cz_assets_publishdate = 4;
			FI.cz_assets_rating = 0;
			FI.cz_assets_kitid = 6;
			FI.cz_assets_xms_media_id = 7;
			FI.cz_assets_type = 8;
			FI.cz_assets_author = 0;
			FI.cz_assets_assetname = 1;
			FI.cz_assets_assetyear = 1;
			FI.cz_assets_playerposition = 3;
			FI.cz_assets_version = 5;
			FI.cz_teams_hascrestimage = 0;
			FI.cz_teams_hassponsorimage = 3;
			FI.cz_teams_teamabbrev3 = 0;
			FI.cz_teams_teamid = 1;
			FI.cz_teams_commentaryid = 2;
			FI.cz_teamkits_hotspotjerseyfrontsponsorr = 0;
			FI.cz_teamkits_hotspotjerseyfrontsponsorb = 1;
			FI.cz_teamkits_hotspotjerseyfrontsponsorl = 2;
			FI.cz_teamkits_assetid = 13;
			FI.cz_teamkits_hotspotjerseyfrontsponsort = 3;
			FI.cz_teamkits_sockscolortertr = 1;
			FI.cz_teamkits_jerseycolorprimg = 2;
			FI.cz_teamkits_jerseycolortertg = 3;
			FI.cz_teamkits_sponsorcolourg = 4;
			FI.cz_teamkits_sockscolorsecb = 5;
			FI.cz_teamkits_sponsorcolourr = 7;
			FI.cz_teamkits_sockscolortertg = 8;
			FI.cz_teamkits_shortcolorsecb = 9;
			FI.cz_teamkits_shortcolortertg = 10;
			FI.cz_teamkits_numberfonttype = 11;
			FI.cz_teamkits_shortcolorprimb = 12;
			FI.cz_teamkits_jerseycolorsecr = 14;
			FI.cz_teamkits_jerseynamefonttype = 15;
			FI.cz_teamkits_jerseynamelayouttype = 16;
			FI.cz_teamkits_jerseycolortertb = 17;
			FI.cz_teamkits_shortsnumbercolor = 18;
			FI.cz_teamkits_jerseyshapestyle = 19;
			FI.cz_teamkits_shortcolortertr = 20;
			FI.cz_teamkits_shortcolorsecr = 22;
			FI.cz_teamkits_jerseynamecolorg = 23;
			FI.cz_teamkits_jerseycolorprimr = 24;
			FI.cz_teamkits_sponsorcolourb = 25;
			FI.cz_teamkits_sockscolorsecg = 26;
			FI.cz_teamkits_jerseycolorsecb = 27;
			FI.cz_teamkits_sockscolorprimg = 28;
			FI.cz_teamkits_shortcolorprimr = 30;
			FI.cz_teamkits_jerseycolortertr = 32;
			FI.cz_teamkits_shortcolorsecg = 33;
			FI.cz_teamkits_jerseycolorprimb = 34;
			FI.cz_teamkits_sockscolorprimr = 35;
			FI.cz_teamkits_sockscolorsecr = 36;
			FI.cz_teamkits_shortcolortertb = 37;
			FI.cz_teamkits_jerseynamecolorr = 38;
			FI.cz_teamkits_numbercolor = 39;
			FI.cz_teamkits_sockscolorprimb = 40;
			FI.cz_teamkits_jerseycolorsecg = 41;
			FI.cz_teamkits_shortsnumberfonttype = 42;
			FI.cz_teamkits_jerseynamecolorb = 45;
			FI.cz_teamkits_shortcolorprimg = 46;
			FI.cz_teamkits_sockscolortertb = 47;
			FI.cz_teamkits_jerseybacknamefontcase = 0;
			FI.cz_teamkits_hassponsor = 6;
			FI.cz_teamkits_jerseybacknameplacementcode = 21;
			FI.cz_teamkits_artificialkey = 29;
			FI.cz_teamkits_teamid = 31;
			FI.cz_teamkits_kitid = 43;
			FI.cz_teamkits_kittypeid = 44;
			FI.cz_players_assetid = 0;
			FI.cz_players_commentaryid = 1;
			FI.cz_players_playerid = 2;
			FI.cz_leagues_overlaybgcolour3r = 0;
			FI.cz_leagues_tournamentballid = 1;
			FI.cz_leagues_overlaytextcolour3r = 2;
			FI.cz_leagues_overlaytextcolour1g = 4;
			FI.cz_leagues_overlaytextcolour3b = 6;
			FI.cz_leagues_overlaybgcolour1g = 7;
			FI.cz_leagues_championcupslotallotment = 8;
			FI.cz_leagues_overlaybgcolour3b = 12;
			FI.cz_leagues_finalstadiumid = 13;
			FI.cz_leagues_overlaytextcolour2b = 14;
			FI.cz_leagues_overlaybgcolour1r = 16;
			FI.cz_leagues_overlaybgcolour2b = 18;
			FI.cz_leagues_overlaytextcolour1r = 20;
			FI.cz_leagues_overlaytextcolour3g = 21;
			FI.cz_leagues_overlaytextcolour1b = 22;
			FI.cz_leagues_overlaybgcolour3g = 23;
			FI.cz_leagues_overlaybgcolour1b = 24;
			FI.cz_leagues_overlaybgcolour2r = 25;
			FI.cz_leagues_overlaytextcolour2g = 26;
			FI.cz_leagues_eurocupslotallotment = 27;
			FI.cz_leagues_overlaytextcolour2r = 28;
			FI.cz_leagues_overlaybgcolour2g = 29;
			FI.cz_leagues_leaguedescription = 0;
			FI.cz_leagues_leaguetype = 3;
			FI.cz_leagues_numteams = 5;
			FI.cz_leagues_trophyid = 9;
			FI.cz_leagues_teamadvancingpergroup = 10;
			FI.cz_leagues_leagueid = 11;
			FI.cz_leagues_fixturevsgroup = 15;
			FI.cz_leagues_teampergroup = 17;
			FI.cz_leagues_finalmatchlegs = 19;
			FI.cz_leagues_fixturevseachteam = 30;
			FI.cz_leagues_subonbench = 31;
			FI.dlcballs_name = 0;
			FI.dlcballs_assetid = 0;
			FI.teamstadiumlinkscache_stadiumid = 0;
			FI.teamstadiumlinkscache_teamid = 1;
			FI.dlcboots_name = 0;
			FI.dlcboots_assetid = 0;
			FI.eatrax_album = 0;
			FI.eatrax_songname = 1;
			FI.eatrax_artist = 2;
			FI.eatrax_songid = 0;
			FI.eatrax_intro = 1;
			FI.songplaylistlinks_songid = 0;
			FI.songplaylistlinks_playlistid = 1;
			FI.songplaylistlinks_unlocked = 2;
			FI.songplaylistlinks_artificialkey = 3;
			FI.celebrations_celebrationid = 0;
			FI.videos_countrycode = 0;
			FI.videos_languagecode = 1;
			FI.videos_videoid = 0;
			FI.videos_artificialkey = 1;
			FI.fce_activeteams_teamid = 0;
			FI.fce_activeteams_userid = 1;
			FI.fce_weathersettings_weatherid = 0;
			FI.fce_weathersettings_rainpct = 1;
			FI.fce_weathersettings_snowpct = 2;
			FI.fce_weathersettings_clearpct = 3;
			FI.fce_weathersettings_quarter = 4;
			FI.fce_weathersettings_compid = 5;
			FI.fce_weathersettings_inuse = 6;
			FI.fce_statistics_goals = 0;
			FI.fce_statistics_saves = 1;
			FI.fce_statistics_shots = 4;
			FI.fce_statistics_goalsconceded = 11;
			FI.fce_statistics_totalreds = 2;
			FI.fce_statistics_manofmatch = 3;
			FI.fce_statistics_minutes = 5;
			FI.fce_statistics_appearances = 6;
			FI.fce_statistics_compid = 7;
			FI.fce_statistics_assists = 8;
			FI.fce_statistics_matchratings = 9;
			FI.fce_statistics_cleansheets = 10;
			FI.fce_statistics_teamid = 12;
			FI.fce_statistics_totalyellows = 13;
			FI.fce_statistics_statisticsid = 14;
			FI.fce_statistics_playerid = 15;
			FI.fce_statistics_inuse = 16;
			FI.fce_standings_homegoalsfor = 0;
			FI.fce_standings_teamindex = 1;
			FI.fce_standings_standingsid = 2;
			FI.fce_standings_homegoalsagainst = 3;
			FI.fce_standings_compid = 4;
			FI.fce_standings_homewins = 5;
			FI.fce_standings_teamid = 6;
			FI.fce_standings_awaywins = 7;
			FI.fce_standings_points = 8;
			FI.fce_standings_awaygoalsfor = 9;
			FI.fce_standings_homelosses = 10;
			FI.fce_standings_awaygoalsagainst = 11;
			FI.fce_standings_awaylosses = 12;
			FI.fce_standings_awaydraws = 13;
			FI.fce_standings_inuse = 14;
			FI.fce_standings_homedraws = 15;
			FI.fce_stageadvance_actiondate = 0;
			FI.fce_stageadvance_active = 1;
			FI.fce_stageadvance_stageindex = 2;
			FI.fce_stageadvance_randomnumber = 3;
			FI.fce_stageadvance_compid = 4;
			FI.fce_stageadvance_inuse = 5;
			FI.fce_stageadvance_stageadvanceid = 6;
			FI.fce_settings_settingvalue = 0;
			FI.fce_settings_settingenumid = 1;
			FI.fce_settings_settingid = 2;
			FI.fce_settings_compid = 3;
			FI.fce_settings_inuse = 4;
			FI.fce_scriptfunctions_scriptfuncid = 0;
			FI.fce_scriptfunctions_funcparam1 = 1;
			FI.fce_scriptfunctions_compid = 2;
			FI.fce_scriptfunctions_funcparam2 = 3;
			FI.fce_scriptfunctions_targetcompid = 4;
			FI.fce_scriptfunctions_funcparam3 = 5;
			FI.fce_scriptfunctions_inuse = 6;
			FI.fce_scriptfunctions_functype = 7;
			FI.fce_scheduleinfo_time = 0;
			FI.fce_scheduleinfo_dayofweek = 1;
			FI.fce_scheduleinfo_compid = 2;
			FI.fce_scheduleinfo_chance = 3;
			FI.fce_scheduleinfo_priority = 4;
			FI.fce_scheduleinfo_inuse = 5;
			FI.fce_scheduleinfo_scheduleinfoid = 6;
			FI.fce_fixtures_time = 0;
			FI.fce_fixtures_homescore = 1;
			FI.fce_fixtures_awayscore = 2;
			FI.fce_fixtures_gamecompletion = 3;
			FI.fce_fixtures_compid = 4;
			FI.fce_fixtures_date = 5;
			FI.fce_fixtures_fixtureid = 6;
			FI.fce_fixtures_awaystandingid = 7;
			FI.fce_fixtures_homestandingid = 8;
			FI.fce_fixtures_awaypens = 9;
			FI.fce_fixtures_homepens = 10;
			FI.fce_fixtures_inuse = 11;
			FI.fce_competitionteams_teamindex = 0;
			FI.fce_competitionteams_compteamid = 1;
			FI.fce_competitionteams_compid = 2;
			FI.fce_competitionteams_teamid = 3;
			FI.fce_competitionteams_inuse = 4;
			FI.fce_competitioninfo_compobjshortdesc = 1;
			FI.fce_competitioninfo_compobjdesc = 0;
			FI.fce_competitioninfo_compparentid = 0;
			FI.fce_competitioninfo_comptype = 1;
			FI.fce_competitioninfo_compid = 2;
			FI.fce_competitioninfo_inuse = 3;
			FI.fce_compavgs_mid = 0;
			FI.fce_compavgs_ovr = 1;
			FI.fce_compavgs_def = 2;
			FI.fce_compavgs_compid = 3;
			FI.fce_compavgs_gk = 4;
			FI.fce_compavgs_att = 5;
			FI.fce_advancement_fromcompid = 0;
			FI.fce_advancement_fromteamindex = 1;
			FI.fce_advancement_tocompid = 2;
			FI.fce_advancement_advancementid = 3;
			FI.fce_advancement_toteamindex = 4;
			FI.fce_advancement_inuse = 5;
			FI.fifaGameSettings_IonCameraZPosition = 97;
			FI.fifaGameSettings_GcAccelerationUser = 0;
			FI.fifaGameSettings_CamOTP = 1;
			FI.fifaGameSettings_FirstBoot = 2;
			FI.fifaGameSettings_GcSprintSpeedCpu = 3;
			FI.fifaGameSettings_GcGkAbilityUser = 4;
			FI.fifaGameSettings_GcShotErrorCpu = 5;
			FI.fifaGameSettings_KinCustomMentalityCmd = 6;
			FI.fifaGameSettings_GcPosLineWidthCpu = 7;
			FI.fifaGameSettings_GoalNews = 8;
			FI.fifaGameSettings_Penalties = 9;
			FI.fifaGameSettings_GcPassErrorUser = 10;
			FI.fifaGameSettings_GenericSetting0 = 11;
			FI.fifaGameSettings_Camera = 12;
			FI.fifaGameSettings_PAVolume = 13;
			FI.fifaGameSettings_Vibration = 14;
			FI.fifaGameSettings_KinCustomFormation = 15;
			FI.fifaGameSettings_SubsOnBench = 16;
			FI.fifaGameSettings_CamHeight = 17;
			FI.fifaGameSettings_DifficultyLevel = 18;
			FI.fifaGameSettings_PitchWear = 19;
			FI.fifaGameSettings_KinCustomFormationCmd = 20;
			FI.fifaGameSettings_MowPattern = 21;
			FI.fifaGameSettings_GcPosDefensiveLineHeightCpu = 22;
			FI.fifaGameSettings_Ball = 23;
			FI.fifaGameSettings_Handball = 24;
			FI.fifaGameSettings_GameSettingsContext = 25;
			FI.fifaGameSettings_GcTrapErrorUser = 26;
			FI.fifaGameSettings_GcPosRunFrequencyCpu = 27;
			FI.fifaGameSettings_KinCustomMentality = 28;
			FI.fifaGameSettings_Season = 29;
			FI.fifaGameSettings_MM_DifficultyLevel = 30;
			FI.fifaGameSettings_FIWC_Ball = 31;
			FI.fifaGameSettings_UserMusicVolume = 32;
			FI.fifaGameSettings_PerformanceBar = 33;
			FI.fifaGameSettings_MusicVolume = 34;
			FI.fifaGameSettings_GcPosFullbackPositioningUser = 35;
			FI.fifaGameSettings_KinFormation5 = 36;
			FI.fifaGameSettings_GcPosLineLengthCpu = 37;
			FI.fifaGameSettings_GcPassSpeedCpu = 38;
			FI.fifaGameSettings_KinCustomFutFormation = 39;
			FI.fifaGameSettings_GcInjurySeverityUser = 40;
			FI.fifaGameSettings_KinFutFormation2 = 41;
			FI.fifaGameSettings_KinFormation2 = 42;
			FI.fifaGameSettings_GcTrapErrorCpu = 43;
			FI.fifaGameSettings_KinFutFormation1 = 44;
			FI.fifaGameSettings_GcShotSpeedUser = 45;
			FI.fifaGameSettings_GcInjuryFrequencyUser = 46;
			FI.fifaGameSettings_StartUpTutorial = 47;
			FI.fifaGameSettings_MovDifficultyLevel = 48;
			FI.fifaGameSettings_GcPowerBarUser = 49;
			FI.fifaGameSettings_KinComboCommand = 50;
			FI.fifaGameSettings_KinCustomTacticCmd = 51;
			FI.fifaGameSettings_GcSprintSpeedUser = 52;
			FI.fifaGameSettings_KinComboFormation = 53;
			FI.fifaGameSettings_GcShotSpeedCpu = 54;
			FI.fifaGameSettings_NetShape = 55;
			FI.fifaGameSettings_UgcAllowed = 56;
			FI.fifaGameSettings_Contrast = 57;
			FI.fifaGameSettings_TimeScoreDisplay = 58;
			FI.fifaGameSettings_GcPassErrorCpu = 59;
			FI.fifaGameSettings_RadarOrientation = 60;
			FI.fifaGameSettings_KinComboFutFormation = 61;
			FI.fifaGameSettings_IPI = 62;
			FI.fifaGameSettings_CommentaryVolume = 63;
			FI.fifaGameSettings_FavoriteTeam = 64;
			FI.fifaGameSettings_MenuMusicVolume = 65;
			FI.fifaGameSettings_GcGkAbilityCpu = 66;
			FI.fifaGameSettings_KinFormation4 = 67;
			FI.fifaGameSettings_Offsides = 68;
			FI.fifaGameSettings_CamProSpeed = 69;
			FI.fifaGameSettings_GameSettingsPK = 70;
			FI.fifaGameSettings_HalfLength = 71;
			FI.fifaGameSettings_KinFutFormation5 = 72;
			FI.fifaGameSettings_CommentaryTeam = 73;
			FI.fifaGameSettings_GcPosFullbackPositioningCpu = 74;
			FI.fifaGameSettings_PosIndicator = 75;
			FI.fifaGameSettings_CamSingle = 76;
			FI.fifaGameSettings_NumOfSubs = 77;
			FI.fifaGameSettings_GcPassSpeedUser = 78;
			FI.fifaGameSettings_CamBeAPro = 79;
			FI.fifaGameSettings_BallTrailIndicator = 80;
			FI.fifaGameSettings_CamProSwing = 81;
			FI.fifaGameSettings_NetTension = 82;
			FI.fifaGameSettings_UserChantsVolume = 83;
			FI.fifaGameSettings_CrowdVolume = 84;
			FI.fifaGameSettings_DynamicTimeOfDay = 85;
			FI.fifaGameSettings_CamProZoom = 86;
			FI.fifaGameSettings_AutoSave = 87;
			FI.fifaGameSettings_KinFormation3 = 88;
			FI.fifaGameSettings_KinFutFormation3 = 89;
			FI.fifaGameSettings_GcInjuryFrequencyCpu = 90;
			FI.fifaGameSettings_NIB = 91;
			FI.fifaGameSettings_GcPosDefensiveLineHeightUser = 92;
			FI.fifaGameSettings_ThreatIndicator = 93;
			FI.fifaGameSettings_PlayerCalls = 94;
			FI.fifaGameSettings_Injuries = 95;
			FI.fifaGameSettings_CamZoomHeightEnable = 96;
			FI.fifaGameSettings_StadiumNameInfo = 98;
			FI.fifaGameSettings_KinFutFormation4 = 99;
			FI.fifaGameSettings_CamZoom = 100;
			FI.fifaGameSettings_CamMulti = 101;
			FI.fifaGameSettings_KinRefereeHearing = 102;
			FI.fifaGameSettings_AwayAutoSwitch = 103;
			FI.fifaGameSettings_AudioSetup = 104;
			FI.fifaGameSettings_Weather = 105;
			FI.fifaGameSettings_GcInjurySeverityCpu = 106;
			FI.fifaGameSettings_Avatar = 107;
			FI.fifaGameSettings_Referee_ID = 108;
			FI.fifaGameSettings_Radar = 109;
			FI.fifaGameSettings_HomeAutoSwitch = 110;
			FI.fifaGameSettings_CPUPlayerStatus = 111;
			FI.fifaGameSettings_Brightness = 112;
			FI.fifaGameSettings_KinFormation1 = 113;
			FI.fifaGameSettings_BallFutureTrajectoryIndicator = 114;
			FI.fifaGameSettings_GenericSetting2 = 115;
			FI.fifaGameSettings_TimeOfDay = 116;
			FI.fifaGameSettings_ExtraTime = 117;
			FI.fifaGameSettings_lm_LoungeStadium = 118;
			FI.fifaGameSettings_KinSpeechRecognition = 119;
			FI.fifaGameSettings_KinComboMentality = 120;
			FI.fifaGameSettings_NIBState = 121;
			FI.fifaGameSettings_Bookings = 122;
			FI.fifaGameSettings_GcPosLineLengthUser = 123;
			FI.fifaGameSettings_GcPosLineWidthUser = 124;
			FI.fifaGameSettings_GenericSetting1 = 125;
			FI.fifaGameSettings_GcShotErrorUser = 126;
			FI.fifaGameSettings_CommentaryLanguage = 127;
			FI.fifaGameSettings_GcAccelerationCpu = 128;
			FI.fifaGameSettings_GcPosRunFrequencyUser = 129;
			FI.fifaGameSettings_KinCustomTactic = 130;
			FI.fifaGameSettings_KinComboTactic = 131;
			FI.fifaGameSettings_PlayerStatusBar = 132;
			FI.fifaGameSettings_GcPosMarkingUser = 133;
			FI.fifaGameSettings_RadarLocation = 134;
			FI.fifaGameSettings_OwnOnlineGamerTag = 135;
			FI.fifaGameSettings_GameFXVolume = 136;
			FI.fifaGameSettings_GcPosMarkingCpu = 137;
			FI.fifaGameSettings_CamBeAKeeper = 138;
			FI.fifaGameSettings_lm_MatchUpSetting = 139;
			FI.fifaGameSettings_GameSpeed = 140;
			FI.fifaGameSettings_ShootSwitching = 141;
			FI.fifaGameSettings_MovAssistedPathFinding = 142;
			FI.mls_fixtures_fixture_id = 2;
			FI.mls_fixtures_rtsg = 4;
			FI.mls_fixtures_away_id = 0;
			FI.mls_fixtures_home_score = 1;
			FI.mls_fixtures_date = 3;
			FI.mls_fixtures_game_flags = 5;
			FI.mls_fixtures_away_score = 6;
			FI.mls_fixtures_home_id = 7;
			FI.customteamstyles_defmentality = 0;
			FI.customteamstyles_teamstyleid = 1;
			FI.customteamstyles_basestyle = 2;
			FI.customteamstyles_buspassing = 3;
			FI.customteamstyles_defteamwidth = 4;
			FI.customteamstyles_defaggression = 5;
			FI.customteamstyles_buspositioning = 6;
			FI.customteamstyles_ccpositioning = 7;
			FI.customteamstyles_busbuildupspeed = 8;
			FI.customteamstyles_ccshooting = 9;
			FI.customteamstyles_ccpassing = 10;
			FI.customteamstyles_defdefenderline = 11;
			FI.customteamstyles_cccrossing = 12;
			FI.teamformationteamstylelinks_teamstyleid = 0;
			FI.teamformationteamstylelinks_teamid = 1;
			FI.teamformationteamstylelinks_formationid = 2;
			FI.teamformationteamstylelinks_cddl = 3;
			FI.career_news_body = 0;
			FI.career_news_image = 1;
			FI.career_news_title = 2;
			FI.career_news_importance = 0;
			FI.career_news_date = 1;
			FI.career_news_teamid = 2;
			FI.career_news_playerid = 3;
			FI.career_news_crest = 4;
			FI.career_news_newsid = 5;
			FI.career_news_emotion = 6;
			FI.career_news_type = 7;
			FI.career_newspicweights_maxvariationspos = 0;
			FI.career_newspicweights_maxvariationsstd = 1;
			FI.career_newspicweights_maxvariationsneg = 2;
			FI.career_newspicweights_crestweight = 3;
			FI.career_newspicweights_teamweight = 4;
			FI.career_newspicweights_teamid = 5;
			FI.career_newspicweights_genericweight = 6;
			FI.career_newsban_artificialkey = 1;
			FI.career_newsban_newstype = 2;
			FI.career_newsban_compobjid = 0;
			FI.career_newsban_teamid = 3;
			FI.persistent_events_MiscValue = 6;
			FI.persistent_events_Team2Id = 0;
			FI.persistent_events_Id = 1;
			FI.persistent_events_CompObjId = 2;
			FI.persistent_events_EventId = 3;
			FI.persistent_events_Team1Id = 4;
			FI.persistent_events_EventDate = 5;
			FI.persistent_events_Player1Id = 7;
			FI.career_playasplayer_numwithdrawrequests = 0;
			FI.career_playasplayer_numconsecclubbenched = 1;
			FI.career_playasplayer_lastwithdrawdate = 2;
			FI.career_playasplayer_playedlastmatch = 3;
			FI.career_playasplayer_numtransferrequests = 4;
			FI.career_playasplayer_requestactiondays = 5;
			FI.career_playasplayer_position = 6;
			FI.career_playasplayer_playerrequest = 7;
			FI.career_playasplayer_numloanrequests = 8;
			FI.career_playasplayer_numconsecnatbenched = 9;
			FI.career_playasplayer_playerid = 10;
			FI.career_playasplayer_userid = 11;
			FI.career_playerbonusper_bonus_per_15 = 0;
			FI.career_playerbonusper_clubleveltype = 1;
			FI.career_playerbonusper_bonus_per_5 = 2;
			FI.career_playerbonusper_bonus_per_20 = 3;
			FI.career_playerbonusper_bonus_per_0 = 4;
			FI.career_playerbonusper_bonus_per_10 = 5;
			FI.career_playasplayerhistory_goals = 0;
			FI.career_playasplayerhistory_saves = 1;
			FI.career_playasplayerhistory_totaltackles = 3;
			FI.career_playasplayerhistory_tacklesontarget = 7;
			FI.career_playasplayerhistory_totalshots = 9;
			FI.career_playasplayerhistory_totalpasses = 14;
			FI.career_playasplayerhistory_motm = 16;
			FI.career_playasplayerhistory_fouls = 26;
			FI.career_playasplayerhistory_saveattemps = 28;
			FI.career_playasplayerhistory_shotsontarget = 30;
			FI.career_playasplayerhistory_passesontarget = 34;
			FI.career_playasplayerhistory_continentalcuptrophies = 2;
			FI.career_playasplayerhistory_totalreds = 4;
			FI.career_playasplayerhistory_draws = 5;
			FI.career_playasplayerhistory_season = 6;
			FI.career_playasplayerhistory_leaguetrophies = 8;
			FI.career_playasplayerhistory_loses = 10;
			FI.career_playasplayerhistory_playasplayerhistoryid = 11;
			FI.career_playasplayerhistory_domesticcuptrophies = 12;
			FI.career_playasplayerhistory_wins = 13;
			FI.career_playasplayerhistory_leagueid = 15;
			FI.career_playasplayerhistory_appearances = 17;
			FI.career_playasplayerhistory_overall = 18;
			FI.career_playasplayerhistory_wage = 19;
			FI.career_playasplayerhistory_value = 20;
			FI.career_playasplayerhistory_assists = 21;
			FI.career_playasplayerhistory_matchratings = 22;
			FI.career_playasplayerhistory_cleansheets = 23;
			FI.career_playasplayerhistory_position = 24;
			FI.career_playasplayerhistory_goalsconceded = 25;
			FI.career_playasplayerhistory_teamid = 27;
			FI.career_playasplayerhistory_totalyellows = 29;
			FI.career_playasplayerhistory_clublevel = 31;
			FI.career_playasplayerhistory_tableposition = 32;
			FI.career_playasplayerhistory_userid = 33;
			FI.career_growthcurveinfo_physicalcurveid = 0;
			FI.career_growthcurveinfo_physicalcurveoffset = 1;
			FI.career_growthcurveinfo_mentalcurveid = 2;
			FI.career_growthcurveinfo_skillcurveoffset = 3;
			FI.career_growthcurveinfo_mentalcurveoffset = 4;
			FI.career_growthcurveinfo_playerid = 5;
			FI.career_growthcurveinfo_skillcurveid = 6;
			FI.player_growth_experience_points_skill_xp = 0;
			FI.player_growth_experience_points_potential = 1;
			FI.player_growth_experience_points_mental_xp = 2;
			FI.player_growth_experience_points_physical_xp = 3;
			FI.player_growth_experience_points_playerid = 0;
			FI.player_career_season_num = 0;
			FI.player_career_overall = 1;
			FI.player_career_artificialkey = 2;
			FI.player_career_playerid = 3;
			FI.experiencepoints_createplayer_xp = 0;
			FI.experiencepoints_playerid = 1;
			FI.career_playergrowthuserseason_curve = 0;
			FI.career_playergrowthuserseason_agility = 1;
			FI.career_playergrowthuserseason_positioning = 2;
			FI.career_playergrowthuserseason_standingtackle = 3;
			FI.career_playergrowthuserseason_longpassing = 4;
			FI.career_playergrowthuserseason_penalties = 5;
			FI.career_playergrowthuserseason_longshots = 6;
			FI.career_playergrowthuserseason_gkdiving = 7;
			FI.career_playergrowthuserseason_interceptions = 8;
			FI.career_playergrowthuserseason_crossing = 9;
			FI.career_playergrowthuserseason_gkreflexes = 10;
			FI.career_playergrowthuserseason_reactions = 11;
			FI.career_playergrowthuserseason_vision = 12;
			FI.career_playergrowthuserseason_finishing = 13;
			FI.career_playergrowthuserseason_dribspeed = 14;
			FI.career_playergrowthuserseason_dribbling = 15;
			FI.career_playergrowthuserseason_slidingtackle = 16;
			FI.career_playergrowthuserseason_sprintspeed = 17;
			FI.career_playergrowthuserseason_strength = 18;
			FI.career_playergrowthuserseason_ballcontrol = 19;
			FI.career_playergrowthuserseason_shotpower = 20;
			FI.career_playergrowthuserseason_balance = 21;
			FI.career_playergrowthuserseason_gkkicking = 22;
			FI.career_playergrowthuserseason_shortpassing = 23;
			FI.career_playergrowthuserseason_freekickaccuracy = 24;
			FI.career_playergrowthuserseason_aggression = 25;
			FI.career_playergrowthuserseason_acceleration = 26;
			FI.career_playergrowthuserseason_headingaccuracy = 27;
			FI.career_playergrowthuserseason_gkhandling = 28;
			FI.career_playergrowthuserseason_jumping = 29;
			FI.career_playergrowthuserseason_stamina = 30;
			FI.career_playergrowthuserseason_playerid = 31;
			FI.career_playergrowthuserseason_marking = 32;
			FI.career_playergrowthuserseason_gkpositioning = 33;
			FI.career_playergrowthuserseason_volleys = 34;
			FI.career_playergrowthupdates_notifygrowth = 0;
			FI.career_playergrowthupdates_playerid = 1;
			FI.career_playergrowthhistory_startingoverall = 0;
			FI.career_playergrowthhistory_startingage = 1;
			FI.career_playergrowthhistory_playerid = 2;
			FI.finalstadiums_leagueid = 0;
			FI.finalstadiums_final_stadium = 1;
			FI.tourn_team_manager_rt = 1;
			FI.tourn_team_manager_teamid = 0;
			FI.tourn_team_manager_outcome = 2;
			FI.tourn_team_manager_points = 3;
			FI.tourn_settings_setting_value = 0;
			FI.tourn_settings_setting_code = 0;
			FI.tourn_settings_setting_id = 1;
			FI.tourn_rtsg_rtsg = 0;
			FI.tourn_rtsg_tournid = 1;
			FI.tourn_manager_settings_mLastSimulatedUserFixture = 20;
			FI.tourn_manager_settings_setting_4 = 0;
			FI.tourn_manager_settings_setting_7 = 2;
			FI.tourn_manager_settings_TournamentName = 0;
			FI.tourn_manager_settings_setting_9 = 3;
			FI.tourn_manager_settings_setting_0 = 4;
			FI.tourn_manager_settings_setting_18 = 5;
			FI.tourn_manager_settings_setting_8 = 6;
			FI.tourn_manager_settings_setting_6 = 8;
			FI.tourn_manager_settings_setting_16 = 10;
			FI.tourn_manager_settings_setting_11 = 11;
			FI.tourn_manager_settings_setting_17 = 12;
			FI.tourn_manager_settings_setting_1 = 13;
			FI.tourn_manager_settings_setting_13 = 14;
			FI.tourn_manager_settings_setting_10 = 15;
			FI.tourn_manager_settings_setting_14 = 18;
			FI.tourn_manager_settings_setting_2 = 19;
			FI.tourn_manager_settings_setting_12 = 21;
			FI.tourn_manager_settings_setting_5 = 22;
			FI.tourn_manager_settings_setting_3 = 23;
			FI.tourn_manager_settings_setting_15 = 24;
			FI.tourn_manager_settings_NumTeamsInTournament = 1;
			FI.tourn_manager_settings_TournamentStarted = 7;
			FI.tourn_manager_settings_IsSimulating = 9;
			FI.tourn_manager_settings_setting_id = 16;
			FI.tourn_manager_settings_ActiveTournamentID = 17;
			FI.tourn_licensed_stages_lt_numlegs = 0;
			FI.tourn_licensed_stages_lt_league3 = 1;
			FI.tourn_licensed_stages_lt_stage_num = 2;
			FI.tourn_licensed_stages_lt_id = 3;
			FI.tourn_licensed_stages_lt_league2 = 4;
			FI.tourn_licensed_stages_lt_league4 = 5;
			FI.tourn_licensed_stages_lt_num_teams_in_stage = 6;
			FI.tourn_licensed_stages_lt_league5 = 7;
			FI.tourn_licensed_stages_lt_drawtype = 8;
			FI.tourn_licensed_stages_lt_league6 = 9;
			FI.tourn_licensed_stages_lt_league1 = 10;
			FI.tourn_licensed_stages_lt_num_bye_teams = 11;
			FI.tourn_licensed_lt_num_teams_to_advance = 0;
			FI.tourn_licensed_lt_id = 1;
			FI.tourn_licensed_lt_away_goal_rules = 2;
			FI.tourn_licensed_lt_num_stages = 3;
			FI.tourn_licensed_lt_yellow_card_rule = 4;
			FI.tourn_licensed_lt_num_unique_teams = 5;
			FI.tourn_licensed_lt_tourn_type = 6;
			FI.tourn_licensed_lt_country = 7;
			FI.tourn_licensed_lt_redcard_ban = 8;
			FI.tourn_licensed_lt_num_teams_per_group = 9;
			FI.tourn_licensed_lt_starting_subs = 10;
			FI.tourn_licensed_lt_assetid = 11;
			FI.tourn_licensed_lt_first_stage_is_KO = 12;
			FI.specialteams_teamtype = 0;
			FI.specialteams_originalteamid = 1;
			FI.specialteams_teamid = 2;
			FI.stadiumassignments_stadiumcustomname = 0;
			FI.stadiumassignments_teamid = 0;
			FI.factory_teams_assetid = 14;
			FI.factory_teams_balltype = 1;
			FI.factory_teams_teamcolor1g = 3;
			FI.factory_teams_teamcolor1r = 6;
			FI.factory_teams_teamcolor2b = 9;
			FI.factory_teams_teamcolor2r = 17;
			FI.factory_teams_teamcolor3r = 27;
			FI.factory_teams_teamcolor1b = 29;
			FI.factory_teams_latitude = 32;
			FI.factory_teams_teamcolor3g = 36;
			FI.factory_teams_teamcolor2g = 48;
			FI.factory_teams_teamname = 0;
			FI.factory_teams_adboardid = 56;
			FI.factory_teams_teamcolor3b = 59;
			FI.factory_teams_defmentality = 0;
			FI.factory_teams_powid = 2;
			FI.factory_teams_physioid_secondary = 4;
			FI.factory_teams_domesticprestige = 5;
			FI.factory_teams_genericint2 = 7;
			FI.factory_teams_jerseytype = 8;
			FI.factory_teams_rivalteam = 10;
			FI.factory_teams_midfieldrating = 11;
			FI.factory_teams_matchdayoverallrating = 12;
			FI.factory_teams_matchdaymidfieldrating = 13;
			FI.factory_teams_attackrating = 15;
			FI.factory_teams_physioid_primary = 16;
			FI.factory_teams_longitude = 18;
			FI.factory_teams_buspassing = 19;
			FI.factory_teams_matchdaydefenserating = 20;
			FI.factory_teams_defenserating = 21;
			FI.factory_teams_defteamwidth = 22;
			FI.factory_teams_longkicktakerid = 23;
			FI.factory_teams_bodytypeid = 24;
			FI.factory_teams_rightcornerkicktakerid = 25;
			FI.factory_teams_suitvariationid = 26;
			FI.factory_teams_defaggression = 28;
			FI.factory_teams_ethnicity = 30;
			FI.factory_teams_leftcornerkicktakerid = 31;
			FI.factory_teams_teamid = 33;
			FI.factory_teams_fancrowdhairskintexturecode = 34;
			FI.factory_teams_suittypeid = 35;
			FI.factory_teams_numtransfersin = 37;
			FI.factory_teams_captainid = 38;
			FI.factory_teams_personalityid = 39;
			FI.factory_teams_genericbanner = 40;
			FI.factory_teams_buspositioning = 41;
			FI.factory_teams_stafftracksuitcolorcode = 42;
			FI.factory_teams_ccpositioning = 43;
			FI.factory_teams_busbuildupspeed = 44;
			FI.factory_teams_transferbudget = 45;
			FI.factory_teams_ccshooting = 46;
			FI.factory_teams_overallrating = 47;
			FI.factory_teams_ccpassing = 49;
			FI.factory_teams_utcoffset = 50;
			FI.factory_teams_penaltytakerid = 51;
			FI.factory_teams_freekicktakerid = 52;
			FI.factory_teams_defdefenderline = 53;
			FI.factory_teams_internationalprestige = 54;
			FI.factory_teams_form = 55;
			FI.factory_teams_genericint1 = 57;
			FI.factory_teams_cccrossing = 58;
			FI.factory_teams_matchdayattackrating = 60;
			FI.temp_createplayer_cpmorphcomposite_noseprofile_protrusion_lsx = 0;
			FI.temp_createplayer_cpmorphcomposite_eyedetail1_folds_lsy = 1;
			FI.temp_createplayer_cpmorphcomposite_mouthposition_protrusion_rsx = 2;
			FI.temp_createplayer_cpmorphcomposite_nostrildetail_height_lsy = 3;
			FI.temp_createplayer_cpmorphcomposite_browshape_protrusion_rsx = 4;
			FI.temp_createplayer_cpmorphcomposite_browshape_tilt_lsy = 5;
			FI.temp_createplayer_cpmorphcomposite_earplacement_height_lsy = 6;
			FI.temp_createplayer_cpmorphcomposite_cheekplacement_position_lsy = 7;
			FI.temp_createplayer_cpmorphcomposite_eyeshape_shape_rsx = 8;
			FI.temp_createplayer_cpmorphcomposite_lips_upperlip_shape_lsx = 9;
			FI.temp_createplayer_cpmorphcomposite_eyeshape_height_lsy = 10;
			FI.temp_createplayer_cpmorphcomposite_mouthposition_bite_rsy = 11;
			FI.temp_createplayer_cpmorphcomposite_cheekstyle_blemishes_rsx = 12;
			FI.temp_createplayer_cpmorphcomposite_nostrils_height_lsy = 13;
			FI.temp_createplayer_cpmorphcomposite_mouthblemishes_lsx = 14;
			FI.temp_createplayer_cpmorphcomposite_earstyle_lobe_lsx = 15;
			FI.temp_createplayer_cpmorphcomposite_mouthposition_width_lsx = 16;
			FI.temp_createplayer_cpmorphcomposite_eyeshape_tilt_rsy = 17;
			FI.temp_createplayer_cpmorphcomposite_noseprofile_tipshape_rsy = 18;
			FI.temp_createplayer_cpmorphcomposite_browplacement_thickness_rsy = 19;
			FI.temp_createplayer_cpmorphcomposite_noseplacement_position_lsy = 20;
			FI.temp_createplayer_cpmorphcomposite_eyeshape_seperation_lsx = 21;
			FI.temp_createplayer_cpmorphcomposite_noseprofile_tipprotrusion_rsx = 22;
			FI.temp_createplayer_cpmorphcomposite_cheekplacement_width_lsx = 23;
			FI.temp_createplayer_cpmorphcomposite_laughlinedarkness_lsx = 24;
			FI.temp_createplayer_cpmorphcomposite_jaw_position_lsy = 25;
			FI.temp_createplayer_cpmorphcomposite_browplacement_protrusion_rsx = 26;
			FI.temp_createplayer_cpmorphcomposite_eyedetail2_lowerlid_lsx = 27;
			FI.temp_createplayer_cpmorphcomposite_lips_upperlip_thickness_lsy = 28;
			FI.temp_createplayer_cpmorphcomposite_noseprofile_shape_lsy = 29;
			FI.temp_createplayer_cpmorphcomposite_lips_lowerlip_thickness_rsy = 30;
			FI.temp_createplayer_cpmorhpcomposite_chin_width_lsx = 31;
			FI.temp_createplayer_cpmorphcomposite_nosestyle_nosestyle_lsx = 32;
			FI.temp_createplayer_cpmorphcomposite_mouthposition_position_lsy = 33;
			FI.temp_createplayer_cpmorphcomposite_earplacement_protrusion_lsx = 34;
			FI.temp_createplayer_cpmorphcomposite_dimpledarkness_lsx = 35;
			FI.temp_createplayer_cpmorphcomposite_noseplacement_width_rsx = 36;
			FI.temp_createplayer_cpmorphcomposite_eyedetail2_protrusion_rsy = 37;
			FI.temp_createplayer_cpmorphcomposite_lipstyle_corners_lipdimple_rsx = 38;
			FI.temp_createplayer_cpmorphcomposite_lips_lowerlip_thickness_rsx = 39;
			FI.temp_createplayer_cpmorphcomposite_browplacement_position_lsy = 40;
			FI.temp_createplayer_cpmorhpcomposite_chin_postion_lsy = 41;
			FI.temp_createplayer_cpmorphcomposite_lipstyle_corners_updown_lsy = 42;
			FI.temp_createplayer_cpmorphcomposite_eyedetail1_protrusion_rsx = 43;
			FI.temp_createplayer_cpmorphcomposite_browshape_seperation_lsx = 44;
			FI.temp_createplayer_cpmorphcomposite_jaw_bulk_rsx = 45;
			FI.temp_createplayer_cpmorphcomposite_noseplacement_width_lsx = 46;
			FI.temp_createplayer_cpmorphcomposite_eyedetail1_symmetry_lsx = 47;
			FI.temp_createplayer_cpmorphcomposite_nostrils_width_lsx = 48;
			FI.temp_createplayer_cpmorphcomposite_eyedetail2_upperlid_lsy = 49;
			FI.temp_createplayer_cpmorphcomposite_lipstyle_corners_leftright_lsx = 50;
			FI.temp_createplayer_cpmorphcomposite_browplacement_tilt_lsx = 51;
			FI.temp_createplayer_cpmorphcomposite_jaw_width_lsx = 52;
			FI.temp_createplayer_cpmorphcomposite_browshape_thickness_rsy = 53;
			FI.temp_createplayer_cpmorhpcomposite_chin_protrusion_rsx = 54;
			FI.temp_createplayer_cpmorphcomposite_noseplacement_position_rsy = 55;
			FI.temp_createplayer_cpmorphcomposite_nostrildetail_width_lsx = 56;
			FI.temp_createplayer_cpmorphcomposite_cheekstyle_style_lsx = 57;
			FI.temp_createplayer_cpmorhpcomposite_chin_deatil_rsy = 58;
			FI.temp_createplayer_create_originalplayerid = 0;
			FI.temp_createplayer_create_playerid = 1;
			FI.temp_createplayer_cpattributename_hair_colour = 2;
			FI.temp_createplayer_cpattributename_hair_style = 3;
			FI.temp_createplayer_celebrationid = 4;
			FI.temp_createplayer_cpattributename_brow_style = 5;
			FI.temp_createplayer_cpattributename_eye_colour = 6;
			FI.temp_createplayer_create_artificialkey = 7;
			FI.temp_createplayer_commentaryid = 8;
			FI.temp_createplayer_cpattributename_facial_hair_style = 9;
			FI.temp_createplayer_cpattributename_brow_colour = 10;
			FI.temp_createplayer_cpattributename_facial_hair_colour = 11;
			FI.temp_arenacreateplayer_cpmorphcomposite_noseprofile_protrusion_lsx = 0;
			FI.temp_arenacreateplayer_cpmorphcomposite_eyedetail1_folds_lsy = 1;
			FI.temp_arenacreateplayer_cpmorphcomposite_mouthposition_protrusion_rsx = 2;
			FI.temp_arenacreateplayer_cpmorphcomposite_nostrildetail_height_lsy = 3;
			FI.temp_arenacreateplayer_cpmorphcomposite_browshape_protrusion_rsx = 4;
			FI.temp_arenacreateplayer_cpmorphcomposite_browshape_tilt_lsy = 5;
			FI.temp_arenacreateplayer_cpmorphcomposite_earplacement_height_lsy = 6;
			FI.temp_arenacreateplayer_cpmorphcomposite_cheekplacement_position_lsy = 7;
			FI.temp_arenacreateplayer_cpmorphcomposite_eyeshape_shape_rsx = 8;
			FI.temp_arenacreateplayer_cpmorphcomposite_lips_upperlip_shape_lsx = 9;
			FI.temp_arenacreateplayer_cpmorphcomposite_eyeshape_height_lsy = 10;
			FI.temp_arenacreateplayer_cpmorphcomposite_mouthposition_bite_rsy = 11;
			FI.temp_arenacreateplayer_cpmorphcomposite_cheekstyle_blemishes_rsx = 12;
			FI.temp_arenacreateplayer_cpmorphcomposite_nostrils_height_lsy = 13;
			FI.temp_arenacreateplayer_cpmorphcomposite_mouthblemishes_lsx = 14;
			FI.temp_arenacreateplayer_cpmorphcomposite_earstyle_lobe_lsx = 15;
			FI.temp_arenacreateplayer_cpmorphcomposite_mouthposition_width_lsx = 16;
			FI.temp_arenacreateplayer_cpmorphcomposite_eyeshape_tilt_rsy = 17;
			FI.temp_arenacreateplayer_cpmorphcomposite_noseprofile_tipshape_rsy = 18;
			FI.temp_arenacreateplayer_cpmorphcomposite_browplacement_thickness_rsy = 19;
			FI.temp_arenacreateplayer_cpmorphcomposite_noseplacement_position_lsy = 20;
			FI.temp_arenacreateplayer_cpmorphcomposite_eyeshape_seperation_lsx = 21;
			FI.temp_arenacreateplayer_cpmorphcomposite_noseprofile_tipprotrusion_rsx = 22;
			FI.temp_arenacreateplayer_cpmorphcomposite_cheekplacement_width_lsx = 23;
			FI.temp_arenacreateplayer_cpmorphcomposite_laughlinedarkness_lsx = 24;
			FI.temp_arenacreateplayer_cpmorphcomposite_jaw_position_lsy = 25;
			FI.temp_arenacreateplayer_cpmorphcomposite_browplacement_protrusion_rsx = 26;
			FI.temp_arenacreateplayer_cpmorphcomposite_eyedetail2_lowerlid_lsx = 27;
			FI.temp_arenacreateplayer_cpmorphcomposite_lips_upperlip_thickness_lsy = 28;
			FI.temp_arenacreateplayer_cpmorphcomposite_noseprofile_shape_lsy = 29;
			FI.temp_arenacreateplayer_cpmorphcomposite_lips_lowerlip_thickness_rsy = 30;
			FI.temp_arenacreateplayer_cpmorhpcomposite_chin_width_lsx = 31;
			FI.temp_arenacreateplayer_cpmorphcomposite_nosestyle_nosestyle_lsx = 32;
			FI.temp_arenacreateplayer_cpmorphcomposite_mouthposition_position_lsy = 33;
			FI.temp_arenacreateplayer_cpmorphcomposite_earplacement_protrusion_lsx = 34;
			FI.temp_arenacreateplayer_cpmorphcomposite_dimpledarkness_lsx = 35;
			FI.temp_arenacreateplayer_cpmorphcomposite_noseplacement_width_rsx = 36;
			FI.temp_arenacreateplayer_cpmorphcomposite_eyedetail2_protrusion_rsy = 37;
			FI.temp_arenacreateplayer_cpmorphcomposite_lipstyle_corners_lipdimple_rsx = 38;
			FI.temp_arenacreateplayer_cpmorphcomposite_lips_lowerlip_thickness_rsx = 39;
			FI.temp_arenacreateplayer_cpmorphcomposite_browplacement_position_lsy = 40;
			FI.temp_arenacreateplayer_cpmorhpcomposite_chin_postion_lsy = 41;
			FI.temp_arenacreateplayer_cpmorphcomposite_lipstyle_corners_updown_lsy = 42;
			FI.temp_arenacreateplayer_cpmorphcomposite_eyedetail1_protrusion_rsx = 43;
			FI.temp_arenacreateplayer_cpmorphcomposite_browshape_seperation_lsx = 44;
			FI.temp_arenacreateplayer_cpmorphcomposite_jaw_bulk_rsx = 45;
			FI.temp_arenacreateplayer_cpmorphcomposite_noseplacement_width_lsx = 46;
			FI.temp_arenacreateplayer_cpmorphcomposite_eyedetail1_symmetry_lsx = 47;
			FI.temp_arenacreateplayer_cpmorphcomposite_nostrils_width_lsx = 48;
			FI.temp_arenacreateplayer_cpmorphcomposite_eyedetail2_upperlid_lsy = 49;
			FI.temp_arenacreateplayer_cpmorphcomposite_lipstyle_corners_leftright_lsx = 50;
			FI.temp_arenacreateplayer_cpmorphcomposite_browplacement_tilt_lsx = 51;
			FI.temp_arenacreateplayer_cpmorphcomposite_jaw_width_lsx = 52;
			FI.temp_arenacreateplayer_cpmorphcomposite_browshape_thickness_rsy = 53;
			FI.temp_arenacreateplayer_cpmorhpcomposite_chin_protrusion_rsx = 54;
			FI.temp_arenacreateplayer_cpmorphcomposite_noseplacement_position_rsy = 55;
			FI.temp_arenacreateplayer_cpmorphcomposite_nostrildetail_width_lsx = 56;
			FI.temp_arenacreateplayer_cpmorphcomposite_cheekstyle_style_lsx = 57;
			FI.temp_arenacreateplayer_cpmorhpcomposite_chin_deatil_rsy = 58;
			FI.temp_arenacreateplayer_create_originalplayerid = 0;
			FI.temp_arenacreateplayer_create_playerid = 1;
			FI.temp_arenacreateplayer_cpattributename_hair_colour = 2;
			FI.temp_arenacreateplayer_cpattributename_hair_style = 3;
			FI.temp_arenacreateplayer_celebrationid = 4;
			FI.temp_arenacreateplayer_cpattributename_brow_style = 5;
			FI.temp_arenacreateplayer_cpattributename_eye_colour = 6;
			FI.temp_arenacreateplayer_create_artificialkey = 7;
			FI.temp_arenacreateplayer_commentaryid = 8;
			FI.temp_arenacreateplayer_cpattributename_facial_hair_style = 9;
			FI.temp_arenacreateplayer_cpattributename_brow_colour = 10;
			FI.temp_arenacreateplayer_cpattributename_facial_hair_colour = 11;
			FI.career_blacklist_permanent = 0;
			FI.career_blacklist_playerid = 1;
			FI.career_transferoffer_startdate = 8;
			FI.career_transferoffer_date = 11;
			FI.career_transferoffer_offerteamid = 0;
			FI.career_transferoffer_approachreason = 1;
			FI.career_transferoffer_offerid = 2;
			FI.career_transferoffer_stage = 3;
			FI.career_transferoffer_isCPUTransfer = 4;
			FI.career_transferoffer_exchangeplayerid = 5;
			FI.career_transferoffer_offeredfee = 6;
			FI.career_transferoffer_counteroffers = 7;
			FI.career_transferoffer_offeredwage = 9;
			FI.career_transferoffer_currentcontractlength = 10;
			FI.career_transferoffer_result = 12;
			FI.career_transferoffer_desiredFee = 13;
			FI.career_transferoffer_isloanbuy = 14;
			FI.career_transferoffer_teamid = 15;
			FI.career_transferoffer_offeredcontracttype = 16;
			FI.career_transferoffer_valuation = 17;
			FI.career_transferoffer_snipedteamid = 18;
			FI.career_transferoffer_playerid = 19;
			FI.career_transferoffer_squadrole = 20;
			FI.career_transferoffer_issnipe = 21;
			FI.career_transferoffer_transferwindow = 22;
			FI.career_transferoffer_isloan = 23;
			FI.career_transferoffer_offeredbonus = 24;
			FI.career_transferlist_leagueid = 0;
			FI.career_transferlist_preferredposition1 = 1;
			FI.career_transferlist_pitcharea = 2;
			FI.career_transferlist_teamid = 3;
			FI.career_transferlist_playerid = 4;
			FI.career_transferlist_overallrating = 5;
			FI.career_transferlist_potentialtype = 6;
			FI.career_playercontract_offered_wage = 0;
			FI.career_playercontract_salary_demand = 1;
			FI.career_playercontract_offered_bonus = 2;
			FI.career_playercontract_contract_status = 3;
			FI.career_playercontract_contract_status_change_date = 4;
			FI.career_playercontract_wage = 5;
			FI.career_playercontract_extension_years = 6;
			FI.career_playercontract_teamid = 7;
			FI.career_playercontract_negotiation_status = 8;
			FI.career_playercontract_bonus = 9;
			FI.career_playercontract_negotiation_date = 10;
			FI.career_playercontract_playerid = 11;
			FI.career_loanbuy_future_fee = 0;
			FI.career_loanbuy_stage = 1;
			FI.career_loanbuy_playerid = 2;
			FI.achievements_orderAchieved = 0;
			FI.achievements_isDisplayed = 1;
			FI.achievements_achievementID = 2;
			FI.achievements_isAchieved = 3;
			FI.fifaUnlockables_AccompString = 0;
			FI.fifaUnlockables_TournString = 1;
			FI.fifaUnlockables_TeamString = 2;
			FI.fifaUnlockables_UnlockableString = 3;
			FI.fifaUnlockables_ItemId = 0;
			FI.fifaUnlockables_ItemType = 1;
			FI.fifaUnlockables_AssetId = 2;
			FI.fifaUnlockables_KOTeams = 3;
			FI.fifaUnlockables_UnlockableID = 4;
			FI.fifaUnlockables_Price = 5;
			FI.fifaUnlockables_Locked = 6;
			FI.usability_title = 0;
			FI.usability_body_text = 1;
			FI.usability_usability_id = 0;
			FI.usability_button_3 = 1;
			FI.usability_button_4 = 2;
			FI.usability_button_1 = 3;
			FI.usability_difficulty = 4;
			FI.usability_button_2 = 5;
			FI.usability_type = 6;
			FI.usability_functions_funct_text = 0;
			FI.usability_functions_action_cnt = 0;
			FI.usability_functions_button_id = 1;
			FI.usability_functions_arrow = 2;
			FI.usability_functions_funct = 3;
			FI.virtualleagues_name = 0;
			FI.virtualleagues_id = 0;
			FI.virtualleagues_dbleagueid = 1;
			FI.career_namesgroups_nationality = 0;
			FI.career_namesgroups_groupid = 1;
			FI.career_youthplayers_playertier = 0;
			FI.career_youthplayers_playertype = 1;
			FI.career_youthplayers_swinglowpotential = 2;
			FI.career_youthplayers_potentialvariance = 3;
			FI.career_youthplayers_playerid = 4;
			FI.career_youthplayers_monthsinsquad = 5;
			FI.career_youthplayerhistory_goals = 0;
			FI.career_youthplayerhistory_appearances = 1;
			FI.career_youthplayerhistory_playerid = 2;
			FI.career_youthplayerattributes_playertier = 0;
			FI.career_youthplayerattributes_curve = 1;
			FI.career_youthplayerattributes_agility = 2;
			FI.career_youthplayerattributes_positioning = 3;
			FI.career_youthplayerattributes_playertype = 4;
			FI.career_youthplayerattributes_standingtackle = 5;
			FI.career_youthplayerattributes_longpassing = 6;
			FI.career_youthplayerattributes_penalties = 7;
			FI.career_youthplayerattributes_longshots = 8;
			FI.career_youthplayerattributes_gkdiving = 9;
			FI.career_youthplayerattributes_interceptions = 10;
			FI.career_youthplayerattributes_crossing = 11;
			FI.career_youthplayerattributes_potential = 12;
			FI.career_youthplayerattributes_gkreflexes = 13;
			FI.career_youthplayerattributes_reactions = 14;
			FI.career_youthplayerattributes_vision = 15;
			FI.career_youthplayerattributes_finishing = 16;
			FI.career_youthplayerattributes_dribbling = 17;
			FI.career_youthplayerattributes_slidingtackle = 18;
			FI.career_youthplayerattributes_sprintspeed = 19;
			FI.career_youthplayerattributes_age = 20;
			FI.career_youthplayerattributes_strength = 21;
			FI.career_youthplayerattributes_ballcontrol = 22;
			FI.career_youthplayerattributes_shotpower = 23;
			FI.career_youthplayerattributes_balance = 24;
			FI.career_youthplayerattributes_gkkicking = 25;
			FI.career_youthplayerattributes_shortpassing = 26;
			FI.career_youthplayerattributes_freekickaccuracy = 27;
			FI.career_youthplayerattributes_aggression = 28;
			FI.career_youthplayerattributes_acceleration = 29;
			FI.career_youthplayerattributes_headingaccuracy = 30;
			FI.career_youthplayerattributes_gkhandling = 31;
			FI.career_youthplayerattributes_jumping = 32;
			FI.career_youthplayerattributes_stamina = 33;
			FI.career_youthplayerattributes_marking = 34;
			FI.career_youthplayerattributes_gkpositioning = 35;
			FI.career_youthplayerattributes_volleys = 36;
			FI.career_scouts_firstname = 0;
			FI.career_scouts_lastname = 1;
			FI.career_scouts_regionid = 0;
			FI.career_scouts_state = 1;
			FI.career_scouts_knowledge = 2;
			FI.career_scouts_nationality = 3;
			FI.career_scouts_scoutid = 4;
			FI.career_scouts_experience = 5;
			FI.career_scoutmission_playertype = 0;
			FI.career_scoutmission_durationid = 1;
			FI.career_scoutmission_returningdate = 2;
			FI.career_scoutmission_nationality = 3;
			FI.career_scoutmission_scoutid = 4;
			FI.career_regenplayerattributes_curve = 0;
			FI.career_regenplayerattributes_agility = 1;
			FI.career_regenplayerattributes_positioning = 2;
			FI.career_regenplayerattributes_standingtackle = 3;
			FI.career_regenplayerattributes_longpassing = 4;
			FI.career_regenplayerattributes_penalties = 5;
			FI.career_regenplayerattributes_longshots = 6;
			FI.career_regenplayerattributes_gkdiving = 7;
			FI.career_regenplayerattributes_interceptions = 8;
			FI.career_regenplayerattributes_crossing = 9;
			FI.career_regenplayerattributes_gkreflexes = 10;
			FI.career_regenplayerattributes_reactions = 11;
			FI.career_regenplayerattributes_vision = 12;
			FI.career_regenplayerattributes_finishing = 13;
			FI.career_regenplayerattributes_dribbling = 14;
			FI.career_regenplayerattributes_slidingtackle = 15;
			FI.career_regenplayerattributes_sprintspeed = 16;
			FI.career_regenplayerattributes_age = 17;
			FI.career_regenplayerattributes_strength = 18;
			FI.career_regenplayerattributes_ballcontrol = 19;
			FI.career_regenplayerattributes_shotpower = 20;
			FI.career_regenplayerattributes_overall = 21;
			FI.career_regenplayerattributes_balance = 22;
			FI.career_regenplayerattributes_gkkicking = 23;
			FI.career_regenplayerattributes_shortpassing = 24;
			FI.career_regenplayerattributes_freekickaccuracy = 25;
			FI.career_regenplayerattributes_aggression = 26;
			FI.career_regenplayerattributes_acceleration = 27;
			FI.career_regenplayerattributes_headingaccuracy = 28;
			FI.career_regenplayerattributes_gkhandling = 29;
			FI.career_regenplayerattributes_jumping = 30;
			FI.career_regenplayerattributes_stamina = 31;
			FI.career_regenplayerattributes_marking = 32;
			FI.career_regenplayerattributes_gkpositioning = 33;
			FI.career_regenplayerattributes_playerposgroup = 34;
			FI.career_regenplayerattributes_volleys = 35;
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0003A2B4 File Offset: 0x000384B4
		public static void InitFI(DbFile fifaDb)
		{
			FI.language_hashid = 0;
			FI.language_stringid = 1;
			FI.language_sourcetext = 0;
			Table table = fifaDb.GetTable("teamstadiumlinks");
			if (table != null)
			{
				FI.teamstadiumlinks_stadiumid = table.TableDescriptor.GetFieldIndex("stadiumid");
				FI.teamstadiumlinks_teamid = table.TableDescriptor.GetFieldIndex("teamid");
			}
			table = fifaDb.GetTable("teams");
			if (table != null)
			{
				FI.teams_trait1 = table.TableDescriptor.GetFieldIndex("trait1");
				FI.teams_busdribbling = table.TableDescriptor.GetFieldIndex("busdribbling");
				FI.teams_assetid = table.TableDescriptor.GetFieldIndex("assetid");
				FI.teams_balltype = table.TableDescriptor.GetFieldIndex("balltype");
				FI.teams_teamcolor1g = table.TableDescriptor.GetFieldIndex("teamcolor1g");
				FI.teams_teamcolor1r = table.TableDescriptor.GetFieldIndex("teamcolor1r");
				FI.teams_teamcolor2b = table.TableDescriptor.GetFieldIndex("teamcolor2b");
				FI.teams_teamcolor2r = table.TableDescriptor.GetFieldIndex("teamcolor2r");
				FI.teams_teamcolor3r = table.TableDescriptor.GetFieldIndex("teamcolor3r");
				FI.teams_teamcolor1b = table.TableDescriptor.GetFieldIndex("teamcolor1b");
				FI.teams_latitude = table.TableDescriptor.GetFieldIndex("latitude");
				FI.teams_teamcolor3g = table.TableDescriptor.GetFieldIndex("teamcolor3g");
				FI.teams_teamcolor2g = table.TableDescriptor.GetFieldIndex("teamcolor2g");
				FI.teams_teamname = table.TableDescriptor.GetFieldIndex("teamname");
				FI.teams_adboardid = table.TableDescriptor.GetFieldIndex("adboardid");
				FI.teams_teamcolor3b = table.TableDescriptor.GetFieldIndex("teamcolor3b");
				FI.teams_defmentality = table.TableDescriptor.GetFieldIndex("defmentality");
				FI.teams_powid = table.TableDescriptor.GetFieldIndex("powid");
				FI.teams_physioid_secondary = table.TableDescriptor.GetFieldIndex("physioid_secondary");
				FI.teams_domesticprestige = table.TableDescriptor.GetFieldIndex("domesticprestige");
				FI.teams_genericint2 = table.TableDescriptor.GetFieldIndex("genericint2");
				FI.teams_jerseytype = table.TableDescriptor.GetFieldIndex("jerseytype");
				FI.teams_rivalteam = table.TableDescriptor.GetFieldIndex("rivalteam");
				FI.teams_midfieldrating = table.TableDescriptor.GetFieldIndex("midfieldrating");
				FI.teams_matchdayoverallrating = table.TableDescriptor.GetFieldIndex("matchdayoverallrating");
				FI.teams_matchdaymidfieldrating = table.TableDescriptor.GetFieldIndex("matchdaymidfieldrating");
				FI.teams_attackrating = table.TableDescriptor.GetFieldIndex("attackrating");
				FI.teams_physioid_primary = table.TableDescriptor.GetFieldIndex("physioid_primary");
				FI.teams_longitude = table.TableDescriptor.GetFieldIndex("longitude");
				FI.teams_buspassing = table.TableDescriptor.GetFieldIndex("buspassing");
				FI.teams_matchdaydefenserating = table.TableDescriptor.GetFieldIndex("matchdaydefenserating");
				FI.teams_defenserating = table.TableDescriptor.GetFieldIndex("defenserating");
				FI.teams_defteamwidth = table.TableDescriptor.GetFieldIndex("defteamwidth");
				FI.teams_longkicktakerid = table.TableDescriptor.GetFieldIndex("longkicktakerid");
				FI.teams_bodytypeid = table.TableDescriptor.GetFieldIndex("bodytypeid");
				FI.teams_rightcornerkicktakerid = table.TableDescriptor.GetFieldIndex("rightcornerkicktakerid");
				FI.teams_suitvariationid = table.TableDescriptor.GetFieldIndex("suitvariationid");
				FI.teams_defaggression = table.TableDescriptor.GetFieldIndex("defaggression");
				FI.teams_ethnicity = table.TableDescriptor.GetFieldIndex("ethnicity");
				FI.teams_leftcornerkicktakerid = table.TableDescriptor.GetFieldIndex("leftcornerkicktakerid");
				FI.teams_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.teams_fancrowdhairskintexturecode = table.TableDescriptor.GetFieldIndex("fancrowdhairskintexturecode");
				FI.teams_suittypeid = table.TableDescriptor.GetFieldIndex("suittypeid");
				FI.teams_numtransfersin = table.TableDescriptor.GetFieldIndex("numtransfersin");
				FI.teams_captainid = table.TableDescriptor.GetFieldIndex("captainid");
				FI.teams_personalityid = table.TableDescriptor.GetFieldIndex("personalityid");
				FI.teams_genericbanner = table.TableDescriptor.GetFieldIndex("genericbanner");
				FI.teams_buspositioning = table.TableDescriptor.GetFieldIndex("buspositioning");
				FI.teams_stafftracksuitcolorcode = table.TableDescriptor.GetFieldIndex("stafftracksuitcolorcode");
				FI.teams_ccpositioning = table.TableDescriptor.GetFieldIndex("ccpositioning");
				FI.teams_busbuildupspeed = table.TableDescriptor.GetFieldIndex("busbuildupspeed");
				FI.teams_transferbudget = table.TableDescriptor.GetFieldIndex("transferbudget");
				FI.teams_ccshooting = table.TableDescriptor.GetFieldIndex("ccshooting");
				FI.teams_overallrating = table.TableDescriptor.GetFieldIndex("overallrating");
				FI.teams_ccpassing = table.TableDescriptor.GetFieldIndex("ccpassing");
				FI.teams_utcoffset = table.TableDescriptor.GetFieldIndex("utcoffset");
				FI.teams_penaltytakerid = table.TableDescriptor.GetFieldIndex("penaltytakerid");
				FI.teams_freekicktakerid = table.TableDescriptor.GetFieldIndex("freekicktakerid");
				FI.teams_defdefenderline = table.TableDescriptor.GetFieldIndex("defdefenderline");
				FI.teams_internationalprestige = table.TableDescriptor.GetFieldIndex("internationalprestige");
				FI.teams_form = table.TableDescriptor.GetFieldIndex("form");
				FI.teams_genericint1 = table.TableDescriptor.GetFieldIndex("genericint1");
				FI.teams_cccrossing = table.TableDescriptor.GetFieldIndex("cccrossing");
				FI.teams_matchdayattackrating = table.TableDescriptor.GetFieldIndex("matchdayattackrating");
			}
			table = fifaDb.GetTable("teamplayerlinks");
			if (table != null)
			{
				FI.teamplayerlinks_leaguegoals = table.TableDescriptor.GetFieldIndex("leaguegoals");
				FI.teamplayerlinks_isamongtopscorers = table.TableDescriptor.GetFieldIndex("isamongtopscorers");
				FI.teamplayerlinks_yellows = table.TableDescriptor.GetFieldIndex("yellows");
				FI.teamplayerlinks_isamongtopscorersinteam = table.TableDescriptor.GetFieldIndex("isamongtopscorersinteam");
				FI.teamplayerlinks_jerseynumber = table.TableDescriptor.GetFieldIndex("jerseynumber");
				FI.teamplayerlinks_position = table.TableDescriptor.GetFieldIndex("position");
				FI.teamplayerlinks_artificialkey = table.TableDescriptor.GetFieldIndex("artificialkey");
				FI.teamplayerlinks_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.teamplayerlinks_injury = table.TableDescriptor.GetFieldIndex("injury");
				FI.teamplayerlinks_leagueappearances = table.TableDescriptor.GetFieldIndex("leagueappearances");
				FI.teamplayerlinks_prevform = table.TableDescriptor.GetFieldIndex("prevform");
				FI.teamplayerlinks_istopscorer = table.TableDescriptor.GetFieldIndex("istopscorer");
				FI.teamplayerlinks_playerid = table.TableDescriptor.GetFieldIndex("playerid");
				FI.teamplayerlinks_form = table.TableDescriptor.GetFieldIndex("form");
				FI.teamplayerlinks_reds = table.TableDescriptor.GetFieldIndex("reds");
			}
			table = fifaDb.GetTable("teamformationteamstylelinks");
			if (table != null)
			{
				FI.teamformationteamstylelinks_cddl = table.TableDescriptor.GetFieldIndex("cddl");
				FI.teamformationteamstylelinks_formationid = table.TableDescriptor.GetFieldIndex("formationid");
				FI.teamformationteamstylelinks_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.teamformationteamstylelinks_teamstyleid = table.TableDescriptor.GetFieldIndex("teamstyleid");
			}
			table = fifaDb.GetTable("teamkits");
			if (table != null)
			{
				FI.teamkits_shortsnumberplacementcode = table.TableDescriptor.GetFieldIndex("shortsnumberplacementcode");
				FI.teamkits_teamcolorsecb = table.TableDescriptor.GetFieldIndex("teamcolorsecb");
				FI.teamkits_shortsrenderingdetailmaptype = table.TableDescriptor.GetFieldIndex("shortsrenderingdetailmaptype");
				FI.teamkits_jerseyfrontnumberplacementcode = table.TableDescriptor.GetFieldIndex("jerseyfrontnumberplacementcode");
				FI.teamkits_teamcolorprimg = table.TableDescriptor.GetFieldIndex("teamcolorprimg");
				FI.teamkits_numberfonttype = table.TableDescriptor.GetFieldIndex("numberfonttype");
				FI.teamkits_teamcolortertb = table.TableDescriptor.GetFieldIndex("teamcolortertb");
				FI.teamkits_jerseynamefonttype = table.TableDescriptor.GetFieldIndex("jerseynamefonttype");
				FI.teamkits_jerseynamelayouttype = table.TableDescriptor.GetFieldIndex("jerseynamelayouttype");
				FI.teamkits_shortsnumbercolor = table.TableDescriptor.GetFieldIndex("shortsnumbercolor");
				FI.teamkits_jerseyshapestyle = table.TableDescriptor.GetFieldIndex("jerseyshapestyle");
				FI.teamkits_jerseybacknameplacementcode = table.TableDescriptor.GetFieldIndex("jerseybacknameplacementcode");
				FI.teamkits_teamcolorprimr = table.TableDescriptor.GetFieldIndex("teamcolorprimr");
				FI.teamkits_jerseynamecolorg = table.TableDescriptor.GetFieldIndex("jerseynamecolorg");
				FI.teamkits_teamcolorsecg = table.TableDescriptor.GetFieldIndex("teamcolorsecg");
				FI.teamkits_teamcolortertr = table.TableDescriptor.GetFieldIndex("teamcolortertr");
				FI.teamkits_renderingmaterialtype = table.TableDescriptor.GetFieldIndex("renderingmaterialtype");
				FI.teamkits_teamcolorsecr = table.TableDescriptor.GetFieldIndex("teamcolorsecr");
				FI.teamkits_jerseycollargeometrytype = table.TableDescriptor.GetFieldIndex("jerseycollargeometrytype");
				FI.teamkits_jerseynamecolorr = table.TableDescriptor.GetFieldIndex("jerseynamecolorr");
				FI.teamkits_numbercolor = table.TableDescriptor.GetFieldIndex("numbercolor");
				FI.teamkits_teamcolorprimb = table.TableDescriptor.GetFieldIndex("teamcolorprimb");
				FI.teamkits_jerseyrenderingdetailmaptype = table.TableDescriptor.GetFieldIndex("jerseyrenderingdetailmaptype");
				FI.teamkits_shortsnumberfonttype = table.TableDescriptor.GetFieldIndex("shortsnumberfonttype");
				FI.teamkits_jerseynamecolorb = table.TableDescriptor.GetFieldIndex("jerseynamecolorb");
				FI.teamkits_teamcolortertg = table.TableDescriptor.GetFieldIndex("teamcolortertg");
				FI.teamkits_jerseybacknamefontcase = table.TableDescriptor.GetFieldIndex("jerseybacknamefontcase");
				FI.teamkits_teamkittypetechid = table.TableDescriptor.GetFieldIndex("teamkittypetechid");
				FI.teamkits_powid = table.TableDescriptor.GetFieldIndex("powid");
				FI.teamkits_isinheritbasedetailmap = table.TableDescriptor.GetFieldIndex("isinheritbasedetailmap");
				FI.teamkits_islocked = table.TableDescriptor.GetFieldIndex("islocked");
				FI.teamkits_teamkitid = table.TableDescriptor.GetFieldIndex("teamkitid");
				FI.teamkits_year = table.TableDescriptor.GetFieldIndex("year");
				FI.teamkits_teamtechid = table.TableDescriptor.GetFieldIndex("teamtechid");
				FI.teamkits_hasadvertisingkit = table.TableDescriptor.GetFieldIndex("hasadvertisingkit");
				FI.teamkits_dlc = table.TableDescriptor.GetFieldIndex("dlc");
			}
			table = fifaDb.GetTable("teamballs");
			if (table != null)
			{
				FI.teamballs_ballid = table.TableDescriptor.GetFieldIndex("ballid");
				FI.teamballs_powid = table.TableDescriptor.GetFieldIndex("powid");
				FI.teamballs_islicensed = table.TableDescriptor.GetFieldIndex("islicensed");
				FI.teamballs_isembargoed = table.TableDescriptor.GetFieldIndex("isembargoed");
				FI.teamballs_isavailableinstore = table.TableDescriptor.GetFieldIndex("isavailableinstore");
			}
			table = fifaDb.GetTable("playerboots");
			if (table != null)
			{
				FI.playerboots_isadidas = table.TableDescriptor.GetFieldIndex("isadidas");
				FI.playerboots_isavailableinstore = table.TableDescriptor.GetFieldIndex("isavailableinstore");
				FI.playerboots_isembargoed = table.TableDescriptor.GetFieldIndex("isembargoed");
				FI.playerboots_islegacy = table.TableDescriptor.GetFieldIndex("islegacy");
				FI.playerboots_islicensed = table.TableDescriptor.GetFieldIndex("islicensed");
				FI.playerboots_islocked = table.TableDescriptor.GetFieldIndex("islocked");
				FI.playerboots_powid = table.TableDescriptor.GetFieldIndex("powid");
				FI.playerboots_shoecolor1 = table.TableDescriptor.GetFieldIndex("shoecolor1");
				FI.playerboots_shoecolor2 = table.TableDescriptor.GetFieldIndex("shoecolor2");
				FI.playerboots_shoedesign = table.TableDescriptor.GetFieldIndex("shoedesign");
				FI.playerboots_shoetype = table.TableDescriptor.GetFieldIndex("shoetype");
			}
			table = fifaDb.GetTable("stadiums");
			if (table != null)
			{
				FI.stadiums_yearbuilt = table.TableDescriptor.GetFieldIndex("yearbuilt");
				FI.stadiums_name = table.TableDescriptor.GetFieldIndex("name");
				FI.stadiums_timeofday3 = table.TableDescriptor.GetFieldIndex("timeofday3");
				FI.stadiums_adboardsidelinedistance = table.TableDescriptor.GetFieldIndex("adboardsidelinedistance");
				FI.stadiums_stadiumgloalnetdepth = table.TableDescriptor.GetFieldIndex("stadiumgloalnetdepth");
				FI.stadiums_hometeamid = table.TableDescriptor.GetFieldIndex("hometeamid");
				FI.stadiums_managerhometoplefty = table.TableDescriptor.GetFieldIndex("managerhometoplefty");
				FI.stadiums_capacity = table.TableDescriptor.GetFieldIndex("capacity");
				FI.stadiums_seatcolor = table.TableDescriptor.GetFieldIndex("seatcolor");
				FI.stadiums_managerawaytoplefty = table.TableDescriptor.GetFieldIndex("managerawaytoplefty");
				FI.stadiums_subsawaybotrightx = table.TableDescriptor.GetFieldIndex("subsawaybotrightx");
				FI.stadiums_sectionfacedbydefault = table.TableDescriptor.GetFieldIndex("sectionfacedbydefault");
				FI.stadiums_subshomebotrightx = table.TableDescriptor.GetFieldIndex("subshomebotrightx");
				FI.stadiums_policetypecode = table.TableDescriptor.GetFieldIndex("policetypecode");
				FI.stadiums_subsawaybotrighty = table.TableDescriptor.GetFieldIndex("subsawaybotrighty");
				FI.stadiums_timeofday4 = table.TableDescriptor.GetFieldIndex("timeofday4");
				FI.stadiums_subsawaytopleftx = table.TableDescriptor.GetFieldIndex("subsawaytopleftx");
				FI.stadiums_stadiumpitchlength = table.TableDescriptor.GetFieldIndex("stadiumpitchlength");
				FI.stadiums_stadiumgoalnetstyle = table.TableDescriptor.GetFieldIndex("stadiumgoalnetstyle");
				FI.stadiums_subshomebotrighty = table.TableDescriptor.GetFieldIndex("subshomebotrighty");
				FI.stadiums_upgradetier = table.TableDescriptor.GetFieldIndex("upgradetier");
				FI.stadiums_tod4weather = table.TableDescriptor.GetFieldIndex("tod4weather");
				FI.stadiums_countrycode = table.TableDescriptor.GetFieldIndex("countrycode");
				FI.stadiums_stadiummowpattern_code = table.TableDescriptor.GetFieldIndex("stadiummowpattern_code");
				FI.stadiums_subsawaytoplefty = table.TableDescriptor.GetFieldIndex("subsawaytoplefty");
				FI.stadiums_managerhomebotrightx = table.TableDescriptor.GetFieldIndex("managerhomebotrightx");
				FI.stadiums_stadiumid = table.TableDescriptor.GetFieldIndex("stadiumid");
				FI.stadiums_cameraheight = table.TableDescriptor.GetFieldIndex("cameraheight");
				FI.stadiums_managerawaytopleftx = table.TableDescriptor.GetFieldIndex("managerawaytopleftx");
				FI.stadiums_managerhomebotrighty = table.TableDescriptor.GetFieldIndex("managerhomebotrighty");
				FI.stadiums_stadiumgoalnettype = table.TableDescriptor.GetFieldIndex("stadiumgoalnettype");
				FI.stadiums_stadiumpitchwidth = table.TableDescriptor.GetFieldIndex("stadiumpitchwidth");
				FI.stadiums_stadiumtype = table.TableDescriptor.GetFieldIndex("stadiumtype");
				FI.stadiums_managerhometopleftx = table.TableDescriptor.GetFieldIndex("managerhometopleftx");
				FI.stadiums_stadiumgoalnettension = table.TableDescriptor.GetFieldIndex("stadiumgoalnettension");
				FI.stadiums_tod1weather = table.TableDescriptor.GetFieldIndex("tod1weather");
				FI.stadiums_dlc = table.TableDescriptor.GetFieldIndex("dlc");
				FI.stadiums_tod2weather = table.TableDescriptor.GetFieldIndex("tod2weather");
				FI.stadiums_camerazoom = table.TableDescriptor.GetFieldIndex("camerazoom");
				FI.stadiums_adboardendlinedistance = table.TableDescriptor.GetFieldIndex("adboardendlinedistance");
				FI.stadiums_subshometoplefty = table.TableDescriptor.GetFieldIndex("subshometoplefty");
				FI.stadiums_iseditable = table.TableDescriptor.GetFieldIndex("iseditable");
				FI.stadiums_isdynamic = table.TableDescriptor.GetFieldIndex("isdynamic");
				FI.stadiums_tod3weather = table.TableDescriptor.GetFieldIndex("tod3weather");
				FI.stadiums_upgradestyle = table.TableDescriptor.GetFieldIndex("upgradestyle");
				FI.stadiums_genericrank = table.TableDescriptor.GetFieldIndex("genericrank");
				FI.stadiums_timeofday1 = table.TableDescriptor.GetFieldIndex("timeofday1");
				FI.stadiums_timeofday2 = table.TableDescriptor.GetFieldIndex("timeofday2");
				FI.stadiums_stadiumgoalnetwidth = table.TableDescriptor.GetFieldIndex("stadiumgoalnetwidth");
				FI.stadiums_managerawaybotrightx = table.TableDescriptor.GetFieldIndex("managerawaybotrightx");
				FI.stadiums_subshometopleftx = table.TableDescriptor.GetFieldIndex("subshometopleftx");
				FI.stadiums_stadiumgoalnetlength = table.TableDescriptor.GetFieldIndex("stadiumgoalnetlength");
				FI.stadiums_managerawaybotrighty = table.TableDescriptor.GetFieldIndex("managerawaybotrighty");
			}
			table = fifaDb.GetTable("shoecolors");
			if (table != null)
			{
				FI.shoecolors_blue = table.TableDescriptor.GetFieldIndex("blue");
				FI.shoecolors_green = table.TableDescriptor.GetFieldIndex("green");
				FI.shoecolors_red = table.TableDescriptor.GetFieldIndex("red");
				FI.shoecolors_colorid = table.TableDescriptor.GetFieldIndex("colorid");
			}
			table = fifaDb.GetTable("rowteamnationlinks");
			if (table != null)
			{
				FI.rowteamnationlinks_nationid = table.TableDescriptor.GetFieldIndex("nationid");
				FI.rowteamnationlinks_teamid = table.TableDescriptor.GetFieldIndex("teamid");
			}
			table = fifaDb.GetTable("rivals");
			if (table != null)
			{
				FI.rivals_rivaltype = table.TableDescriptor.GetFieldIndex("rivaltype");
				FI.rivals_teamid2 = table.TableDescriptor.GetFieldIndex("teamid2");
				FI.rivals_teamid1 = table.TableDescriptor.GetFieldIndex("teamid1");
			}
			table = fifaDb.GetTable("referee");
			if (table != null)
			{
				FI.referee_birthdate = table.TableDescriptor.GetFieldIndex("birthdate");
				FI.referee_firstname = table.TableDescriptor.GetFieldIndex("firstname");
				FI.referee_shoetypecode = table.TableDescriptor.GetFieldIndex("shoetypecode");
				FI.referee_surname = table.TableDescriptor.GetFieldIndex("surname");
				FI.referee_nationalitycode = table.TableDescriptor.GetFieldIndex("nationalitycode");
				FI.referee_haircolorcode = table.TableDescriptor.GetFieldIndex("haircolorcode");
				FI.referee_facialhairtypecode = table.TableDescriptor.GetFieldIndex("facialhairtypecode");
				FI.referee_hairtypecode = table.TableDescriptor.GetFieldIndex("hairtypecode");
				FI.referee_cardstrictness = table.TableDescriptor.GetFieldIndex("cardstrictness");
				FI.referee_shoecolorcode2 = table.TableDescriptor.GetFieldIndex("shoecolorcode2");
				FI.referee_stylecode = table.TableDescriptor.GetFieldIndex("stylecode");
				FI.referee_proxyhaircolorid = table.TableDescriptor.GetFieldIndex("proxyhaircolorid");
				FI.referee_headtypecode = table.TableDescriptor.GetFieldIndex("headtypecode");
				FI.referee_foulstrictness = table.TableDescriptor.GetFieldIndex("foulstrictness");
				FI.referee_height = table.TableDescriptor.GetFieldIndex("height");
				FI.referee_hairstateid = table.TableDescriptor.GetFieldIndex("hairstateid");
				FI.referee_leagueid = table.TableDescriptor.GetFieldIndex("leagueid");
				FI.referee_sockheightcode = table.TableDescriptor.GetFieldIndex("sockheightcode");
				FI.referee_weight = table.TableDescriptor.GetFieldIndex("weight");
				FI.referee_proxyheadclass = table.TableDescriptor.GetFieldIndex("proxyheadclass");
				FI.referee_eyebrowcode = table.TableDescriptor.GetFieldIndex("eyebrowcode");
				FI.referee_eyecolorcode = table.TableDescriptor.GetFieldIndex("eyecolorcode");
				FI.referee_jerseysleevelengthcode = table.TableDescriptor.GetFieldIndex("jerseysleevelengthcode");
				FI.referee_hairlinecode = table.TableDescriptor.GetFieldIndex("hairlinecode");
				FI.referee_headclasscode = table.TableDescriptor.GetFieldIndex("headclasscode");
				FI.referee_haireffecttypecode = table.TableDescriptor.GetFieldIndex("haireffecttypecode");
				FI.referee_sideburnscode = table.TableDescriptor.GetFieldIndex("sideburnscode");
				FI.referee_skintypecode = table.TableDescriptor.GetFieldIndex("skintypecode");
				FI.referee_hairpartcode = table.TableDescriptor.GetFieldIndex("hairpartcode");
				FI.referee_sweatid = table.TableDescriptor.GetFieldIndex("sweatid");
				FI.referee_skintonecode = table.TableDescriptor.GetFieldIndex("skintonecode");
				FI.referee_hairvariationid = table.TableDescriptor.GetFieldIndex("hairvariationid");
				FI.referee_refereeid = table.TableDescriptor.GetFieldIndex("refereeid");
				FI.referee_homecitycode = table.TableDescriptor.GetFieldIndex("homecitycode");
				FI.referee_shoedesigncode = table.TableDescriptor.GetFieldIndex("shoedesigncode");
				FI.referee_shoecolorcode1 = table.TableDescriptor.GetFieldIndex("shoecolorcode1");
				FI.referee_bodytypecode = table.TableDescriptor.GetFieldIndex("bodytypecode");
				FI.referee_wrinkleid = table.TableDescriptor.GetFieldIndex("wrinkleid");
				FI.referee_facialhaircolorcode = table.TableDescriptor.GetFieldIndex("facialhaircolorcode");
			}
			table = fifaDb.GetTable("previousteam");
			if (table != null)
			{
				FI.previousteam_previousteamid = table.TableDescriptor.GetFieldIndex("previousteamid");
				FI.previousteam_playerid = table.TableDescriptor.GetFieldIndex("playerid");
			}
			table = fifaDb.GetTable("players");
			if (table != null)
			{
				FI.players_birthdate = table.TableDescriptor.GetFieldIndex("birthdate");
				FI.players_playerjointeamdate = table.TableDescriptor.GetFieldIndex("playerjointeamdate");
				FI.players_shoetypecode = table.TableDescriptor.GetFieldIndex("shoetypecode");
				FI.players_haircolorcode = table.TableDescriptor.GetFieldIndex("haircolorcode");
				FI.players_facialhairtypecode = table.TableDescriptor.GetFieldIndex("facialhairtypecode");
				FI.players_curve = table.TableDescriptor.GetFieldIndex("curve");
				FI.players_jerseystylecode = table.TableDescriptor.GetFieldIndex("jerseystylecode");
				FI.players_agility = table.TableDescriptor.GetFieldIndex("agility");
				FI.players_accessorycode4 = table.TableDescriptor.GetFieldIndex("accessorycode4");
				FI.players_gksavetype = table.TableDescriptor.GetFieldIndex("gksavetype");
				FI.players_positioning = table.TableDescriptor.GetFieldIndex("positioning");
				FI.players_hairtypecode = table.TableDescriptor.GetFieldIndex("hairtypecode");
				FI.players_standingtackle = table.TableDescriptor.GetFieldIndex("standingtackle");
				FI.players_faceposercode = table.TableDescriptor.GetFieldIndex("faceposercode");
				FI.players_preferredposition3 = table.TableDescriptor.GetFieldIndex("preferredposition3");
				FI.players_longpassing = table.TableDescriptor.GetFieldIndex("longpassing");
				FI.players_penalties = table.TableDescriptor.GetFieldIndex("penalties");
				FI.players_animfreekickstartposcode = table.TableDescriptor.GetFieldIndex("animfreekickstartposcode");
				FI.players_animpenaltieskickstylecode = table.TableDescriptor.GetFieldIndex("animpenaltieskickstylecode");
				FI.players_isretiring = table.TableDescriptor.GetFieldIndex("isretiring");
				FI.players_longshots = table.TableDescriptor.GetFieldIndex("longshots");
				FI.players_gkdiving = table.TableDescriptor.GetFieldIndex("gkdiving");
				FI.players_interceptions = table.TableDescriptor.GetFieldIndex("interceptions");
				FI.players_shoecolorcode2 = table.TableDescriptor.GetFieldIndex("shoecolorcode2");
				FI.players_crossing = table.TableDescriptor.GetFieldIndex("crossing");
				FI.players_potential = table.TableDescriptor.GetFieldIndex("potential");
				FI.players_gkreflexes = table.TableDescriptor.GetFieldIndex("gkreflexes");
				FI.players_finishingcode1 = table.TableDescriptor.GetFieldIndex("finishingcode1");
				FI.players_reactions = table.TableDescriptor.GetFieldIndex("reactions");
				FI.players_vision = table.TableDescriptor.GetFieldIndex("vision");
				FI.players_contractvaliduntil = table.TableDescriptor.GetFieldIndex("contractvaliduntil");
				FI.players_finishing = table.TableDescriptor.GetFieldIndex("finishing");
				FI.players_dribbling = table.TableDescriptor.GetFieldIndex("dribbling");
				FI.players_slidingtackle = table.TableDescriptor.GetFieldIndex("slidingtackle");
				FI.players_accessorycode3 = table.TableDescriptor.GetFieldIndex("accessorycode3");
				FI.players_accessorycolourcode1 = table.TableDescriptor.GetFieldIndex("accessorycolourcode1");
				FI.players_headtypecode = table.TableDescriptor.GetFieldIndex("headtypecode");
				FI.players_firstnameid = table.TableDescriptor.GetFieldIndex("firstnameid");
				FI.players_sprintspeed = table.TableDescriptor.GetFieldIndex("sprintspeed");
				FI.players_height = table.TableDescriptor.GetFieldIndex("height");
				FI.players_hasseasonaljersey = table.TableDescriptor.GetFieldIndex("hasseasonaljersey");
				FI.players_preferredposition2 = table.TableDescriptor.GetFieldIndex("preferredposition2");
				FI.players_strength = table.TableDescriptor.GetFieldIndex("strength");
				FI.players_preferredposition1 = table.TableDescriptor.GetFieldIndex("preferredposition1");
				FI.players_ballcontrol = table.TableDescriptor.GetFieldIndex("ballcontrol");
				FI.players_shotpower = table.TableDescriptor.GetFieldIndex("shotpower");
				FI.players_trait1 = table.TableDescriptor.GetFieldIndex("trait1");
				FI.players_socklengthcode = table.TableDescriptor.GetFieldIndex("socklengthcode");
				FI.players_weight = table.TableDescriptor.GetFieldIndex("weight");
				FI.players_hashighqualityhead = table.TableDescriptor.GetFieldIndex("hashighqualityhead");
				FI.players_gkglovetypecode = table.TableDescriptor.GetFieldIndex("gkglovetypecode");
				FI.players_balance = table.TableDescriptor.GetFieldIndex("balance");
				FI.players_gkkicking = table.TableDescriptor.GetFieldIndex("gkkicking");
				FI.players_lastnameid = table.TableDescriptor.GetFieldIndex("lastnameid");
				FI.players_internationalrep = table.TableDescriptor.GetFieldIndex("internationalrep");
				FI.players_animpenaltiesmotionstylecode = table.TableDescriptor.GetFieldIndex("animpenaltiesmotionstylecode");
				FI.players_shortpassing = table.TableDescriptor.GetFieldIndex("shortpassing");
				FI.players_freekickaccuracy = table.TableDescriptor.GetFieldIndex("freekickaccuracy");
				FI.players_skillmoves = table.TableDescriptor.GetFieldIndex("skillmoves");
				FI.players_usercaneditname = table.TableDescriptor.GetFieldIndex("usercaneditname");
				FI.players_attackingworkrate = table.TableDescriptor.GetFieldIndex("attackingworkrate");
				FI.players_finishingcode2 = table.TableDescriptor.GetFieldIndex("finishingcode2");
				FI.players_aggression = table.TableDescriptor.GetFieldIndex("aggression");
				FI.players_acceleration = table.TableDescriptor.GetFieldIndex("acceleration");
				FI.players_headingaccuracy = table.TableDescriptor.GetFieldIndex("headingaccuracy");
				FI.players_eyebrowcode = table.TableDescriptor.GetFieldIndex("eyebrowcode");
				FI.players_runningcode2 = table.TableDescriptor.GetFieldIndex("runningcode2");
				FI.players_gkhandling = table.TableDescriptor.GetFieldIndex("gkhandling");
				FI.players_eyecolorcode = table.TableDescriptor.GetFieldIndex("eyecolorcode");
				FI.players_jerseysleevelengthcode = table.TableDescriptor.GetFieldIndex("jerseysleevelengthcode");
				FI.players_accessorycolourcode3 = table.TableDescriptor.GetFieldIndex("accessorycolourcode3");
				FI.players_accessorycode1 = table.TableDescriptor.GetFieldIndex("accessorycode1");
				FI.players_headclasscode = table.TableDescriptor.GetFieldIndex("headclasscode");
				FI.players_defensiveworkrate = table.TableDescriptor.GetFieldIndex("defensiveworkrate");
				FI.players_nationality = table.TableDescriptor.GetFieldIndex("nationality");
				FI.players_preferredfoot = table.TableDescriptor.GetFieldIndex("preferredfoot");
				FI.players_sideburnscode = table.TableDescriptor.GetFieldIndex("sideburnscode");
				FI.players_weakfootabilitytypecode = table.TableDescriptor.GetFieldIndex("weakfootabilitytypecode");
				FI.players_jumping = table.TableDescriptor.GetFieldIndex("jumping");
				FI.players_skintypecode = table.TableDescriptor.GetFieldIndex("skintypecode");
				FI.players_gkkickstyle = table.TableDescriptor.GetFieldIndex("gkkickstyle");
				FI.players_stamina = table.TableDescriptor.GetFieldIndex("stamina");
				FI.players_playerid = table.TableDescriptor.GetFieldIndex("playerid");
				FI.players_marking = table.TableDescriptor.GetFieldIndex("marking");
				FI.players_accessorycolourcode4 = table.TableDescriptor.GetFieldIndex("accessorycolourcode4");
				FI.players_gkpositioning = table.TableDescriptor.GetFieldIndex("gkpositioning");
				FI.players_trait2 = table.TableDescriptor.GetFieldIndex("trait2");
				FI.players_skintonecode = table.TableDescriptor.GetFieldIndex("skintonecode");
				FI.players_shortstyle = table.TableDescriptor.GetFieldIndex("shortstyle");
				FI.players_overallrating = table.TableDescriptor.GetFieldIndex("overallrating");
				FI.players_jerseyfit = table.TableDescriptor.GetFieldIndex("jerseyfit");
				FI.players_accessorycode2 = table.TableDescriptor.GetFieldIndex("accessorycode2");
				FI.players_shoedesigncode = table.TableDescriptor.GetFieldIndex("shoedesigncode");
				FI.players_playerjerseynameid = table.TableDescriptor.GetFieldIndex("playerjerseynameid");
				FI.players_shoecolorcode1 = table.TableDescriptor.GetFieldIndex("shoecolorcode1");
				FI.players_commonnameid = table.TableDescriptor.GetFieldIndex("commonnameid");
				FI.players_bodytypecode = table.TableDescriptor.GetFieldIndex("bodytypecode");
				FI.players_animpenaltiesstartposcode = table.TableDescriptor.GetFieldIndex("animpenaltiesstartposcode");
				FI.players_runningcode1 = table.TableDescriptor.GetFieldIndex("runningcode1");
				FI.players_preferredposition4 = table.TableDescriptor.GetFieldIndex("preferredposition4");
				FI.players_volleys = table.TableDescriptor.GetFieldIndex("volleys");
				FI.players_accessorycolourcode2 = table.TableDescriptor.GetFieldIndex("accessorycolourcode2");
				FI.players_facialhaircolorcode = table.TableDescriptor.GetFieldIndex("facialhaircolorcode");
			}
			table = fifaDb.GetTable("playernames");
			if (table != null)
			{
				FI.playernames_name = table.TableDescriptor.GetFieldIndex("name");
				FI.playernames_commentaryid = table.TableDescriptor.GetFieldIndex("commentaryid");
				FI.playernames_nameid = table.TableDescriptor.GetFieldIndex("nameid");
			}
			table = fifaDb.GetTable("playerloans");
			if (table != null)
			{
				FI.playerloans_loandateend = table.TableDescriptor.GetFieldIndex("loandateend");
				FI.playerloans_teamidloanedfrom = table.TableDescriptor.GetFieldIndex("teamidloanedfrom");
				FI.playerloans_playerid = table.TableDescriptor.GetFieldIndex("playerid");
			}
			table = fifaDb.GetTable("playerboots");
			if (table != null)
			{
				FI.playerboots_shoetype = table.TableDescriptor.GetFieldIndex("shoetype");
				FI.playerboots_powid = table.TableDescriptor.GetFieldIndex("powid");
				FI.playerboots_islocked = table.TableDescriptor.GetFieldIndex("islocked");
				FI.playerboots_islegacy = table.TableDescriptor.GetFieldIndex("islegacy");
				FI.playerboots_shoecolor1 = table.TableDescriptor.GetFieldIndex("shoecolor1");
				FI.playerboots_islicensed = table.TableDescriptor.GetFieldIndex("islicensed");
				FI.playerboots_isavailableinstore = table.TableDescriptor.GetFieldIndex("isavailableinstore");
				FI.playerboots_isadidas = table.TableDescriptor.GetFieldIndex("isadidas");
				FI.playerboots_shoedesign = table.TableDescriptor.GetFieldIndex("shoedesign");
				FI.playerboots_shoecolor2 = table.TableDescriptor.GetFieldIndex("shoecolor2");
			}
			table = fifaDb.GetTable("player_grudgelove");
			if (table != null)
			{
				FI.player_grudgelove_level_of_emotion = table.TableDescriptor.GetFieldIndex("level_of_emotion");
				FI.player_grudgelove_playerid = table.TableDescriptor.GetFieldIndex("playerid");
				FI.player_grudgelove_emotional_teamid = table.TableDescriptor.GetFieldIndex("emotional_teamid");
			}
			table = fifaDb.GetTable("nations");
			if (table != null)
			{
				FI.nations_nationname = table.TableDescriptor.GetFieldIndex("nationname");
				FI.nations_nationid = table.TableDescriptor.GetFieldIndex("nationid");
				FI.nations_confederation = table.TableDescriptor.GetFieldIndex("confederation");
				FI.nations_top_tier = table.TableDescriptor.GetFieldIndex("top_tier");
				FI.nations_nationstartingfirstletter = table.TableDescriptor.GetFieldIndex("nationstartingfirstletter");
				FI.nations_teamid = table.TableDescriptor.GetFieldIndex("teamid");
			}
			table = fifaDb.GetTable("manager");
			if (table != null)
			{
				FI.manager_firstname = table.TableDescriptor.GetFieldIndex("firstname");
				FI.manager_surname = table.TableDescriptor.GetFieldIndex("surname");
				FI.manager_teamid = table.TableDescriptor.GetFieldIndex("teamid");
			}
			table = fifaDb.GetTable("leagueteamlinks");
			if (table != null)
			{
				FI.leagueteamlinks_homega = table.TableDescriptor.GetFieldIndex("homega");
				FI.leagueteamlinks_homegf = table.TableDescriptor.GetFieldIndex("homegf");
				FI.leagueteamlinks_points = table.TableDescriptor.GetFieldIndex("points");
				FI.leagueteamlinks_awayga = table.TableDescriptor.GetFieldIndex("awayga");
				FI.leagueteamlinks_awaygf = table.TableDescriptor.GetFieldIndex("awaygf");
				FI.leagueteamlinks_teamshortform = table.TableDescriptor.GetFieldIndex("teamshortform");
				FI.leagueteamlinks_hasachievedobjective = table.TableDescriptor.GetFieldIndex("hasachievedobjective");
				FI.leagueteamlinks_secondarytable = table.TableDescriptor.GetFieldIndex("secondarytable");
				FI.leagueteamlinks_yettowin = table.TableDescriptor.GetFieldIndex("yettowin");
				FI.leagueteamlinks_unbeatenallcomps = table.TableDescriptor.GetFieldIndex("unbeatenallcomps");
				FI.leagueteamlinks_unbeatenleague = table.TableDescriptor.GetFieldIndex("unbeatenleague");
				FI.leagueteamlinks_champion = table.TableDescriptor.GetFieldIndex("champion");
				FI.leagueteamlinks_leagueid = table.TableDescriptor.GetFieldIndex("leagueid");
				FI.leagueteamlinks_prevleagueid = table.TableDescriptor.GetFieldIndex("prevleagueid");
				FI.leagueteamlinks_previousyeartableposition = table.TableDescriptor.GetFieldIndex("previousyeartableposition");
				FI.leagueteamlinks_highestpossible = table.TableDescriptor.GetFieldIndex("highestpossible");
				FI.leagueteamlinks_teamform = table.TableDescriptor.GetFieldIndex("teamform");
				FI.leagueteamlinks_highestprobable = table.TableDescriptor.GetFieldIndex("highestprobable");
				FI.leagueteamlinks_homewins = table.TableDescriptor.GetFieldIndex("homewins");
				FI.leagueteamlinks_artificialkey = table.TableDescriptor.GetFieldIndex("artificialkey");
				FI.leagueteamlinks_nummatchesplayed = table.TableDescriptor.GetFieldIndex("nummatchesplayed");
				FI.leagueteamlinks_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.leagueteamlinks_gapresult = table.TableDescriptor.GetFieldIndex("gapresult");
				FI.leagueteamlinks_grouping = table.TableDescriptor.GetFieldIndex("grouping");
				FI.leagueteamlinks_currenttableposition = table.TableDescriptor.GetFieldIndex("currenttableposition");
				FI.leagueteamlinks_awaywins = table.TableDescriptor.GetFieldIndex("awaywins");
				FI.leagueteamlinks_objective = table.TableDescriptor.GetFieldIndex("objective");
				FI.leagueteamlinks_actualvsexpectations = table.TableDescriptor.GetFieldIndex("actualvsexpectations");
				FI.leagueteamlinks_homelosses = table.TableDescriptor.GetFieldIndex("homelosses");
				FI.leagueteamlinks_unbeatenhome = table.TableDescriptor.GetFieldIndex("unbeatenhome");
				FI.leagueteamlinks_lastgameresult = table.TableDescriptor.GetFieldIndex("lastgameresult");
				FI.leagueteamlinks_unbeatenaway = table.TableDescriptor.GetFieldIndex("unbeatenaway");
				FI.leagueteamlinks_awaylosses = table.TableDescriptor.GetFieldIndex("awaylosses");
				FI.leagueteamlinks_awaydraws = table.TableDescriptor.GetFieldIndex("awaydraws");
				FI.leagueteamlinks_homedraws = table.TableDescriptor.GetFieldIndex("homedraws");
				FI.leagueteamlinks_teamlongform = table.TableDescriptor.GetFieldIndex("teamlongform");
			}
			table = fifaDb.GetTable("leagues");
			if (table != null)
			{
				FI.leagues_countryid = table.TableDescriptor.GetFieldIndex("countryid");
				FI.leagues_leaguename = table.TableDescriptor.GetFieldIndex("leaguename");
				FI.leagues_level = table.TableDescriptor.GetFieldIndex("level");
				FI.leagues_leagueid = table.TableDescriptor.GetFieldIndex("leagueid");
				FI.leagues_leaguetimeslice = table.TableDescriptor.GetFieldIndex("leaguetimeslice");
				FI.leagues_iswithintransferwindow = table.TableDescriptor.GetFieldIndex("iswithintransferwindow");
			}
			table = fifaDb.GetTable("leaguerefereelinks");
			if (table != null)
			{
				FI.leaguerefereelinks_leagueid = table.TableDescriptor.GetFieldIndex("leagueid");
				FI.leaguerefereelinks_refereeid = table.TableDescriptor.GetFieldIndex("refereeid");
			}
			table = fifaDb.GetTable("formupdate");
			if (table != null)
			{
				FI.formupdate_leagueid = table.TableDescriptor.GetFieldIndex("leagueid");
				FI.formupdate_position = table.TableDescriptor.GetFieldIndex("position");
				FI.formupdate_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.formupdate_formaudio = table.TableDescriptor.GetFieldIndex("formaudio");
				FI.formupdate_prevform = table.TableDescriptor.GetFieldIndex("prevform");
				FI.formupdate_playerid = table.TableDescriptor.GetFieldIndex("playerid");
				FI.formupdate_overallrating = table.TableDescriptor.GetFieldIndex("overallrating");
				FI.formupdate_form = table.TableDescriptor.GetFieldIndex("form");
			}
			table = fifaDb.GetTable("formations");
			if (table != null)
			{
				FI.formations_offset6x = table.TableDescriptor.GetFieldIndex("offset6x");
				FI.formations_offset5y = table.TableDescriptor.GetFieldIndex("offset5y");
				FI.formations_offset10x = table.TableDescriptor.GetFieldIndex("offset10x");
				FI.formations_offset2x = table.TableDescriptor.GetFieldIndex("offset2x");
				FI.formations_defenders = table.TableDescriptor.GetFieldIndex("defenders");
				FI.formations_offset2y = table.TableDescriptor.GetFieldIndex("offset2y");
				FI.formations_offset6y = table.TableDescriptor.GetFieldIndex("offset6y");
				FI.formations_offset7x = table.TableDescriptor.GetFieldIndex("offset7x");
				FI.formations_offset3x = table.TableDescriptor.GetFieldIndex("offset3x");
				FI.formations_offset8x = table.TableDescriptor.GetFieldIndex("offset8x");
				FI.formations_offset10y = table.TableDescriptor.GetFieldIndex("offset10y");
				FI.formations_offset3y = table.TableDescriptor.GetFieldIndex("offset3y");
				FI.formations_offset4x = table.TableDescriptor.GetFieldIndex("offset4x");
				FI.formations_offset7y = table.TableDescriptor.GetFieldIndex("offset7y");
				FI.formations_offset0x = table.TableDescriptor.GetFieldIndex("offset0x");
				FI.formations_offset8y = table.TableDescriptor.GetFieldIndex("offset8y");
				FI.formations_attackers = table.TableDescriptor.GetFieldIndex("attackers");
				FI.formations_offset9x = table.TableDescriptor.GetFieldIndex("offset9x");
				FI.formations_midfielders = table.TableDescriptor.GetFieldIndex("midfielders");
				FI.formations_offset5x = table.TableDescriptor.GetFieldIndex("offset5x");
				FI.formations_offset0y = table.TableDescriptor.GetFieldIndex("offset0y");
				FI.formations_offset1x = table.TableDescriptor.GetFieldIndex("offset1x");
				FI.formations_offset4y = table.TableDescriptor.GetFieldIndex("offset4y");
				FI.formations_offset9y = table.TableDescriptor.GetFieldIndex("offset9y");
				FI.formations_offset1y = table.TableDescriptor.GetFieldIndex("offset1y");
				FI.formations_formationname = table.TableDescriptor.GetFieldIndex("formationname");
				FI.formations_attackingdirection_0 = table.TableDescriptor.GetFieldIndex("attackingdirection_0");
				FI.formations_attackingrole_5 = table.TableDescriptor.GetFieldIndex("attackingrole_5");
				FI.formations_position10 = table.TableDescriptor.GetFieldIndex("position10");
				FI.formations_attackingdirection_7 = table.TableDescriptor.GetFieldIndex("attackingdirection_7");
				FI.formations_defensivedirection_0 = table.TableDescriptor.GetFieldIndex("defensivedirection_0");
				FI.formations_defensivedirection_9 = table.TableDescriptor.GetFieldIndex("defensivedirection_9");
				FI.formations_defensivedirection_8 = table.TableDescriptor.GetFieldIndex("defensivedirection_8");
				FI.formations_attackingdirection_9 = table.TableDescriptor.GetFieldIndex("attackingdirection_9");
				FI.formations_position6 = table.TableDescriptor.GetFieldIndex("position6");
				FI.formations_attackingrole_4 = table.TableDescriptor.GetFieldIndex("attackingrole_4");
				FI.formations_offensiverating = table.TableDescriptor.GetFieldIndex("offensiverating");
				FI.formations_attackingrole_2 = table.TableDescriptor.GetFieldIndex("attackingrole_2");
				FI.formations_attackingdirection_1 = table.TableDescriptor.GetFieldIndex("attackingdirection_1");
				FI.formations_position8 = table.TableDescriptor.GetFieldIndex("position8");
				FI.formations_defensiverole_4 = table.TableDescriptor.GetFieldIndex("defensiverole_4");
				FI.formations_attackingdirection_10 = table.TableDescriptor.GetFieldIndex("attackingdirection_10");
				FI.formations_defensivedirection_6 = table.TableDescriptor.GetFieldIndex("defensivedirection_6");
				FI.formations_attackingdirection_8 = table.TableDescriptor.GetFieldIndex("attackingdirection_8");
				FI.formations_attackingrole_3 = table.TableDescriptor.GetFieldIndex("attackingrole_3");
				FI.formations_defensiverole_3 = table.TableDescriptor.GetFieldIndex("defensiverole_3");
				FI.formations_attackingrole_0 = table.TableDescriptor.GetFieldIndex("attackingrole_0");
				FI.formations_defensivedirection_1 = table.TableDescriptor.GetFieldIndex("defensivedirection_1");
				FI.formations_attackingdirection_5 = table.TableDescriptor.GetFieldIndex("attackingdirection_5");
				FI.formations_defensivedirection_2 = table.TableDescriptor.GetFieldIndex("defensivedirection_2");
				FI.formations_attackingdirection_6 = table.TableDescriptor.GetFieldIndex("attackingdirection_6");
				FI.formations_position5 = table.TableDescriptor.GetFieldIndex("position5");
				FI.formations_attackingrole_7 = table.TableDescriptor.GetFieldIndex("attackingrole_7");
				FI.formations_defensiverole_5 = table.TableDescriptor.GetFieldIndex("defensiverole_5");
				FI.formations_defensivedirection_10 = table.TableDescriptor.GetFieldIndex("defensivedirection_10");
				FI.formations_defensivedirection_3 = table.TableDescriptor.GetFieldIndex("defensivedirection_3");
				FI.formations_defensivedirection_5 = table.TableDescriptor.GetFieldIndex("defensivedirection_5");
				FI.formations_issweeper = table.TableDescriptor.GetFieldIndex("issweeper");
				FI.formations_attackingdirection_2 = table.TableDescriptor.GetFieldIndex("attackingdirection_2");
				FI.formations_attackingdirection_4 = table.TableDescriptor.GetFieldIndex("attackingdirection_4");
				FI.formations_attackingrole_9 = table.TableDescriptor.GetFieldIndex("attackingrole_9");
				FI.formations_defensiverole_2 = table.TableDescriptor.GetFieldIndex("defensiverole_2");
				FI.formations_attackingdirection_3 = table.TableDescriptor.GetFieldIndex("attackingdirection_3");
				FI.formations_attackingrole_8 = table.TableDescriptor.GetFieldIndex("attackingrole_8");
				FI.formations_attackingrole_1 = table.TableDescriptor.GetFieldIndex("attackingrole_1");
				FI.formations_defensiverole_10 = table.TableDescriptor.GetFieldIndex("defensiverole_10");
				FI.formations_defensiverole_1 = table.TableDescriptor.GetFieldIndex("defensiverole_1");
				FI.formations_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.formations_position2 = table.TableDescriptor.GetFieldIndex("position2");
				FI.formations_defensivedirection_4 = table.TableDescriptor.GetFieldIndex("defensivedirection_4");
				FI.formations_formationid = table.TableDescriptor.GetFieldIndex("formationid");
				FI.formations_defensiverole_8 = table.TableDescriptor.GetFieldIndex("defensiverole_8");
				FI.formations_attackingrole_6 = table.TableDescriptor.GetFieldIndex("attackingrole_6");
				FI.formations_relativeformationid = table.TableDescriptor.GetFieldIndex("relativeformationid");
				FI.formations_defensiverole_0 = table.TableDescriptor.GetFieldIndex("defensiverole_0");
				FI.formations_defensiverole_6 = table.TableDescriptor.GetFieldIndex("defensiverole_6");
				FI.formations_position4 = table.TableDescriptor.GetFieldIndex("position4");
				FI.formations_attackingrole_10 = table.TableDescriptor.GetFieldIndex("attackingrole_10");
				FI.formations_position3 = table.TableDescriptor.GetFieldIndex("position3");
				FI.formations_defensiverole_7 = table.TableDescriptor.GetFieldIndex("defensiverole_7");
				FI.formations_formationfullnameid = table.TableDescriptor.GetFieldIndex("formationfullnameid");
				FI.formations_defensiverole_9 = table.TableDescriptor.GetFieldIndex("defensiverole_9");
				FI.formations_position0 = table.TableDescriptor.GetFieldIndex("position0");
				FI.formations_position9 = table.TableDescriptor.GetFieldIndex("position9");
				FI.formations_position7 = table.TableDescriptor.GetFieldIndex("position7");
				FI.formations_position1 = table.TableDescriptor.GetFieldIndex("position1");
				FI.formations_defensivedirection_7 = table.TableDescriptor.GetFieldIndex("defensivedirection_7");
			}
			table = fifaDb.GetTable("fieldpositionboundingboxes");
			if (table != null)
			{
				FI.fieldpositionboundingboxes_pointy1 = table.TableDescriptor.GetFieldIndex("pointy1");
				FI.fieldpositionboundingboxes_pointx1 = table.TableDescriptor.GetFieldIndex("pointx1");
				FI.fieldpositionboundingboxes_pointy0 = table.TableDescriptor.GetFieldIndex("pointy0");
				FI.fieldpositionboundingboxes_pointy3 = table.TableDescriptor.GetFieldIndex("pointy3");
				FI.fieldpositionboundingboxes_pointy2 = table.TableDescriptor.GetFieldIndex("pointy2");
				FI.fieldpositionboundingboxes_pointx0 = table.TableDescriptor.GetFieldIndex("pointx0");
				FI.fieldpositionboundingboxes_pointx3 = table.TableDescriptor.GetFieldIndex("pointx3");
				FI.fieldpositionboundingboxes_pointx2 = table.TableDescriptor.GetFieldIndex("pointx2");
				FI.fieldpositionboundingboxes_positionid = table.TableDescriptor.GetFieldIndex("positionid");
			}
			table = fifaDb.GetTable("editedplayernames");
			if (table != null)
			{
				FI.editedplayernames_firstname = table.TableDescriptor.GetFieldIndex("firstname");
				FI.editedplayernames_commonname = table.TableDescriptor.GetFieldIndex("commonname");
				FI.editedplayernames_playerjerseyname = table.TableDescriptor.GetFieldIndex("playerjerseyname");
				FI.editedplayernames_surname = table.TableDescriptor.GetFieldIndex("surname");
				FI.editedplayernames_playerid = table.TableDescriptor.GetFieldIndex("playerid");
			}
			table = fifaDb.GetTable("competition");
			if (table != null)
			{
				FI.competition_ballid = table.TableDescriptor.GetFieldIndex("ballid");
				FI.competition_competitionid = table.TableDescriptor.GetFieldIndex("competitionid");
			}
			table = fifaDb.GetTable("career_lastnames");
			if (table != null)
			{
				FI.career_lastnames_lastname = table.TableDescriptor.GetFieldIndex("lastname");
				FI.career_lastnames_lastnameid = table.TableDescriptor.GetFieldIndex("lastnameid");
				FI.career_lastnames_groupid = table.TableDescriptor.GetFieldIndex("groupid");
			}
			table = fifaDb.GetTable("career_firstnames");
			if (table != null)
			{
				FI.career_firstnames_firstname = table.TableDescriptor.GetFieldIndex("firstname");
				FI.career_firstnames_firstnameid = table.TableDescriptor.GetFieldIndex("firstnameid");
				FI.career_firstnames_groupid = table.TableDescriptor.GetFieldIndex("groupid");
			}
			table = fifaDb.GetTable("career_commonnames");
			if (table != null)
			{
				FI.career_commonnames_firstname = table.TableDescriptor.GetFieldIndex("firstname");
				FI.career_commonnames_lastname = table.TableDescriptor.GetFieldIndex("lastname");
				FI.career_commonnames_commonnameid = table.TableDescriptor.GetFieldIndex("commonnameid");
				FI.career_commonnames_groupid = table.TableDescriptor.GetFieldIndex("groupid");
			}
			table = fifaDb.GetTable("attributeprefpositionformula");
			if (table != null)
			{
				FI.attributeprefpositionformula_attribute = table.TableDescriptor.GetFieldIndex("attribute");
				FI.attributeprefpositionformula_position = table.TableDescriptor.GetFieldIndex("position");
				FI.attributeprefpositionformula_percentage = table.TableDescriptor.GetFieldIndex("percentage");
			}
			table = fifaDb.GetTable("audionation");
			if (table != null)
			{
				FI.audionation_nationid = table.TableDescriptor.GetFieldIndex("nationid");
				FI.audionation_PALanguageIndex = table.TableDescriptor.GetFieldIndex("palanguageindex");
				FI.audionation_DefaultCommLang = table.TableDescriptor.GetFieldIndex("defaultcommlang");
				FI.audionation_CrowdBedsRegionIndex = table.TableDescriptor.GetFieldIndex("crowdbedsregionindex");
				FI.audionation_WhistlesRegionIndex = table.TableDescriptor.GetFieldIndex("whistlesregionindex");
				FI.audionation_AmbienceRegionIndex = table.TableDescriptor.GetFieldIndex("ambienceregionindex");
				FI.audionation_PlayerCallPatchBankIndex = table.TableDescriptor.GetFieldIndex("playercallpatchbankindex");
				FI.audionation_HecklesRegionIndex = table.TableDescriptor.GetFieldIndex("hecklesregionindex");
				FI.audionation_ChantRegionIndex = table.TableDescriptor.GetFieldIndex("chantregionindex");
				FI.audionation_TeamCanWhistleIndex = table.TableDescriptor.GetFieldIndex("teamcanwhistleindex");
				FI.audionation_ReactionsRegionIndex = table.TableDescriptor.GetFieldIndex("reactionsregionindex");
			}
			table = fifaDb.GetTable("audiostadium");
			if (table != null)
			{
				FI.audiostadium_stadiumid = table.TableDescriptor.GetFieldIndex("stadiumid");
				FI.audiostadium_audioindex = table.TableDescriptor.GetFieldIndex("audioindex");
			}
			table = fifaDb.GetTable("career_boardoutcomes");
			if (table != null)
			{
				FI.career_boardoutcomes_outcome3 = table.TableDescriptor.GetFieldIndex("outcome3");
				FI.career_boardoutcomes_outcome4 = table.TableDescriptor.GetFieldIndex("outcome4");
				FI.career_boardoutcomes_leagueid = table.TableDescriptor.GetFieldIndex("leagueid");
				FI.career_boardoutcomes_outcome1 = table.TableDescriptor.GetFieldIndex("outcome1");
				FI.career_boardoutcomes_outcome2 = table.TableDescriptor.GetFieldIndex("outcome2");
				FI.career_boardoutcomes_outcome5 = table.TableDescriptor.GetFieldIndex("outcome5");
			}
			table = fifaDb.GetTable("career_leagueballs");
			if (table != null)
			{
				FI.career_leagueballs_balltype = table.TableDescriptor.GetFieldIndex("balltype");
				FI.career_leagueballs_leagueid = table.TableDescriptor.GetFieldIndex("leagueid");
			}
			table = fifaDb.GetTable("clubcommentarynames");
			if (table != null)
			{
				FI.clubcommentarynames_commentaryid = table.TableDescriptor.GetFieldIndex("commentaryid");
				FI.clubcommentarynames_commentarystartingletter = table.TableDescriptor.GetFieldIndex("commentarystartingletter");
			}
			table = fifaDb.GetTable("commentarynames");
			if (table != null)
			{
				FI.commentarynames_commentarystring = table.TableDescriptor.GetFieldIndex("commentarystring");
				FI.commentarynames_commentaryid = table.TableDescriptor.GetFieldIndex("commentaryid");
				FI.commentarynames_commentarystartingletter = table.TableDescriptor.GetFieldIndex("commentarystartingletter");
				FI.commentarynames_commentarypreview = table.TableDescriptor.GetFieldIndex("commentarypreview");
			}
			table = fifaDb.GetTable("cz_assets");
			if (table != null)
			{
				FI.cz_assets_crestid = table.TableDescriptor.GetFieldIndex("crestid");
				FI.cz_assets_dbid = table.TableDescriptor.GetFieldIndex("dbid");
				FI.cz_assets_publishdate = table.TableDescriptor.GetFieldIndex("publishdate");
				FI.cz_assets_rating = table.TableDescriptor.GetFieldIndex("rating");
				FI.cz_assets_kitid = table.TableDescriptor.GetFieldIndex("kitid");
				FI.cz_assets_xms_media_id = table.TableDescriptor.GetFieldIndex("xms_media_id");
				FI.cz_assets_type = table.TableDescriptor.GetFieldIndex("type");
				FI.cz_assets_author = table.TableDescriptor.GetFieldIndex("author");
				FI.cz_assets_assetname = table.TableDescriptor.GetFieldIndex("assetname");
				FI.cz_assets_assetyear = table.TableDescriptor.GetFieldIndex("assetyear");
				FI.cz_assets_playerposition = table.TableDescriptor.GetFieldIndex("playerposition");
				FI.cz_assets_version = table.TableDescriptor.GetFieldIndex("version");
			}
			table = fifaDb.GetTable("cz_teams");
			if (table != null)
			{
				FI.cz_teams_hascrestimage = table.TableDescriptor.GetFieldIndex("hascrestimage");
				FI.cz_teams_hassponsorimage = table.TableDescriptor.GetFieldIndex("hassponsorimage");
				FI.cz_teams_teamabbrev3 = table.TableDescriptor.GetFieldIndex("teamabbrev3");
				FI.cz_teams_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.cz_teams_commentaryid = table.TableDescriptor.GetFieldIndex("commentaryid");
			}
			table = fifaDb.GetTable("cz_teamkits");
			if (table != null)
			{
				FI.cz_teamkits_hotspotjerseyfrontsponsorr = table.TableDescriptor.GetFieldIndex("hotspotjerseyfrontsponsorr");
				FI.cz_teamkits_hotspotjerseyfrontsponsorb = table.TableDescriptor.GetFieldIndex("hotspotjerseyfrontsponsorb");
				FI.cz_teamkits_hotspotjerseyfrontsponsorl = table.TableDescriptor.GetFieldIndex("hotspotjerseyfrontsponsorl");
				FI.cz_teamkits_assetid = table.TableDescriptor.GetFieldIndex("assetid");
				FI.cz_teamkits_hotspotjerseyfrontsponsort = table.TableDescriptor.GetFieldIndex("hotspotjerseyfrontsponsort");
				FI.cz_teamkits_sockscolortertr = table.TableDescriptor.GetFieldIndex("sockscolortertr");
				FI.cz_teamkits_jerseycolorprimg = table.TableDescriptor.GetFieldIndex("jerseycolorprimg");
				FI.cz_teamkits_jerseycolortertg = table.TableDescriptor.GetFieldIndex("jerseycolortertg");
				FI.cz_teamkits_sponsorcolourg = table.TableDescriptor.GetFieldIndex("sponsorcolourg");
				FI.cz_teamkits_sockscolorsecb = table.TableDescriptor.GetFieldIndex("sockscolorsecb");
				FI.cz_teamkits_sponsorcolourr = table.TableDescriptor.GetFieldIndex("sponsorcolourr");
				FI.cz_teamkits_sockscolortertg = table.TableDescriptor.GetFieldIndex("sockscolortertg");
				FI.cz_teamkits_shortcolorsecb = table.TableDescriptor.GetFieldIndex("shortcolorsecb");
				FI.cz_teamkits_shortcolortertg = table.TableDescriptor.GetFieldIndex("shortcolortertg");
				FI.cz_teamkits_numberfonttype = table.TableDescriptor.GetFieldIndex("numberfonttype");
				FI.cz_teamkits_shortcolorprimb = table.TableDescriptor.GetFieldIndex("shortcolorprimb");
				FI.cz_teamkits_jerseycolorsecr = table.TableDescriptor.GetFieldIndex("jerseycolorsecr");
				FI.cz_teamkits_jerseynamefonttype = table.TableDescriptor.GetFieldIndex("jerseynamefonttype");
				FI.cz_teamkits_jerseynamelayouttype = table.TableDescriptor.GetFieldIndex("jerseynamelayouttype");
				FI.cz_teamkits_jerseycolortertb = table.TableDescriptor.GetFieldIndex("jerseycolortertb");
				FI.cz_teamkits_shortsnumbercolor = table.TableDescriptor.GetFieldIndex("shortsnumbercolor");
				FI.cz_teamkits_jerseyshapestyle = table.TableDescriptor.GetFieldIndex("jerseyshapestyle");
				FI.cz_teamkits_shortcolortertr = table.TableDescriptor.GetFieldIndex("shortcolortertr");
				FI.cz_teamkits_shortcolorsecr = table.TableDescriptor.GetFieldIndex("shortcolorsecr");
				FI.cz_teamkits_jerseynamecolorg = table.TableDescriptor.GetFieldIndex("jerseynamecolorg");
				FI.cz_teamkits_jerseycolorprimr = table.TableDescriptor.GetFieldIndex("jerseycolorprimr");
				FI.cz_teamkits_sponsorcolourb = table.TableDescriptor.GetFieldIndex("sponsorcolourb");
				FI.cz_teamkits_sockscolorsecg = table.TableDescriptor.GetFieldIndex("sockscolorsecg");
				FI.cz_teamkits_jerseycolorsecb = table.TableDescriptor.GetFieldIndex("jerseycolorsecb");
				FI.cz_teamkits_sockscolorprimg = table.TableDescriptor.GetFieldIndex("sockscolorprimg");
				FI.cz_teamkits_shortcolorprimr = table.TableDescriptor.GetFieldIndex("shortcolorprimr");
				FI.cz_teamkits_jerseycolortertr = table.TableDescriptor.GetFieldIndex("jerseycolortertr");
				FI.cz_teamkits_shortcolorsecg = table.TableDescriptor.GetFieldIndex("shortcolorsecg");
				FI.cz_teamkits_jerseycolorprimb = table.TableDescriptor.GetFieldIndex("jerseycolorprimb");
				FI.cz_teamkits_sockscolorprimr = table.TableDescriptor.GetFieldIndex("sockscolorprimr");
				FI.cz_teamkits_sockscolorsecr = table.TableDescriptor.GetFieldIndex("sockscolorsecr");
				FI.cz_teamkits_shortcolortertb = table.TableDescriptor.GetFieldIndex("shortcolortertb");
				FI.cz_teamkits_jerseynamecolorr = table.TableDescriptor.GetFieldIndex("jerseynamecolorr");
				FI.cz_teamkits_numbercolor = table.TableDescriptor.GetFieldIndex("numbercolor");
				FI.cz_teamkits_sockscolorprimb = table.TableDescriptor.GetFieldIndex("sockscolorprimb");
				FI.cz_teamkits_jerseycolorsecg = table.TableDescriptor.GetFieldIndex("jerseycolorsecg");
				FI.cz_teamkits_shortsnumberfonttype = table.TableDescriptor.GetFieldIndex("shortsnumberfonttype");
				FI.cz_teamkits_jerseynamecolorb = table.TableDescriptor.GetFieldIndex("jerseynamecolorb");
				FI.cz_teamkits_shortcolorprimg = table.TableDescriptor.GetFieldIndex("shortcolorprimg");
				FI.cz_teamkits_sockscolortertb = table.TableDescriptor.GetFieldIndex("sockscolortertb");
				FI.cz_teamkits_jerseybacknamefontcase = table.TableDescriptor.GetFieldIndex("jerseybacknamefontcase");
				FI.cz_teamkits_hassponsor = table.TableDescriptor.GetFieldIndex("hassponsor");
				FI.cz_teamkits_jerseybacknameplacementcode = table.TableDescriptor.GetFieldIndex("jerseybacknameplacementcode");
				FI.cz_teamkits_artificialkey = table.TableDescriptor.GetFieldIndex("artificialkey");
				FI.cz_teamkits_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.cz_teamkits_kitid = table.TableDescriptor.GetFieldIndex("kitid");
				FI.cz_teamkits_kittypeid = table.TableDescriptor.GetFieldIndex("kittypeid");
			}
			table = fifaDb.GetTable("cz_players");
			if (table != null)
			{
				FI.cz_players_assetid = table.TableDescriptor.GetFieldIndex("assetid");
				FI.cz_players_commentaryid = table.TableDescriptor.GetFieldIndex("commentaryid");
				FI.cz_players_playerid = table.TableDescriptor.GetFieldIndex("playerid");
			}
			table = fifaDb.GetTable("cz_leagues");
			if (table != null)
			{
				FI.cz_leagues_overlaybgcolour3r = table.TableDescriptor.GetFieldIndex("overlaybgcolour3r");
				FI.cz_leagues_tournamentballid = table.TableDescriptor.GetFieldIndex("tournamentballid");
				FI.cz_leagues_overlaytextcolour3r = table.TableDescriptor.GetFieldIndex("overlaytextcolour3r");
				FI.cz_leagues_overlaytextcolour1g = table.TableDescriptor.GetFieldIndex("overlaytextcolour1g");
				FI.cz_leagues_overlaytextcolour3b = table.TableDescriptor.GetFieldIndex("overlaytextcolour3b");
				FI.cz_leagues_overlaybgcolour1g = table.TableDescriptor.GetFieldIndex("overlaybgcolour1g");
				FI.cz_leagues_championcupslotallotment = table.TableDescriptor.GetFieldIndex("championcupslotallotment");
				FI.cz_leagues_overlaybgcolour3b = table.TableDescriptor.GetFieldIndex("overlaybgcolour3b");
				FI.cz_leagues_finalstadiumid = table.TableDescriptor.GetFieldIndex("finalstadiumid");
				FI.cz_leagues_overlaytextcolour2b = table.TableDescriptor.GetFieldIndex("overlaytextcolour2b");
				FI.cz_leagues_overlaybgcolour1r = table.TableDescriptor.GetFieldIndex("overlaybgcolour1r");
				FI.cz_leagues_overlaybgcolour2b = table.TableDescriptor.GetFieldIndex("overlaybgcolour2b");
				FI.cz_leagues_overlaytextcolour1r = table.TableDescriptor.GetFieldIndex("overlaytextcolour1r");
				FI.cz_leagues_overlaytextcolour3g = table.TableDescriptor.GetFieldIndex("overlaytextcolour3g");
				FI.cz_leagues_overlaytextcolour1b = table.TableDescriptor.GetFieldIndex("overlaytextcolour1b");
				FI.cz_leagues_overlaybgcolour3g = table.TableDescriptor.GetFieldIndex("overlaybgcolour3g");
				FI.cz_leagues_overlaybgcolour1b = table.TableDescriptor.GetFieldIndex("overlaybgcolour1b");
				FI.cz_leagues_overlaybgcolour2r = table.TableDescriptor.GetFieldIndex("overlaybgcolour2r");
				FI.cz_leagues_overlaytextcolour2g = table.TableDescriptor.GetFieldIndex("overlaytextcolour2g");
				FI.cz_leagues_eurocupslotallotment = table.TableDescriptor.GetFieldIndex("eurocupslotallotment");
				FI.cz_leagues_overlaytextcolour2r = table.TableDescriptor.GetFieldIndex("overlaytextcolour2r");
				FI.cz_leagues_overlaybgcolour2g = table.TableDescriptor.GetFieldIndex("overlaybgcolour2g");
				FI.cz_leagues_leaguedescription = table.TableDescriptor.GetFieldIndex("leaguedescription");
				FI.cz_leagues_leaguetype = table.TableDescriptor.GetFieldIndex("leaguetype");
				FI.cz_leagues_numteams = table.TableDescriptor.GetFieldIndex("numteams");
				FI.cz_leagues_trophyid = table.TableDescriptor.GetFieldIndex("trophyid");
				FI.cz_leagues_teamadvancingpergroup = table.TableDescriptor.GetFieldIndex("teamadvancingpergroup");
				FI.cz_leagues_leagueid = table.TableDescriptor.GetFieldIndex("leagueid");
				FI.cz_leagues_fixturevsgroup = table.TableDescriptor.GetFieldIndex("fixturevsgroup");
				FI.cz_leagues_teampergroup = table.TableDescriptor.GetFieldIndex("teampergroup");
				FI.cz_leagues_finalmatchlegs = table.TableDescriptor.GetFieldIndex("finalmatchlegs");
				FI.cz_leagues_fixturevseachteam = table.TableDescriptor.GetFieldIndex("fixturevseachteam");
				FI.cz_leagues_subonbench = table.TableDescriptor.GetFieldIndex("subonbench");
			}
			table = fifaDb.GetTable("fce_activeteams");
			if (table != null)
			{
				FI.fce_activeteams_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.fce_activeteams_userid = table.TableDescriptor.GetFieldIndex("userid");
			}
			table = fifaDb.GetTable("fce_weathersettings");
			if (table != null)
			{
				FI.fce_weathersettings_weatherid = table.TableDescriptor.GetFieldIndex("weatherid");
				FI.fce_weathersettings_rainpct = table.TableDescriptor.GetFieldIndex("rainpct");
				FI.fce_weathersettings_snowpct = table.TableDescriptor.GetFieldIndex("snowpct");
				FI.fce_weathersettings_clearpct = table.TableDescriptor.GetFieldIndex("clearpct");
				FI.fce_weathersettings_quarter = table.TableDescriptor.GetFieldIndex("quarter");
				FI.fce_weathersettings_compid = table.TableDescriptor.GetFieldIndex("compid");
				FI.fce_weathersettings_inuse = table.TableDescriptor.GetFieldIndex("inuse");
			}
			table = fifaDb.GetTable("fce_statistics");
			if (table != null)
			{
				FI.fce_statistics_goals = table.TableDescriptor.GetFieldIndex("goals");
				FI.fce_statistics_saves = table.TableDescriptor.GetFieldIndex("saves");
				FI.fce_statistics_shots = table.TableDescriptor.GetFieldIndex("shots");
				FI.fce_statistics_goalsconceded = table.TableDescriptor.GetFieldIndex("goalsconceded");
				FI.fce_statistics_totalreds = table.TableDescriptor.GetFieldIndex("totalreds");
				FI.fce_statistics_manofmatch = table.TableDescriptor.GetFieldIndex("manofmatch");
				FI.fce_statistics_minutes = table.TableDescriptor.GetFieldIndex("minutes");
				FI.fce_statistics_appearances = table.TableDescriptor.GetFieldIndex("appearances");
				FI.fce_statistics_compid = table.TableDescriptor.GetFieldIndex("compid");
				FI.fce_statistics_assists = table.TableDescriptor.GetFieldIndex("assists");
				FI.fce_statistics_matchratings = table.TableDescriptor.GetFieldIndex("matchratings");
				FI.fce_statistics_cleansheets = table.TableDescriptor.GetFieldIndex("cleansheets");
				FI.fce_statistics_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.fce_statistics_totalyellows = table.TableDescriptor.GetFieldIndex("totalyellows");
				FI.fce_statistics_statisticsid = table.TableDescriptor.GetFieldIndex("statisticsid");
				FI.fce_statistics_playerid = table.TableDescriptor.GetFieldIndex("playerid");
				FI.fce_statistics_inuse = table.TableDescriptor.GetFieldIndex("inuse");
			}
			table = fifaDb.GetTable("fce_standings");
			if (table != null)
			{
				FI.fce_standings_homegoalsfor = table.TableDescriptor.GetFieldIndex("homegoalsfor");
				FI.fce_standings_teamindex = table.TableDescriptor.GetFieldIndex("teamindex");
				FI.fce_standings_standingsid = table.TableDescriptor.GetFieldIndex("standingsid");
				FI.fce_standings_homegoalsagainst = table.TableDescriptor.GetFieldIndex("homegoalsagainst");
				FI.fce_standings_compid = table.TableDescriptor.GetFieldIndex("compid");
				FI.fce_standings_homewins = table.TableDescriptor.GetFieldIndex("homewins");
				FI.fce_standings_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.fce_standings_awaywins = table.TableDescriptor.GetFieldIndex("awaywins");
				FI.fce_standings_points = table.TableDescriptor.GetFieldIndex("points");
				FI.fce_standings_awaygoalsfor = table.TableDescriptor.GetFieldIndex("awaygoalsfor");
				FI.fce_standings_homelosses = table.TableDescriptor.GetFieldIndex("homelosses");
				FI.fce_standings_awaygoalsagainst = table.TableDescriptor.GetFieldIndex("awaygoalsagainst");
				FI.fce_standings_awaylosses = table.TableDescriptor.GetFieldIndex("awaylosses");
				FI.fce_standings_awaydraws = table.TableDescriptor.GetFieldIndex("awaydraws");
				FI.fce_standings_inuse = table.TableDescriptor.GetFieldIndex("inuse");
				FI.fce_standings_homedraws = table.TableDescriptor.GetFieldIndex("homedraws");
			}
			table = fifaDb.GetTable("fce_settings");
			if (table != null)
			{
				FI.fce_settings_settingvalue = table.TableDescriptor.GetFieldIndex("settingvalue");
				FI.fce_settings_settingenumid = table.TableDescriptor.GetFieldIndex("settingenumid");
				FI.fce_settings_settingid = table.TableDescriptor.GetFieldIndex("settingid");
				FI.fce_settings_compid = table.TableDescriptor.GetFieldIndex("compid");
				FI.fce_settings_inuse = table.TableDescriptor.GetFieldIndex("inuse");
			}
			table = fifaDb.GetTable("fce_stageadvance");
			if (table != null)
			{
				FI.fce_stageadvance_actiondate = table.TableDescriptor.GetFieldIndex("actiondate");
				FI.fce_stageadvance_active = table.TableDescriptor.GetFieldIndex("active");
				FI.fce_stageadvance_stageindex = table.TableDescriptor.GetFieldIndex("stageindex");
				FI.fce_stageadvance_randomnumber = table.TableDescriptor.GetFieldIndex("randomnumber");
				FI.fce_stageadvance_compid = table.TableDescriptor.GetFieldIndex("compid");
				FI.fce_stageadvance_inuse = table.TableDescriptor.GetFieldIndex("inuse");
				FI.fce_stageadvance_stageadvanceid = table.TableDescriptor.GetFieldIndex("stageadvanceid");
			}
			table = fifaDb.GetTable("fce_scriptfunctions");
			if (table != null)
			{
				FI.fce_scriptfunctions_scriptfuncid = table.TableDescriptor.GetFieldIndex("scriptfuncid");
				FI.fce_scriptfunctions_funcparam1 = table.TableDescriptor.GetFieldIndex("funcparam1");
				FI.fce_scriptfunctions_compid = table.TableDescriptor.GetFieldIndex("compid");
				FI.fce_scriptfunctions_funcparam2 = table.TableDescriptor.GetFieldIndex("funcparam2");
				FI.fce_scriptfunctions_targetcompid = table.TableDescriptor.GetFieldIndex("targetcompid");
				FI.fce_scriptfunctions_funcparam3 = table.TableDescriptor.GetFieldIndex("funcparam3");
				FI.fce_scriptfunctions_inuse = table.TableDescriptor.GetFieldIndex("inuse");
				FI.fce_scriptfunctions_functype = table.TableDescriptor.GetFieldIndex("functype");
			}
			table = fifaDb.GetTable("fce_scheduleinfo");
			if (table != null)
			{
				FI.fce_scheduleinfo_time = table.TableDescriptor.GetFieldIndex("time");
				FI.fce_scheduleinfo_dayofweek = table.TableDescriptor.GetFieldIndex("dayofweek");
				FI.fce_scheduleinfo_compid = table.TableDescriptor.GetFieldIndex("compid");
				FI.fce_scheduleinfo_chance = table.TableDescriptor.GetFieldIndex("chance");
				FI.fce_scheduleinfo_priority = table.TableDescriptor.GetFieldIndex("priority");
				FI.fce_scheduleinfo_inuse = table.TableDescriptor.GetFieldIndex("inuse");
				FI.fce_scheduleinfo_scheduleinfoid = table.TableDescriptor.GetFieldIndex("scheduleinfoid");
			}
			table = fifaDb.GetTable("fce_fixtures");
			if (table != null)
			{
				FI.fce_fixtures_time = table.TableDescriptor.GetFieldIndex("time");
				FI.fce_fixtures_homescore = table.TableDescriptor.GetFieldIndex("homescore");
				FI.fce_fixtures_awayscore = table.TableDescriptor.GetFieldIndex("awayscore");
				FI.fce_fixtures_gamecompletion = table.TableDescriptor.GetFieldIndex("gamecompletion");
				FI.fce_fixtures_compid = table.TableDescriptor.GetFieldIndex("compid");
				FI.fce_fixtures_date = table.TableDescriptor.GetFieldIndex("date");
				FI.fce_fixtures_fixtureid = table.TableDescriptor.GetFieldIndex("fixtureid");
				FI.fce_fixtures_awaystandingid = table.TableDescriptor.GetFieldIndex("awaystandingid");
				FI.fce_fixtures_homestandingid = table.TableDescriptor.GetFieldIndex("homestandingid");
				FI.fce_fixtures_awaypens = table.TableDescriptor.GetFieldIndex("awaypens");
				FI.fce_fixtures_homepens = table.TableDescriptor.GetFieldIndex("homepens");
				FI.fce_fixtures_inuse = table.TableDescriptor.GetFieldIndex("inuse");
			}
			table = fifaDb.GetTable("fce_competitionteams");
			if (table != null)
			{
				FI.fce_competitionteams_teamindex = table.TableDescriptor.GetFieldIndex("teamindex");
				FI.fce_competitionteams_compteamid = table.TableDescriptor.GetFieldIndex("compteamid");
				FI.fce_competitionteams_compid = table.TableDescriptor.GetFieldIndex("compid");
				FI.fce_competitionteams_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.fce_competitionteams_inuse = table.TableDescriptor.GetFieldIndex("inuse");
			}
			table = fifaDb.GetTable("fce_competitioninfo");
			if (table != null)
			{
				FI.fce_competitioninfo_compobjshortdesc = table.TableDescriptor.GetFieldIndex("compobjshortdesc");
				FI.fce_competitioninfo_compobjdesc = table.TableDescriptor.GetFieldIndex("compobjdesc");
				FI.fce_competitioninfo_compparentid = table.TableDescriptor.GetFieldIndex("compparentid");
				FI.fce_competitioninfo_comptype = table.TableDescriptor.GetFieldIndex("comptype");
				FI.fce_competitioninfo_compid = table.TableDescriptor.GetFieldIndex("compid");
				FI.fce_competitioninfo_inuse = table.TableDescriptor.GetFieldIndex("inuse");
			}
			table = fifaDb.GetTable("fce_compavgs");
			if (table != null)
			{
				FI.fce_compavgs_mid = table.TableDescriptor.GetFieldIndex("mid");
				FI.fce_compavgs_ovr = table.TableDescriptor.GetFieldIndex("ovr");
				FI.fce_compavgs_def = table.TableDescriptor.GetFieldIndex("def");
				FI.fce_compavgs_compid = table.TableDescriptor.GetFieldIndex("compid");
				FI.fce_compavgs_gk = table.TableDescriptor.GetFieldIndex("gk");
				FI.fce_compavgs_att = table.TableDescriptor.GetFieldIndex("att");
			}
			table = fifaDb.GetTable("fce_advancement");
			if (table != null)
			{
				FI.fce_advancement_fromcompid = table.TableDescriptor.GetFieldIndex("fromcompid");
				FI.fce_advancement_fromteamindex = table.TableDescriptor.GetFieldIndex("fromteamindex");
				FI.fce_advancement_tocompid = table.TableDescriptor.GetFieldIndex("tocompid");
				FI.fce_advancement_advancementid = table.TableDescriptor.GetFieldIndex("advancementid");
				FI.fce_advancement_toteamindex = table.TableDescriptor.GetFieldIndex("toteamindex");
				FI.fce_advancement_inuse = table.TableDescriptor.GetFieldIndex("inuse");
			}
			table = fifaDb.GetTable("career_newspicweights");
			if (table != null)
			{
				FI.career_newspicweights_maxvariationspos = table.TableDescriptor.GetFieldIndex("maxvariationspos");
				FI.career_newspicweights_maxvariationsstd = table.TableDescriptor.GetFieldIndex("maxvariationsstd");
				FI.career_newspicweights_maxvariationsneg = table.TableDescriptor.GetFieldIndex("maxvariationsneg");
				FI.career_newspicweights_crestweight = table.TableDescriptor.GetFieldIndex("crestweight");
				FI.career_newspicweights_teamweight = table.TableDescriptor.GetFieldIndex("teamweight");
				FI.career_newspicweights_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.career_newspicweights_genericweight = table.TableDescriptor.GetFieldIndex("genericweight");
			}
			table = fifaDb.GetTable("finalstadiums");
			if (table != null)
			{
				FI.finalstadiums_leagueid = table.TableDescriptor.GetFieldIndex("leagueid");
				FI.finalstadiums_final_stadium = table.TableDescriptor.GetFieldIndex("final_stadium");
			}
			table = fifaDb.GetTable("tourn_licensed_stages");
			if (table != null)
			{
				FI.tourn_licensed_stages_lt_numlegs = table.TableDescriptor.GetFieldIndex("lt_numlegs");
				FI.tourn_licensed_stages_lt_league3 = table.TableDescriptor.GetFieldIndex("lt_league3");
				FI.tourn_licensed_stages_lt_stage_num = table.TableDescriptor.GetFieldIndex("lt_stage_num");
				FI.tourn_licensed_stages_lt_id = table.TableDescriptor.GetFieldIndex("lt_id");
				FI.tourn_licensed_stages_lt_league2 = table.TableDescriptor.GetFieldIndex("lt_league2");
				FI.tourn_licensed_stages_lt_league4 = table.TableDescriptor.GetFieldIndex("lt_league4");
				FI.tourn_licensed_stages_lt_num_teams_in_stage = table.TableDescriptor.GetFieldIndex("lt_num_teams_in_stage");
				FI.tourn_licensed_stages_lt_league5 = table.TableDescriptor.GetFieldIndex("lt_league5");
				FI.tourn_licensed_stages_lt_drawtype = table.TableDescriptor.GetFieldIndex("lt_drawtype");
				FI.tourn_licensed_stages_lt_league6 = table.TableDescriptor.GetFieldIndex("lt_league6");
				FI.tourn_licensed_stages_lt_league1 = table.TableDescriptor.GetFieldIndex("lt_league1");
				FI.tourn_licensed_stages_lt_num_bye_teams = table.TableDescriptor.GetFieldIndex("lt_num_bye_teams");
			}
			table = fifaDb.GetTable("tourn_licensed");
			if (table != null)
			{
				FI.tourn_licensed_lt_num_teams_to_advance = table.TableDescriptor.GetFieldIndex("lt_num_teams_to_advance");
				FI.tourn_licensed_lt_id = table.TableDescriptor.GetFieldIndex("lt_id");
				FI.tourn_licensed_lt_away_goal_rules = table.TableDescriptor.GetFieldIndex("lt_away_goal_rules");
				FI.tourn_licensed_lt_num_stages = table.TableDescriptor.GetFieldIndex("lt_num_stages");
				FI.tourn_licensed_lt_yellow_card_rule = table.TableDescriptor.GetFieldIndex("lt_yellow_card_rule");
				FI.tourn_licensed_lt_num_unique_teams = table.TableDescriptor.GetFieldIndex("lt_num_unique_teams");
				FI.tourn_licensed_lt_tourn_type = table.TableDescriptor.GetFieldIndex("lt_tourn_type");
				FI.tourn_licensed_lt_country = table.TableDescriptor.GetFieldIndex("lt_country");
				FI.tourn_licensed_lt_redcard_ban = table.TableDescriptor.GetFieldIndex("lt_redcard_ban");
				FI.tourn_licensed_lt_num_teams_per_group = table.TableDescriptor.GetFieldIndex("lt_num_teams_per_group");
				FI.tourn_licensed_lt_starting_subs = table.TableDescriptor.GetFieldIndex("lt_starting_subs");
				FI.tourn_licensed_lt_assetid = table.TableDescriptor.GetFieldIndex("lt_assetid");
				FI.tourn_licensed_lt_first_stage_is_KO = table.TableDescriptor.GetFieldIndex("lt_first_stage_is_KO");
			}
			table = fifaDb.GetTable("stadiumassignments");
			if (table != null)
			{
				FI.stadiumassignments_stadiumcustomname = table.TableDescriptor.GetFieldIndex("stadiumcustomname");
				FI.stadiumassignments_teamid = table.TableDescriptor.GetFieldIndex("teamid");
			}
			table = fifaDb.GetTable("career_namesgroups");
			if (table != null)
			{
				FI.career_namesgroups_nationality = table.TableDescriptor.GetFieldIndex("nationality");
				FI.career_namesgroups_groupid = table.TableDescriptor.GetFieldIndex("groupid");
			}
			table = fifaDb.GetTable("playerloans");
			if (table != null)
			{
				FI.playerloans_playerid = table.TableDescriptor.GetFieldIndex("playerid");
				FI.playerloans_teamidloanedfrom = table.TableDescriptor.GetFieldIndex("teamidloanedfrom");
				FI.playerloans_loandateend = table.TableDescriptor.GetFieldIndex("loandateend");
			}
		}

		// Token: 0x040004DA RID: 1242
		public static int language_hashid = 0;

		// Token: 0x040004DB RID: 1243
		public static int language_stringid = 0;

		// Token: 0x040004DC RID: 1244
		public static int language_sourcetext = 1;

		// Token: 0x040004DD RID: 1245
		public static int fixtures_fixturedate = -1;

		// Token: 0x040004DE RID: 1246
		public static int fixtures_fixtureid = -1;

		// Token: 0x040004DF RID: 1247
		public static int fixtures_textid_gameotw = -1;

		// Token: 0x040004E0 RID: 1248
		public static int fixtures_hometeamid = -1;

		// Token: 0x040004E1 RID: 1249
		public static int fixtures_hometeamskill = -1;

		// Token: 0x040004E2 RID: 1250
		public static int fixtures_legno = -1;

		// Token: 0x040004E3 RID: 1251
		public static int fixtures_awayteamskill = -1;

		// Token: 0x040004E4 RID: 1252
		public static int fixtures_stageofcompetition = -1;

		// Token: 0x040004E5 RID: 1253
		public static int fixtures_competitionid = -1;

		// Token: 0x040004E6 RID: 1254
		public static int fixtures_stadiumid = -1;

		// Token: 0x040004E7 RID: 1255
		public static int fixtures_currawayprevscore = -1;

		// Token: 0x040004E8 RID: 1256
		public static int fixtures_drawmode = -1;

		// Token: 0x040004E9 RID: 1257
		public static int fixtures_competitiontype = -1;

		// Token: 0x040004EA RID: 1258
		public static int fixtures_matchimportance = -1;

		// Token: 0x040004EB RID: 1259
		public static int fixtures_multipleleg = -1;

		// Token: 0x040004EC RID: 1260
		public static int fixtures_livegametype = -1;

		// Token: 0x040004ED RID: 1261
		public static int fixtures_currhomeprevscore = -1;

		// Token: 0x040004EE RID: 1262
		public static int fixtures_fixturetime = -1;

		// Token: 0x040004EF RID: 1263
		public static int fixtures_awayteamid = -1;

		// Token: 0x040004F0 RID: 1264
		public static int player_stats_rt = -1;

		// Token: 0x040004F1 RID: 1265
		public static int player_stats_frmcode = -1;

		// Token: 0x040004F2 RID: 1266
		public static int player_stats_goals = -1;

		// Token: 0x040004F3 RID: 1267
		public static int player_stats_goals_cup = -1;

		// Token: 0x040004F4 RID: 1268
		public static int player_stats_goals_conceded = -1;

		// Token: 0x040004F5 RID: 1269
		public static int player_stats_injury_duration = -1;

		// Token: 0x040004F6 RID: 1270
		public static int player_stats_momentum_value = -1;

		// Token: 0x040004F7 RID: 1271
		public static int player_stats_saves = -1;

		// Token: 0x040004F8 RID: 1272
		public static int player_stats_red_cards_international = -1;

		// Token: 0x040004F9 RID: 1273
		public static int player_stats_gk_shots_on_target = -1;

		// Token: 0x040004FA RID: 1274
		public static int player_stats_appearances_cup = -1;

		// Token: 0x040004FB RID: 1275
		public static int player_stats_frm = -1;

		// Token: 0x040004FC RID: 1276
		public static int player_stats_total_reds = -1;

		// Token: 0x040004FD RID: 1277
		public static int player_stats_games_played_at_position = -1;

		// Token: 0x040004FE RID: 1278
		public static int player_stats_match_rating = -1;

		// Token: 0x040004FF RID: 1279
		public static int player_stats_injury_end_date = -1;

		// Token: 0x04000500 RID: 1280
		public static int player_stats_red_cards = -1;

		// Token: 0x04000501 RID: 1281
		public static int player_stats_appearances = -1;

		// Token: 0x04000502 RID: 1282
		public static int player_stats_suspended = -1;

		// Token: 0x04000503 RID: 1283
		public static int player_stats_shots_on_goal = -1;

		// Token: 0x04000504 RID: 1284
		public static int player_stats_suspended_international = -1;

		// Token: 0x04000505 RID: 1285
		public static int player_stats_assists = -1;

		// Token: 0x04000506 RID: 1286
		public static int player_stats_man_of_the_match = -1;

		// Token: 0x04000507 RID: 1287
		public static int player_stats_teamid = -1;

		// Token: 0x04000508 RID: 1288
		public static int player_stats_rating = -1;

		// Token: 0x04000509 RID: 1289
		public static int player_stats_yellow_cards = -1;

		// Token: 0x0400050A RID: 1290
		public static int player_stats_total_yellows = -1;

		// Token: 0x0400050B RID: 1291
		public static int player_stats_transfer_done = -1;

		// Token: 0x0400050C RID: 1292
		public static int player_stats_playerid = -1;

		// Token: 0x0400050D RID: 1293
		public static int player_stats_injury_type = -1;

		// Token: 0x0400050E RID: 1294
		public static int player_stats_clean_sheets = -1;

		// Token: 0x0400050F RID: 1295
		public static int player_stats_morale = -1;

		// Token: 0x04000510 RID: 1296
		public static int player_stats_yellow_cards_international = -1;

		// Token: 0x04000511 RID: 1297
		public static int player_stats_fatigue = -1;

		// Token: 0x04000512 RID: 1298
		public static int team_lookup_move_from_tsgt = -1;

		// Token: 0x04000513 RID: 1299
		public static int team_lookup_rtsgt = -1;

		// Token: 0x04000514 RID: 1300
		public static int team_lookup_final_ranking = -1;

		// Token: 0x04000515 RID: 1301
		public static int team_lookup_away_num_wins = -1;

		// Token: 0x04000516 RID: 1302
		public static int team_lookup_num_goals_for = -1;

		// Token: 0x04000517 RID: 1303
		public static int team_lookup_away_num_losses = -1;

		// Token: 0x04000518 RID: 1304
		public static int team_lookup_num_draws = -1;

		// Token: 0x04000519 RID: 1305
		public static int team_lookup_num_wins = -1;

		// Token: 0x0400051A RID: 1306
		public static int team_lookup_goals_for_home = -1;

		// Token: 0x0400051B RID: 1307
		public static int team_lookup_goals_for_away = -1;

		// Token: 0x0400051C RID: 1308
		public static int team_lookup_goals_against_home = -1;

		// Token: 0x0400051D RID: 1309
		public static int team_lookup_goals_against_away = -1;

		// Token: 0x0400051E RID: 1310
		public static int team_lookup_num_yellow_cards = -1;

		// Token: 0x0400051F RID: 1311
		public static int team_lookup_num_losses = -1;

		// Token: 0x04000520 RID: 1312
		public static int team_lookup_teamid = -1;

		// Token: 0x04000521 RID: 1313
		public static int team_lookup_outcome = -1;

		// Token: 0x04000522 RID: 1314
		public static int team_lookup_away_num_draws = -1;

		// Token: 0x04000523 RID: 1315
		public static int team_lookup_points = -1;

		// Token: 0x04000524 RID: 1316
		public static int team_lookup_played = -1;

		// Token: 0x04000525 RID: 1317
		public static int team_lookup_num_goals_against = -1;

		// Token: 0x04000526 RID: 1318
		public static int team_lookup_num_clean_sheets = -1;

		// Token: 0x04000527 RID: 1319
		public static int team_lookup_num_red_cards = -1;

		// Token: 0x04000528 RID: 1320
		public static int team_lookup_goal_diff = -1;

		// Token: 0x04000529 RID: 1321
		public static int assetcryptokeys_key = -1;

		// Token: 0x0400052A RID: 1322
		public static int assetcryptokeys_keyid = -1;

		// Token: 0x0400052B RID: 1323
		public static int assetcryptokeys_artificialkey = -1;

		// Token: 0x0400052C RID: 1324
		public static int version_exportdate = -1;

		// Token: 0x0400052D RID: 1325
		public static int version_schema = -1;

		// Token: 0x0400052E RID: 1326
		public static int version_isonline = -1;

		// Token: 0x0400052F RID: 1327
		public static int version_minor = -1;

		// Token: 0x04000530 RID: 1328
		public static int version_artificialkey = -1;

		// Token: 0x04000531 RID: 1329
		public static int version_major = -1;

		// Token: 0x04000532 RID: 1330
		public static int transactionhistory_movedto = -1;

		// Token: 0x04000533 RID: 1331
		public static int transactionhistory_teamid = -1;

		// Token: 0x04000534 RID: 1332
		public static int transactionhistory_playerid = -1;

		// Token: 0x04000535 RID: 1333
		public static int trainingteamplayers_birthdate = -1;

		// Token: 0x04000536 RID: 1334
		public static int trainingteamplayers_playerjointeamdate = -1;

		// Token: 0x04000537 RID: 1335
		public static int trainingteamplayers_shoetypecode = -1;

		// Token: 0x04000538 RID: 1336
		public static int trainingteamplayers_haircolorcode = -1;

		// Token: 0x04000539 RID: 1337
		public static int trainingteamplayers_facialhairtypecode = -1;

		// Token: 0x0400053A RID: 1338
		public static int trainingteamplayers_curve = -1;

		// Token: 0x0400053B RID: 1339
		public static int trainingteamplayers_jerseystylecode = -1;

		// Token: 0x0400053C RID: 1340
		public static int trainingteamplayers_agility = -1;

		// Token: 0x0400053D RID: 1341
		public static int trainingteamplayers_accessorycode4 = -1;

		// Token: 0x0400053E RID: 1342
		public static int trainingteamplayers_gksavetype = -1;

		// Token: 0x0400053F RID: 1343
		public static int trainingteamplayers_positioning = -1;

		// Token: 0x04000540 RID: 1344
		public static int trainingteamplayers_hairtypecode = -1;

		// Token: 0x04000541 RID: 1345
		public static int trainingteamplayers_standingtackle = -1;

		// Token: 0x04000542 RID: 1346
		public static int trainingteamplayers_faceposercode = -1;

		// Token: 0x04000543 RID: 1347
		public static int trainingteamplayers_preferredposition3 = -1;

		// Token: 0x04000544 RID: 1348
		public static int trainingteamplayers_longpassing = -1;

		// Token: 0x04000545 RID: 1349
		public static int trainingteamplayers_penalties = -1;

		// Token: 0x04000546 RID: 1350
		public static int trainingteamplayers_animfreekickstartposcode = -1;

		// Token: 0x04000547 RID: 1351
		public static int trainingteamplayers_animpenaltieskickstylecode = -1;

		// Token: 0x04000548 RID: 1352
		public static int trainingteamplayers_isretiring = -1;

		// Token: 0x04000549 RID: 1353
		public static int trainingteamplayers_longshots = -1;

		// Token: 0x0400054A RID: 1354
		public static int trainingteamplayers_gkdiving = -1;

		// Token: 0x0400054B RID: 1355
		public static int trainingteamplayers_interceptions = -1;

		// Token: 0x0400054C RID: 1356
		public static int trainingteamplayers_shoecolorcode2 = -1;

		// Token: 0x0400054D RID: 1357
		public static int trainingteamplayers_crossing = -1;

		// Token: 0x0400054E RID: 1358
		public static int trainingteamplayers_potential = -1;

		// Token: 0x0400054F RID: 1359
		public static int trainingteamplayers_gkreflexes = -1;

		// Token: 0x04000550 RID: 1360
		public static int trainingteamplayers_finishingcode1 = -1;

		// Token: 0x04000551 RID: 1361
		public static int trainingteamplayers_reactions = -1;

		// Token: 0x04000552 RID: 1362
		public static int trainingteamplayers_vision = -1;

		// Token: 0x04000553 RID: 1363
		public static int trainingteamplayers_contractvaliduntil = -1;

		// Token: 0x04000554 RID: 1364
		public static int trainingteamplayers_finishing = -1;

		// Token: 0x04000555 RID: 1365
		public static int trainingteamplayers_dribbling = -1;

		// Token: 0x04000556 RID: 1366
		public static int trainingteamplayers_slidingtackle = -1;

		// Token: 0x04000557 RID: 1367
		public static int trainingteamplayers_accessorycode3 = -1;

		// Token: 0x04000558 RID: 1368
		public static int trainingteamplayers_accessorycolourcode1 = -1;

		// Token: 0x04000559 RID: 1369
		public static int trainingteamplayers_headtypecode = -1;

		// Token: 0x0400055A RID: 1370
		public static int trainingteamplayers_firstnameid = -1;

		// Token: 0x0400055B RID: 1371
		public static int trainingteamplayers_sprintspeed = -1;

		// Token: 0x0400055C RID: 1372
		public static int trainingteamplayers_height = -1;

		// Token: 0x0400055D RID: 1373
		public static int trainingteamplayers_hasseasonaljersey = -1;

		// Token: 0x0400055E RID: 1374
		public static int trainingteamplayers_preferredposition2 = -1;

		// Token: 0x0400055F RID: 1375
		public static int trainingteamplayers_strength = -1;

		// Token: 0x04000560 RID: 1376
		public static int trainingteamplayers_preferredposition1 = -1;

		// Token: 0x04000561 RID: 1377
		public static int trainingteamplayers_ballcontrol = -1;

		// Token: 0x04000562 RID: 1378
		public static int trainingteamplayers_shotpower = -1;

		// Token: 0x04000563 RID: 1379
		public static int trainingteamplayers_trait1 = -1;

		// Token: 0x04000564 RID: 1380
		public static int trainingteamplayers_socklengthcode = -1;

		// Token: 0x04000565 RID: 1381
		public static int trainingteamplayers_weight = -1;

		// Token: 0x04000566 RID: 1382
		public static int trainingteamplayers_hashighqualityhead = -1;

		// Token: 0x04000567 RID: 1383
		public static int trainingteamplayers_gkglovetypecode = -1;

		// Token: 0x04000568 RID: 1384
		public static int trainingteamplayers_balance = -1;

		// Token: 0x04000569 RID: 1385
		public static int trainingteamplayers_gkkicking = -1;

		// Token: 0x0400056A RID: 1386
		public static int trainingteamplayers_lastnameid = -1;

		// Token: 0x0400056B RID: 1387
		public static int trainingteamplayers_internationalrep = -1;

		// Token: 0x0400056C RID: 1388
		public static int trainingteamplayers_animpenaltiesmotionstylecode = -1;

		// Token: 0x0400056D RID: 1389
		public static int trainingteamplayers_shortpassing = -1;

		// Token: 0x0400056E RID: 1390
		public static int trainingteamplayers_freekickaccuracy = -1;

		// Token: 0x0400056F RID: 1391
		public static int trainingteamplayers_skillmoves = -1;

		// Token: 0x04000570 RID: 1392
		public static int trainingteamplayers_usercaneditname = -1;

		// Token: 0x04000571 RID: 1393
		public static int trainingteamplayers_attackingworkrate = -1;

		// Token: 0x04000572 RID: 1394
		public static int trainingteamplayers_finishingcode2 = -1;

		// Token: 0x04000573 RID: 1395
		public static int trainingteamplayers_aggression = -1;

		// Token: 0x04000574 RID: 1396
		public static int trainingteamplayers_acceleration = -1;

		// Token: 0x04000575 RID: 1397
		public static int trainingteamplayers_headingaccuracy = -1;

		// Token: 0x04000576 RID: 1398
		public static int trainingteamplayers_eyebrowcode = -1;

		// Token: 0x04000577 RID: 1399
		public static int trainingteamplayers_runningcode2 = -1;

		// Token: 0x04000578 RID: 1400
		public static int trainingteamplayers_gkhandling = -1;

		// Token: 0x04000579 RID: 1401
		public static int trainingteamplayers_eyecolorcode = -1;

		// Token: 0x0400057A RID: 1402
		public static int trainingteamplayers_jerseysleevelengthcode = -1;

		// Token: 0x0400057B RID: 1403
		public static int trainingteamplayers_accessorycolourcode3 = -1;

		// Token: 0x0400057C RID: 1404
		public static int trainingteamplayers_accessorycode1 = -1;

		// Token: 0x0400057D RID: 1405
		public static int trainingteamplayers_headclasscode = -1;

		// Token: 0x0400057E RID: 1406
		public static int trainingteamplayers_defensiveworkrate = -1;

		// Token: 0x0400057F RID: 1407
		public static int trainingteamplayers_nationality = -1;

		// Token: 0x04000580 RID: 1408
		public static int trainingteamplayers_preferredfoot = -1;

		// Token: 0x04000581 RID: 1409
		public static int trainingteamplayers_sideburnscode = -1;

		// Token: 0x04000582 RID: 1410
		public static int trainingteamplayers_weakfootabilitytypecode = -1;

		// Token: 0x04000583 RID: 1411
		public static int trainingteamplayers_jumping = -1;

		// Token: 0x04000584 RID: 1412
		public static int trainingteamplayers_skintypecode = -1;

		// Token: 0x04000585 RID: 1413
		public static int trainingteamplayers_gkkickstyle = -1;

		// Token: 0x04000586 RID: 1414
		public static int trainingteamplayers_stamina = -1;

		// Token: 0x04000587 RID: 1415
		public static int trainingteamplayers_playerid = -1;

		// Token: 0x04000588 RID: 1416
		public static int trainingteamplayers_marking = -1;

		// Token: 0x04000589 RID: 1417
		public static int trainingteamplayers_accessorycolourcode4 = -1;

		// Token: 0x0400058A RID: 1418
		public static int trainingteamplayers_gkpositioning = -1;

		// Token: 0x0400058B RID: 1419
		public static int trainingteamplayers_trait2 = -1;

		// Token: 0x0400058C RID: 1420
		public static int trainingteamplayers_skintonecode = -1;

		// Token: 0x0400058D RID: 1421
		public static int trainingteamplayers_shortstyle = -1;

		// Token: 0x0400058E RID: 1422
		public static int trainingteamplayers_overallrating = -1;

		// Token: 0x0400058F RID: 1423
		public static int trainingteamplayers_jerseyfit = -1;

		// Token: 0x04000590 RID: 1424
		public static int trainingteamplayers_accessorycode2 = -1;

		// Token: 0x04000591 RID: 1425
		public static int trainingteamplayers_shoedesigncode = -1;

		// Token: 0x04000592 RID: 1426
		public static int trainingteamplayers_playerjerseynameid = -1;

		// Token: 0x04000593 RID: 1427
		public static int trainingteamplayers_shoecolorcode1 = -1;

		// Token: 0x04000594 RID: 1428
		public static int trainingteamplayers_commonnameid = -1;

		// Token: 0x04000595 RID: 1429
		public static int trainingteamplayers_bodytypecode = -1;

		// Token: 0x04000596 RID: 1430
		public static int trainingteamplayers_animpenaltiesstartposcode = -1;

		// Token: 0x04000597 RID: 1431
		public static int trainingteamplayers_runningcode1 = -1;

		// Token: 0x04000598 RID: 1432
		public static int trainingteamplayers_preferredposition4 = -1;

		// Token: 0x04000599 RID: 1433
		public static int trainingteamplayers_volleys = -1;

		// Token: 0x0400059A RID: 1434
		public static int trainingteamplayers_accessorycolourcode2 = -1;

		// Token: 0x0400059B RID: 1435
		public static int trainingteamplayers_facialhaircolorcode = -1;

		// Token: 0x0400059C RID: 1436
		public static int trainingteamplayernames_name = -1;

		// Token: 0x0400059D RID: 1437
		public static int trainingteamplayernames_commentaryid = -1;

		// Token: 0x0400059E RID: 1438
		public static int trainingteamplayernames_nameid = -1;

		// Token: 0x0400059F RID: 1439
		public static int trainingteamplayerlinks_jerseynumber = -1;

		// Token: 0x040005A0 RID: 1440
		public static int trainingteamplayerlinks_position = -1;

		// Token: 0x040005A1 RID: 1441
		public static int trainingteamplayerlinks_playerid = -1;

		// Token: 0x040005A2 RID: 1442
		public static int temp_teams_assetid = -1;

		// Token: 0x040005A3 RID: 1443
		public static int temp_teams_balltype = -1;

		// Token: 0x040005A4 RID: 1444
		public static int temp_teams_teamcolor1g = -1;

		// Token: 0x040005A5 RID: 1445
		public static int temp_teams_teamcolor1r = -1;

		// Token: 0x040005A6 RID: 1446
		public static int temp_teams_teamcolor2b = -1;

		// Token: 0x040005A7 RID: 1447
		public static int temp_teams_teamcolor2r = -1;

		// Token: 0x040005A8 RID: 1448
		public static int temp_teams_teamcolor3r = -1;

		// Token: 0x040005A9 RID: 1449
		public static int temp_teams_teamcolor1b = -1;

		// Token: 0x040005AA RID: 1450
		public static int temp_teams_latitude = -1;

		// Token: 0x040005AB RID: 1451
		public static int temp_teams_teamcolor3g = -1;

		// Token: 0x040005AC RID: 1452
		public static int temp_teams_teamcolor2g = -1;

		// Token: 0x040005AD RID: 1453
		public static int temp_teams_teamname = -1;

		// Token: 0x040005AE RID: 1454
		public static int temp_teams_adboardid = -1;

		// Token: 0x040005AF RID: 1455
		public static int temp_teams_teamcolor3b = -1;

		// Token: 0x040005B0 RID: 1456
		public static int temp_teams_defmentality = -1;

		// Token: 0x040005B1 RID: 1457
		public static int temp_teams_powid = -1;

		// Token: 0x040005B2 RID: 1458
		public static int temp_teams_physioid_secondary = -1;

		// Token: 0x040005B3 RID: 1459
		public static int temp_teams_domesticprestige = -1;

		// Token: 0x040005B4 RID: 1460
		public static int temp_teams_genericint2 = -1;

		// Token: 0x040005B5 RID: 1461
		public static int temp_teams_jerseytype = -1;

		// Token: 0x040005B6 RID: 1462
		public static int temp_teams_rivalteam = -1;

		// Token: 0x040005B7 RID: 1463
		public static int temp_teams_midfieldrating = -1;

		// Token: 0x040005B8 RID: 1464
		public static int temp_teams_matchdayoverallrating = -1;

		// Token: 0x040005B9 RID: 1465
		public static int temp_teams_matchdaymidfieldrating = -1;

		// Token: 0x040005BA RID: 1466
		public static int temp_teams_attackrating = -1;

		// Token: 0x040005BB RID: 1467
		public static int temp_teams_physioid_primary = -1;

		// Token: 0x040005BC RID: 1468
		public static int temp_teams_longitude = -1;

		// Token: 0x040005BD RID: 1469
		public static int temp_teams_buspassing = -1;

		// Token: 0x040005BE RID: 1470
		public static int temp_teams_matchdaydefenserating = -1;

		// Token: 0x040005BF RID: 1471
		public static int temp_teams_defenserating = -1;

		// Token: 0x040005C0 RID: 1472
		public static int temp_teams_defteamwidth = -1;

		// Token: 0x040005C1 RID: 1473
		public static int temp_teams_longkicktakerid = -1;

		// Token: 0x040005C2 RID: 1474
		public static int temp_teams_bodytypeid = -1;

		// Token: 0x040005C3 RID: 1475
		public static int temp_teams_rightcornerkicktakerid = -1;

		// Token: 0x040005C4 RID: 1476
		public static int temp_teams_suitvariationid = -1;

		// Token: 0x040005C5 RID: 1477
		public static int temp_teams_defaggression = -1;

		// Token: 0x040005C6 RID: 1478
		public static int temp_teams_ethnicity = -1;

		// Token: 0x040005C7 RID: 1479
		public static int temp_teams_leftcornerkicktakerid = -1;

		// Token: 0x040005C8 RID: 1480
		public static int temp_teams_teamid = -1;

		// Token: 0x040005C9 RID: 1481
		public static int temp_teams_fancrowdhairskintexturecode = -1;

		// Token: 0x040005CA RID: 1482
		public static int temp_teams_suittypeid = -1;

		// Token: 0x040005CB RID: 1483
		public static int temp_teams_numtransfersin = -1;

		// Token: 0x040005CC RID: 1484
		public static int temp_teams_captainid = -1;

		// Token: 0x040005CD RID: 1485
		public static int temp_teams_personalityid = -1;

		// Token: 0x040005CE RID: 1486
		public static int temp_teams_genericbanner = -1;

		// Token: 0x040005CF RID: 1487
		public static int temp_teams_buspositioning = -1;

		// Token: 0x040005D0 RID: 1488
		public static int temp_teams_stafftracksuitcolorcode = -1;

		// Token: 0x040005D1 RID: 1489
		public static int temp_teams_ccpositioning = -1;

		// Token: 0x040005D2 RID: 1490
		public static int temp_teams_busbuildupspeed = -1;

		// Token: 0x040005D3 RID: 1491
		public static int temp_teams_transferbudget = -1;

		// Token: 0x040005D4 RID: 1492
		public static int temp_teams_ccshooting = -1;

		// Token: 0x040005D5 RID: 1493
		public static int temp_teams_overallrating = -1;

		// Token: 0x040005D6 RID: 1494
		public static int temp_teams_ccpassing = -1;

		// Token: 0x040005D7 RID: 1495
		public static int temp_teams_utcoffset = -1;

		// Token: 0x040005D8 RID: 1496
		public static int temp_teams_penaltytakerid = -1;

		// Token: 0x040005D9 RID: 1497
		public static int temp_teams_freekicktakerid = -1;

		// Token: 0x040005DA RID: 1498
		public static int temp_teams_defdefenderline = -1;

		// Token: 0x040005DB RID: 1499
		public static int temp_teams_internationalprestige = -1;

		// Token: 0x040005DC RID: 1500
		public static int temp_teams_form = -1;

		// Token: 0x040005DD RID: 1501
		public static int temp_teams_genericint1 = -1;

		// Token: 0x040005DE RID: 1502
		public static int temp_teams_cccrossing = -1;

		// Token: 0x040005DF RID: 1503
		public static int temp_teams_matchdayattackrating = -1;

		// Token: 0x040005E0 RID: 1504
		public static int temp_teamplayerlinks_leaguegoals = -1;

		// Token: 0x040005E1 RID: 1505
		public static int temp_teamplayerlinks_isamongtopscorers = -1;

		// Token: 0x040005E2 RID: 1506
		public static int temp_teamplayerlinks_yellows = -1;

		// Token: 0x040005E3 RID: 1507
		public static int temp_teamplayerlinks_isamongtopscorersinteam = -1;

		// Token: 0x040005E4 RID: 1508
		public static int temp_teamplayerlinks_jerseynumber = -1;

		// Token: 0x040005E5 RID: 1509
		public static int temp_teamplayerlinks_position = -1;

		// Token: 0x040005E6 RID: 1510
		public static int temp_teamplayerlinks_artificialkey = -1;

		// Token: 0x040005E7 RID: 1511
		public static int temp_teamplayerlinks_teamid = -1;

		// Token: 0x040005E8 RID: 1512
		public static int temp_teamplayerlinks_injury = -1;

		// Token: 0x040005E9 RID: 1513
		public static int temp_teamplayerlinks_leagueappearances = -1;

		// Token: 0x040005EA RID: 1514
		public static int temp_teamplayerlinks_prevform = -1;

		// Token: 0x040005EB RID: 1515
		public static int temp_teamplayerlinks_istopscorer = -1;

		// Token: 0x040005EC RID: 1516
		public static int temp_teamplayerlinks_playerid = -1;

		// Token: 0x040005ED RID: 1517
		public static int temp_teamplayerlinks_form = -1;

		// Token: 0x040005EE RID: 1518
		public static int temp_teamplayerlinks_reds = -1;

		// Token: 0x040005EF RID: 1519
		public static int temp_players_birthdate = -1;

		// Token: 0x040005F0 RID: 1520
		public static int temp_players_playerjointeamdate = -1;

		// Token: 0x040005F1 RID: 1521
		public static int temp_players_shoetypecode = -1;

		// Token: 0x040005F2 RID: 1522
		public static int temp_players_haircolorcode = -1;

		// Token: 0x040005F3 RID: 1523
		public static int temp_players_facialhairtypecode = -1;

		// Token: 0x040005F4 RID: 1524
		public static int temp_players_curve = -1;

		// Token: 0x040005F5 RID: 1525
		public static int temp_players_jerseystylecode = -1;

		// Token: 0x040005F6 RID: 1526
		public static int temp_players_agility = -1;

		// Token: 0x040005F7 RID: 1527
		public static int temp_players_accessorycode4 = -1;

		// Token: 0x040005F8 RID: 1528
		public static int temp_players_gksavetype = -1;

		// Token: 0x040005F9 RID: 1529
		public static int temp_players_positioning = -1;

		// Token: 0x040005FA RID: 1530
		public static int temp_players_hairtypecode = -1;

		// Token: 0x040005FB RID: 1531
		public static int temp_players_standingtackle = -1;

		// Token: 0x040005FC RID: 1532
		public static int temp_players_faceposercode = -1;

		// Token: 0x040005FD RID: 1533
		public static int temp_players_preferredposition3 = -1;

		// Token: 0x040005FE RID: 1534
		public static int temp_players_longpassing = -1;

		// Token: 0x040005FF RID: 1535
		public static int temp_players_penalties = -1;

		// Token: 0x04000600 RID: 1536
		public static int temp_players_animfreekickstartposcode = -1;

		// Token: 0x04000601 RID: 1537
		public static int temp_players_animpenaltieskickstylecode = -1;

		// Token: 0x04000602 RID: 1538
		public static int temp_players_isretiring = -1;

		// Token: 0x04000603 RID: 1539
		public static int temp_players_longshots = -1;

		// Token: 0x04000604 RID: 1540
		public static int temp_players_gkdiving = -1;

		// Token: 0x04000605 RID: 1541
		public static int temp_players_interceptions = -1;

		// Token: 0x04000606 RID: 1542
		public static int temp_players_shoecolorcode2 = -1;

		// Token: 0x04000607 RID: 1543
		public static int temp_players_crossing = -1;

		// Token: 0x04000608 RID: 1544
		public static int temp_players_potential = -1;

		// Token: 0x04000609 RID: 1545
		public static int temp_players_gkreflexes = -1;

		// Token: 0x0400060A RID: 1546
		public static int temp_players_finishingcode1 = -1;

		// Token: 0x0400060B RID: 1547
		public static int temp_players_reactions = -1;

		// Token: 0x0400060C RID: 1548
		public static int temp_players_vision = -1;

		// Token: 0x0400060D RID: 1549
		public static int temp_players_contractvaliduntil = -1;

		// Token: 0x0400060E RID: 1550
		public static int temp_players_finishing = -1;

		// Token: 0x0400060F RID: 1551
		public static int temp_players_dribbling = -1;

		// Token: 0x04000610 RID: 1552
		public static int temp_players_slidingtackle = -1;

		// Token: 0x04000611 RID: 1553
		public static int temp_players_accessorycode3 = -1;

		// Token: 0x04000612 RID: 1554
		public static int temp_players_accessorycolourcode1 = -1;

		// Token: 0x04000613 RID: 1555
		public static int temp_players_headtypecode = -1;

		// Token: 0x04000614 RID: 1556
		public static int temp_players_firstnameid = -1;

		// Token: 0x04000615 RID: 1557
		public static int temp_players_sprintspeed = -1;

		// Token: 0x04000616 RID: 1558
		public static int temp_players_height = -1;

		// Token: 0x04000617 RID: 1559
		public static int temp_players_hasseasonaljersey = -1;

		// Token: 0x04000618 RID: 1560
		public static int temp_players_preferredposition2 = -1;

		// Token: 0x04000619 RID: 1561
		public static int temp_players_strength = -1;

		// Token: 0x0400061A RID: 1562
		public static int temp_players_preferredposition1 = -1;

		// Token: 0x0400061B RID: 1563
		public static int temp_players_ballcontrol = -1;

		// Token: 0x0400061C RID: 1564
		public static int temp_players_shotpower = -1;

		// Token: 0x0400061D RID: 1565
		public static int temp_players_trait1 = -1;

		// Token: 0x0400061E RID: 1566
		public static int temp_players_socklengthcode = -1;

		// Token: 0x0400061F RID: 1567
		public static int temp_players_weight = -1;

		// Token: 0x04000620 RID: 1568
		public static int temp_players_hashighqualityhead = -1;

		// Token: 0x04000621 RID: 1569
		public static int temp_players_gkglovetypecode = -1;

		// Token: 0x04000622 RID: 1570
		public static int temp_players_balance = -1;

		// Token: 0x04000623 RID: 1571
		public static int temp_players_gkkicking = -1;

		// Token: 0x04000624 RID: 1572
		public static int temp_players_lastnameid = -1;

		// Token: 0x04000625 RID: 1573
		public static int temp_players_internationalrep = -1;

		// Token: 0x04000626 RID: 1574
		public static int temp_players_animpenaltiesmotionstylecode = -1;

		// Token: 0x04000627 RID: 1575
		public static int temp_players_shortpassing = -1;

		// Token: 0x04000628 RID: 1576
		public static int temp_players_freekickaccuracy = -1;

		// Token: 0x04000629 RID: 1577
		public static int temp_players_skillmoves = -1;

		// Token: 0x0400062A RID: 1578
		public static int temp_players_usercaneditname = -1;

		// Token: 0x0400062B RID: 1579
		public static int temp_players_attackingworkrate = -1;

		// Token: 0x0400062C RID: 1580
		public static int temp_players_finishingcode2 = -1;

		// Token: 0x0400062D RID: 1581
		public static int temp_players_aggression = -1;

		// Token: 0x0400062E RID: 1582
		public static int temp_players_acceleration = -1;

		// Token: 0x0400062F RID: 1583
		public static int temp_players_headingaccuracy = -1;

		// Token: 0x04000630 RID: 1584
		public static int temp_players_eyebrowcode = -1;

		// Token: 0x04000631 RID: 1585
		public static int temp_players_runningcode2 = -1;

		// Token: 0x04000632 RID: 1586
		public static int temp_players_gkhandling = -1;

		// Token: 0x04000633 RID: 1587
		public static int temp_players_eyecolorcode = -1;

		// Token: 0x04000634 RID: 1588
		public static int temp_players_jerseysleevelengthcode = -1;

		// Token: 0x04000635 RID: 1589
		public static int temp_players_accessorycolourcode3 = -1;

		// Token: 0x04000636 RID: 1590
		public static int temp_players_accessorycode1 = -1;

		// Token: 0x04000637 RID: 1591
		public static int temp_players_headclasscode = -1;

		// Token: 0x04000638 RID: 1592
		public static int temp_players_defensiveworkrate = -1;

		// Token: 0x04000639 RID: 1593
		public static int temp_players_nationality = -1;

		// Token: 0x0400063A RID: 1594
		public static int temp_players_preferredfoot = -1;

		// Token: 0x0400063B RID: 1595
		public static int temp_players_sideburnscode = -1;

		// Token: 0x0400063C RID: 1596
		public static int temp_players_weakfootabilitytypecode = -1;

		// Token: 0x0400063D RID: 1597
		public static int temp_players_jumping = -1;

		// Token: 0x0400063E RID: 1598
		public static int temp_players_skintypecode = -1;

		// Token: 0x0400063F RID: 1599
		public static int temp_players_gkkickstyle = -1;

		// Token: 0x04000640 RID: 1600
		public static int temp_players_stamina = -1;

		// Token: 0x04000641 RID: 1601
		public static int temp_players_playerid = -1;

		// Token: 0x04000642 RID: 1602
		public static int temp_players_marking = -1;

		// Token: 0x04000643 RID: 1603
		public static int temp_players_accessorycolourcode4 = -1;

		// Token: 0x04000644 RID: 1604
		public static int temp_players_gkpositioning = -1;

		// Token: 0x04000645 RID: 1605
		public static int temp_players_trait2 = -1;

		// Token: 0x04000646 RID: 1606
		public static int temp_players_skintonecode = -1;

		// Token: 0x04000647 RID: 1607
		public static int temp_players_shortstyle = -1;

		// Token: 0x04000648 RID: 1608
		public static int temp_players_overallrating = -1;

		// Token: 0x04000649 RID: 1609
		public static int temp_players_jerseyfit = -1;

		// Token: 0x0400064A RID: 1610
		public static int temp_players_accessorycode2 = -1;

		// Token: 0x0400064B RID: 1611
		public static int temp_players_shoedesigncode = -1;

		// Token: 0x0400064C RID: 1612
		public static int temp_players_playerjerseynameid = -1;

		// Token: 0x0400064D RID: 1613
		public static int temp_players_shoecolorcode1 = -1;

		// Token: 0x0400064E RID: 1614
		public static int temp_players_commonnameid = -1;

		// Token: 0x0400064F RID: 1615
		public static int temp_players_bodytypecode = -1;

		// Token: 0x04000650 RID: 1616
		public static int temp_players_animpenaltiesstartposcode = -1;

		// Token: 0x04000651 RID: 1617
		public static int temp_players_runningcode1 = -1;

		// Token: 0x04000652 RID: 1618
		public static int temp_players_preferredposition4 = -1;

		// Token: 0x04000653 RID: 1619
		public static int temp_players_volleys = -1;

		// Token: 0x04000654 RID: 1620
		public static int temp_players_accessorycolourcode2 = -1;

		// Token: 0x04000655 RID: 1621
		public static int temp_players_facialhaircolorcode = -1;

		// Token: 0x04000656 RID: 1622
		public static int temp_formations_offset6x = -1;

		// Token: 0x04000657 RID: 1623
		public static int temp_formations_offset5y = -1;

		// Token: 0x04000658 RID: 1624
		public static int temp_formations_offset10x = -1;

		// Token: 0x04000659 RID: 1625
		public static int temp_formations_offset2x = -1;

		// Token: 0x0400065A RID: 1626
		public static int temp_formations_defenders = -1;

		// Token: 0x0400065B RID: 1627
		public static int temp_formations_offset2y = -1;

		// Token: 0x0400065C RID: 1628
		public static int temp_formations_offset6y = -1;

		// Token: 0x0400065D RID: 1629
		public static int temp_formations_offset7x = -1;

		// Token: 0x0400065E RID: 1630
		public static int temp_formations_offset3x = -1;

		// Token: 0x0400065F RID: 1631
		public static int temp_formations_offset8x = -1;

		// Token: 0x04000660 RID: 1632
		public static int temp_formations_offset10y = -1;

		// Token: 0x04000661 RID: 1633
		public static int temp_formations_offset3y = -1;

		// Token: 0x04000662 RID: 1634
		public static int temp_formations_offset4x = -1;

		// Token: 0x04000663 RID: 1635
		public static int temp_formations_offset7y = -1;

		// Token: 0x04000664 RID: 1636
		public static int temp_formations_offset0x = -1;

		// Token: 0x04000665 RID: 1637
		public static int temp_formations_offset8y = -1;

		// Token: 0x04000666 RID: 1638
		public static int temp_formations_attackers = -1;

		// Token: 0x04000667 RID: 1639
		public static int temp_formations_offset9x = -1;

		// Token: 0x04000668 RID: 1640
		public static int temp_formations_midfielders = -1;

		// Token: 0x04000669 RID: 1641
		public static int temp_formations_offset5x = -1;

		// Token: 0x0400066A RID: 1642
		public static int temp_formations_offset0y = -1;

		// Token: 0x0400066B RID: 1643
		public static int temp_formations_offset1x = -1;

		// Token: 0x0400066C RID: 1644
		public static int temp_formations_offset4y = -1;

		// Token: 0x0400066D RID: 1645
		public static int temp_formations_offset9y = -1;

		// Token: 0x0400066E RID: 1646
		public static int temp_formations_offset1y = -1;

		// Token: 0x0400066F RID: 1647
		public static int temp_formations_formationname = -1;

		// Token: 0x04000670 RID: 1648
		public static int temp_formations_attackingdirection_0 = -1;

		// Token: 0x04000671 RID: 1649
		public static int temp_formations_attackingrole_5 = -1;

		// Token: 0x04000672 RID: 1650
		public static int temp_formations_position10 = -1;

		// Token: 0x04000673 RID: 1651
		public static int temp_formations_attackingdirection_7 = -1;

		// Token: 0x04000674 RID: 1652
		public static int temp_formations_defensivedirection_0 = -1;

		// Token: 0x04000675 RID: 1653
		public static int temp_formations_defensivedirection_9 = -1;

		// Token: 0x04000676 RID: 1654
		public static int temp_formations_defensivedirection_8 = -1;

		// Token: 0x04000677 RID: 1655
		public static int temp_formations_attackingdirection_9 = -1;

		// Token: 0x04000678 RID: 1656
		public static int temp_formations_position6 = -1;

		// Token: 0x04000679 RID: 1657
		public static int temp_formations_attackingrole_4 = -1;

		// Token: 0x0400067A RID: 1658
		public static int temp_formations_offensiverating = -1;

		// Token: 0x0400067B RID: 1659
		public static int temp_formations_attackingrole_2 = -1;

		// Token: 0x0400067C RID: 1660
		public static int temp_formations_attackingdirection_1 = -1;

		// Token: 0x0400067D RID: 1661
		public static int temp_formations_position8 = -1;

		// Token: 0x0400067E RID: 1662
		public static int temp_formations_defensiverole_4 = -1;

		// Token: 0x0400067F RID: 1663
		public static int temp_formations_attackingdirection_10 = -1;

		// Token: 0x04000680 RID: 1664
		public static int temp_formations_defensivedirection_6 = -1;

		// Token: 0x04000681 RID: 1665
		public static int temp_formations_attackingdirection_8 = -1;

		// Token: 0x04000682 RID: 1666
		public static int temp_formations_attackingrole_3 = -1;

		// Token: 0x04000683 RID: 1667
		public static int temp_formations_defensiverole_3 = -1;

		// Token: 0x04000684 RID: 1668
		public static int temp_formations_attackingrole_0 = -1;

		// Token: 0x04000685 RID: 1669
		public static int temp_formations_defensivedirection_1 = -1;

		// Token: 0x04000686 RID: 1670
		public static int temp_formations_attackingdirection_5 = -1;

		// Token: 0x04000687 RID: 1671
		public static int temp_formations_defensivedirection_2 = -1;

		// Token: 0x04000688 RID: 1672
		public static int temp_formations_attackingdirection_6 = -1;

		// Token: 0x04000689 RID: 1673
		public static int temp_formations_position5 = -1;

		// Token: 0x0400068A RID: 1674
		public static int temp_formations_attackingrole_7 = -1;

		// Token: 0x0400068B RID: 1675
		public static int temp_formations_defensiverole_5 = -1;

		// Token: 0x0400068C RID: 1676
		public static int temp_formations_defensivedirection_10 = -1;

		// Token: 0x0400068D RID: 1677
		public static int temp_formations_defensivedirection_3 = -1;

		// Token: 0x0400068E RID: 1678
		public static int temp_formations_defensivedirection_5 = -1;

		// Token: 0x0400068F RID: 1679
		public static int temp_formations_issweeper = -1;

		// Token: 0x04000690 RID: 1680
		public static int temp_formations_attackingdirection_2 = -1;

		// Token: 0x04000691 RID: 1681
		public static int temp_formations_attackingdirection_4 = -1;

		// Token: 0x04000692 RID: 1682
		public static int temp_formations_attackingrole_9 = -1;

		// Token: 0x04000693 RID: 1683
		public static int temp_formations_defensiverole_2 = -1;

		// Token: 0x04000694 RID: 1684
		public static int temp_formations_attackingdirection_3 = -1;

		// Token: 0x04000695 RID: 1685
		public static int temp_formations_attackingrole_8 = -1;

		// Token: 0x04000696 RID: 1686
		public static int temp_formations_attackingrole_1 = -1;

		// Token: 0x04000697 RID: 1687
		public static int temp_formations_defensiverole_10 = -1;

		// Token: 0x04000698 RID: 1688
		public static int temp_formations_defensiverole_1 = -1;

		// Token: 0x04000699 RID: 1689
		public static int temp_formations_teamid = -1;

		// Token: 0x0400069A RID: 1690
		public static int temp_formations_position2 = -1;

		// Token: 0x0400069B RID: 1691
		public static int temp_formations_defensivedirection_4 = -1;

		// Token: 0x0400069C RID: 1692
		public static int temp_formations_formationid = -1;

		// Token: 0x0400069D RID: 1693
		public static int temp_formations_defensiverole_8 = -1;

		// Token: 0x0400069E RID: 1694
		public static int temp_formations_attackingrole_6 = -1;

		// Token: 0x0400069F RID: 1695
		public static int temp_formations_relativeformationid = -1;

		// Token: 0x040006A0 RID: 1696
		public static int temp_formations_defensiverole_0 = -1;

		// Token: 0x040006A1 RID: 1697
		public static int temp_formations_defensiverole_6 = -1;

		// Token: 0x040006A2 RID: 1698
		public static int temp_formations_position4 = -1;

		// Token: 0x040006A3 RID: 1699
		public static int temp_formations_attackingrole_10 = -1;

		// Token: 0x040006A4 RID: 1700
		public static int temp_formations_position3 = -1;

		// Token: 0x040006A5 RID: 1701
		public static int temp_formations_defensiverole_7 = -1;

		// Token: 0x040006A6 RID: 1702
		public static int temp_formations_formationfullnameid = -1;

		// Token: 0x040006A7 RID: 1703
		public static int temp_formations_defensiverole_9 = -1;

		// Token: 0x040006A8 RID: 1704
		public static int temp_formations_position0 = -1;

		// Token: 0x040006A9 RID: 1705
		public static int temp_formations_position9 = -1;

		// Token: 0x040006AA RID: 1706
		public static int temp_formations_position7 = -1;

		// Token: 0x040006AB RID: 1707
		public static int temp_formations_position1 = -1;

		// Token: 0x040006AC RID: 1708
		public static int temp_formations_defensivedirection_7 = -1;

		// Token: 0x040006AD RID: 1709
		public static int temp_arenateamplayerlinks_leaguegoals = -1;

		// Token: 0x040006AE RID: 1710
		public static int temp_arenateamplayerlinks_isamongtopscorers = -1;

		// Token: 0x040006AF RID: 1711
		public static int temp_arenateamplayerlinks_yellows = -1;

		// Token: 0x040006B0 RID: 1712
		public static int temp_arenateamplayerlinks_isamongtopscorersinteam = -1;

		// Token: 0x040006B1 RID: 1713
		public static int temp_arenateamplayerlinks_jerseynumber = -1;

		// Token: 0x040006B2 RID: 1714
		public static int temp_arenateamplayerlinks_position = -1;

		// Token: 0x040006B3 RID: 1715
		public static int temp_arenateamplayerlinks_artificialkey = -1;

		// Token: 0x040006B4 RID: 1716
		public static int temp_arenateamplayerlinks_teamid = -1;

		// Token: 0x040006B5 RID: 1717
		public static int temp_arenateamplayerlinks_injury = -1;

		// Token: 0x040006B6 RID: 1718
		public static int temp_arenateamplayerlinks_leagueappearances = -1;

		// Token: 0x040006B7 RID: 1719
		public static int temp_arenateamplayerlinks_prevform = -1;

		// Token: 0x040006B8 RID: 1720
		public static int temp_arenateamplayerlinks_istopscorer = -1;

		// Token: 0x040006B9 RID: 1721
		public static int temp_arenateamplayerlinks_playerid = -1;

		// Token: 0x040006BA RID: 1722
		public static int temp_arenateamplayerlinks_form = -1;

		// Token: 0x040006BB RID: 1723
		public static int temp_arenateamplayerlinks_reds = -1;

		// Token: 0x040006BC RID: 1724
		public static int temp_arenateam_assetid = -1;

		// Token: 0x040006BD RID: 1725
		public static int temp_arenateam_balltype = -1;

		// Token: 0x040006BE RID: 1726
		public static int temp_arenateam_teamcolor1g = -1;

		// Token: 0x040006BF RID: 1727
		public static int temp_arenateam_teamcolor1r = -1;

		// Token: 0x040006C0 RID: 1728
		public static int temp_arenateam_teamcolor2b = -1;

		// Token: 0x040006C1 RID: 1729
		public static int temp_arenateam_teamcolor2r = -1;

		// Token: 0x040006C2 RID: 1730
		public static int temp_arenateam_teamcolor3r = -1;

		// Token: 0x040006C3 RID: 1731
		public static int temp_arenateam_teamcolor1b = -1;

		// Token: 0x040006C4 RID: 1732
		public static int temp_arenateam_latitude = -1;

		// Token: 0x040006C5 RID: 1733
		public static int temp_arenateam_teamcolor3g = -1;

		// Token: 0x040006C6 RID: 1734
		public static int temp_arenateam_teamcolor2g = -1;

		// Token: 0x040006C7 RID: 1735
		public static int temp_arenateam_teamname = -1;

		// Token: 0x040006C8 RID: 1736
		public static int temp_arenateam_adboardid = -1;

		// Token: 0x040006C9 RID: 1737
		public static int temp_arenateam_teamcolor3b = -1;

		// Token: 0x040006CA RID: 1738
		public static int temp_arenateam_defmentality = -1;

		// Token: 0x040006CB RID: 1739
		public static int temp_arenateam_powid = -1;

		// Token: 0x040006CC RID: 1740
		public static int temp_arenateam_physioid_secondary = -1;

		// Token: 0x040006CD RID: 1741
		public static int temp_arenateam_domesticprestige = -1;

		// Token: 0x040006CE RID: 1742
		public static int temp_arenateam_genericint2 = -1;

		// Token: 0x040006CF RID: 1743
		public static int temp_arenateam_jerseytype = -1;

		// Token: 0x040006D0 RID: 1744
		public static int temp_arenateam_rivalteam = -1;

		// Token: 0x040006D1 RID: 1745
		public static int temp_arenateam_midfieldrating = -1;

		// Token: 0x040006D2 RID: 1746
		public static int temp_arenateam_matchdayoverallrating = -1;

		// Token: 0x040006D3 RID: 1747
		public static int temp_arenateam_matchdaymidfieldrating = -1;

		// Token: 0x040006D4 RID: 1748
		public static int temp_arenateam_attackrating = -1;

		// Token: 0x040006D5 RID: 1749
		public static int temp_arenateam_physioid_primary = -1;

		// Token: 0x040006D6 RID: 1750
		public static int temp_arenateam_longitude = -1;

		// Token: 0x040006D7 RID: 1751
		public static int temp_arenateam_buspassing = -1;

		// Token: 0x040006D8 RID: 1752
		public static int temp_arenateam_matchdaydefenserating = -1;

		// Token: 0x040006D9 RID: 1753
		public static int temp_arenateam_defenserating = -1;

		// Token: 0x040006DA RID: 1754
		public static int temp_arenateam_defteamwidth = -1;

		// Token: 0x040006DB RID: 1755
		public static int temp_arenateam_longkicktakerid = -1;

		// Token: 0x040006DC RID: 1756
		public static int temp_arenateam_bodytypeid = -1;

		// Token: 0x040006DD RID: 1757
		public static int temp_arenateam_rightcornerkicktakerid = -1;

		// Token: 0x040006DE RID: 1758
		public static int temp_arenateam_suitvariationid = -1;

		// Token: 0x040006DF RID: 1759
		public static int temp_arenateam_defaggression = -1;

		// Token: 0x040006E0 RID: 1760
		public static int temp_arenateam_ethnicity = -1;

		// Token: 0x040006E1 RID: 1761
		public static int temp_arenateam_leftcornerkicktakerid = -1;

		// Token: 0x040006E2 RID: 1762
		public static int temp_arenateam_teamid = -1;

		// Token: 0x040006E3 RID: 1763
		public static int temp_arenateam_fancrowdhairskintexturecode = -1;

		// Token: 0x040006E4 RID: 1764
		public static int temp_arenateam_suittypeid = -1;

		// Token: 0x040006E5 RID: 1765
		public static int temp_arenateam_numtransfersin = -1;

		// Token: 0x040006E6 RID: 1766
		public static int temp_arenateam_captainid = -1;

		// Token: 0x040006E7 RID: 1767
		public static int temp_arenateam_personalityid = -1;

		// Token: 0x040006E8 RID: 1768
		public static int temp_arenateam_genericbanner = -1;

		// Token: 0x040006E9 RID: 1769
		public static int temp_arenateam_buspositioning = -1;

		// Token: 0x040006EA RID: 1770
		public static int temp_arenateam_stafftracksuitcolorcode = -1;

		// Token: 0x040006EB RID: 1771
		public static int temp_arenateam_ccpositioning = -1;

		// Token: 0x040006EC RID: 1772
		public static int temp_arenateam_busbuildupspeed = -1;

		// Token: 0x040006ED RID: 1773
		public static int temp_arenateam_transferbudget = -1;

		// Token: 0x040006EE RID: 1774
		public static int temp_arenateam_ccshooting = -1;

		// Token: 0x040006EF RID: 1775
		public static int temp_arenateam_overallrating = -1;

		// Token: 0x040006F0 RID: 1776
		public static int temp_arenateam_ccpassing = -1;

		// Token: 0x040006F1 RID: 1777
		public static int temp_arenateam_utcoffset = -1;

		// Token: 0x040006F2 RID: 1778
		public static int temp_arenateam_penaltytakerid = -1;

		// Token: 0x040006F3 RID: 1779
		public static int temp_arenateam_freekicktakerid = -1;

		// Token: 0x040006F4 RID: 1780
		public static int temp_arenateam_defdefenderline = -1;

		// Token: 0x040006F5 RID: 1781
		public static int temp_arenateam_internationalprestige = -1;

		// Token: 0x040006F6 RID: 1782
		public static int temp_arenateam_form = -1;

		// Token: 0x040006F7 RID: 1783
		public static int temp_arenateam_genericint1 = -1;

		// Token: 0x040006F8 RID: 1784
		public static int temp_arenateam_cccrossing = -1;

		// Token: 0x040006F9 RID: 1785
		public static int temp_arenateam_matchdayattackrating = -1;

		// Token: 0x040006FA RID: 1786
		public static int temp_arenaplayername_firstname = -1;

		// Token: 0x040006FB RID: 1787
		public static int temp_arenaplayername_commonname = -1;

		// Token: 0x040006FC RID: 1788
		public static int temp_arenaplayername_playerjerseyname = -1;

		// Token: 0x040006FD RID: 1789
		public static int temp_arenaplayername_surname = -1;

		// Token: 0x040006FE RID: 1790
		public static int temp_arenaplayername_playerid = -1;

		// Token: 0x040006FF RID: 1791
		public static int temp_arenaplayer_birthdate = -1;

		// Token: 0x04000700 RID: 1792
		public static int temp_arenaplayer_playerjointeamdate = -1;

		// Token: 0x04000701 RID: 1793
		public static int temp_arenaplayer_shoetypecode = -1;

		// Token: 0x04000702 RID: 1794
		public static int temp_arenaplayer_haircolorcode = -1;

		// Token: 0x04000703 RID: 1795
		public static int temp_arenaplayer_facialhairtypecode = -1;

		// Token: 0x04000704 RID: 1796
		public static int temp_arenaplayer_curve = -1;

		// Token: 0x04000705 RID: 1797
		public static int temp_arenaplayer_jerseystylecode = -1;

		// Token: 0x04000706 RID: 1798
		public static int temp_arenaplayer_agility = -1;

		// Token: 0x04000707 RID: 1799
		public static int temp_arenaplayer_accessorycode4 = -1;

		// Token: 0x04000708 RID: 1800
		public static int temp_arenaplayer_gksavetype = -1;

		// Token: 0x04000709 RID: 1801
		public static int temp_arenaplayer_positioning = -1;

		// Token: 0x0400070A RID: 1802
		public static int temp_arenaplayer_hairtypecode = -1;

		// Token: 0x0400070B RID: 1803
		public static int temp_arenaplayer_standingtackle = -1;

		// Token: 0x0400070C RID: 1804
		public static int temp_arenaplayer_faceposercode = -1;

		// Token: 0x0400070D RID: 1805
		public static int temp_arenaplayer_preferredposition3 = -1;

		// Token: 0x0400070E RID: 1806
		public static int temp_arenaplayer_longpassing = -1;

		// Token: 0x0400070F RID: 1807
		public static int temp_arenaplayer_penalties = -1;

		// Token: 0x04000710 RID: 1808
		public static int temp_arenaplayer_animfreekickstartposcode = -1;

		// Token: 0x04000711 RID: 1809
		public static int temp_arenaplayer_animpenaltieskickstylecode = -1;

		// Token: 0x04000712 RID: 1810
		public static int temp_arenaplayer_isretiring = -1;

		// Token: 0x04000713 RID: 1811
		public static int temp_arenaplayer_longshots = -1;

		// Token: 0x04000714 RID: 1812
		public static int temp_arenaplayer_gkdiving = -1;

		// Token: 0x04000715 RID: 1813
		public static int temp_arenaplayer_interceptions = -1;

		// Token: 0x04000716 RID: 1814
		public static int temp_arenaplayer_shoecolorcode2 = -1;

		// Token: 0x04000717 RID: 1815
		public static int temp_arenaplayer_crossing = -1;

		// Token: 0x04000718 RID: 1816
		public static int temp_arenaplayer_potential = -1;

		// Token: 0x04000719 RID: 1817
		public static int temp_arenaplayer_gkreflexes = -1;

		// Token: 0x0400071A RID: 1818
		public static int temp_arenaplayer_finishingcode1 = -1;

		// Token: 0x0400071B RID: 1819
		public static int temp_arenaplayer_reactions = -1;

		// Token: 0x0400071C RID: 1820
		public static int temp_arenaplayer_vision = -1;

		// Token: 0x0400071D RID: 1821
		public static int temp_arenaplayer_contractvaliduntil = -1;

		// Token: 0x0400071E RID: 1822
		public static int temp_arenaplayer_finishing = -1;

		// Token: 0x0400071F RID: 1823
		public static int temp_arenaplayer_dribbling = -1;

		// Token: 0x04000720 RID: 1824
		public static int temp_arenaplayer_slidingtackle = -1;

		// Token: 0x04000721 RID: 1825
		public static int temp_arenaplayer_accessorycode3 = -1;

		// Token: 0x04000722 RID: 1826
		public static int temp_arenaplayer_accessorycolourcode1 = -1;

		// Token: 0x04000723 RID: 1827
		public static int temp_arenaplayer_headtypecode = -1;

		// Token: 0x04000724 RID: 1828
		public static int temp_arenaplayer_firstnameid = -1;

		// Token: 0x04000725 RID: 1829
		public static int temp_arenaplayer_sprintspeed = -1;

		// Token: 0x04000726 RID: 1830
		public static int temp_arenaplayer_height = -1;

		// Token: 0x04000727 RID: 1831
		public static int temp_arenaplayer_hasseasonaljersey = -1;

		// Token: 0x04000728 RID: 1832
		public static int temp_arenaplayer_preferredposition2 = -1;

		// Token: 0x04000729 RID: 1833
		public static int temp_arenaplayer_strength = -1;

		// Token: 0x0400072A RID: 1834
		public static int temp_arenaplayer_preferredposition1 = -1;

		// Token: 0x0400072B RID: 1835
		public static int temp_arenaplayer_ballcontrol = -1;

		// Token: 0x0400072C RID: 1836
		public static int temp_arenaplayer_shotpower = -1;

		// Token: 0x0400072D RID: 1837
		public static int temp_arenaplayer_trait1 = -1;

		// Token: 0x0400072E RID: 1838
		public static int temp_arenaplayer_socklengthcode = -1;

		// Token: 0x0400072F RID: 1839
		public static int temp_arenaplayer_weight = -1;

		// Token: 0x04000730 RID: 1840
		public static int temp_arenaplayer_hashighqualityhead = -1;

		// Token: 0x04000731 RID: 1841
		public static int temp_arenaplayer_gkglovetypecode = -1;

		// Token: 0x04000732 RID: 1842
		public static int temp_arenaplayer_balance = -1;

		// Token: 0x04000733 RID: 1843
		public static int temp_arenaplayer_gkkicking = -1;

		// Token: 0x04000734 RID: 1844
		public static int temp_arenaplayer_lastnameid = -1;

		// Token: 0x04000735 RID: 1845
		public static int temp_arenaplayer_internationalrep = -1;

		// Token: 0x04000736 RID: 1846
		public static int temp_arenaplayer_animpenaltiesmotionstylecode = -1;

		// Token: 0x04000737 RID: 1847
		public static int temp_arenaplayer_shortpassing = -1;

		// Token: 0x04000738 RID: 1848
		public static int temp_arenaplayer_freekickaccuracy = -1;

		// Token: 0x04000739 RID: 1849
		public static int temp_arenaplayer_skillmoves = -1;

		// Token: 0x0400073A RID: 1850
		public static int temp_arenaplayer_usercaneditname = -1;

		// Token: 0x0400073B RID: 1851
		public static int temp_arenaplayer_attackingworkrate = -1;

		// Token: 0x0400073C RID: 1852
		public static int temp_arenaplayer_finishingcode2 = -1;

		// Token: 0x0400073D RID: 1853
		public static int temp_arenaplayer_aggression = -1;

		// Token: 0x0400073E RID: 1854
		public static int temp_arenaplayer_acceleration = -1;

		// Token: 0x0400073F RID: 1855
		public static int temp_arenaplayer_headingaccuracy = -1;

		// Token: 0x04000740 RID: 1856
		public static int temp_arenaplayer_eyebrowcode = -1;

		// Token: 0x04000741 RID: 1857
		public static int temp_arenaplayer_runningcode2 = -1;

		// Token: 0x04000742 RID: 1858
		public static int temp_arenaplayer_gkhandling = -1;

		// Token: 0x04000743 RID: 1859
		public static int temp_arenaplayer_eyecolorcode = -1;

		// Token: 0x04000744 RID: 1860
		public static int temp_arenaplayer_jerseysleevelengthcode = -1;

		// Token: 0x04000745 RID: 1861
		public static int temp_arenaplayer_accessorycolourcode3 = -1;

		// Token: 0x04000746 RID: 1862
		public static int temp_arenaplayer_accessorycode1 = -1;

		// Token: 0x04000747 RID: 1863
		public static int temp_arenaplayer_headclasscode = -1;

		// Token: 0x04000748 RID: 1864
		public static int temp_arenaplayer_defensiveworkrate = -1;

		// Token: 0x04000749 RID: 1865
		public static int temp_arenaplayer_nationality = -1;

		// Token: 0x0400074A RID: 1866
		public static int temp_arenaplayer_preferredfoot = -1;

		// Token: 0x0400074B RID: 1867
		public static int temp_arenaplayer_sideburnscode = -1;

		// Token: 0x0400074C RID: 1868
		public static int temp_arenaplayer_weakfootabilitytypecode = -1;

		// Token: 0x0400074D RID: 1869
		public static int temp_arenaplayer_jumping = -1;

		// Token: 0x0400074E RID: 1870
		public static int temp_arenaplayer_skintypecode = -1;

		// Token: 0x0400074F RID: 1871
		public static int temp_arenaplayer_gkkickstyle = -1;

		// Token: 0x04000750 RID: 1872
		public static int temp_arenaplayer_stamina = -1;

		// Token: 0x04000751 RID: 1873
		public static int temp_arenaplayer_playerid = -1;

		// Token: 0x04000752 RID: 1874
		public static int temp_arenaplayer_marking = -1;

		// Token: 0x04000753 RID: 1875
		public static int temp_arenaplayer_accessorycolourcode4 = -1;

		// Token: 0x04000754 RID: 1876
		public static int temp_arenaplayer_gkpositioning = -1;

		// Token: 0x04000755 RID: 1877
		public static int temp_arenaplayer_trait2 = -1;

		// Token: 0x04000756 RID: 1878
		public static int temp_arenaplayer_skintonecode = -1;

		// Token: 0x04000757 RID: 1879
		public static int temp_arenaplayer_shortstyle = -1;

		// Token: 0x04000758 RID: 1880
		public static int temp_arenaplayer_overallrating = -1;

		// Token: 0x04000759 RID: 1881
		public static int temp_arenaplayer_jerseyfit = -1;

		// Token: 0x0400075A RID: 1882
		public static int temp_arenaplayer_accessorycode2 = -1;

		// Token: 0x0400075B RID: 1883
		public static int temp_arenaplayer_shoedesigncode = -1;

		// Token: 0x0400075C RID: 1884
		public static int temp_arenaplayer_playerjerseynameid = -1;

		// Token: 0x0400075D RID: 1885
		public static int temp_arenaplayer_shoecolorcode1 = -1;

		// Token: 0x0400075E RID: 1886
		public static int temp_arenaplayer_commonnameid = -1;

		// Token: 0x0400075F RID: 1887
		public static int temp_arenaplayer_bodytypecode = -1;

		// Token: 0x04000760 RID: 1888
		public static int temp_arenaplayer_animpenaltiesstartposcode = -1;

		// Token: 0x04000761 RID: 1889
		public static int temp_arenaplayer_runningcode1 = -1;

		// Token: 0x04000762 RID: 1890
		public static int temp_arenaplayer_preferredposition4 = -1;

		// Token: 0x04000763 RID: 1891
		public static int temp_arenaplayer_volleys = -1;

		// Token: 0x04000764 RID: 1892
		public static int temp_arenaplayer_accessorycolourcode2 = -1;

		// Token: 0x04000765 RID: 1893
		public static int temp_arenaplayer_facialhaircolorcode = -1;

		// Token: 0x04000766 RID: 1894
		public static int teamstadiumlinks_stadiumid = -1;

		// Token: 0x04000767 RID: 1895
		public static int teamstadiumlinks_teamid = -1;

		// Token: 0x04000768 RID: 1896
		public static int teams_assetid = -1;

		// Token: 0x04000769 RID: 1897
		public static int teams_balltype = -1;

		// Token: 0x0400076A RID: 1898
		public static int teams_teamcolor1g = -1;

		// Token: 0x0400076B RID: 1899
		public static int teams_teamcolor1r = -1;

		// Token: 0x0400076C RID: 1900
		public static int teams_teamcolor2b = -1;

		// Token: 0x0400076D RID: 1901
		public static int teams_teamcolor2r = -1;

		// Token: 0x0400076E RID: 1902
		public static int teams_teamcolor3r = -1;

		// Token: 0x0400076F RID: 1903
		public static int teams_teamcolor1b = -1;

		// Token: 0x04000770 RID: 1904
		public static int teams_latitude = -1;

		// Token: 0x04000771 RID: 1905
		public static int teams_teamcolor3g = -1;

		// Token: 0x04000772 RID: 1906
		public static int teams_teamcolor2g = -1;

		// Token: 0x04000773 RID: 1907
		public static int teams_teamname = -1;

		// Token: 0x04000774 RID: 1908
		public static int teams_adboardid = -1;

		// Token: 0x04000775 RID: 1909
		public static int teams_teamcolor3b = -1;

		// Token: 0x04000776 RID: 1910
		public static int teams_defmentality = -1;

		// Token: 0x04000777 RID: 1911
		public static int teams_powid = -1;

		// Token: 0x04000778 RID: 1912
		public static int teams_physioid_secondary = -1;

		// Token: 0x04000779 RID: 1913
		public static int teams_domesticprestige = -1;

		// Token: 0x0400077A RID: 1914
		public static int teams_genericint2 = -1;

		// Token: 0x0400077B RID: 1915
		public static int teams_jerseytype = -1;

		// Token: 0x0400077C RID: 1916
		public static int teams_rivalteam = -1;

		// Token: 0x0400077D RID: 1917
		public static int teams_midfieldrating = -1;

		// Token: 0x0400077E RID: 1918
		public static int teams_matchdayoverallrating = -1;

		// Token: 0x0400077F RID: 1919
		public static int teams_matchdaymidfieldrating = -1;

		// Token: 0x04000780 RID: 1920
		public static int teams_attackrating = -1;

		// Token: 0x04000781 RID: 1921
		public static int teams_physioid_primary = -1;

		// Token: 0x04000782 RID: 1922
		public static int teams_longitude = -1;

		// Token: 0x04000783 RID: 1923
		public static int teams_buspassing = -1;

		// Token: 0x04000784 RID: 1924
		public static int teams_matchdaydefenserating = -1;

		// Token: 0x04000785 RID: 1925
		public static int teams_defenserating = -1;

		// Token: 0x04000786 RID: 1926
		public static int teams_defteamwidth = -1;

		// Token: 0x04000787 RID: 1927
		public static int teams_longkicktakerid = -1;

		// Token: 0x04000788 RID: 1928
		public static int teams_bodytypeid = -1;

		// Token: 0x04000789 RID: 1929
		public static int teams_rightcornerkicktakerid = -1;

		// Token: 0x0400078A RID: 1930
		public static int teams_suitvariationid = -1;

		// Token: 0x0400078B RID: 1931
		public static int teams_defaggression = -1;

		// Token: 0x0400078C RID: 1932
		public static int teams_ethnicity = -1;

		// Token: 0x0400078D RID: 1933
		public static int teams_leftcornerkicktakerid = -1;

		// Token: 0x0400078E RID: 1934
		public static int teams_teamid = -1;

		// Token: 0x0400078F RID: 1935
		public static int teams_fancrowdhairskintexturecode = -1;

		// Token: 0x04000790 RID: 1936
		public static int teams_suittypeid = -1;

		// Token: 0x04000791 RID: 1937
		public static int teams_numtransfersin = -1;

		// Token: 0x04000792 RID: 1938
		public static int teams_captainid = -1;

		// Token: 0x04000793 RID: 1939
		public static int teams_personalityid = -1;

		// Token: 0x04000794 RID: 1940
		public static int teams_genericbanner = -1;

		// Token: 0x04000795 RID: 1941
		public static int teams_buspositioning = -1;

		// Token: 0x04000796 RID: 1942
		public static int teams_stafftracksuitcolorcode = -1;

		// Token: 0x04000797 RID: 1943
		public static int teams_ccpositioning = -1;

		// Token: 0x04000798 RID: 1944
		public static int teams_busbuildupspeed = -1;

		// Token: 0x04000799 RID: 1945
		public static int teams_transferbudget = -1;

		// Token: 0x0400079A RID: 1946
		public static int teams_ccshooting = -1;

		// Token: 0x0400079B RID: 1947
		public static int teams_overallrating = -1;

		// Token: 0x0400079C RID: 1948
		public static int teams_ccpassing = -1;

		// Token: 0x0400079D RID: 1949
		public static int teams_utcoffset = -1;

		// Token: 0x0400079E RID: 1950
		public static int teams_penaltytakerid = -1;

		// Token: 0x0400079F RID: 1951
		public static int teams_freekicktakerid = -1;

		// Token: 0x040007A0 RID: 1952
		public static int teams_defdefenderline = -1;

		// Token: 0x040007A1 RID: 1953
		public static int teams_internationalprestige = -1;

		// Token: 0x040007A2 RID: 1954
		public static int teams_form = -1;

		// Token: 0x040007A3 RID: 1955
		public static int teams_genericint1 = -1;

		// Token: 0x040007A4 RID: 1956
		public static int teams_cccrossing = -1;

		// Token: 0x040007A5 RID: 1957
		public static int teams_matchdayattackrating = -1;

		// Token: 0x040007A6 RID: 1958
		public static int teams_trait1 = -1;

		// Token: 0x040007A7 RID: 1959
		public static int teams_busdribbling = -1;

		// Token: 0x040007A8 RID: 1960
		public static int teamplayerlinks_leaguegoals = -1;

		// Token: 0x040007A9 RID: 1961
		public static int teamplayerlinks_isamongtopscorers = -1;

		// Token: 0x040007AA RID: 1962
		public static int teamplayerlinks_yellows = -1;

		// Token: 0x040007AB RID: 1963
		public static int teamplayerlinks_isamongtopscorersinteam = -1;

		// Token: 0x040007AC RID: 1964
		public static int teamplayerlinks_jerseynumber = -1;

		// Token: 0x040007AD RID: 1965
		public static int teamplayerlinks_position = -1;

		// Token: 0x040007AE RID: 1966
		public static int teamplayerlinks_artificialkey = -1;

		// Token: 0x040007AF RID: 1967
		public static int teamplayerlinks_teamid = -1;

		// Token: 0x040007B0 RID: 1968
		public static int teamplayerlinks_injury = -1;

		// Token: 0x040007B1 RID: 1969
		public static int teamplayerlinks_leagueappearances = -1;

		// Token: 0x040007B2 RID: 1970
		public static int teamplayerlinks_prevform = -1;

		// Token: 0x040007B3 RID: 1971
		public static int teamplayerlinks_istopscorer = -1;

		// Token: 0x040007B4 RID: 1972
		public static int teamplayerlinks_playerid = -1;

		// Token: 0x040007B5 RID: 1973
		public static int teamplayerlinks_form = -1;

		// Token: 0x040007B6 RID: 1974
		public static int teamplayerlinks_reds = -1;

		// Token: 0x040007B7 RID: 1975
		public static int teamkits_shortsnumberplacementcode = -1;

		// Token: 0x040007B8 RID: 1976
		public static int teamkits_teamcolorsecb = -1;

		// Token: 0x040007B9 RID: 1977
		public static int teamkits_shortsrenderingdetailmaptype = -1;

		// Token: 0x040007BA RID: 1978
		public static int teamkits_jerseyfrontnumberplacementcode = -1;

		// Token: 0x040007BB RID: 1979
		public static int teamkits_teamcolorprimg = -1;

		// Token: 0x040007BC RID: 1980
		public static int teamkits_numberfonttype = -1;

		// Token: 0x040007BD RID: 1981
		public static int teamkits_teamcolortertb = -1;

		// Token: 0x040007BE RID: 1982
		public static int teamkits_jerseynamefonttype = -1;

		// Token: 0x040007BF RID: 1983
		public static int teamkits_jerseynamelayouttype = -1;

		// Token: 0x040007C0 RID: 1984
		public static int teamkits_shortsnumbercolor = -1;

		// Token: 0x040007C1 RID: 1985
		public static int teamkits_jerseyshapestyle = -1;

		// Token: 0x040007C2 RID: 1986
		public static int teamkits_jerseybacknameplacementcode = -1;

		// Token: 0x040007C3 RID: 1987
		public static int teamkits_teamcolorprimr = -1;

		// Token: 0x040007C4 RID: 1988
		public static int teamkits_jerseynamecolorg = -1;

		// Token: 0x040007C5 RID: 1989
		public static int teamkits_teamcolorsecg = -1;

		// Token: 0x040007C6 RID: 1990
		public static int teamkits_teamcolortertr = -1;

		// Token: 0x040007C7 RID: 1991
		public static int teamkits_renderingmaterialtype = -1;

		// Token: 0x040007C8 RID: 1992
		public static int teamkits_teamcolorsecr = -1;

		// Token: 0x040007C9 RID: 1993
		public static int teamkits_jerseycollargeometrytype = -1;

		// Token: 0x040007CA RID: 1994
		public static int teamkits_jerseynamecolorr = -1;

		// Token: 0x040007CB RID: 1995
		public static int teamkits_numbercolor = -1;

		// Token: 0x040007CC RID: 1996
		public static int teamkits_teamcolorprimb = -1;

		// Token: 0x040007CD RID: 1997
		public static int teamkits_jerseyrenderingdetailmaptype = -1;

		// Token: 0x040007CE RID: 1998
		public static int teamkits_shortsnumberfonttype = -1;

		// Token: 0x040007CF RID: 1999
		public static int teamkits_jerseynamecolorb = -1;

		// Token: 0x040007D0 RID: 2000
		public static int teamkits_teamcolortertg = -1;

		// Token: 0x040007D1 RID: 2001
		public static int teamkits_jerseybacknamefontcase = -1;

		// Token: 0x040007D2 RID: 2002
		public static int teamkits_teamkittypetechid = -1;

		// Token: 0x040007D3 RID: 2003
		public static int teamkits_powid = -1;

		// Token: 0x040007D4 RID: 2004
		public static int teamkits_isinheritbasedetailmap = -1;

		// Token: 0x040007D5 RID: 2005
		public static int teamkits_islocked = -1;

		// Token: 0x040007D6 RID: 2006
		public static int teamkits_teamkitid = -1;

		// Token: 0x040007D7 RID: 2007
		public static int teamkits_year = -1;

		// Token: 0x040007D8 RID: 2008
		public static int teamkits_teamtechid = -1;

		// Token: 0x040007D9 RID: 2009
		public static int teamkits_hasadvertisingkit = -1;

		// Token: 0x040007DA RID: 2010
		public static int teamkits_dlc = -1;

		// Token: 0x040007DB RID: 2011
		public static int teamformdiff_overallratingdiff = -1;

		// Token: 0x040007DC RID: 2012
		public static int teamformdiff_olddefenserating = -1;

		// Token: 0x040007DD RID: 2013
		public static int teamformdiff_newoverallrating = -1;

		// Token: 0x040007DE RID: 2014
		public static int teamformdiff_oldoverallrating = -1;

		// Token: 0x040007DF RID: 2015
		public static int teamformdiff_oldattackrating = -1;

		// Token: 0x040007E0 RID: 2016
		public static int teamformdiff_oldmidfieldrating = -1;

		// Token: 0x040007E1 RID: 2017
		public static int teamformdiff_newdefenserating = -1;

		// Token: 0x040007E2 RID: 2018
		public static int teamformdiff_teamid = -1;

		// Token: 0x040007E3 RID: 2019
		public static int teamformdiff_newattackrating = -1;

		// Token: 0x040007E4 RID: 2020
		public static int teamformdiff_newmidfieldrating = -1;

		// Token: 0x040007E5 RID: 2021
		public static int teamballs_ballid = -1;

		// Token: 0x040007E6 RID: 2022
		public static int teamballs_powid = -1;

		// Token: 0x040007E7 RID: 2023
		public static int teamballs_islicensed = -1;

		// Token: 0x040007E8 RID: 2024
		public static int teamballs_isavailableinstore = -1;

		// Token: 0x040007E9 RID: 2025
		public static int teamballs_isembargoed = -1;

		// Token: 0x040007EA RID: 2026
		public static int stories_target_fixture = -1;

		// Token: 0x040007EB RID: 2027
		public static int stories_audioid = -1;

		// Token: 0x040007EC RID: 2028
		public static int stories_entity_id = -1;

		// Token: 0x040007ED RID: 2029
		public static int stories_chance = -1;

		// Token: 0x040007EE RID: 2030
		public static int stories_priority = -1;

		// Token: 0x040007EF RID: 2031
		public static int stories_entity_type = -1;

		// Token: 0x040007F0 RID: 2032
		public static int stories_storyid = -1;

		// Token: 0x040007F1 RID: 2033
		public static int starratingboundaries_stars = -1;

		// Token: 0x040007F2 RID: 2034
		public static int starratingboundaries_starratingfrom = -1;

		// Token: 0x040007F3 RID: 2035
		public static int starratingboundaries_starratingto = -1;

		// Token: 0x040007F4 RID: 2036
		public static int stadiums_yearbuilt = -1;

		// Token: 0x040007F5 RID: 2037
		public static int stadiums_name = -1;

		// Token: 0x040007F6 RID: 2038
		public static int stadiums_timeofday3 = -1;

		// Token: 0x040007F7 RID: 2039
		public static int stadiums_adboardsidelinedistance = -1;

		// Token: 0x040007F8 RID: 2040
		public static int stadiums_stadiumgloalnetdepth = -1;

		// Token: 0x040007F9 RID: 2041
		public static int stadiums_hometeamid = -1;

		// Token: 0x040007FA RID: 2042
		public static int stadiums_managerhometoplefty = -1;

		// Token: 0x040007FB RID: 2043
		public static int stadiums_capacity = -1;

		// Token: 0x040007FC RID: 2044
		public static int stadiums_seatcolor = -1;

		// Token: 0x040007FD RID: 2045
		public static int stadiums_managerawaytoplefty = -1;

		// Token: 0x040007FE RID: 2046
		public static int stadiums_subsawaybotrightx = -1;

		// Token: 0x040007FF RID: 2047
		public static int stadiums_sectionfacedbydefault = -1;

		// Token: 0x04000800 RID: 2048
		public static int stadiums_subshomebotrightx = -1;

		// Token: 0x04000801 RID: 2049
		public static int stadiums_policetypecode = -1;

		// Token: 0x04000802 RID: 2050
		public static int stadiums_subsawaybotrighty = -1;

		// Token: 0x04000803 RID: 2051
		public static int stadiums_timeofday4 = -1;

		// Token: 0x04000804 RID: 2052
		public static int stadiums_subsawaytopleftx = -1;

		// Token: 0x04000805 RID: 2053
		public static int stadiums_stadiumpitchlength = -1;

		// Token: 0x04000806 RID: 2054
		public static int stadiums_stadiumgoalnetstyle = -1;

		// Token: 0x04000807 RID: 2055
		public static int stadiums_subshomebotrighty = -1;

		// Token: 0x04000808 RID: 2056
		public static int stadiums_upgradetier = -1;

		// Token: 0x04000809 RID: 2057
		public static int stadiums_tod4weather = -1;

		// Token: 0x0400080A RID: 2058
		public static int stadiums_countrycode = -1;

		// Token: 0x0400080B RID: 2059
		public static int stadiums_stadiummowpattern_code = -1;

		// Token: 0x0400080C RID: 2060
		public static int stadiums_subsawaytoplefty = -1;

		// Token: 0x0400080D RID: 2061
		public static int stadiums_managerhomebotrightx = -1;

		// Token: 0x0400080E RID: 2062
		public static int stadiums_stadiumid = -1;

		// Token: 0x0400080F RID: 2063
		public static int stadiums_cameraheight = -1;

		// Token: 0x04000810 RID: 2064
		public static int stadiums_managerawaytopleftx = -1;

		// Token: 0x04000811 RID: 2065
		public static int stadiums_managerhomebotrighty = -1;

		// Token: 0x04000812 RID: 2066
		public static int stadiums_stadiumgoalnettype = -1;

		// Token: 0x04000813 RID: 2067
		public static int stadiums_stadiumpitchwidth = -1;

		// Token: 0x04000814 RID: 2068
		public static int stadiums_stadiumtype = -1;

		// Token: 0x04000815 RID: 2069
		public static int stadiums_managerhometopleftx = -1;

		// Token: 0x04000816 RID: 2070
		public static int stadiums_stadiumgoalnettension = -1;

		// Token: 0x04000817 RID: 2071
		public static int stadiums_tod1weather = -1;

		// Token: 0x04000818 RID: 2072
		public static int stadiums_dlc = -1;

		// Token: 0x04000819 RID: 2073
		public static int stadiums_tod2weather = -1;

		// Token: 0x0400081A RID: 2074
		public static int stadiums_camerazoom = -1;

		// Token: 0x0400081B RID: 2075
		public static int stadiums_adboardendlinedistance = -1;

		// Token: 0x0400081C RID: 2076
		public static int stadiums_subshometoplefty = -1;

		// Token: 0x0400081D RID: 2077
		public static int stadiums_iseditable = -1;

		// Token: 0x0400081E RID: 2078
		public static int stadiums_isdynamic = -1;

		// Token: 0x0400081F RID: 2079
		public static int stadiums_tod3weather = -1;

		// Token: 0x04000820 RID: 2080
		public static int stadiums_upgradestyle = -1;

		// Token: 0x04000821 RID: 2081
		public static int stadiums_genericrank = -1;

		// Token: 0x04000822 RID: 2082
		public static int stadiums_timeofday1 = -1;

		// Token: 0x04000823 RID: 2083
		public static int stadiums_timeofday2 = -1;

		// Token: 0x04000824 RID: 2084
		public static int stadiums_stadiumgoalnetwidth = -1;

		// Token: 0x04000825 RID: 2085
		public static int stadiums_managerawaybotrightx = -1;

		// Token: 0x04000826 RID: 2086
		public static int stadiums_subshometopleftx = -1;

		// Token: 0x04000827 RID: 2087
		public static int stadiums_stadiumgoalnetlength = -1;

		// Token: 0x04000828 RID: 2088
		public static int stadiums_managerawaybotrighty = -1;

		// Token: 0x04000829 RID: 2089
		public static int shoecolors_blue = -1;

		// Token: 0x0400082A RID: 2090
		public static int shoecolors_green = -1;

		// Token: 0x0400082B RID: 2091
		public static int shoecolors_red = -1;

		// Token: 0x0400082C RID: 2092
		public static int shoecolors_colorid = -1;

		// Token: 0x0400082D RID: 2093
		public static int rowteamnationlinks_nationid = -1;

		// Token: 0x0400082E RID: 2094
		public static int rowteamnationlinks_teamid = -1;

		// Token: 0x0400082F RID: 2095
		public static int rivals_rivaltype = -1;

		// Token: 0x04000830 RID: 2096
		public static int rivals_teamid2 = -1;

		// Token: 0x04000831 RID: 2097
		public static int rivals_teamid1 = -1;

		// Token: 0x04000832 RID: 2098
		public static int restrictedplayers_fixtureid = -1;

		// Token: 0x04000833 RID: 2099
		public static int restrictedplayers_reason = -1;

		// Token: 0x04000834 RID: 2100
		public static int restrictedplayers_replacementplayerid = -1;

		// Token: 0x04000835 RID: 2101
		public static int restrictedplayers_teamid = -1;

		// Token: 0x04000836 RID: 2102
		public static int restrictedplayers_playerid = -1;

		// Token: 0x04000837 RID: 2103
		public static int referee_birthdate = -1;

		// Token: 0x04000838 RID: 2104
		public static int referee_firstname = -1;

		// Token: 0x04000839 RID: 2105
		public static int referee_shoetypecode = -1;

		// Token: 0x0400083A RID: 2106
		public static int referee_surname = -1;

		// Token: 0x0400083B RID: 2107
		public static int referee_nationalitycode = -1;

		// Token: 0x0400083C RID: 2108
		public static int referee_haircolorcode = -1;

		// Token: 0x0400083D RID: 2109
		public static int referee_facialhairtypecode = -1;

		// Token: 0x0400083E RID: 2110
		public static int referee_hairtypecode = -1;

		// Token: 0x0400083F RID: 2111
		public static int referee_cardstrictness = -1;

		// Token: 0x04000840 RID: 2112
		public static int referee_shoecolorcode2 = -1;

		// Token: 0x04000841 RID: 2113
		public static int referee_stylecode = -1;

		// Token: 0x04000842 RID: 2114
		public static int referee_proxyhaircolorid = -1;

		// Token: 0x04000843 RID: 2115
		public static int referee_headtypecode = -1;

		// Token: 0x04000844 RID: 2116
		public static int referee_foulstrictness = -1;

		// Token: 0x04000845 RID: 2117
		public static int referee_height = -1;

		// Token: 0x04000846 RID: 2118
		public static int referee_hairstateid = -1;

		// Token: 0x04000847 RID: 2119
		public static int referee_leagueid = -1;

		// Token: 0x04000848 RID: 2120
		public static int referee_sockheightcode = -1;

		// Token: 0x04000849 RID: 2121
		public static int referee_weight = -1;

		// Token: 0x0400084A RID: 2122
		public static int referee_proxyheadclass = -1;

		// Token: 0x0400084B RID: 2123
		public static int referee_eyebrowcode = -1;

		// Token: 0x0400084C RID: 2124
		public static int referee_eyecolorcode = -1;

		// Token: 0x0400084D RID: 2125
		public static int referee_jerseysleevelengthcode = -1;

		// Token: 0x0400084E RID: 2126
		public static int referee_hairlinecode = -1;

		// Token: 0x0400084F RID: 2127
		public static int referee_headclasscode = -1;

		// Token: 0x04000850 RID: 2128
		public static int referee_haireffecttypecode = -1;

		// Token: 0x04000851 RID: 2129
		public static int referee_sideburnscode = -1;

		// Token: 0x04000852 RID: 2130
		public static int referee_skintypecode = -1;

		// Token: 0x04000853 RID: 2131
		public static int referee_hairpartcode = -1;

		// Token: 0x04000854 RID: 2132
		public static int referee_sweatid = -1;

		// Token: 0x04000855 RID: 2133
		public static int referee_skintonecode = -1;

		// Token: 0x04000856 RID: 2134
		public static int referee_hairvariationid = -1;

		// Token: 0x04000857 RID: 2135
		public static int referee_refereeid = -1;

		// Token: 0x04000858 RID: 2136
		public static int referee_homecitycode = -1;

		// Token: 0x04000859 RID: 2137
		public static int referee_shoedesigncode = -1;

		// Token: 0x0400085A RID: 2138
		public static int referee_shoecolorcode1 = -1;

		// Token: 0x0400085B RID: 2139
		public static int referee_bodytypecode = -1;

		// Token: 0x0400085C RID: 2140
		public static int referee_wrinkleid = -1;

		// Token: 0x0400085D RID: 2141
		public static int referee_facialhaircolorcode = -1;

		// Token: 0x0400085E RID: 2142
		public static int previousteam_previousteamid = -1;

		// Token: 0x0400085F RID: 2143
		public static int previousteam_playerid = -1;

		// Token: 0x04000860 RID: 2144
		public static int players_birthdate = -1;

		// Token: 0x04000861 RID: 2145
		public static int players_playerjointeamdate = -1;

		// Token: 0x04000862 RID: 2146
		public static int players_shoetypecode = -1;

		// Token: 0x04000863 RID: 2147
		public static int players_haircolorcode = -1;

		// Token: 0x04000864 RID: 2148
		public static int players_facialhairtypecode = -1;

		// Token: 0x04000865 RID: 2149
		public static int players_curve = -1;

		// Token: 0x04000866 RID: 2150
		public static int players_jerseystylecode = -1;

		// Token: 0x04000867 RID: 2151
		public static int players_agility = -1;

		// Token: 0x04000868 RID: 2152
		public static int players_accessorycode4 = -1;

		// Token: 0x04000869 RID: 2153
		public static int players_gksavetype = -1;

		// Token: 0x0400086A RID: 2154
		public static int players_positioning = -1;

		// Token: 0x0400086B RID: 2155
		public static int players_hairtypecode = -1;

		// Token: 0x0400086C RID: 2156
		public static int players_standingtackle = -1;

		// Token: 0x0400086D RID: 2157
		public static int players_faceposercode = -1;

		// Token: 0x0400086E RID: 2158
		public static int players_preferredposition3 = -1;

		// Token: 0x0400086F RID: 2159
		public static int players_longpassing = -1;

		// Token: 0x04000870 RID: 2160
		public static int players_penalties = -1;

		// Token: 0x04000871 RID: 2161
		public static int players_animfreekickstartposcode = -1;

		// Token: 0x04000872 RID: 2162
		public static int players_animpenaltieskickstylecode = -1;

		// Token: 0x04000873 RID: 2163
		public static int players_isretiring = -1;

		// Token: 0x04000874 RID: 2164
		public static int players_longshots = -1;

		// Token: 0x04000875 RID: 2165
		public static int players_gkdiving = -1;

		// Token: 0x04000876 RID: 2166
		public static int players_interceptions = -1;

		// Token: 0x04000877 RID: 2167
		public static int players_shoecolorcode2 = -1;

		// Token: 0x04000878 RID: 2168
		public static int players_crossing = -1;

		// Token: 0x04000879 RID: 2169
		public static int players_potential = -1;

		// Token: 0x0400087A RID: 2170
		public static int players_gkreflexes = -1;

		// Token: 0x0400087B RID: 2171
		public static int players_finishingcode1 = -1;

		// Token: 0x0400087C RID: 2172
		public static int players_reactions = -1;

		// Token: 0x0400087D RID: 2173
		public static int players_vision = -1;

		// Token: 0x0400087E RID: 2174
		public static int players_contractvaliduntil = -1;

		// Token: 0x0400087F RID: 2175
		public static int players_finishing = -1;

		// Token: 0x04000880 RID: 2176
		public static int players_dribbling = -1;

		// Token: 0x04000881 RID: 2177
		public static int players_slidingtackle = -1;

		// Token: 0x04000882 RID: 2178
		public static int players_accessorycode3 = -1;

		// Token: 0x04000883 RID: 2179
		public static int players_accessorycolourcode1 = -1;

		// Token: 0x04000884 RID: 2180
		public static int players_headtypecode = -1;

		// Token: 0x04000885 RID: 2181
		public static int players_firstnameid = -1;

		// Token: 0x04000886 RID: 2182
		public static int players_sprintspeed = -1;

		// Token: 0x04000887 RID: 2183
		public static int players_height = -1;

		// Token: 0x04000888 RID: 2184
		public static int players_hasseasonaljersey = -1;

		// Token: 0x04000889 RID: 2185
		public static int players_preferredposition2 = -1;

		// Token: 0x0400088A RID: 2186
		public static int players_strength = -1;

		// Token: 0x0400088B RID: 2187
		public static int players_preferredposition1 = -1;

		// Token: 0x0400088C RID: 2188
		public static int players_ballcontrol = -1;

		// Token: 0x0400088D RID: 2189
		public static int players_shotpower = -1;

		// Token: 0x0400088E RID: 2190
		public static int players_trait1 = -1;

		// Token: 0x0400088F RID: 2191
		public static int players_socklengthcode = -1;

		// Token: 0x04000890 RID: 2192
		public static int players_weight = -1;

		// Token: 0x04000891 RID: 2193
		public static int players_hashighqualityhead = -1;

		// Token: 0x04000892 RID: 2194
		public static int players_gkglovetypecode = -1;

		// Token: 0x04000893 RID: 2195
		public static int players_balance = -1;

		// Token: 0x04000894 RID: 2196
		public static int players_gkkicking = -1;

		// Token: 0x04000895 RID: 2197
		public static int players_lastnameid = -1;

		// Token: 0x04000896 RID: 2198
		public static int players_internationalrep = -1;

		// Token: 0x04000897 RID: 2199
		public static int players_animpenaltiesmotionstylecode = -1;

		// Token: 0x04000898 RID: 2200
		public static int players_shortpassing = -1;

		// Token: 0x04000899 RID: 2201
		public static int players_freekickaccuracy = -1;

		// Token: 0x0400089A RID: 2202
		public static int players_skillmoves = -1;

		// Token: 0x0400089B RID: 2203
		public static int players_usercaneditname = -1;

		// Token: 0x0400089C RID: 2204
		public static int players_attackingworkrate = -1;

		// Token: 0x0400089D RID: 2205
		public static int players_finishingcode2 = -1;

		// Token: 0x0400089E RID: 2206
		public static int players_aggression = -1;

		// Token: 0x0400089F RID: 2207
		public static int players_acceleration = -1;

		// Token: 0x040008A0 RID: 2208
		public static int players_headingaccuracy = -1;

		// Token: 0x040008A1 RID: 2209
		public static int players_eyebrowcode = -1;

		// Token: 0x040008A2 RID: 2210
		public static int players_runningcode2 = -1;

		// Token: 0x040008A3 RID: 2211
		public static int players_gkhandling = -1;

		// Token: 0x040008A4 RID: 2212
		public static int players_eyecolorcode = -1;

		// Token: 0x040008A5 RID: 2213
		public static int players_jerseysleevelengthcode = -1;

		// Token: 0x040008A6 RID: 2214
		public static int players_accessorycolourcode3 = -1;

		// Token: 0x040008A7 RID: 2215
		public static int players_accessorycode1 = -1;

		// Token: 0x040008A8 RID: 2216
		public static int players_headclasscode = -1;

		// Token: 0x040008A9 RID: 2217
		public static int players_defensiveworkrate = -1;

		// Token: 0x040008AA RID: 2218
		public static int players_nationality = -1;

		// Token: 0x040008AB RID: 2219
		public static int players_preferredfoot = -1;

		// Token: 0x040008AC RID: 2220
		public static int players_sideburnscode = -1;

		// Token: 0x040008AD RID: 2221
		public static int players_weakfootabilitytypecode = -1;

		// Token: 0x040008AE RID: 2222
		public static int players_jumping = -1;

		// Token: 0x040008AF RID: 2223
		public static int players_skintypecode = -1;

		// Token: 0x040008B0 RID: 2224
		public static int players_gkkickstyle = -1;

		// Token: 0x040008B1 RID: 2225
		public static int players_stamina = -1;

		// Token: 0x040008B2 RID: 2226
		public static int players_playerid = -1;

		// Token: 0x040008B3 RID: 2227
		public static int players_marking = -1;

		// Token: 0x040008B4 RID: 2228
		public static int players_accessorycolourcode4 = -1;

		// Token: 0x040008B5 RID: 2229
		public static int players_gkpositioning = -1;

		// Token: 0x040008B6 RID: 2230
		public static int players_trait2 = -1;

		// Token: 0x040008B7 RID: 2231
		public static int players_skintonecode = -1;

		// Token: 0x040008B8 RID: 2232
		public static int players_shortstyle = -1;

		// Token: 0x040008B9 RID: 2233
		public static int players_overallrating = -1;

		// Token: 0x040008BA RID: 2234
		public static int players_jerseyfit = -1;

		// Token: 0x040008BB RID: 2235
		public static int players_accessorycode2 = -1;

		// Token: 0x040008BC RID: 2236
		public static int players_shoedesigncode = -1;

		// Token: 0x040008BD RID: 2237
		public static int players_playerjerseynameid = -1;

		// Token: 0x040008BE RID: 2238
		public static int players_shoecolorcode1 = -1;

		// Token: 0x040008BF RID: 2239
		public static int players_commonnameid = -1;

		// Token: 0x040008C0 RID: 2240
		public static int players_bodytypecode = -1;

		// Token: 0x040008C1 RID: 2241
		public static int players_animpenaltiesstartposcode = -1;

		// Token: 0x040008C2 RID: 2242
		public static int players_runningcode1 = -1;

		// Token: 0x040008C3 RID: 2243
		public static int players_preferredposition4 = -1;

		// Token: 0x040008C4 RID: 2244
		public static int players_volleys = -1;

		// Token: 0x040008C5 RID: 2245
		public static int players_accessorycolourcode2 = -1;

		// Token: 0x040008C6 RID: 2246
		public static int players_facialhaircolorcode = -1;

		// Token: 0x040008C7 RID: 2247
		public static int playernames_name = -1;

		// Token: 0x040008C8 RID: 2248
		public static int playernames_commentaryid = -1;

		// Token: 0x040008C9 RID: 2249
		public static int playernames_nameid = -1;

		// Token: 0x040008CA RID: 2250
		public static int playerloans_loandateend = -1;

		// Token: 0x040008CB RID: 2251
		public static int playerloans_teamidloanedfrom = -1;

		// Token: 0x040008CC RID: 2252
		public static int playerloans_playerid = -1;

		// Token: 0x040008CD RID: 2253
		public static int playerformdiff_overallratingdiff = -1;

		// Token: 0x040008CE RID: 2254
		public static int playerformdiff_newoverallrating = -1;

		// Token: 0x040008CF RID: 2255
		public static int playerformdiff_oldoverallrating = -1;

		// Token: 0x040008D0 RID: 2256
		public static int playerformdiff_teamid = -1;

		// Token: 0x040008D1 RID: 2257
		public static int playerformdiff_playerid = -1;

		// Token: 0x040008D2 RID: 2258
		public static int playerboots_shoetype = -1;

		// Token: 0x040008D3 RID: 2259
		public static int playerboots_powid = -1;

		// Token: 0x040008D4 RID: 2260
		public static int playerboots_islocked = -1;

		// Token: 0x040008D5 RID: 2261
		public static int playerboots_islegacy = -1;

		// Token: 0x040008D6 RID: 2262
		public static int playerboots_isembargoed = -1;

		// Token: 0x040008D7 RID: 2263
		public static int playerboots_shoecolor1 = -1;

		// Token: 0x040008D8 RID: 2264
		public static int playerboots_islicensed = -1;

		// Token: 0x040008D9 RID: 2265
		public static int playerboots_isavailableinstore = -1;

		// Token: 0x040008DA RID: 2266
		public static int playerboots_isadidas = -1;

		// Token: 0x040008DB RID: 2267
		public static int playerboots_shoedesign = -1;

		// Token: 0x040008DC RID: 2268
		public static int playerboots_shoecolor2 = -1;

		// Token: 0x040008DD RID: 2269
		public static int player_grudgelove_level_of_emotion = -1;

		// Token: 0x040008DE RID: 2270
		public static int player_grudgelove_playerid = -1;

		// Token: 0x040008DF RID: 2271
		public static int player_grudgelove_emotional_teamid = -1;

		// Token: 0x040008E0 RID: 2272
		public static int physio_birthdate = -1;

		// Token: 0x040008E1 RID: 2273
		public static int physio_firstname = -1;

		// Token: 0x040008E2 RID: 2274
		public static int physio_surname = -1;

		// Token: 0x040008E3 RID: 2275
		public static int physio_haircolorcode = -1;

		// Token: 0x040008E4 RID: 2276
		public static int physio_facialhairtypecode = -1;

		// Token: 0x040008E5 RID: 2277
		public static int physio_hairtypecode = -1;

		// Token: 0x040008E6 RID: 2278
		public static int physio_headtypecode = -1;

		// Token: 0x040008E7 RID: 2279
		public static int physio_eyebrowcode = -1;

		// Token: 0x040008E8 RID: 2280
		public static int physio_eyecolorcode = -1;

		// Token: 0x040008E9 RID: 2281
		public static int physio_physioid = -1;

		// Token: 0x040008EA RID: 2282
		public static int physio_headclasscode = -1;

		// Token: 0x040008EB RID: 2283
		public static int physio_haireffecttypecode = -1;

		// Token: 0x040008EC RID: 2284
		public static int physio_skintonecode = -1;

		// Token: 0x040008ED RID: 2285
		public static int physio_nationalitycode = -1;

		// Token: 0x040008EE RID: 2286
		public static int physio_bodytypecode = -1;

		// Token: 0x040008EF RID: 2287
		public static int physio_facialhaircolorcode = -1;

		// Token: 0x040008F0 RID: 2288
		public static int nations_nationname = -1;

		// Token: 0x040008F1 RID: 2289
		public static int nations_nationid = -1;

		// Token: 0x040008F2 RID: 2290
		public static int nations_confederation = -1;

		// Token: 0x040008F3 RID: 2291
		public static int nations_top_tier = -1;

		// Token: 0x040008F4 RID: 2292
		public static int nations_nationstartingfirstletter = -1;

		// Token: 0x040008F5 RID: 2293
		public static int nations_teamid = -1;

		// Token: 0x040008F6 RID: 2294
		public static int manager_firstname = -1;

		// Token: 0x040008F7 RID: 2295
		public static int manager_surname = -1;

		// Token: 0x040008F8 RID: 2296
		public static int manager_teamid = -1;

		// Token: 0x040008F9 RID: 2297
		public static int leagueteamlinks_teamshortform = -1;

		// Token: 0x040008FA RID: 2298
		public static int leagueteamlinks_hasachievedobjective = -1;

		// Token: 0x040008FB RID: 2299
		public static int leagueteamlinks_yettowin = -1;

		// Token: 0x040008FC RID: 2300
		public static int leagueteamlinks_unbeatenallcomps = -1;

		// Token: 0x040008FD RID: 2301
		public static int leagueteamlinks_unbeatenleague = -1;

		// Token: 0x040008FE RID: 2302
		public static int leagueteamlinks_champion = -1;

		// Token: 0x040008FF RID: 2303
		public static int leagueteamlinks_leagueid = -1;

		// Token: 0x04000900 RID: 2304
		public static int leagueteamlinks_prevleagueid = -1;

		// Token: 0x04000901 RID: 2305
		public static int leagueteamlinks_previousyeartableposition = -1;

		// Token: 0x04000902 RID: 2306
		public static int leagueteamlinks_highestpossible = -1;

		// Token: 0x04000903 RID: 2307
		public static int leagueteamlinks_teamform = -1;

		// Token: 0x04000904 RID: 2308
		public static int leagueteamlinks_highestprobable = -1;

		// Token: 0x04000905 RID: 2309
		public static int leagueteamlinks_artificialkey = -1;

		// Token: 0x04000906 RID: 2310
		public static int leagueteamlinks_nummatchesplayed = -1;

		// Token: 0x04000907 RID: 2311
		public static int leagueteamlinks_teamid = -1;

		// Token: 0x04000908 RID: 2312
		public static int leagueteamlinks_gapresult = -1;

		// Token: 0x04000909 RID: 2313
		public static int leagueteamlinks_grouping = -1;

		// Token: 0x0400090A RID: 2314
		public static int leagueteamlinks_currenttableposition = -1;

		// Token: 0x0400090B RID: 2315
		public static int leagueteamlinks_objective = -1;

		// Token: 0x0400090C RID: 2316
		public static int leagueteamlinks_actualvsexpectations = -1;

		// Token: 0x0400090D RID: 2317
		public static int leagueteamlinks_unbeatenhome = -1;

		// Token: 0x0400090E RID: 2318
		public static int leagueteamlinks_lastgameresult = -1;

		// Token: 0x0400090F RID: 2319
		public static int leagueteamlinks_unbeatenaway = -1;

		// Token: 0x04000910 RID: 2320
		public static int leagueteamlinks_teamlongform = -1;

		// Token: 0x04000911 RID: 2321
		public static int leagueteamlinks_homega = -1;

		// Token: 0x04000912 RID: 2322
		public static int leagueteamlinks_homegf = -1;

		// Token: 0x04000913 RID: 2323
		public static int leagueteamlinks_points = -1;

		// Token: 0x04000914 RID: 2324
		public static int leagueteamlinks_awayga = -1;

		// Token: 0x04000915 RID: 2325
		public static int leagueteamlinks_awaygf = -1;

		// Token: 0x04000916 RID: 2326
		public static int leagueteamlinks_secondarytable = -1;

		// Token: 0x04000917 RID: 2327
		public static int leagueteamlinks_homewins = -1;

		// Token: 0x04000918 RID: 2328
		public static int leagueteamlinks_awaywins = -1;

		// Token: 0x04000919 RID: 2329
		public static int leagueteamlinks_homelosses = -1;

		// Token: 0x0400091A RID: 2330
		public static int leagueteamlinks_awaylosses = -1;

		// Token: 0x0400091B RID: 2331
		public static int leagueteamlinks_awaydraws = -1;

		// Token: 0x0400091C RID: 2332
		public static int leagueteamlinks_homedraws = -1;

		// Token: 0x0400091D RID: 2333
		public static int leagues_countryid = -1;

		// Token: 0x0400091E RID: 2334
		public static int leagues_leaguename = -1;

		// Token: 0x0400091F RID: 2335
		public static int leagues_level = -1;

		// Token: 0x04000920 RID: 2336
		public static int leagues_leagueid = -1;

		// Token: 0x04000921 RID: 2337
		public static int leagues_leaguetimeslice = -1;

		// Token: 0x04000922 RID: 2338
		public static int leagues_iswithintransferwindow = -1;

		// Token: 0x04000923 RID: 2339
		public static int leaguerefereelinks_leagueid = -1;

		// Token: 0x04000924 RID: 2340
		public static int leaguerefereelinks_refereeid = -1;

		// Token: 0x04000925 RID: 2341
		public static int formupdate_leagueid = -1;

		// Token: 0x04000926 RID: 2342
		public static int formupdate_position = -1;

		// Token: 0x04000927 RID: 2343
		public static int formupdate_teamid = -1;

		// Token: 0x04000928 RID: 2344
		public static int formupdate_formaudio = -1;

		// Token: 0x04000929 RID: 2345
		public static int formupdate_prevform = -1;

		// Token: 0x0400092A RID: 2346
		public static int formupdate_playerid = -1;

		// Token: 0x0400092B RID: 2347
		public static int formupdate_overallrating = -1;

		// Token: 0x0400092C RID: 2348
		public static int formupdate_form = -1;

		// Token: 0x0400092D RID: 2349
		public static int formations_offset6x = -1;

		// Token: 0x0400092E RID: 2350
		public static int formations_offset5y = -1;

		// Token: 0x0400092F RID: 2351
		public static int formations_offset10x = -1;

		// Token: 0x04000930 RID: 2352
		public static int formations_offset2x = -1;

		// Token: 0x04000931 RID: 2353
		public static int formations_defenders = -1;

		// Token: 0x04000932 RID: 2354
		public static int formations_offset2y = -1;

		// Token: 0x04000933 RID: 2355
		public static int formations_offset6y = -1;

		// Token: 0x04000934 RID: 2356
		public static int formations_offset7x = -1;

		// Token: 0x04000935 RID: 2357
		public static int formations_offset3x = -1;

		// Token: 0x04000936 RID: 2358
		public static int formations_offset8x = -1;

		// Token: 0x04000937 RID: 2359
		public static int formations_offset10y = -1;

		// Token: 0x04000938 RID: 2360
		public static int formations_offset3y = -1;

		// Token: 0x04000939 RID: 2361
		public static int formations_offset4x = -1;

		// Token: 0x0400093A RID: 2362
		public static int formations_offset7y = -1;

		// Token: 0x0400093B RID: 2363
		public static int formations_offset0x = -1;

		// Token: 0x0400093C RID: 2364
		public static int formations_offset8y = -1;

		// Token: 0x0400093D RID: 2365
		public static int formations_attackers = -1;

		// Token: 0x0400093E RID: 2366
		public static int formations_offset9x = -1;

		// Token: 0x0400093F RID: 2367
		public static int formations_midfielders = -1;

		// Token: 0x04000940 RID: 2368
		public static int formations_offset5x = -1;

		// Token: 0x04000941 RID: 2369
		public static int formations_offset0y = -1;

		// Token: 0x04000942 RID: 2370
		public static int formations_offset1x = -1;

		// Token: 0x04000943 RID: 2371
		public static int formations_offset4y = -1;

		// Token: 0x04000944 RID: 2372
		public static int formations_offset9y = -1;

		// Token: 0x04000945 RID: 2373
		public static int formations_offset1y = -1;

		// Token: 0x04000946 RID: 2374
		public static int formations_formationname = -1;

		// Token: 0x04000947 RID: 2375
		public static int formations_attackingdirection_0 = -1;

		// Token: 0x04000948 RID: 2376
		public static int formations_attackingrole_5 = -1;

		// Token: 0x04000949 RID: 2377
		public static int formations_position10 = -1;

		// Token: 0x0400094A RID: 2378
		public static int formations_attackingdirection_7 = -1;

		// Token: 0x0400094B RID: 2379
		public static int formations_defensivedirection_0 = -1;

		// Token: 0x0400094C RID: 2380
		public static int formations_defensivedirection_9 = -1;

		// Token: 0x0400094D RID: 2381
		public static int formations_defensivedirection_8 = -1;

		// Token: 0x0400094E RID: 2382
		public static int formations_attackingdirection_9 = -1;

		// Token: 0x0400094F RID: 2383
		public static int formations_position6 = -1;

		// Token: 0x04000950 RID: 2384
		public static int formations_attackingrole_4 = -1;

		// Token: 0x04000951 RID: 2385
		public static int formations_offensiverating = -1;

		// Token: 0x04000952 RID: 2386
		public static int formations_attackingrole_2 = -1;

		// Token: 0x04000953 RID: 2387
		public static int formations_attackingdirection_1 = -1;

		// Token: 0x04000954 RID: 2388
		public static int formations_position8 = -1;

		// Token: 0x04000955 RID: 2389
		public static int formations_defensiverole_4 = -1;

		// Token: 0x04000956 RID: 2390
		public static int formations_attackingdirection_10 = -1;

		// Token: 0x04000957 RID: 2391
		public static int formations_defensivedirection_6 = -1;

		// Token: 0x04000958 RID: 2392
		public static int formations_attackingdirection_8 = -1;

		// Token: 0x04000959 RID: 2393
		public static int formations_attackingrole_3 = -1;

		// Token: 0x0400095A RID: 2394
		public static int formations_defensiverole_3 = -1;

		// Token: 0x0400095B RID: 2395
		public static int formations_attackingrole_0 = -1;

		// Token: 0x0400095C RID: 2396
		public static int formations_defensivedirection_1 = -1;

		// Token: 0x0400095D RID: 2397
		public static int formations_attackingdirection_5 = -1;

		// Token: 0x0400095E RID: 2398
		public static int formations_defensivedirection_2 = -1;

		// Token: 0x0400095F RID: 2399
		public static int formations_attackingdirection_6 = -1;

		// Token: 0x04000960 RID: 2400
		public static int formations_position5 = -1;

		// Token: 0x04000961 RID: 2401
		public static int formations_attackingrole_7 = -1;

		// Token: 0x04000962 RID: 2402
		public static int formations_defensiverole_5 = -1;

		// Token: 0x04000963 RID: 2403
		public static int formations_defensivedirection_10 = -1;

		// Token: 0x04000964 RID: 2404
		public static int formations_defensivedirection_3 = -1;

		// Token: 0x04000965 RID: 2405
		public static int formations_defensivedirection_5 = -1;

		// Token: 0x04000966 RID: 2406
		public static int formations_issweeper = -1;

		// Token: 0x04000967 RID: 2407
		public static int formations_attackingdirection_2 = -1;

		// Token: 0x04000968 RID: 2408
		public static int formations_attackingdirection_4 = -1;

		// Token: 0x04000969 RID: 2409
		public static int formations_attackingrole_9 = -1;

		// Token: 0x0400096A RID: 2410
		public static int formations_defensiverole_2 = -1;

		// Token: 0x0400096B RID: 2411
		public static int formations_attackingdirection_3 = -1;

		// Token: 0x0400096C RID: 2412
		public static int formations_attackingrole_8 = -1;

		// Token: 0x0400096D RID: 2413
		public static int formations_attackingrole_1 = -1;

		// Token: 0x0400096E RID: 2414
		public static int formations_defensiverole_10 = -1;

		// Token: 0x0400096F RID: 2415
		public static int formations_defensiverole_1 = -1;

		// Token: 0x04000970 RID: 2416
		public static int formations_teamid = -1;

		// Token: 0x04000971 RID: 2417
		public static int formations_position2 = -1;

		// Token: 0x04000972 RID: 2418
		public static int formations_defensivedirection_4 = -1;

		// Token: 0x04000973 RID: 2419
		public static int formations_formationid = -1;

		// Token: 0x04000974 RID: 2420
		public static int formations_defensiverole_8 = -1;

		// Token: 0x04000975 RID: 2421
		public static int formations_attackingrole_6 = -1;

		// Token: 0x04000976 RID: 2422
		public static int formations_relativeformationid = -1;

		// Token: 0x04000977 RID: 2423
		public static int formations_defensiverole_0 = -1;

		// Token: 0x04000978 RID: 2424
		public static int formations_defensiverole_6 = -1;

		// Token: 0x04000979 RID: 2425
		public static int formations_position4 = -1;

		// Token: 0x0400097A RID: 2426
		public static int formations_attackingrole_10 = -1;

		// Token: 0x0400097B RID: 2427
		public static int formations_position3 = -1;

		// Token: 0x0400097C RID: 2428
		public static int formations_defensiverole_7 = -1;

		// Token: 0x0400097D RID: 2429
		public static int formations_formationfullnameid = -1;

		// Token: 0x0400097E RID: 2430
		public static int formations_defensiverole_9 = -1;

		// Token: 0x0400097F RID: 2431
		public static int formations_position0 = -1;

		// Token: 0x04000980 RID: 2432
		public static int formations_position9 = -1;

		// Token: 0x04000981 RID: 2433
		public static int formations_position7 = -1;

		// Token: 0x04000982 RID: 2434
		public static int formations_position1 = -1;

		// Token: 0x04000983 RID: 2435
		public static int formations_defensivedirection_7 = -1;

		// Token: 0x04000984 RID: 2436
		public static int fieldpositionboundingboxes_pointy1 = -1;

		// Token: 0x04000985 RID: 2437
		public static int fieldpositionboundingboxes_pointx1 = -1;

		// Token: 0x04000986 RID: 2438
		public static int fieldpositionboundingboxes_pointy0 = -1;

		// Token: 0x04000987 RID: 2439
		public static int fieldpositionboundingboxes_pointy3 = -1;

		// Token: 0x04000988 RID: 2440
		public static int fieldpositionboundingboxes_pointy2 = -1;

		// Token: 0x04000989 RID: 2441
		public static int fieldpositionboundingboxes_pointx0 = -1;

		// Token: 0x0400098A RID: 2442
		public static int fieldpositionboundingboxes_pointx3 = -1;

		// Token: 0x0400098B RID: 2443
		public static int fieldpositionboundingboxes_pointx2 = -1;

		// Token: 0x0400098C RID: 2444
		public static int fieldpositionboundingboxes_positionid = -1;

		// Token: 0x0400098D RID: 2445
		public static int editedplayernames_firstname = -1;

		// Token: 0x0400098E RID: 2446
		public static int editedplayernames_commonname = -1;

		// Token: 0x0400098F RID: 2447
		public static int editedplayernames_playerjerseyname = -1;

		// Token: 0x04000990 RID: 2448
		public static int editedplayernames_surname = -1;

		// Token: 0x04000991 RID: 2449
		public static int editedplayernames_playerid = -1;

		// Token: 0x04000992 RID: 2450
		public static int dna_dna = -1;

		// Token: 0x04000993 RID: 2451
		public static int dna_playerid = -1;

		// Token: 0x04000994 RID: 2452
		public static int dcplayernames_name = -1;

		// Token: 0x04000995 RID: 2453
		public static int dcplayernames_nameid = -1;

		// Token: 0x04000996 RID: 2454
		public static int customformations_offset6x = -1;

		// Token: 0x04000997 RID: 2455
		public static int customformations_offset5y = -1;

		// Token: 0x04000998 RID: 2456
		public static int customformations_offset10x = -1;

		// Token: 0x04000999 RID: 2457
		public static int customformations_offset2x = -1;

		// Token: 0x0400099A RID: 2458
		public static int customformations_defenders = -1;

		// Token: 0x0400099B RID: 2459
		public static int customformations_offset2y = -1;

		// Token: 0x0400099C RID: 2460
		public static int customformations_offset6y = -1;

		// Token: 0x0400099D RID: 2461
		public static int customformations_offset7x = -1;

		// Token: 0x0400099E RID: 2462
		public static int customformations_offset3x = -1;

		// Token: 0x0400099F RID: 2463
		public static int customformations_offset8x = -1;

		// Token: 0x040009A0 RID: 2464
		public static int customformations_offset10y = -1;

		// Token: 0x040009A1 RID: 2465
		public static int customformations_offset3y = -1;

		// Token: 0x040009A2 RID: 2466
		public static int customformations_offset4x = -1;

		// Token: 0x040009A3 RID: 2467
		public static int customformations_offset7y = -1;

		// Token: 0x040009A4 RID: 2468
		public static int customformations_offset0x = -1;

		// Token: 0x040009A5 RID: 2469
		public static int customformations_offset8y = -1;

		// Token: 0x040009A6 RID: 2470
		public static int customformations_attackers = -1;

		// Token: 0x040009A7 RID: 2471
		public static int customformations_offset9x = -1;

		// Token: 0x040009A8 RID: 2472
		public static int customformations_midfielders = -1;

		// Token: 0x040009A9 RID: 2473
		public static int customformations_offset5x = -1;

		// Token: 0x040009AA RID: 2474
		public static int customformations_offset0y = -1;

		// Token: 0x040009AB RID: 2475
		public static int customformations_offset1x = -1;

		// Token: 0x040009AC RID: 2476
		public static int customformations_offset4y = -1;

		// Token: 0x040009AD RID: 2477
		public static int customformations_offset9y = -1;

		// Token: 0x040009AE RID: 2478
		public static int customformations_offset1y = -1;

		// Token: 0x040009AF RID: 2479
		public static int customformations_formationname = -1;

		// Token: 0x040009B0 RID: 2480
		public static int customformations_attackingdirection_0 = -1;

		// Token: 0x040009B1 RID: 2481
		public static int customformations_attackingrole_5 = -1;

		// Token: 0x040009B2 RID: 2482
		public static int customformations_position10 = -1;

		// Token: 0x040009B3 RID: 2483
		public static int customformations_attackingdirection_7 = -1;

		// Token: 0x040009B4 RID: 2484
		public static int customformations_defensivedirection_0 = -1;

		// Token: 0x040009B5 RID: 2485
		public static int customformations_defensivedirection_9 = -1;

		// Token: 0x040009B6 RID: 2486
		public static int customformations_defensivedirection_8 = -1;

		// Token: 0x040009B7 RID: 2487
		public static int customformations_attackingdirection_9 = -1;

		// Token: 0x040009B8 RID: 2488
		public static int customformations_position6 = -1;

		// Token: 0x040009B9 RID: 2489
		public static int customformations_attackingrole_4 = -1;

		// Token: 0x040009BA RID: 2490
		public static int customformations_offensiverating = -1;

		// Token: 0x040009BB RID: 2491
		public static int customformations_attackingrole_2 = -1;

		// Token: 0x040009BC RID: 2492
		public static int customformations_attackingdirection_1 = -1;

		// Token: 0x040009BD RID: 2493
		public static int customformations_position8 = -1;

		// Token: 0x040009BE RID: 2494
		public static int customformations_defensiverole_4 = -1;

		// Token: 0x040009BF RID: 2495
		public static int customformations_attackingdirection_10 = -1;

		// Token: 0x040009C0 RID: 2496
		public static int customformations_defensivedirection_6 = -1;

		// Token: 0x040009C1 RID: 2497
		public static int customformations_attackingdirection_8 = -1;

		// Token: 0x040009C2 RID: 2498
		public static int customformations_attackingrole_3 = -1;

		// Token: 0x040009C3 RID: 2499
		public static int customformations_defensiverole_3 = -1;

		// Token: 0x040009C4 RID: 2500
		public static int customformations_attackingrole_0 = -1;

		// Token: 0x040009C5 RID: 2501
		public static int customformations_defensivedirection_1 = -1;

		// Token: 0x040009C6 RID: 2502
		public static int customformations_attackingdirection_5 = -1;

		// Token: 0x040009C7 RID: 2503
		public static int customformations_defensivedirection_2 = -1;

		// Token: 0x040009C8 RID: 2504
		public static int customformations_attackingdirection_6 = -1;

		// Token: 0x040009C9 RID: 2505
		public static int customformations_position5 = -1;

		// Token: 0x040009CA RID: 2506
		public static int customformations_attackingrole_7 = -1;

		// Token: 0x040009CB RID: 2507
		public static int customformations_defensiverole_5 = -1;

		// Token: 0x040009CC RID: 2508
		public static int customformations_defensivedirection_10 = -1;

		// Token: 0x040009CD RID: 2509
		public static int customformations_defensivedirection_3 = -1;

		// Token: 0x040009CE RID: 2510
		public static int customformations_defensivedirection_5 = -1;

		// Token: 0x040009CF RID: 2511
		public static int customformations_issweeper = -1;

		// Token: 0x040009D0 RID: 2512
		public static int customformations_attackingdirection_2 = -1;

		// Token: 0x040009D1 RID: 2513
		public static int customformations_attackingdirection_4 = -1;

		// Token: 0x040009D2 RID: 2514
		public static int customformations_attackingrole_9 = -1;

		// Token: 0x040009D3 RID: 2515
		public static int customformations_defensiverole_2 = -1;

		// Token: 0x040009D4 RID: 2516
		public static int customformations_attackingdirection_3 = -1;

		// Token: 0x040009D5 RID: 2517
		public static int customformations_attackingrole_8 = -1;

		// Token: 0x040009D6 RID: 2518
		public static int customformations_attackingrole_1 = -1;

		// Token: 0x040009D7 RID: 2519
		public static int customformations_defensiverole_10 = -1;

		// Token: 0x040009D8 RID: 2520
		public static int customformations_defensiverole_1 = -1;

		// Token: 0x040009D9 RID: 2521
		public static int customformations_teamid = -1;

		// Token: 0x040009DA RID: 2522
		public static int customformations_position2 = -1;

		// Token: 0x040009DB RID: 2523
		public static int customformations_defensivedirection_4 = -1;

		// Token: 0x040009DC RID: 2524
		public static int customformations_formationid = -1;

		// Token: 0x040009DD RID: 2525
		public static int customformations_defensiverole_8 = -1;

		// Token: 0x040009DE RID: 2526
		public static int customformations_attackingrole_6 = -1;

		// Token: 0x040009DF RID: 2527
		public static int customformations_relativeformationid = -1;

		// Token: 0x040009E0 RID: 2528
		public static int customformations_defensiverole_0 = -1;

		// Token: 0x040009E1 RID: 2529
		public static int customformations_defensiverole_6 = -1;

		// Token: 0x040009E2 RID: 2530
		public static int customformations_position4 = -1;

		// Token: 0x040009E3 RID: 2531
		public static int customformations_attackingrole_10 = -1;

		// Token: 0x040009E4 RID: 2532
		public static int customformations_position3 = -1;

		// Token: 0x040009E5 RID: 2533
		public static int customformations_defensiverole_7 = -1;

		// Token: 0x040009E6 RID: 2534
		public static int customformations_formationfullnameid = -1;

		// Token: 0x040009E7 RID: 2535
		public static int customformations_defensiverole_9 = -1;

		// Token: 0x040009E8 RID: 2536
		public static int customformations_position0 = -1;

		// Token: 0x040009E9 RID: 2537
		public static int customformations_position9 = -1;

		// Token: 0x040009EA RID: 2538
		public static int customformations_position7 = -1;

		// Token: 0x040009EB RID: 2539
		public static int customformations_position1 = -1;

		// Token: 0x040009EC RID: 2540
		public static int customformations_defensivedirection_7 = -1;

		// Token: 0x040009ED RID: 2541
		public static int competition_ballid = -1;

		// Token: 0x040009EE RID: 2542
		public static int competition_competitionid = -1;

		// Token: 0x040009EF RID: 2543
		public static int career_lastnames_lastname = -1;

		// Token: 0x040009F0 RID: 2544
		public static int career_lastnames_lastnameid = -1;

		// Token: 0x040009F1 RID: 2545
		public static int career_lastnames_groupid = -1;

		// Token: 0x040009F2 RID: 2546
		public static int career_firstnames_firstname = -1;

		// Token: 0x040009F3 RID: 2547
		public static int career_firstnames_firstnameid = -1;

		// Token: 0x040009F4 RID: 2548
		public static int career_firstnames_groupid = -1;

		// Token: 0x040009F5 RID: 2549
		public static int career_commonnames_firstname = -1;

		// Token: 0x040009F6 RID: 2550
		public static int career_commonnames_lastname = -1;

		// Token: 0x040009F7 RID: 2551
		public static int career_commonnames_commonnameid = -1;

		// Token: 0x040009F8 RID: 2552
		public static int career_commonnames_groupid = -1;

		// Token: 0x040009F9 RID: 2553
		public static int attributeprefpositionformula_attribute = -1;

		// Token: 0x040009FA RID: 2554
		public static int attributeprefpositionformula_position = -1;

		// Token: 0x040009FB RID: 2555
		public static int attributeprefpositionformula_percentage = -1;

		// Token: 0x040009FC RID: 2556
		public static int audionation_nationid = -1;

		// Token: 0x040009FD RID: 2557
		public static int audionation_PALanguageIndex = -1;

		// Token: 0x040009FE RID: 2558
		public static int audionation_DefaultCommLang = -1;

		// Token: 0x040009FF RID: 2559
		public static int audionation_CrowdBedsRegionIndex = -1;

		// Token: 0x04000A00 RID: 2560
		public static int audionation_WhistlesRegionIndex = -1;

		// Token: 0x04000A01 RID: 2561
		public static int audionation_AmbienceRegionIndex = -1;

		// Token: 0x04000A02 RID: 2562
		public static int audionation_PlayerCallPatchBankIndex = -1;

		// Token: 0x04000A03 RID: 2563
		public static int audionation_HecklesRegionIndex = -1;

		// Token: 0x04000A04 RID: 2564
		public static int audionation_ChantRegionIndex = -1;

		// Token: 0x04000A05 RID: 2565
		public static int audionation_TeamCanWhistleIndex = -1;

		// Token: 0x04000A06 RID: 2566
		public static int audionation_ReactionsRegionIndex = -1;

		// Token: 0x04000A07 RID: 2567
		public static int NoAttendance_Max = -1;

		// Token: 0x04000A08 RID: 2568
		public static int NoAttendance_Emotion = -1;

		// Token: 0x04000A09 RID: 2569
		public static int NoAttendance_Min = -1;

		// Token: 0x04000A0A RID: 2570
		public static int MatchIntensity_ScoreDiff = -1;

		// Token: 0x04000A0B RID: 2571
		public static int MatchIntensity_time60 = -1;

		// Token: 0x04000A0C RID: 2572
		public static int MatchIntensity_time90 = -1;

		// Token: 0x04000A0D RID: 2573
		public static int MatchIntensity_time120 = -1;

		// Token: 0x04000A0E RID: 2574
		public static int MatchIntensity_time75 = -1;

		// Token: 0x04000A0F RID: 2575
		public static int MatchIntensity_time45 = -1;

		// Token: 0x04000A10 RID: 2576
		public static int MatchIntensity_time30 = -1;

		// Token: 0x04000A11 RID: 2577
		public static int MatchIntensity_time15 = -1;

		// Token: 0x04000A12 RID: 2578
		public static int BigAttendance_Max = -1;

		// Token: 0x04000A13 RID: 2579
		public static int BigAttendance_Emotion = -1;

		// Token: 0x04000A14 RID: 2580
		public static int BigAttendance_Min = -1;

		// Token: 0x04000A15 RID: 2581
		public static int audiostadium_stadiumid = -1;

		// Token: 0x04000A16 RID: 2582
		public static int audiostadium_audioindex = -1;

		// Token: 0x04000A17 RID: 2583
		public static int career_managerawards_count = -1;

		// Token: 0x04000A18 RID: 2584
		public static int career_managerawards_season = -1;

		// Token: 0x04000A19 RID: 2585
		public static int career_managerawards_compobjid = -1;

		// Token: 0x04000A1A RID: 2586
		public static int career_managerawards_artificialkey = -1;

		// Token: 0x04000A1B RID: 2587
		public static int career_managerawards_teamid = -1;

		// Token: 0x04000A1C RID: 2588
		public static int career_managerawards_typeid = -1;

		// Token: 0x04000A1D RID: 2589
		public static int career_teamofweek_artificialkey = -1;

		// Token: 0x04000A1E RID: 2590
		public static int career_teamofweek_matchrating = -1;

		// Token: 0x04000A1F RID: 2591
		public static int career_teamofweek_weekswon = -1;

		// Token: 0x04000A20 RID: 2592
		public static int career_teamofweek_month = -1;

		// Token: 0x04000A21 RID: 2593
		public static int career_teamofweek_playerid = -1;

		// Token: 0x04000A22 RID: 2594
		public static int career_playerawards_season = -1;

		// Token: 0x04000A23 RID: 2595
		public static int career_playerawards_compobjid = -1;

		// Token: 0x04000A24 RID: 2596
		public static int career_playerawards_count = -1;

		// Token: 0x04000A25 RID: 2597
		public static int career_playerawards_artificialkey = -1;

		// Token: 0x04000A26 RID: 2598
		public static int career_playerawards_teamid = -1;

		// Token: 0x04000A27 RID: 2599
		public static int career_playerawards_playerid = -1;

		// Token: 0x04000A28 RID: 2600
		public static int career_playerawards_typeid = -1;

		// Token: 0x04000A29 RID: 2601
		public static int career_calendar_transferwindowend1 = -1;

		// Token: 0x04000A2A RID: 2602
		public static int career_calendar_transferwindowstart1 = -1;

		// Token: 0x04000A2B RID: 2603
		public static int career_calendar_transferwindowend2 = -1;

		// Token: 0x04000A2C RID: 2604
		public static int career_calendar_setupdate = -1;

		// Token: 0x04000A2D RID: 2605
		public static int career_calendar_dateid = -1;

		// Token: 0x04000A2E RID: 2606
		public static int career_calendar_enddate = -1;

		// Token: 0x04000A2F RID: 2607
		public static int career_calendar_currdate = -1;

		// Token: 0x04000A30 RID: 2608
		public static int career_calendar_startdate = -1;

		// Token: 0x04000A31 RID: 2609
		public static int career_calendar_transferwindowstart2 = -1;

		// Token: 0x04000A32 RID: 2610
		public static int career_squadranking_curroverall = -1;

		// Token: 0x04000A33 RID: 2611
		public static int career_squadranking_playerid = -1;

		// Token: 0x04000A34 RID: 2612
		public static int career_squadranking_lastoverall = -1;

		// Token: 0x04000A35 RID: 2613
		public static int career_playermatchratinghistory_minsplayed = -1;

		// Token: 0x04000A36 RID: 2614
		public static int career_playermatchratinghistory_date = -1;

		// Token: 0x04000A37 RID: 2615
		public static int career_playermatchratinghistory_artificialkey = -1;

		// Token: 0x04000A38 RID: 2616
		public static int career_playermatchratinghistory_rating = -1;

		// Token: 0x04000A39 RID: 2617
		public static int career_playermatchratinghistory_playerid = -1;

		// Token: 0x04000A3A RID: 2618
		public static int career_fixtureinfo_homeprevscore = -1;

		// Token: 0x04000A3B RID: 2619
		public static int career_fixtureinfo_hometeamid = -1;

		// Token: 0x04000A3C RID: 2620
		public static int career_fixtureinfo_totalmatches = -1;

		// Token: 0x04000A3D RID: 2621
		public static int career_fixtureinfo_stagecompobjid = -1;

		// Token: 0x04000A3E RID: 2622
		public static int career_fixtureinfo_subsonbench = -1;

		// Token: 0x04000A3F RID: 2623
		public static int career_fixtureinfo_pitchwear = -1;

		// Token: 0x04000A40 RID: 2624
		public static int career_fixtureinfo_assetid = -1;

		// Token: 0x04000A41 RID: 2625
		public static int career_fixtureinfo_stadiumid = -1;

		// Token: 0x04000A42 RID: 2626
		public static int career_fixtureinfo_matchsituation = -1;

		// Token: 0x04000A43 RID: 2627
		public static int career_fixtureinfo_fixturedate = -1;

		// Token: 0x04000A44 RID: 2628
		public static int career_fixtureinfo_suspensioncompobjid = -1;

		// Token: 0x04000A45 RID: 2629
		public static int career_fixtureinfo_numgamesdoubleyellowbanmin = -1;

		// Token: 0x04000A46 RID: 2630
		public static int career_fixtureinfo_neutralstadium = -1;

		// Token: 0x04000A47 RID: 2631
		public static int career_fixtureinfo_compobjid = -1;

		// Token: 0x04000A48 RID: 2632
		public static int career_fixtureinfo_offsides = -1;

		// Token: 0x04000A49 RID: 2633
		public static int career_fixtureinfo_comptype = -1;

		// Token: 0x04000A4A RID: 2634
		public static int career_fixtureinfo_numgamesdoubleyellowbanmax = -1;

		// Token: 0x04000A4B RID: 2635
		public static int career_fixtureinfo_weathertype = -1;

		// Token: 0x04000A4C RID: 2636
		public static int career_fixtureinfo_subsavailable = -1;

		// Token: 0x04000A4D RID: 2637
		public static int career_fixtureinfo_matchimportance = -1;

		// Token: 0x04000A4E RID: 2638
		public static int career_fixtureinfo_awayprevscore = -1;

		// Token: 0x04000A4F RID: 2639
		public static int career_fixtureinfo_matchnumber = -1;

		// Token: 0x04000A50 RID: 2640
		public static int career_fixtureinfo_fixtureid = -1;

		// Token: 0x04000A51 RID: 2641
		public static int career_fixtureinfo_numyellowsforban = -1;

		// Token: 0x04000A52 RID: 2642
		public static int career_fixtureinfo_injuries = -1;

		// Token: 0x04000A53 RID: 2643
		public static int career_fixtureinfo_matchsetupflags = -1;

		// Token: 0x04000A54 RID: 2644
		public static int career_fixtureinfo_timeofday = -1;

		// Token: 0x04000A55 RID: 2645
		public static int career_fixtureinfo_fixturetime = -1;

		// Token: 0x04000A56 RID: 2646
		public static int career_fixtureinfo_numgamesyellowbanmax = -1;

		// Token: 0x04000A57 RID: 2647
		public static int career_fixtureinfo_awayteamid = -1;

		// Token: 0x04000A58 RID: 2648
		public static int career_fixtureinfo_bookings = -1;

		// Token: 0x04000A59 RID: 2649
		public static int career_fixtureinfo_numgamesredbanmax = -1;

		// Token: 0x04000A5A RID: 2650
		public static int career_fixtureinfo_numgamesyellowbanmin = -1;

		// Token: 0x04000A5B RID: 2651
		public static int career_fixtureinfo_userid = -1;

		// Token: 0x04000A5C RID: 2652
		public static int career_fixtureinfo_matchtype = -1;

		// Token: 0x04000A5D RID: 2653
		public static int career_fixtureinfo_numgamesredbanmin = -1;

		// Token: 0x04000A5E RID: 2654
		public static int career_fixtureinfo_fixtureinfoid = -1;

		// Token: 0x04000A5F RID: 2655
		public static int career_clinchedobjectives_predictedclinchfordrawflags = -1;

		// Token: 0x04000A60 RID: 2656
		public static int career_clinchedobjectives_clinchedobjectivesflags = -1;

		// Token: 0x04000A61 RID: 2657
		public static int career_clinchedobjectives_predictedclinchforwinflags = -1;

		// Token: 0x04000A62 RID: 2658
		public static int career_clinchedobjectives_teamid = -1;

		// Token: 0x04000A63 RID: 2659
		public static int career_clinchedobjectives_predictedclinchforlossflags = -1;

		// Token: 0x04000A64 RID: 2660
		public static int cmeventhistory_artificialkey = -1;

		// Token: 0x04000A65 RID: 2661
		public static int cmeventhistory_teamId = -1;

		// Token: 0x04000A66 RID: 2662
		public static int cmeventhistory_eventId = -1;

		// Token: 0x04000A67 RID: 2663
		public static int cmeventhistory_playerId = -1;

		// Token: 0x04000A68 RID: 2664
		public static int cmeventhistory_daysfromstart = -1;

		// Token: 0x04000A69 RID: 2665
		public static int cmteameventhistory_artificialkey = -1;

		// Token: 0x04000A6A RID: 2666
		public static int cmteameventhistory_teamId = -1;

		// Token: 0x04000A6B RID: 2667
		public static int cmteameventhistory_eventId = -1;

		// Token: 0x04000A6C RID: 2668
		public static int cmteameventhistory_daysfromstart = -1;

		// Token: 0x04000A6D RID: 2669
		public static int career_boardoutcomes_outcome3 = -1;

		// Token: 0x04000A6E RID: 2670
		public static int career_boardoutcomes_outcome4 = -1;

		// Token: 0x04000A6F RID: 2671
		public static int career_boardoutcomes_leagueid = -1;

		// Token: 0x04000A70 RID: 2672
		public static int career_boardoutcomes_outcome1 = -1;

		// Token: 0x04000A71 RID: 2673
		public static int career_boardoutcomes_outcome2 = -1;

		// Token: 0x04000A72 RID: 2674
		public static int career_boardoutcomes_outcome5 = -1;

		// Token: 0x04000A73 RID: 2675
		public static int career_users_firstname = -1;

		// Token: 0x04000A74 RID: 2676
		public static int career_users_surname = -1;

		// Token: 0x04000A75 RID: 2677
		public static int career_users_agentname = -1;

		// Token: 0x04000A76 RID: 2678
		public static int career_users_nationalityid = -1;

		// Token: 0x04000A77 RID: 2679
		public static int career_users_goalnews = -1;

		// Token: 0x04000A78 RID: 2680
		public static int career_users_playertype = -1;

		// Token: 0x04000A79 RID: 2681
		public static int career_users_nationalteamid = -1;

		// Token: 0x04000A7A RID: 2682
		public static int career_users_leagueseasonmessagesent = -1;

		// Token: 0x04000A7B RID: 2683
		public static int career_users_sponsorid = -1;

		// Token: 0x04000A7C RID: 2684
		public static int career_users_leagueid = -1;

		// Token: 0x04000A7D RID: 2685
		public static int career_users_clubteamid = -1;

		// Token: 0x04000A7E RID: 2686
		public static int career_users_wage = -1;

		// Token: 0x04000A7F RID: 2687
		public static int career_users_primarycompobjid = -1;

		// Token: 0x04000A80 RID: 2688
		public static int career_users_seasoncount = -1;

		// Token: 0x04000A81 RID: 2689
		public static int career_users_usertype = -1;

		// Token: 0x04000A82 RID: 2690
		public static int career_users_userid = -1;

		// Token: 0x04000A83 RID: 2691
		public static int career_trophies_season = -1;

		// Token: 0x04000A84 RID: 2692
		public static int career_trophies_flags = -1;

		// Token: 0x04000A85 RID: 2693
		public static int career_trophies_userid = -1;

		// Token: 0x04000A86 RID: 2694
		public static int career_managerpref_currency = -1;

		// Token: 0x04000A87 RID: 2695
		public static int career_managerpref_matchdifficulty = -1;

		// Token: 0x04000A88 RID: 2696
		public static int career_managerpref_playasaiteam = -1;

		// Token: 0x04000A89 RID: 2697
		public static int career_managerpref_bonuspercentage = -1;

		// Token: 0x04000A8A RID: 2698
		public static int career_managerpref_boardfinancialstrictness = -1;

		// Token: 0x04000A8B RID: 2699
		public static int career_managerpref_usedsquad = -1;

		// Token: 0x04000A8C RID: 2700
		public static int career_managerpref_stadiumid = -1;

		// Token: 0x04000A8D RID: 2701
		public static int career_managerpref_halflength = -1;

		// Token: 0x04000A8E RID: 2702
		public static int career_managerpref_managerprefid = -1;

		// Token: 0x04000A8F RID: 2703
		public static int career_managerpref_wagebudget = -1;

		// Token: 0x04000A90 RID: 2704
		public static int career_managerpref_boardaidifficulty = -1;

		// Token: 0x04000A91 RID: 2705
		public static int career_managerpref_startofseasontransferbudget = -1;

		// Token: 0x04000A92 RID: 2706
		public static int career_managerpref_transferbudget = -1;

		// Token: 0x04000A93 RID: 2707
		public static int career_managerpref_startofseasonwagebudget = -1;

		// Token: 0x04000A94 RID: 2708
		public static int career_managerpref_startofseasonplayerwages = -1;

		// Token: 0x04000A95 RID: 2709
		public static int career_managerinfo_biglossoppscore = -1;

		// Token: 0x04000A96 RID: 2710
		public static int career_managerinfo_bigwinoppscore = -1;

		// Token: 0x04000A97 RID: 2711
		public static int career_managerinfo_biglossuserscore = -1;

		// Token: 0x04000A98 RID: 2712
		public static int career_managerinfo_bigwinuserscore = -1;

		// Token: 0x04000A99 RID: 2713
		public static int career_managerinfo_seasonobjective3 = -1;

		// Token: 0x04000A9A RID: 2714
		public static int career_managerinfo_bigwindate = -1;

		// Token: 0x04000A9B RID: 2715
		public static int career_managerinfo_bigwinoppteamid = -1;

		// Token: 0x04000A9C RID: 2716
		public static int career_managerinfo_biglossdate = -1;

		// Token: 0x04000A9D RID: 2717
		public static int career_managerinfo_seasonobjectiveresult1 = -1;

		// Token: 0x04000A9E RID: 2718
		public static int career_managerinfo_seasonobjectiveresult2 = -1;

		// Token: 0x04000A9F RID: 2719
		public static int career_managerinfo_totalearnings = -1;

		// Token: 0x04000AA0 RID: 2720
		public static int career_managerinfo_clubteamid = -1;

		// Token: 0x04000AA1 RID: 2721
		public static int career_managerinfo_biglossuserteamid = -1;

		// Token: 0x04000AA2 RID: 2722
		public static int career_managerinfo_wage = -1;

		// Token: 0x04000AA3 RID: 2723
		public static int career_managerinfo_bigwinuserteamid = -1;

		// Token: 0x04000AA4 RID: 2724
		public static int career_managerinfo_losingstreak = -1;

		// Token: 0x04000AA5 RID: 2725
		public static int career_managerinfo_seasonobjectiveresult3 = -1;

		// Token: 0x04000AA6 RID: 2726
		public static int career_managerinfo_playersreleasedthisseason = -1;

		// Token: 0x04000AA7 RID: 2727
		public static int career_managerinfo_biglossoppteamid = -1;

		// Token: 0x04000AA8 RID: 2728
		public static int career_managerinfo_seasonobjective1 = -1;

		// Token: 0x04000AA9 RID: 2729
		public static int career_managerinfo_internationalteamid = -1;

		// Token: 0x04000AAA RID: 2730
		public static int career_managerinfo_managerreputation = -1;

		// Token: 0x04000AAB RID: 2731
		public static int career_managerinfo_seasonobjective2 = -1;

		// Token: 0x04000AAC RID: 2732
		public static int career_managerinfo_boardconfidence = -1;

		// Token: 0x04000AAD RID: 2733
		public static int career_managerinfo_userid = -1;

		// Token: 0x04000AAE RID: 2734
		public static int career_managerhistory_draws = -1;

		// Token: 0x04000AAF RID: 2735
		public static int career_managerhistory_losses = -1;

		// Token: 0x04000AB0 RID: 2736
		public static int career_managerhistory_wins = -1;

		// Token: 0x04000AB1 RID: 2737
		public static int career_managerhistory_games_played = -1;

		// Token: 0x04000AB2 RID: 2738
		public static int career_managerhistory_bigbuyplayername = -1;

		// Token: 0x04000AB3 RID: 2739
		public static int career_managerhistory_bigsellplayername = -1;

		// Token: 0x04000AB4 RID: 2740
		public static int career_managerhistory_leagueobjectiveresult = -1;

		// Token: 0x04000AB5 RID: 2741
		public static int career_managerhistory_continentalcuptrophies = -1;

		// Token: 0x04000AB6 RID: 2742
		public static int career_managerhistory_season = -1;

		// Token: 0x04000AB7 RID: 2743
		public static int career_managerhistory_bigsellamount = -1;

		// Token: 0x04000AB8 RID: 2744
		public static int career_managerhistory_leaguetrophies = -1;

		// Token: 0x04000AB9 RID: 2745
		public static int career_managerhistory_domestic_cup_result = -1;

		// Token: 0x04000ABA RID: 2746
		public static int career_managerhistory_domesticcuptrophies = -1;

		// Token: 0x04000ABB RID: 2747
		public static int career_managerhistory_leagueid = -1;

		// Token: 0x04000ABC RID: 2748
		public static int career_managerhistory_bigbuyamount = -1;

		// Token: 0x04000ABD RID: 2749
		public static int career_managerhistory_leagueobjective = -1;

		// Token: 0x04000ABE RID: 2750
		public static int career_managerhistory_domestic_cup_objective = -1;

		// Token: 0x04000ABF RID: 2751
		public static int career_managerhistory_europe_cup_objective = -1;

		// Token: 0x04000AC0 RID: 2752
		public static int career_managerhistory_artificialkey = -1;

		// Token: 0x04000AC1 RID: 2753
		public static int career_managerhistory_teamid = -1;

		// Token: 0x04000AC2 RID: 2754
		public static int career_managerhistory_goals_for = -1;

		// Token: 0x04000AC3 RID: 2755
		public static int career_managerhistory_points = -1;

		// Token: 0x04000AC4 RID: 2756
		public static int career_managerhistory_tableposition = -1;

		// Token: 0x04000AC5 RID: 2757
		public static int career_managerhistory_forfeits = -1;

		// Token: 0x04000AC6 RID: 2758
		public static int career_managerhistory_goals_against = -1;

		// Token: 0x04000AC7 RID: 2759
		public static int career_managerhistory_europe_cup_result = -1;

		// Token: 0x04000AC8 RID: 2760
		public static int career_leagueballs_balltype = -1;

		// Token: 0x04000AC9 RID: 2761
		public static int career_leagueballs_leagueid = -1;

		// Token: 0x04000ACA RID: 2762
		public static int career_competitionprogress_compshortname = -1;

		// Token: 0x04000ACB RID: 2763
		public static int career_competitionprogress_artificialkey = -1;

		// Token: 0x04000ACC RID: 2764
		public static int career_competitionprogress_cup_objective_result = -1;

		// Token: 0x04000ACD RID: 2765
		public static int career_competitionprogress_stageid = -1;

		// Token: 0x04000ACE RID: 2766
		public static int career_competitionprogress_season = -1;

		// Token: 0x04000ACF RID: 2767
		public static int career_competitionprogress_compobjid = -1;

		// Token: 0x04000AD0 RID: 2768
		public static int career_competitionprogress_teamid = -1;

		// Token: 0x04000AD1 RID: 2769
		public static int career_competitionprogress_hasteamwon = -1;

		// Token: 0x04000AD2 RID: 2770
		public static int clubcommentarynames_commentaryid = -1;

		// Token: 0x04000AD3 RID: 2771
		public static int clubcommentarynames_commentarystartingletter = -1;

		// Token: 0x04000AD4 RID: 2772
		public static int createplayerviews_attributeid = -1;

		// Token: 0x04000AD5 RID: 2773
		public static int createplayerviews_mainviewid = -1;

		// Token: 0x04000AD6 RID: 2774
		public static int createplayerpositiontemplates_attributeid = -1;

		// Token: 0x04000AD7 RID: 2775
		public static int createplayerpositiontemplates_attributevalue = -1;

		// Token: 0x04000AD8 RID: 2776
		public static int createplayerpositiontemplates_positionid = -1;

		// Token: 0x04000AD9 RID: 2777
		public static int createplayer_cpmorphcomposite_noseprofile_protrusion_lsx = -1;

		// Token: 0x04000ADA RID: 2778
		public static int createplayer_cpmorphcomposite_eyedetail1_folds_lsy = -1;

		// Token: 0x04000ADB RID: 2779
		public static int createplayer_cpmorphcomposite_mouthposition_protrusion_rsx = -1;

		// Token: 0x04000ADC RID: 2780
		public static int createplayer_cpmorphcomposite_nostrildetail_height_lsy = -1;

		// Token: 0x04000ADD RID: 2781
		public static int createplayer_cpmorphcomposite_browshape_protrusion_rsx = -1;

		// Token: 0x04000ADE RID: 2782
		public static int createplayer_cpmorphcomposite_browshape_tilt_lsy = -1;

		// Token: 0x04000ADF RID: 2783
		public static int createplayer_cpmorphcomposite_earplacement_height_lsy = -1;

		// Token: 0x04000AE0 RID: 2784
		public static int createplayer_cpmorphcomposite_cheekplacement_position_lsy = -1;

		// Token: 0x04000AE1 RID: 2785
		public static int createplayer_cpmorphcomposite_eyeshape_shape_rsx = -1;

		// Token: 0x04000AE2 RID: 2786
		public static int createplayer_cpmorphcomposite_lips_upperlip_shape_lsx = -1;

		// Token: 0x04000AE3 RID: 2787
		public static int createplayer_cpmorphcomposite_eyeshape_height_lsy = -1;

		// Token: 0x04000AE4 RID: 2788
		public static int createplayer_cpmorphcomposite_mouthposition_bite_rsy = -1;

		// Token: 0x04000AE5 RID: 2789
		public static int createplayer_cpmorphcomposite_cheekstyle_blemishes_rsx = -1;

		// Token: 0x04000AE6 RID: 2790
		public static int createplayer_cpmorphcomposite_nostrils_height_lsy = -1;

		// Token: 0x04000AE7 RID: 2791
		public static int createplayer_cpmorphcomposite_mouthblemishes_lsx = -1;

		// Token: 0x04000AE8 RID: 2792
		public static int createplayer_cpmorphcomposite_earstyle_lobe_lsx = -1;

		// Token: 0x04000AE9 RID: 2793
		public static int createplayer_skincolor = -1;

		// Token: 0x04000AEA RID: 2794
		public static int createplayer_cpmorphcomposite_mouthposition_width_lsx = -1;

		// Token: 0x04000AEB RID: 2795
		public static int createplayer_cpmorphcomposite_eyeshape_tilt_rsy = -1;

		// Token: 0x04000AEC RID: 2796
		public static int createplayer_cpmorphcomposite_noseprofile_tipshape_rsy = -1;

		// Token: 0x04000AED RID: 2797
		public static int createplayer_cpmorphcomposite_browplacement_thickness_rsy = -1;

		// Token: 0x04000AEE RID: 2798
		public static int createplayer_cpmorphcomposite_noseplacement_position_lsy = -1;

		// Token: 0x04000AEF RID: 2799
		public static int createplayer_cpmorphcomposite_eyeshape_seperation_lsx = -1;

		// Token: 0x04000AF0 RID: 2800
		public static int createplayer_cpmorphcomposite_noseprofile_tipprotrusion_rsx = -1;

		// Token: 0x04000AF1 RID: 2801
		public static int createplayer_cpmorphcomposite_cheekplacement_width_lsx = -1;

		// Token: 0x04000AF2 RID: 2802
		public static int createplayer_cpmorphcomposite_laughlinedarkness_lsx = -1;

		// Token: 0x04000AF3 RID: 2803
		public static int createplayer_cpmorphcomposite_jaw_position_lsy = -1;

		// Token: 0x04000AF4 RID: 2804
		public static int createplayer_cpmorphcomposite_browplacement_protrusion_rsx = -1;

		// Token: 0x04000AF5 RID: 2805
		public static int createplayer_cpmorphcomposite_eyedetail2_lowerlid_lsx = -1;

		// Token: 0x04000AF6 RID: 2806
		public static int createplayer_cpmorphcomposite_lips_upperlip_thickness_lsy = -1;

		// Token: 0x04000AF7 RID: 2807
		public static int createplayer_cpmorphcomposite_noseprofile_shape_lsy = -1;

		// Token: 0x04000AF8 RID: 2808
		public static int createplayer_cpmorphcomposite_lips_lowerlip_thickness_rsy = -1;

		// Token: 0x04000AF9 RID: 2809
		public static int createplayer_cpmorhpcomposite_chin_width_lsx = -1;

		// Token: 0x04000AFA RID: 2810
		public static int createplayer_cpmorphcomposite_nosestyle_nosestyle_lsx = -1;

		// Token: 0x04000AFB RID: 2811
		public static int createplayer_personaid = -1;

		// Token: 0x04000AFC RID: 2812
		public static int createplayer_cpmorphcomposite_mouthposition_position_lsy = -1;

		// Token: 0x04000AFD RID: 2813
		public static int createplayer_cpmorphcomposite_earplacement_protrusion_lsx = -1;

		// Token: 0x04000AFE RID: 2814
		public static int createplayer_cpmorphcomposite_dimpledarkness_lsx = -1;

		// Token: 0x04000AFF RID: 2815
		public static int createplayer_cpmorphcomposite_noseplacement_width_rsx = -1;

		// Token: 0x04000B00 RID: 2816
		public static int createplayer_cpmorphcomposite_eyedetail2_protrusion_rsy = -1;

		// Token: 0x04000B01 RID: 2817
		public static int createplayer_cpmorphcomposite_lipstyle_corners_lipdimple_rsx = -1;

		// Token: 0x04000B02 RID: 2818
		public static int createplayer_cpmorphcomposite_lips_lowerlip_thickness_rsx = -1;

		// Token: 0x04000B03 RID: 2819
		public static int createplayer_cpmorphcomposite_browplacement_position_lsy = -1;

		// Token: 0x04000B04 RID: 2820
		public static int createplayer_cpmorhpcomposite_chin_postion_lsy = -1;

		// Token: 0x04000B05 RID: 2821
		public static int createplayer_cpmorphcomposite_lipstyle_corners_updown_lsy = -1;

		// Token: 0x04000B06 RID: 2822
		public static int createplayer_cpmorphcomposite_eyedetail1_protrusion_rsx = -1;

		// Token: 0x04000B07 RID: 2823
		public static int createplayer_cpmorphcomposite_browshape_seperation_lsx = -1;

		// Token: 0x04000B08 RID: 2824
		public static int createplayer_cpmorphcomposite_jaw_bulk_rsx = -1;

		// Token: 0x04000B09 RID: 2825
		public static int createplayer_cpmorphcomposite_noseplacement_width_lsx = -1;

		// Token: 0x04000B0A RID: 2826
		public static int createplayer_cpmorphcomposite_eyedetail1_symmetry_lsx = -1;

		// Token: 0x04000B0B RID: 2827
		public static int createplayer_cpmorphcomposite_nostrils_width_lsx = -1;

		// Token: 0x04000B0C RID: 2828
		public static int createplayer_cpmorphcomposite_eyedetail2_upperlid_lsy = -1;

		// Token: 0x04000B0D RID: 2829
		public static int createplayer_cpmorphcomposite_lipstyle_corners_leftright_lsx = -1;

		// Token: 0x04000B0E RID: 2830
		public static int createplayer_cpmorphcomposite_browplacement_tilt_lsx = -1;

		// Token: 0x04000B0F RID: 2831
		public static int createplayer_cpmorphcomposite_jaw_width_lsx = -1;

		// Token: 0x04000B10 RID: 2832
		public static int createplayer_cpmorphcomposite_browshape_thickness_rsy = -1;

		// Token: 0x04000B11 RID: 2833
		public static int createplayer_cpmorhpcomposite_chin_protrusion_rsx = -1;

		// Token: 0x04000B12 RID: 2834
		public static int createplayer_cpmorphcomposite_noseplacement_position_rsy = -1;

		// Token: 0x04000B13 RID: 2835
		public static int createplayer_cpmorphcomposite_nostrildetail_width_lsx = -1;

		// Token: 0x04000B14 RID: 2836
		public static int createplayer_cpmorphcomposite_cheekstyle_style_lsx = -1;

		// Token: 0x04000B15 RID: 2837
		public static int createplayer_cpmorhpcomposite_chin_deatil_rsy = -1;

		// Token: 0x04000B16 RID: 2838
		public static int createplayer_cpattributename_hair_style = -1;

		// Token: 0x04000B17 RID: 2839
		public static int createplayer_create_originalplayerid = -1;

		// Token: 0x04000B18 RID: 2840
		public static int createplayer_create_playerid = -1;

		// Token: 0x04000B19 RID: 2841
		public static int createplayer_cpattributename_hair_colour = -1;

		// Token: 0x04000B1A RID: 2842
		public static int createplayer_celebrationid = -1;

		// Token: 0x04000B1B RID: 2843
		public static int createplayer_cpattributename_brow_style = -1;

		// Token: 0x04000B1C RID: 2844
		public static int createplayer_cpattributename_eye_colour = -1;

		// Token: 0x04000B1D RID: 2845
		public static int createplayer_create_artificialkey = -1;

		// Token: 0x04000B1E RID: 2846
		public static int createplayer_commentaryid = -1;

		// Token: 0x04000B1F RID: 2847
		public static int createplayer_cpattributename_facial_hair_style = -1;

		// Token: 0x04000B20 RID: 2848
		public static int createplayer_cpattributename_brow_colour = -1;

		// Token: 0x04000B21 RID: 2849
		public static int createplayer_cpattributename_facial_hair_colour = -1;

		// Token: 0x04000B22 RID: 2850
		public static int commentarynames_commentarystring = -1;

		// Token: 0x04000B23 RID: 2851
		public static int commentarynames_commentaryid = -1;

		// Token: 0x04000B24 RID: 2852
		public static int commentarynames_commentarystartingletter = -1;

		// Token: 0x04000B25 RID: 2853
		public static int commentarynames_commentarypreview = -1;

		// Token: 0x04000B26 RID: 2854
		public static int cz_assets_crestid = -1;

		// Token: 0x04000B27 RID: 2855
		public static int cz_assets_dbid = -1;

		// Token: 0x04000B28 RID: 2856
		public static int cz_assets_publishdate = -1;

		// Token: 0x04000B29 RID: 2857
		public static int cz_assets_rating = -1;

		// Token: 0x04000B2A RID: 2858
		public static int cz_assets_kitid = -1;

		// Token: 0x04000B2B RID: 2859
		public static int cz_assets_xms_media_id = -1;

		// Token: 0x04000B2C RID: 2860
		public static int cz_assets_type = -1;

		// Token: 0x04000B2D RID: 2861
		public static int cz_assets_author = -1;

		// Token: 0x04000B2E RID: 2862
		public static int cz_assets_assetname = -1;

		// Token: 0x04000B2F RID: 2863
		public static int cz_assets_assetyear = -1;

		// Token: 0x04000B30 RID: 2864
		public static int cz_assets_playerposition = -1;

		// Token: 0x04000B31 RID: 2865
		public static int cz_assets_version = -1;

		// Token: 0x04000B32 RID: 2866
		public static int cz_teams_hascrestimage = -1;

		// Token: 0x04000B33 RID: 2867
		public static int cz_teams_hassponsorimage = -1;

		// Token: 0x04000B34 RID: 2868
		public static int cz_teams_teamabbrev3 = -1;

		// Token: 0x04000B35 RID: 2869
		public static int cz_teams_teamid = -1;

		// Token: 0x04000B36 RID: 2870
		public static int cz_teams_commentaryid = -1;

		// Token: 0x04000B37 RID: 2871
		public static int cz_teamkits_hotspotjerseyfrontsponsorr = -1;

		// Token: 0x04000B38 RID: 2872
		public static int cz_teamkits_hotspotjerseyfrontsponsorb = -1;

		// Token: 0x04000B39 RID: 2873
		public static int cz_teamkits_hotspotjerseyfrontsponsorl = -1;

		// Token: 0x04000B3A RID: 2874
		public static int cz_teamkits_assetid = -1;

		// Token: 0x04000B3B RID: 2875
		public static int cz_teamkits_hotspotjerseyfrontsponsort = -1;

		// Token: 0x04000B3C RID: 2876
		public static int cz_teamkits_sockscolortertr = -1;

		// Token: 0x04000B3D RID: 2877
		public static int cz_teamkits_jerseycolorprimg = -1;

		// Token: 0x04000B3E RID: 2878
		public static int cz_teamkits_jerseycolortertg = -1;

		// Token: 0x04000B3F RID: 2879
		public static int cz_teamkits_sponsorcolourg = -1;

		// Token: 0x04000B40 RID: 2880
		public static int cz_teamkits_sockscolorsecb = -1;

		// Token: 0x04000B41 RID: 2881
		public static int cz_teamkits_sponsorcolourr = -1;

		// Token: 0x04000B42 RID: 2882
		public static int cz_teamkits_sockscolortertg = -1;

		// Token: 0x04000B43 RID: 2883
		public static int cz_teamkits_shortcolorsecb = -1;

		// Token: 0x04000B44 RID: 2884
		public static int cz_teamkits_shortcolortertg = -1;

		// Token: 0x04000B45 RID: 2885
		public static int cz_teamkits_numberfonttype = -1;

		// Token: 0x04000B46 RID: 2886
		public static int cz_teamkits_shortcolorprimb = -1;

		// Token: 0x04000B47 RID: 2887
		public static int cz_teamkits_jerseycolorsecr = -1;

		// Token: 0x04000B48 RID: 2888
		public static int cz_teamkits_jerseynamefonttype = -1;

		// Token: 0x04000B49 RID: 2889
		public static int cz_teamkits_jerseynamelayouttype = -1;

		// Token: 0x04000B4A RID: 2890
		public static int cz_teamkits_jerseycolortertb = -1;

		// Token: 0x04000B4B RID: 2891
		public static int cz_teamkits_shortsnumbercolor = -1;

		// Token: 0x04000B4C RID: 2892
		public static int cz_teamkits_jerseyshapestyle = -1;

		// Token: 0x04000B4D RID: 2893
		public static int cz_teamkits_shortcolortertr = -1;

		// Token: 0x04000B4E RID: 2894
		public static int cz_teamkits_shortcolorsecr = -1;

		// Token: 0x04000B4F RID: 2895
		public static int cz_teamkits_jerseynamecolorg = -1;

		// Token: 0x04000B50 RID: 2896
		public static int cz_teamkits_jerseycolorprimr = -1;

		// Token: 0x04000B51 RID: 2897
		public static int cz_teamkits_sponsorcolourb = -1;

		// Token: 0x04000B52 RID: 2898
		public static int cz_teamkits_sockscolorsecg = -1;

		// Token: 0x04000B53 RID: 2899
		public static int cz_teamkits_jerseycolorsecb = -1;

		// Token: 0x04000B54 RID: 2900
		public static int cz_teamkits_sockscolorprimg = -1;

		// Token: 0x04000B55 RID: 2901
		public static int cz_teamkits_shortcolorprimr = -1;

		// Token: 0x04000B56 RID: 2902
		public static int cz_teamkits_jerseycolortertr = -1;

		// Token: 0x04000B57 RID: 2903
		public static int cz_teamkits_shortcolorsecg = -1;

		// Token: 0x04000B58 RID: 2904
		public static int cz_teamkits_jerseycolorprimb = -1;

		// Token: 0x04000B59 RID: 2905
		public static int cz_teamkits_sockscolorprimr = -1;

		// Token: 0x04000B5A RID: 2906
		public static int cz_teamkits_sockscolorsecr = -1;

		// Token: 0x04000B5B RID: 2907
		public static int cz_teamkits_shortcolortertb = -1;

		// Token: 0x04000B5C RID: 2908
		public static int cz_teamkits_jerseynamecolorr = -1;

		// Token: 0x04000B5D RID: 2909
		public static int cz_teamkits_numbercolor = -1;

		// Token: 0x04000B5E RID: 2910
		public static int cz_teamkits_sockscolorprimb = -1;

		// Token: 0x04000B5F RID: 2911
		public static int cz_teamkits_jerseycolorsecg = -1;

		// Token: 0x04000B60 RID: 2912
		public static int cz_teamkits_shortsnumberfonttype = -1;

		// Token: 0x04000B61 RID: 2913
		public static int cz_teamkits_jerseynamecolorb = -1;

		// Token: 0x04000B62 RID: 2914
		public static int cz_teamkits_shortcolorprimg = -1;

		// Token: 0x04000B63 RID: 2915
		public static int cz_teamkits_sockscolortertb = -1;

		// Token: 0x04000B64 RID: 2916
		public static int cz_teamkits_jerseybacknamefontcase = -1;

		// Token: 0x04000B65 RID: 2917
		public static int cz_teamkits_hassponsor = -1;

		// Token: 0x04000B66 RID: 2918
		public static int cz_teamkits_jerseybacknameplacementcode = -1;

		// Token: 0x04000B67 RID: 2919
		public static int cz_teamkits_artificialkey = -1;

		// Token: 0x04000B68 RID: 2920
		public static int cz_teamkits_teamid = -1;

		// Token: 0x04000B69 RID: 2921
		public static int cz_teamkits_kitid = -1;

		// Token: 0x04000B6A RID: 2922
		public static int cz_teamkits_kittypeid = -1;

		// Token: 0x04000B6B RID: 2923
		public static int cz_players_assetid = -1;

		// Token: 0x04000B6C RID: 2924
		public static int cz_players_commentaryid = -1;

		// Token: 0x04000B6D RID: 2925
		public static int cz_players_playerid = -1;

		// Token: 0x04000B6E RID: 2926
		public static int cz_leagues_overlaybgcolour3r = -1;

		// Token: 0x04000B6F RID: 2927
		public static int cz_leagues_tournamentballid = -1;

		// Token: 0x04000B70 RID: 2928
		public static int cz_leagues_overlaytextcolour3r = -1;

		// Token: 0x04000B71 RID: 2929
		public static int cz_leagues_overlaytextcolour1g = -1;

		// Token: 0x04000B72 RID: 2930
		public static int cz_leagues_overlaytextcolour3b = -1;

		// Token: 0x04000B73 RID: 2931
		public static int cz_leagues_overlaybgcolour1g = -1;

		// Token: 0x04000B74 RID: 2932
		public static int cz_leagues_championcupslotallotment = -1;

		// Token: 0x04000B75 RID: 2933
		public static int cz_leagues_overlaybgcolour3b = -1;

		// Token: 0x04000B76 RID: 2934
		public static int cz_leagues_finalstadiumid = -1;

		// Token: 0x04000B77 RID: 2935
		public static int cz_leagues_overlaytextcolour2b = -1;

		// Token: 0x04000B78 RID: 2936
		public static int cz_leagues_overlaybgcolour1r = -1;

		// Token: 0x04000B79 RID: 2937
		public static int cz_leagues_overlaybgcolour2b = -1;

		// Token: 0x04000B7A RID: 2938
		public static int cz_leagues_overlaytextcolour1r = -1;

		// Token: 0x04000B7B RID: 2939
		public static int cz_leagues_overlaytextcolour3g = -1;

		// Token: 0x04000B7C RID: 2940
		public static int cz_leagues_overlaytextcolour1b = -1;

		// Token: 0x04000B7D RID: 2941
		public static int cz_leagues_overlaybgcolour3g = -1;

		// Token: 0x04000B7E RID: 2942
		public static int cz_leagues_overlaybgcolour1b = -1;

		// Token: 0x04000B7F RID: 2943
		public static int cz_leagues_overlaybgcolour2r = -1;

		// Token: 0x04000B80 RID: 2944
		public static int cz_leagues_overlaytextcolour2g = -1;

		// Token: 0x04000B81 RID: 2945
		public static int cz_leagues_eurocupslotallotment = -1;

		// Token: 0x04000B82 RID: 2946
		public static int cz_leagues_overlaytextcolour2r = -1;

		// Token: 0x04000B83 RID: 2947
		public static int cz_leagues_overlaybgcolour2g = -1;

		// Token: 0x04000B84 RID: 2948
		public static int cz_leagues_leaguedescription = -1;

		// Token: 0x04000B85 RID: 2949
		public static int cz_leagues_leaguetype = -1;

		// Token: 0x04000B86 RID: 2950
		public static int cz_leagues_numteams = -1;

		// Token: 0x04000B87 RID: 2951
		public static int cz_leagues_trophyid = -1;

		// Token: 0x04000B88 RID: 2952
		public static int cz_leagues_teamadvancingpergroup = -1;

		// Token: 0x04000B89 RID: 2953
		public static int cz_leagues_leagueid = -1;

		// Token: 0x04000B8A RID: 2954
		public static int cz_leagues_fixturevsgroup = -1;

		// Token: 0x04000B8B RID: 2955
		public static int cz_leagues_teampergroup = -1;

		// Token: 0x04000B8C RID: 2956
		public static int cz_leagues_finalmatchlegs = -1;

		// Token: 0x04000B8D RID: 2957
		public static int cz_leagues_fixturevseachteam = -1;

		// Token: 0x04000B8E RID: 2958
		public static int cz_leagues_subonbench = -1;

		// Token: 0x04000B8F RID: 2959
		public static int dlcballs_name = -1;

		// Token: 0x04000B90 RID: 2960
		public static int dlcballs_assetid = -1;

		// Token: 0x04000B91 RID: 2961
		public static int teamstadiumlinkscache_stadiumid = -1;

		// Token: 0x04000B92 RID: 2962
		public static int teamstadiumlinkscache_teamid = -1;

		// Token: 0x04000B93 RID: 2963
		public static int dlcboots_name = -1;

		// Token: 0x04000B94 RID: 2964
		public static int dlcboots_assetid = -1;

		// Token: 0x04000B95 RID: 2965
		public static int eatrax_album = -1;

		// Token: 0x04000B96 RID: 2966
		public static int eatrax_songname = -1;

		// Token: 0x04000B97 RID: 2967
		public static int eatrax_artist = -1;

		// Token: 0x04000B98 RID: 2968
		public static int eatrax_songid = -1;

		// Token: 0x04000B99 RID: 2969
		public static int eatrax_intro = -1;

		// Token: 0x04000B9A RID: 2970
		public static int songplaylistlinks_songid = -1;

		// Token: 0x04000B9B RID: 2971
		public static int songplaylistlinks_playlistid = -1;

		// Token: 0x04000B9C RID: 2972
		public static int songplaylistlinks_unlocked = -1;

		// Token: 0x04000B9D RID: 2973
		public static int songplaylistlinks_artificialkey = -1;

		// Token: 0x04000B9E RID: 2974
		public static int celebrations_celebrationid = -1;

		// Token: 0x04000B9F RID: 2975
		public static int videos_countrycode = -1;

		// Token: 0x04000BA0 RID: 2976
		public static int videos_languagecode = -1;

		// Token: 0x04000BA1 RID: 2977
		public static int videos_videoid = -1;

		// Token: 0x04000BA2 RID: 2978
		public static int videos_artificialkey = -1;

		// Token: 0x04000BA3 RID: 2979
		public static int fce_activeteams_teamid = -1;

		// Token: 0x04000BA4 RID: 2980
		public static int fce_activeteams_userid = -1;

		// Token: 0x04000BA5 RID: 2981
		public static int fce_weathersettings_weatherid = -1;

		// Token: 0x04000BA6 RID: 2982
		public static int fce_weathersettings_rainpct = -1;

		// Token: 0x04000BA7 RID: 2983
		public static int fce_weathersettings_snowpct = -1;

		// Token: 0x04000BA8 RID: 2984
		public static int fce_weathersettings_clearpct = -1;

		// Token: 0x04000BA9 RID: 2985
		public static int fce_weathersettings_quarter = -1;

		// Token: 0x04000BAA RID: 2986
		public static int fce_weathersettings_compid = -1;

		// Token: 0x04000BAB RID: 2987
		public static int fce_weathersettings_inuse = -1;

		// Token: 0x04000BAC RID: 2988
		public static int fce_statistics_goals = -1;

		// Token: 0x04000BAD RID: 2989
		public static int fce_statistics_saves = -1;

		// Token: 0x04000BAE RID: 2990
		public static int fce_statistics_shots = -1;

		// Token: 0x04000BAF RID: 2991
		public static int fce_statistics_goalsconceded = -1;

		// Token: 0x04000BB0 RID: 2992
		public static int fce_statistics_totalreds = -1;

		// Token: 0x04000BB1 RID: 2993
		public static int fce_statistics_manofmatch = -1;

		// Token: 0x04000BB2 RID: 2994
		public static int fce_statistics_minutes = -1;

		// Token: 0x04000BB3 RID: 2995
		public static int fce_statistics_appearances = -1;

		// Token: 0x04000BB4 RID: 2996
		public static int fce_statistics_compid = -1;

		// Token: 0x04000BB5 RID: 2997
		public static int fce_statistics_assists = -1;

		// Token: 0x04000BB6 RID: 2998
		public static int fce_statistics_matchratings = -1;

		// Token: 0x04000BB7 RID: 2999
		public static int fce_statistics_cleansheets = -1;

		// Token: 0x04000BB8 RID: 3000
		public static int fce_statistics_teamid = -1;

		// Token: 0x04000BB9 RID: 3001
		public static int fce_statistics_totalyellows = -1;

		// Token: 0x04000BBA RID: 3002
		public static int fce_statistics_statisticsid = -1;

		// Token: 0x04000BBB RID: 3003
		public static int fce_statistics_playerid = -1;

		// Token: 0x04000BBC RID: 3004
		public static int fce_statistics_inuse = -1;

		// Token: 0x04000BBD RID: 3005
		public static int fce_standings_homegoalsfor = -1;

		// Token: 0x04000BBE RID: 3006
		public static int fce_standings_teamindex = -1;

		// Token: 0x04000BBF RID: 3007
		public static int fce_standings_standingsid = -1;

		// Token: 0x04000BC0 RID: 3008
		public static int fce_standings_homegoalsagainst = -1;

		// Token: 0x04000BC1 RID: 3009
		public static int fce_standings_compid = -1;

		// Token: 0x04000BC2 RID: 3010
		public static int fce_standings_homewins = -1;

		// Token: 0x04000BC3 RID: 3011
		public static int fce_standings_teamid = -1;

		// Token: 0x04000BC4 RID: 3012
		public static int fce_standings_awaywins = -1;

		// Token: 0x04000BC5 RID: 3013
		public static int fce_standings_points = -1;

		// Token: 0x04000BC6 RID: 3014
		public static int fce_standings_awaygoalsfor = -1;

		// Token: 0x04000BC7 RID: 3015
		public static int fce_standings_homelosses = -1;

		// Token: 0x04000BC8 RID: 3016
		public static int fce_standings_awaygoalsagainst = -1;

		// Token: 0x04000BC9 RID: 3017
		public static int fce_standings_awaylosses = -1;

		// Token: 0x04000BCA RID: 3018
		public static int fce_standings_awaydraws = -1;

		// Token: 0x04000BCB RID: 3019
		public static int fce_standings_inuse = -1;

		// Token: 0x04000BCC RID: 3020
		public static int fce_standings_homedraws = -1;

		// Token: 0x04000BCD RID: 3021
		public static int fce_stageadvance_actiondate = -1;

		// Token: 0x04000BCE RID: 3022
		public static int fce_stageadvance_active = -1;

		// Token: 0x04000BCF RID: 3023
		public static int fce_stageadvance_stageindex = -1;

		// Token: 0x04000BD0 RID: 3024
		public static int fce_stageadvance_randomnumber = -1;

		// Token: 0x04000BD1 RID: 3025
		public static int fce_stageadvance_compid = -1;

		// Token: 0x04000BD2 RID: 3026
		public static int fce_stageadvance_inuse = -1;

		// Token: 0x04000BD3 RID: 3027
		public static int fce_stageadvance_stageadvanceid = -1;

		// Token: 0x04000BD4 RID: 3028
		public static int fce_settings_settingvalue = -1;

		// Token: 0x04000BD5 RID: 3029
		public static int fce_settings_settingenumid = -1;

		// Token: 0x04000BD6 RID: 3030
		public static int fce_settings_settingid = -1;

		// Token: 0x04000BD7 RID: 3031
		public static int fce_settings_compid = -1;

		// Token: 0x04000BD8 RID: 3032
		public static int fce_settings_inuse = -1;

		// Token: 0x04000BD9 RID: 3033
		public static int fce_scriptfunctions_scriptfuncid = -1;

		// Token: 0x04000BDA RID: 3034
		public static int fce_scriptfunctions_funcparam1 = -1;

		// Token: 0x04000BDB RID: 3035
		public static int fce_scriptfunctions_compid = -1;

		// Token: 0x04000BDC RID: 3036
		public static int fce_scriptfunctions_funcparam2 = -1;

		// Token: 0x04000BDD RID: 3037
		public static int fce_scriptfunctions_targetcompid = -1;

		// Token: 0x04000BDE RID: 3038
		public static int fce_scriptfunctions_funcparam3 = -1;

		// Token: 0x04000BDF RID: 3039
		public static int fce_scriptfunctions_inuse = -1;

		// Token: 0x04000BE0 RID: 3040
		public static int fce_scriptfunctions_functype = -1;

		// Token: 0x04000BE1 RID: 3041
		public static int fce_scheduleinfo_time = -1;

		// Token: 0x04000BE2 RID: 3042
		public static int fce_scheduleinfo_dayofweek = -1;

		// Token: 0x04000BE3 RID: 3043
		public static int fce_scheduleinfo_compid = -1;

		// Token: 0x04000BE4 RID: 3044
		public static int fce_scheduleinfo_chance = -1;

		// Token: 0x04000BE5 RID: 3045
		public static int fce_scheduleinfo_priority = -1;

		// Token: 0x04000BE6 RID: 3046
		public static int fce_scheduleinfo_inuse = -1;

		// Token: 0x04000BE7 RID: 3047
		public static int fce_scheduleinfo_scheduleinfoid = -1;

		// Token: 0x04000BE8 RID: 3048
		public static int fce_fixtures_time = -1;

		// Token: 0x04000BE9 RID: 3049
		public static int fce_fixtures_homescore = -1;

		// Token: 0x04000BEA RID: 3050
		public static int fce_fixtures_awayscore = -1;

		// Token: 0x04000BEB RID: 3051
		public static int fce_fixtures_gamecompletion = -1;

		// Token: 0x04000BEC RID: 3052
		public static int fce_fixtures_compid = -1;

		// Token: 0x04000BED RID: 3053
		public static int fce_fixtures_date = -1;

		// Token: 0x04000BEE RID: 3054
		public static int fce_fixtures_fixtureid = -1;

		// Token: 0x04000BEF RID: 3055
		public static int fce_fixtures_awaystandingid = -1;

		// Token: 0x04000BF0 RID: 3056
		public static int fce_fixtures_homestandingid = -1;

		// Token: 0x04000BF1 RID: 3057
		public static int fce_fixtures_awaypens = -1;

		// Token: 0x04000BF2 RID: 3058
		public static int fce_fixtures_homepens = -1;

		// Token: 0x04000BF3 RID: 3059
		public static int fce_fixtures_inuse = -1;

		// Token: 0x04000BF4 RID: 3060
		public static int fce_competitionteams_teamindex = -1;

		// Token: 0x04000BF5 RID: 3061
		public static int fce_competitionteams_compteamid = -1;

		// Token: 0x04000BF6 RID: 3062
		public static int fce_competitionteams_compid = -1;

		// Token: 0x04000BF7 RID: 3063
		public static int fce_competitionteams_teamid = -1;

		// Token: 0x04000BF8 RID: 3064
		public static int fce_competitionteams_inuse = -1;

		// Token: 0x04000BF9 RID: 3065
		public static int fce_competitioninfo_compobjshortdesc = -1;

		// Token: 0x04000BFA RID: 3066
		public static int fce_competitioninfo_compobjdesc = -1;

		// Token: 0x04000BFB RID: 3067
		public static int fce_competitioninfo_compparentid = -1;

		// Token: 0x04000BFC RID: 3068
		public static int fce_competitioninfo_comptype = -1;

		// Token: 0x04000BFD RID: 3069
		public static int fce_competitioninfo_compid = -1;

		// Token: 0x04000BFE RID: 3070
		public static int fce_competitioninfo_inuse = -1;

		// Token: 0x04000BFF RID: 3071
		public static int fce_compavgs_mid = -1;

		// Token: 0x04000C00 RID: 3072
		public static int fce_compavgs_ovr = -1;

		// Token: 0x04000C01 RID: 3073
		public static int fce_compavgs_def = -1;

		// Token: 0x04000C02 RID: 3074
		public static int fce_compavgs_compid = -1;

		// Token: 0x04000C03 RID: 3075
		public static int fce_compavgs_gk = -1;

		// Token: 0x04000C04 RID: 3076
		public static int fce_compavgs_att = -1;

		// Token: 0x04000C05 RID: 3077
		public static int fce_advancement_fromcompid = -1;

		// Token: 0x04000C06 RID: 3078
		public static int fce_advancement_fromteamindex = -1;

		// Token: 0x04000C07 RID: 3079
		public static int fce_advancement_tocompid = -1;

		// Token: 0x04000C08 RID: 3080
		public static int fce_advancement_advancementid = -1;

		// Token: 0x04000C09 RID: 3081
		public static int fce_advancement_toteamindex = -1;

		// Token: 0x04000C0A RID: 3082
		public static int fce_advancement_inuse = -1;

		// Token: 0x04000C0B RID: 3083
		public static int fifaGameSettings_IonCameraZPosition = -1;

		// Token: 0x04000C0C RID: 3084
		public static int fifaGameSettings_GcAccelerationUser = -1;

		// Token: 0x04000C0D RID: 3085
		public static int fifaGameSettings_CamOTP = -1;

		// Token: 0x04000C0E RID: 3086
		public static int fifaGameSettings_FirstBoot = -1;

		// Token: 0x04000C0F RID: 3087
		public static int fifaGameSettings_GcSprintSpeedCpu = -1;

		// Token: 0x04000C10 RID: 3088
		public static int fifaGameSettings_GcGkAbilityUser = -1;

		// Token: 0x04000C11 RID: 3089
		public static int fifaGameSettings_GcShotErrorCpu = -1;

		// Token: 0x04000C12 RID: 3090
		public static int fifaGameSettings_KinCustomMentalityCmd = -1;

		// Token: 0x04000C13 RID: 3091
		public static int fifaGameSettings_GcPosLineWidthCpu = -1;

		// Token: 0x04000C14 RID: 3092
		public static int fifaGameSettings_GoalNews = -1;

		// Token: 0x04000C15 RID: 3093
		public static int fifaGameSettings_Penalties = -1;

		// Token: 0x04000C16 RID: 3094
		public static int fifaGameSettings_GcPassErrorUser = -1;

		// Token: 0x04000C17 RID: 3095
		public static int fifaGameSettings_GenericSetting0 = -1;

		// Token: 0x04000C18 RID: 3096
		public static int fifaGameSettings_Camera = -1;

		// Token: 0x04000C19 RID: 3097
		public static int fifaGameSettings_PAVolume = -1;

		// Token: 0x04000C1A RID: 3098
		public static int fifaGameSettings_Vibration = -1;

		// Token: 0x04000C1B RID: 3099
		public static int fifaGameSettings_KinCustomFormation = -1;

		// Token: 0x04000C1C RID: 3100
		public static int fifaGameSettings_SubsOnBench = -1;

		// Token: 0x04000C1D RID: 3101
		public static int fifaGameSettings_CamHeight = -1;

		// Token: 0x04000C1E RID: 3102
		public static int fifaGameSettings_DifficultyLevel = -1;

		// Token: 0x04000C1F RID: 3103
		public static int fifaGameSettings_PitchWear = -1;

		// Token: 0x04000C20 RID: 3104
		public static int fifaGameSettings_KinCustomFormationCmd = -1;

		// Token: 0x04000C21 RID: 3105
		public static int fifaGameSettings_MowPattern = -1;

		// Token: 0x04000C22 RID: 3106
		public static int fifaGameSettings_GcPosDefensiveLineHeightCpu = -1;

		// Token: 0x04000C23 RID: 3107
		public static int fifaGameSettings_Ball = -1;

		// Token: 0x04000C24 RID: 3108
		public static int fifaGameSettings_Handball = -1;

		// Token: 0x04000C25 RID: 3109
		public static int fifaGameSettings_GameSettingsContext = -1;

		// Token: 0x04000C26 RID: 3110
		public static int fifaGameSettings_GcTrapErrorUser = -1;

		// Token: 0x04000C27 RID: 3111
		public static int fifaGameSettings_GcPosRunFrequencyCpu = -1;

		// Token: 0x04000C28 RID: 3112
		public static int fifaGameSettings_KinCustomMentality = -1;

		// Token: 0x04000C29 RID: 3113
		public static int fifaGameSettings_Season = -1;

		// Token: 0x04000C2A RID: 3114
		public static int fifaGameSettings_MM_DifficultyLevel = -1;

		// Token: 0x04000C2B RID: 3115
		public static int fifaGameSettings_FIWC_Ball = -1;

		// Token: 0x04000C2C RID: 3116
		public static int fifaGameSettings_UserMusicVolume = -1;

		// Token: 0x04000C2D RID: 3117
		public static int fifaGameSettings_PerformanceBar = -1;

		// Token: 0x04000C2E RID: 3118
		public static int fifaGameSettings_MusicVolume = -1;

		// Token: 0x04000C2F RID: 3119
		public static int fifaGameSettings_GcPosFullbackPositioningUser = -1;

		// Token: 0x04000C30 RID: 3120
		public static int fifaGameSettings_KinFormation5 = -1;

		// Token: 0x04000C31 RID: 3121
		public static int fifaGameSettings_GcPosLineLengthCpu = -1;

		// Token: 0x04000C32 RID: 3122
		public static int fifaGameSettings_GcPassSpeedCpu = -1;

		// Token: 0x04000C33 RID: 3123
		public static int fifaGameSettings_KinCustomFutFormation = -1;

		// Token: 0x04000C34 RID: 3124
		public static int fifaGameSettings_GcInjurySeverityUser = -1;

		// Token: 0x04000C35 RID: 3125
		public static int fifaGameSettings_KinFutFormation2 = -1;

		// Token: 0x04000C36 RID: 3126
		public static int fifaGameSettings_KinFormation2 = -1;

		// Token: 0x04000C37 RID: 3127
		public static int fifaGameSettings_GcTrapErrorCpu = -1;

		// Token: 0x04000C38 RID: 3128
		public static int fifaGameSettings_KinFutFormation1 = -1;

		// Token: 0x04000C39 RID: 3129
		public static int fifaGameSettings_GcShotSpeedUser = -1;

		// Token: 0x04000C3A RID: 3130
		public static int fifaGameSettings_GcInjuryFrequencyUser = -1;

		// Token: 0x04000C3B RID: 3131
		public static int fifaGameSettings_StartUpTutorial = -1;

		// Token: 0x04000C3C RID: 3132
		public static int fifaGameSettings_MovDifficultyLevel = -1;

		// Token: 0x04000C3D RID: 3133
		public static int fifaGameSettings_GcPowerBarUser = -1;

		// Token: 0x04000C3E RID: 3134
		public static int fifaGameSettings_KinComboCommand = -1;

		// Token: 0x04000C3F RID: 3135
		public static int fifaGameSettings_KinCustomTacticCmd = -1;

		// Token: 0x04000C40 RID: 3136
		public static int fifaGameSettings_GcSprintSpeedUser = -1;

		// Token: 0x04000C41 RID: 3137
		public static int fifaGameSettings_KinComboFormation = -1;

		// Token: 0x04000C42 RID: 3138
		public static int fifaGameSettings_GcShotSpeedCpu = -1;

		// Token: 0x04000C43 RID: 3139
		public static int fifaGameSettings_NetShape = -1;

		// Token: 0x04000C44 RID: 3140
		public static int fifaGameSettings_UgcAllowed = -1;

		// Token: 0x04000C45 RID: 3141
		public static int fifaGameSettings_Contrast = -1;

		// Token: 0x04000C46 RID: 3142
		public static int fifaGameSettings_TimeScoreDisplay = -1;

		// Token: 0x04000C47 RID: 3143
		public static int fifaGameSettings_GcPassErrorCpu = -1;

		// Token: 0x04000C48 RID: 3144
		public static int fifaGameSettings_RadarOrientation = -1;

		// Token: 0x04000C49 RID: 3145
		public static int fifaGameSettings_KinComboFutFormation = -1;

		// Token: 0x04000C4A RID: 3146
		public static int fifaGameSettings_IPI = -1;

		// Token: 0x04000C4B RID: 3147
		public static int fifaGameSettings_CommentaryVolume = -1;

		// Token: 0x04000C4C RID: 3148
		public static int fifaGameSettings_FavoriteTeam = -1;

		// Token: 0x04000C4D RID: 3149
		public static int fifaGameSettings_MenuMusicVolume = -1;

		// Token: 0x04000C4E RID: 3150
		public static int fifaGameSettings_GcGkAbilityCpu = -1;

		// Token: 0x04000C4F RID: 3151
		public static int fifaGameSettings_KinFormation4 = -1;

		// Token: 0x04000C50 RID: 3152
		public static int fifaGameSettings_Offsides = -1;

		// Token: 0x04000C51 RID: 3153
		public static int fifaGameSettings_CamProSpeed = -1;

		// Token: 0x04000C52 RID: 3154
		public static int fifaGameSettings_GameSettingsPK = -1;

		// Token: 0x04000C53 RID: 3155
		public static int fifaGameSettings_HalfLength = -1;

		// Token: 0x04000C54 RID: 3156
		public static int fifaGameSettings_KinFutFormation5 = -1;

		// Token: 0x04000C55 RID: 3157
		public static int fifaGameSettings_CommentaryTeam = -1;

		// Token: 0x04000C56 RID: 3158
		public static int fifaGameSettings_GcPosFullbackPositioningCpu = -1;

		// Token: 0x04000C57 RID: 3159
		public static int fifaGameSettings_PosIndicator = -1;

		// Token: 0x04000C58 RID: 3160
		public static int fifaGameSettings_CamSingle = -1;

		// Token: 0x04000C59 RID: 3161
		public static int fifaGameSettings_NumOfSubs = -1;

		// Token: 0x04000C5A RID: 3162
		public static int fifaGameSettings_GcPassSpeedUser = -1;

		// Token: 0x04000C5B RID: 3163
		public static int fifaGameSettings_CamBeAPro = -1;

		// Token: 0x04000C5C RID: 3164
		public static int fifaGameSettings_BallTrailIndicator = -1;

		// Token: 0x04000C5D RID: 3165
		public static int fifaGameSettings_CamProSwing = -1;

		// Token: 0x04000C5E RID: 3166
		public static int fifaGameSettings_NetTension = -1;

		// Token: 0x04000C5F RID: 3167
		public static int fifaGameSettings_UserChantsVolume = -1;

		// Token: 0x04000C60 RID: 3168
		public static int fifaGameSettings_CrowdVolume = -1;

		// Token: 0x04000C61 RID: 3169
		public static int fifaGameSettings_DynamicTimeOfDay = -1;

		// Token: 0x04000C62 RID: 3170
		public static int fifaGameSettings_CamProZoom = -1;

		// Token: 0x04000C63 RID: 3171
		public static int fifaGameSettings_AutoSave = -1;

		// Token: 0x04000C64 RID: 3172
		public static int fifaGameSettings_KinFormation3 = -1;

		// Token: 0x04000C65 RID: 3173
		public static int fifaGameSettings_KinFutFormation3 = -1;

		// Token: 0x04000C66 RID: 3174
		public static int fifaGameSettings_GcInjuryFrequencyCpu = -1;

		// Token: 0x04000C67 RID: 3175
		public static int fifaGameSettings_NIB = -1;

		// Token: 0x04000C68 RID: 3176
		public static int fifaGameSettings_GcPosDefensiveLineHeightUser = -1;

		// Token: 0x04000C69 RID: 3177
		public static int fifaGameSettings_ThreatIndicator = -1;

		// Token: 0x04000C6A RID: 3178
		public static int fifaGameSettings_PlayerCalls = -1;

		// Token: 0x04000C6B RID: 3179
		public static int fifaGameSettings_Injuries = -1;

		// Token: 0x04000C6C RID: 3180
		public static int fifaGameSettings_CamZoomHeightEnable = -1;

		// Token: 0x04000C6D RID: 3181
		public static int fifaGameSettings_StadiumNameInfo = -1;

		// Token: 0x04000C6E RID: 3182
		public static int fifaGameSettings_KinFutFormation4 = -1;

		// Token: 0x04000C6F RID: 3183
		public static int fifaGameSettings_CamZoom = -1;

		// Token: 0x04000C70 RID: 3184
		public static int fifaGameSettings_CamMulti = -1;

		// Token: 0x04000C71 RID: 3185
		public static int fifaGameSettings_KinRefereeHearing = -1;

		// Token: 0x04000C72 RID: 3186
		public static int fifaGameSettings_AwayAutoSwitch = -1;

		// Token: 0x04000C73 RID: 3187
		public static int fifaGameSettings_AudioSetup = -1;

		// Token: 0x04000C74 RID: 3188
		public static int fifaGameSettings_Weather = -1;

		// Token: 0x04000C75 RID: 3189
		public static int fifaGameSettings_GcInjurySeverityCpu = -1;

		// Token: 0x04000C76 RID: 3190
		public static int fifaGameSettings_Avatar = -1;

		// Token: 0x04000C77 RID: 3191
		public static int fifaGameSettings_Referee_ID = -1;

		// Token: 0x04000C78 RID: 3192
		public static int fifaGameSettings_Radar = -1;

		// Token: 0x04000C79 RID: 3193
		public static int fifaGameSettings_HomeAutoSwitch = -1;

		// Token: 0x04000C7A RID: 3194
		public static int fifaGameSettings_CPUPlayerStatus = -1;

		// Token: 0x04000C7B RID: 3195
		public static int fifaGameSettings_Brightness = -1;

		// Token: 0x04000C7C RID: 3196
		public static int fifaGameSettings_KinFormation1 = -1;

		// Token: 0x04000C7D RID: 3197
		public static int fifaGameSettings_BallFutureTrajectoryIndicator = -1;

		// Token: 0x04000C7E RID: 3198
		public static int fifaGameSettings_GenericSetting2 = -1;

		// Token: 0x04000C7F RID: 3199
		public static int fifaGameSettings_TimeOfDay = -1;

		// Token: 0x04000C80 RID: 3200
		public static int fifaGameSettings_ExtraTime = -1;

		// Token: 0x04000C81 RID: 3201
		public static int fifaGameSettings_lm_LoungeStadium = -1;

		// Token: 0x04000C82 RID: 3202
		public static int fifaGameSettings_KinSpeechRecognition = -1;

		// Token: 0x04000C83 RID: 3203
		public static int fifaGameSettings_KinComboMentality = -1;

		// Token: 0x04000C84 RID: 3204
		public static int fifaGameSettings_NIBState = -1;

		// Token: 0x04000C85 RID: 3205
		public static int fifaGameSettings_Bookings = -1;

		// Token: 0x04000C86 RID: 3206
		public static int fifaGameSettings_GcPosLineLengthUser = -1;

		// Token: 0x04000C87 RID: 3207
		public static int fifaGameSettings_GcPosLineWidthUser = -1;

		// Token: 0x04000C88 RID: 3208
		public static int fifaGameSettings_GenericSetting1 = -1;

		// Token: 0x04000C89 RID: 3209
		public static int fifaGameSettings_GcShotErrorUser = -1;

		// Token: 0x04000C8A RID: 3210
		public static int fifaGameSettings_CommentaryLanguage = -1;

		// Token: 0x04000C8B RID: 3211
		public static int fifaGameSettings_GcAccelerationCpu = -1;

		// Token: 0x04000C8C RID: 3212
		public static int fifaGameSettings_GcPosRunFrequencyUser = -1;

		// Token: 0x04000C8D RID: 3213
		public static int fifaGameSettings_KinCustomTactic = -1;

		// Token: 0x04000C8E RID: 3214
		public static int fifaGameSettings_KinComboTactic = -1;

		// Token: 0x04000C8F RID: 3215
		public static int fifaGameSettings_PlayerStatusBar = -1;

		// Token: 0x04000C90 RID: 3216
		public static int fifaGameSettings_GcPosMarkingUser = -1;

		// Token: 0x04000C91 RID: 3217
		public static int fifaGameSettings_RadarLocation = -1;

		// Token: 0x04000C92 RID: 3218
		public static int fifaGameSettings_OwnOnlineGamerTag = -1;

		// Token: 0x04000C93 RID: 3219
		public static int fifaGameSettings_GameFXVolume = -1;

		// Token: 0x04000C94 RID: 3220
		public static int fifaGameSettings_GcPosMarkingCpu = -1;

		// Token: 0x04000C95 RID: 3221
		public static int fifaGameSettings_CamBeAKeeper = -1;

		// Token: 0x04000C96 RID: 3222
		public static int fifaGameSettings_lm_MatchUpSetting = -1;

		// Token: 0x04000C97 RID: 3223
		public static int fifaGameSettings_GameSpeed = -1;

		// Token: 0x04000C98 RID: 3224
		public static int fifaGameSettings_ShootSwitching = -1;

		// Token: 0x04000C99 RID: 3225
		public static int fifaGameSettings_MovAssistedPathFinding = -1;

		// Token: 0x04000C9A RID: 3226
		public static int mls_fixtures_fixture_id = -1;

		// Token: 0x04000C9B RID: 3227
		public static int mls_fixtures_rtsg = -1;

		// Token: 0x04000C9C RID: 3228
		public static int mls_fixtures_away_id = -1;

		// Token: 0x04000C9D RID: 3229
		public static int mls_fixtures_home_score = -1;

		// Token: 0x04000C9E RID: 3230
		public static int mls_fixtures_date = -1;

		// Token: 0x04000C9F RID: 3231
		public static int mls_fixtures_game_flags = -1;

		// Token: 0x04000CA0 RID: 3232
		public static int mls_fixtures_away_score = -1;

		// Token: 0x04000CA1 RID: 3233
		public static int mls_fixtures_home_id = -1;

		// Token: 0x04000CA2 RID: 3234
		public static int customteamstyles_defmentality = -1;

		// Token: 0x04000CA3 RID: 3235
		public static int customteamstyles_teamstyleid = -1;

		// Token: 0x04000CA4 RID: 3236
		public static int customteamstyles_basestyle = -1;

		// Token: 0x04000CA5 RID: 3237
		public static int customteamstyles_buspassing = -1;

		// Token: 0x04000CA6 RID: 3238
		public static int customteamstyles_defteamwidth = -1;

		// Token: 0x04000CA7 RID: 3239
		public static int customteamstyles_defaggression = -1;

		// Token: 0x04000CA8 RID: 3240
		public static int customteamstyles_buspositioning = -1;

		// Token: 0x04000CA9 RID: 3241
		public static int customteamstyles_ccpositioning = -1;

		// Token: 0x04000CAA RID: 3242
		public static int customteamstyles_busbuildupspeed = -1;

		// Token: 0x04000CAB RID: 3243
		public static int customteamstyles_ccshooting = -1;

		// Token: 0x04000CAC RID: 3244
		public static int customteamstyles_ccpassing = -1;

		// Token: 0x04000CAD RID: 3245
		public static int customteamstyles_defdefenderline = -1;

		// Token: 0x04000CAE RID: 3246
		public static int customteamstyles_cccrossing = -1;

		// Token: 0x04000CAF RID: 3247
		public static int teamformationteamstylelinks_teamstyleid = -1;

		// Token: 0x04000CB0 RID: 3248
		public static int teamformationteamstylelinks_teamid = -1;

		// Token: 0x04000CB1 RID: 3249
		public static int teamformationteamstylelinks_formationid = -1;

		// Token: 0x04000CB2 RID: 3250
		public static int teamformationteamstylelinks_cddl = -1;

		// Token: 0x04000CB3 RID: 3251
		public static int career_news_body = -1;

		// Token: 0x04000CB4 RID: 3252
		public static int career_news_image = -1;

		// Token: 0x04000CB5 RID: 3253
		public static int career_news_title = -1;

		// Token: 0x04000CB6 RID: 3254
		public static int career_news_importance = -1;

		// Token: 0x04000CB7 RID: 3255
		public static int career_news_date = -1;

		// Token: 0x04000CB8 RID: 3256
		public static int career_news_teamid = -1;

		// Token: 0x04000CB9 RID: 3257
		public static int career_news_playerid = -1;

		// Token: 0x04000CBA RID: 3258
		public static int career_news_crest = -1;

		// Token: 0x04000CBB RID: 3259
		public static int career_news_newsid = -1;

		// Token: 0x04000CBC RID: 3260
		public static int career_news_emotion = -1;

		// Token: 0x04000CBD RID: 3261
		public static int career_news_type = -1;

		// Token: 0x04000CBE RID: 3262
		public static int career_newspicweights_maxvariationspos = -1;

		// Token: 0x04000CBF RID: 3263
		public static int career_newspicweights_maxvariationsstd = -1;

		// Token: 0x04000CC0 RID: 3264
		public static int career_newspicweights_maxvariationsneg = -1;

		// Token: 0x04000CC1 RID: 3265
		public static int career_newspicweights_crestweight = -1;

		// Token: 0x04000CC2 RID: 3266
		public static int career_newspicweights_teamweight = -1;

		// Token: 0x04000CC3 RID: 3267
		public static int career_newspicweights_teamid = -1;

		// Token: 0x04000CC4 RID: 3268
		public static int career_newspicweights_genericweight = -1;

		// Token: 0x04000CC5 RID: 3269
		public static int career_newsban_artificialkey = -1;

		// Token: 0x04000CC6 RID: 3270
		public static int career_newsban_newstype = -1;

		// Token: 0x04000CC7 RID: 3271
		public static int career_newsban_compobjid = -1;

		// Token: 0x04000CC8 RID: 3272
		public static int career_newsban_teamid = -1;

		// Token: 0x04000CC9 RID: 3273
		public static int persistent_events_MiscValue = -1;

		// Token: 0x04000CCA RID: 3274
		public static int persistent_events_Team2Id = -1;

		// Token: 0x04000CCB RID: 3275
		public static int persistent_events_Id = -1;

		// Token: 0x04000CCC RID: 3276
		public static int persistent_events_CompObjId = -1;

		// Token: 0x04000CCD RID: 3277
		public static int persistent_events_EventId = -1;

		// Token: 0x04000CCE RID: 3278
		public static int persistent_events_Team1Id = -1;

		// Token: 0x04000CCF RID: 3279
		public static int persistent_events_EventDate = -1;

		// Token: 0x04000CD0 RID: 3280
		public static int persistent_events_Player1Id = -1;

		// Token: 0x04000CD1 RID: 3281
		public static int career_playasplayer_numwithdrawrequests = -1;

		// Token: 0x04000CD2 RID: 3282
		public static int career_playasplayer_numconsecclubbenched = -1;

		// Token: 0x04000CD3 RID: 3283
		public static int career_playasplayer_lastwithdrawdate = -1;

		// Token: 0x04000CD4 RID: 3284
		public static int career_playasplayer_playedlastmatch = -1;

		// Token: 0x04000CD5 RID: 3285
		public static int career_playasplayer_numtransferrequests = -1;

		// Token: 0x04000CD6 RID: 3286
		public static int career_playasplayer_requestactiondays = -1;

		// Token: 0x04000CD7 RID: 3287
		public static int career_playasplayer_position = -1;

		// Token: 0x04000CD8 RID: 3288
		public static int career_playasplayer_playerrequest = -1;

		// Token: 0x04000CD9 RID: 3289
		public static int career_playasplayer_numloanrequests = -1;

		// Token: 0x04000CDA RID: 3290
		public static int career_playasplayer_numconsecnatbenched = -1;

		// Token: 0x04000CDB RID: 3291
		public static int career_playasplayer_playerid = -1;

		// Token: 0x04000CDC RID: 3292
		public static int career_playasplayer_userid = -1;

		// Token: 0x04000CDD RID: 3293
		public static int career_playerbonusper_bonus_per_15 = -1;

		// Token: 0x04000CDE RID: 3294
		public static int career_playerbonusper_clubleveltype = -1;

		// Token: 0x04000CDF RID: 3295
		public static int career_playerbonusper_bonus_per_5 = -1;

		// Token: 0x04000CE0 RID: 3296
		public static int career_playerbonusper_bonus_per_20 = -1;

		// Token: 0x04000CE1 RID: 3297
		public static int career_playerbonusper_bonus_per_0 = -1;

		// Token: 0x04000CE2 RID: 3298
		public static int career_playerbonusper_bonus_per_10 = -1;

		// Token: 0x04000CE3 RID: 3299
		public static int career_playasplayerhistory_goals = -1;

		// Token: 0x04000CE4 RID: 3300
		public static int career_playasplayerhistory_saves = -1;

		// Token: 0x04000CE5 RID: 3301
		public static int career_playasplayerhistory_totaltackles = -1;

		// Token: 0x04000CE6 RID: 3302
		public static int career_playasplayerhistory_tacklesontarget = -1;

		// Token: 0x04000CE7 RID: 3303
		public static int career_playasplayerhistory_totalshots = -1;

		// Token: 0x04000CE8 RID: 3304
		public static int career_playasplayerhistory_totalpasses = -1;

		// Token: 0x04000CE9 RID: 3305
		public static int career_playasplayerhistory_motm = -1;

		// Token: 0x04000CEA RID: 3306
		public static int career_playasplayerhistory_fouls = -1;

		// Token: 0x04000CEB RID: 3307
		public static int career_playasplayerhistory_saveattemps = -1;

		// Token: 0x04000CEC RID: 3308
		public static int career_playasplayerhistory_shotsontarget = -1;

		// Token: 0x04000CED RID: 3309
		public static int career_playasplayerhistory_passesontarget = -1;

		// Token: 0x04000CEE RID: 3310
		public static int career_playasplayerhistory_continentalcuptrophies = -1;

		// Token: 0x04000CEF RID: 3311
		public static int career_playasplayerhistory_totalreds = -1;

		// Token: 0x04000CF0 RID: 3312
		public static int career_playasplayerhistory_draws = -1;

		// Token: 0x04000CF1 RID: 3313
		public static int career_playasplayerhistory_season = -1;

		// Token: 0x04000CF2 RID: 3314
		public static int career_playasplayerhistory_leaguetrophies = -1;

		// Token: 0x04000CF3 RID: 3315
		public static int career_playasplayerhistory_loses = -1;

		// Token: 0x04000CF4 RID: 3316
		public static int career_playasplayerhistory_playasplayerhistoryid = -1;

		// Token: 0x04000CF5 RID: 3317
		public static int career_playasplayerhistory_domesticcuptrophies = -1;

		// Token: 0x04000CF6 RID: 3318
		public static int career_playasplayerhistory_wins = -1;

		// Token: 0x04000CF7 RID: 3319
		public static int career_playasplayerhistory_leagueid = -1;

		// Token: 0x04000CF8 RID: 3320
		public static int career_playasplayerhistory_appearances = -1;

		// Token: 0x04000CF9 RID: 3321
		public static int career_playasplayerhistory_overall = -1;

		// Token: 0x04000CFA RID: 3322
		public static int career_playasplayerhistory_wage = -1;

		// Token: 0x04000CFB RID: 3323
		public static int career_playasplayerhistory_value = -1;

		// Token: 0x04000CFC RID: 3324
		public static int career_playasplayerhistory_assists = -1;

		// Token: 0x04000CFD RID: 3325
		public static int career_playasplayerhistory_matchratings = -1;

		// Token: 0x04000CFE RID: 3326
		public static int career_playasplayerhistory_cleansheets = -1;

		// Token: 0x04000CFF RID: 3327
		public static int career_playasplayerhistory_position = -1;

		// Token: 0x04000D00 RID: 3328
		public static int career_playasplayerhistory_goalsconceded = -1;

		// Token: 0x04000D01 RID: 3329
		public static int career_playasplayerhistory_teamid = -1;

		// Token: 0x04000D02 RID: 3330
		public static int career_playasplayerhistory_totalyellows = -1;

		// Token: 0x04000D03 RID: 3331
		public static int career_playasplayerhistory_clublevel = -1;

		// Token: 0x04000D04 RID: 3332
		public static int career_playasplayerhistory_tableposition = -1;

		// Token: 0x04000D05 RID: 3333
		public static int career_playasplayerhistory_userid = -1;

		// Token: 0x04000D06 RID: 3334
		public static int career_growthcurveinfo_physicalcurveid = -1;

		// Token: 0x04000D07 RID: 3335
		public static int career_growthcurveinfo_physicalcurveoffset = -1;

		// Token: 0x04000D08 RID: 3336
		public static int career_growthcurveinfo_mentalcurveid = -1;

		// Token: 0x04000D09 RID: 3337
		public static int career_growthcurveinfo_skillcurveoffset = -1;

		// Token: 0x04000D0A RID: 3338
		public static int career_growthcurveinfo_mentalcurveoffset = -1;

		// Token: 0x04000D0B RID: 3339
		public static int career_growthcurveinfo_playerid = -1;

		// Token: 0x04000D0C RID: 3340
		public static int career_growthcurveinfo_skillcurveid = -1;

		// Token: 0x04000D0D RID: 3341
		public static int player_growth_experience_points_skill_xp = -1;

		// Token: 0x04000D0E RID: 3342
		public static int player_growth_experience_points_potential = -1;

		// Token: 0x04000D0F RID: 3343
		public static int player_growth_experience_points_mental_xp = -1;

		// Token: 0x04000D10 RID: 3344
		public static int player_growth_experience_points_physical_xp = -1;

		// Token: 0x04000D11 RID: 3345
		public static int player_growth_experience_points_playerid = -1;

		// Token: 0x04000D12 RID: 3346
		public static int player_career_season_num = -1;

		// Token: 0x04000D13 RID: 3347
		public static int player_career_overall = -1;

		// Token: 0x04000D14 RID: 3348
		public static int player_career_artificialkey = -1;

		// Token: 0x04000D15 RID: 3349
		public static int player_career_playerid = -1;

		// Token: 0x04000D16 RID: 3350
		public static int experiencepoints_createplayer_xp = -1;

		// Token: 0x04000D17 RID: 3351
		public static int experiencepoints_playerid = -1;

		// Token: 0x04000D18 RID: 3352
		public static int career_playergrowthuserseason_curve = -1;

		// Token: 0x04000D19 RID: 3353
		public static int career_playergrowthuserseason_agility = -1;

		// Token: 0x04000D1A RID: 3354
		public static int career_playergrowthuserseason_positioning = -1;

		// Token: 0x04000D1B RID: 3355
		public static int career_playergrowthuserseason_standingtackle = -1;

		// Token: 0x04000D1C RID: 3356
		public static int career_playergrowthuserseason_longpassing = -1;

		// Token: 0x04000D1D RID: 3357
		public static int career_playergrowthuserseason_penalties = -1;

		// Token: 0x04000D1E RID: 3358
		public static int career_playergrowthuserseason_longshots = -1;

		// Token: 0x04000D1F RID: 3359
		public static int career_playergrowthuserseason_gkdiving = -1;

		// Token: 0x04000D20 RID: 3360
		public static int career_playergrowthuserseason_interceptions = -1;

		// Token: 0x04000D21 RID: 3361
		public static int career_playergrowthuserseason_crossing = -1;

		// Token: 0x04000D22 RID: 3362
		public static int career_playergrowthuserseason_gkreflexes = -1;

		// Token: 0x04000D23 RID: 3363
		public static int career_playergrowthuserseason_reactions = -1;

		// Token: 0x04000D24 RID: 3364
		public static int career_playergrowthuserseason_vision = -1;

		// Token: 0x04000D25 RID: 3365
		public static int career_playergrowthuserseason_finishing = -1;

		// Token: 0x04000D26 RID: 3366
		public static int career_playergrowthuserseason_dribspeed = -1;

		// Token: 0x04000D27 RID: 3367
		public static int career_playergrowthuserseason_dribbling = -1;

		// Token: 0x04000D28 RID: 3368
		public static int career_playergrowthuserseason_slidingtackle = -1;

		// Token: 0x04000D29 RID: 3369
		public static int career_playergrowthuserseason_sprintspeed = -1;

		// Token: 0x04000D2A RID: 3370
		public static int career_playergrowthuserseason_strength = -1;

		// Token: 0x04000D2B RID: 3371
		public static int career_playergrowthuserseason_ballcontrol = -1;

		// Token: 0x04000D2C RID: 3372
		public static int career_playergrowthuserseason_shotpower = -1;

		// Token: 0x04000D2D RID: 3373
		public static int career_playergrowthuserseason_balance = -1;

		// Token: 0x04000D2E RID: 3374
		public static int career_playergrowthuserseason_gkkicking = -1;

		// Token: 0x04000D2F RID: 3375
		public static int career_playergrowthuserseason_shortpassing = -1;

		// Token: 0x04000D30 RID: 3376
		public static int career_playergrowthuserseason_freekickaccuracy = -1;

		// Token: 0x04000D31 RID: 3377
		public static int career_playergrowthuserseason_aggression = -1;

		// Token: 0x04000D32 RID: 3378
		public static int career_playergrowthuserseason_acceleration = -1;

		// Token: 0x04000D33 RID: 3379
		public static int career_playergrowthuserseason_headingaccuracy = -1;

		// Token: 0x04000D34 RID: 3380
		public static int career_playergrowthuserseason_gkhandling = -1;

		// Token: 0x04000D35 RID: 3381
		public static int career_playergrowthuserseason_jumping = -1;

		// Token: 0x04000D36 RID: 3382
		public static int career_playergrowthuserseason_stamina = -1;

		// Token: 0x04000D37 RID: 3383
		public static int career_playergrowthuserseason_playerid = -1;

		// Token: 0x04000D38 RID: 3384
		public static int career_playergrowthuserseason_marking = -1;

		// Token: 0x04000D39 RID: 3385
		public static int career_playergrowthuserseason_gkpositioning = -1;

		// Token: 0x04000D3A RID: 3386
		public static int career_playergrowthuserseason_volleys = -1;

		// Token: 0x04000D3B RID: 3387
		public static int career_playergrowthupdates_notifygrowth = -1;

		// Token: 0x04000D3C RID: 3388
		public static int career_playergrowthupdates_playerid = -1;

		// Token: 0x04000D3D RID: 3389
		public static int career_playergrowthhistory_startingoverall = -1;

		// Token: 0x04000D3E RID: 3390
		public static int career_playergrowthhistory_startingage = -1;

		// Token: 0x04000D3F RID: 3391
		public static int career_playergrowthhistory_playerid = -1;

		// Token: 0x04000D40 RID: 3392
		public static int finalstadiums_leagueid = -1;

		// Token: 0x04000D41 RID: 3393
		public static int finalstadiums_final_stadium = -1;

		// Token: 0x04000D42 RID: 3394
		public static int tourn_team_manager_rt = -1;

		// Token: 0x04000D43 RID: 3395
		public static int tourn_team_manager_teamid = -1;

		// Token: 0x04000D44 RID: 3396
		public static int tourn_team_manager_outcome = -1;

		// Token: 0x04000D45 RID: 3397
		public static int tourn_team_manager_points = -1;

		// Token: 0x04000D46 RID: 3398
		public static int tourn_settings_setting_value = -1;

		// Token: 0x04000D47 RID: 3399
		public static int tourn_settings_setting_code = -1;

		// Token: 0x04000D48 RID: 3400
		public static int tourn_settings_setting_id = -1;

		// Token: 0x04000D49 RID: 3401
		public static int tourn_rtsg_rtsg = -1;

		// Token: 0x04000D4A RID: 3402
		public static int tourn_rtsg_tournid = -1;

		// Token: 0x04000D4B RID: 3403
		public static int tourn_manager_settings_mLastSimulatedUserFixture = -1;

		// Token: 0x04000D4C RID: 3404
		public static int tourn_manager_settings_setting_4 = -1;

		// Token: 0x04000D4D RID: 3405
		public static int tourn_manager_settings_setting_7 = -1;

		// Token: 0x04000D4E RID: 3406
		public static int tourn_manager_settings_TournamentName = -1;

		// Token: 0x04000D4F RID: 3407
		public static int tourn_manager_settings_setting_9 = -1;

		// Token: 0x04000D50 RID: 3408
		public static int tourn_manager_settings_setting_0 = -1;

		// Token: 0x04000D51 RID: 3409
		public static int tourn_manager_settings_setting_18 = -1;

		// Token: 0x04000D52 RID: 3410
		public static int tourn_manager_settings_setting_8 = -1;

		// Token: 0x04000D53 RID: 3411
		public static int tourn_manager_settings_setting_6 = -1;

		// Token: 0x04000D54 RID: 3412
		public static int tourn_manager_settings_setting_16 = -1;

		// Token: 0x04000D55 RID: 3413
		public static int tourn_manager_settings_setting_11 = -1;

		// Token: 0x04000D56 RID: 3414
		public static int tourn_manager_settings_setting_17 = -1;

		// Token: 0x04000D57 RID: 3415
		public static int tourn_manager_settings_setting_1 = -1;

		// Token: 0x04000D58 RID: 3416
		public static int tourn_manager_settings_setting_13 = -1;

		// Token: 0x04000D59 RID: 3417
		public static int tourn_manager_settings_setting_10 = -1;

		// Token: 0x04000D5A RID: 3418
		public static int tourn_manager_settings_setting_14 = -1;

		// Token: 0x04000D5B RID: 3419
		public static int tourn_manager_settings_setting_2 = -1;

		// Token: 0x04000D5C RID: 3420
		public static int tourn_manager_settings_setting_12 = -1;

		// Token: 0x04000D5D RID: 3421
		public static int tourn_manager_settings_setting_5 = -1;

		// Token: 0x04000D5E RID: 3422
		public static int tourn_manager_settings_setting_3 = -1;

		// Token: 0x04000D5F RID: 3423
		public static int tourn_manager_settings_setting_15 = -1;

		// Token: 0x04000D60 RID: 3424
		public static int tourn_manager_settings_NumTeamsInTournament = -1;

		// Token: 0x04000D61 RID: 3425
		public static int tourn_manager_settings_TournamentStarted = -1;

		// Token: 0x04000D62 RID: 3426
		public static int tourn_manager_settings_IsSimulating = -1;

		// Token: 0x04000D63 RID: 3427
		public static int tourn_manager_settings_setting_id = -1;

		// Token: 0x04000D64 RID: 3428
		public static int tourn_manager_settings_ActiveTournamentID = -1;

		// Token: 0x04000D65 RID: 3429
		public static int tourn_licensed_stages_lt_numlegs = -1;

		// Token: 0x04000D66 RID: 3430
		public static int tourn_licensed_stages_lt_league3 = -1;

		// Token: 0x04000D67 RID: 3431
		public static int tourn_licensed_stages_lt_stage_num = -1;

		// Token: 0x04000D68 RID: 3432
		public static int tourn_licensed_stages_lt_id = -1;

		// Token: 0x04000D69 RID: 3433
		public static int tourn_licensed_stages_lt_league2 = -1;

		// Token: 0x04000D6A RID: 3434
		public static int tourn_licensed_stages_lt_league4 = -1;

		// Token: 0x04000D6B RID: 3435
		public static int tourn_licensed_stages_lt_num_teams_in_stage = -1;

		// Token: 0x04000D6C RID: 3436
		public static int tourn_licensed_stages_lt_league5 = -1;

		// Token: 0x04000D6D RID: 3437
		public static int tourn_licensed_stages_lt_drawtype = -1;

		// Token: 0x04000D6E RID: 3438
		public static int tourn_licensed_stages_lt_league6 = -1;

		// Token: 0x04000D6F RID: 3439
		public static int tourn_licensed_stages_lt_league1 = -1;

		// Token: 0x04000D70 RID: 3440
		public static int tourn_licensed_stages_lt_num_bye_teams = -1;

		// Token: 0x04000D71 RID: 3441
		public static int tourn_licensed_lt_num_teams_to_advance = -1;

		// Token: 0x04000D72 RID: 3442
		public static int tourn_licensed_lt_id = -1;

		// Token: 0x04000D73 RID: 3443
		public static int tourn_licensed_lt_away_goal_rules = -1;

		// Token: 0x04000D74 RID: 3444
		public static int tourn_licensed_lt_num_stages = -1;

		// Token: 0x04000D75 RID: 3445
		public static int tourn_licensed_lt_yellow_card_rule = -1;

		// Token: 0x04000D76 RID: 3446
		public static int tourn_licensed_lt_num_unique_teams = -1;

		// Token: 0x04000D77 RID: 3447
		public static int tourn_licensed_lt_tourn_type = -1;

		// Token: 0x04000D78 RID: 3448
		public static int tourn_licensed_lt_country = -1;

		// Token: 0x04000D79 RID: 3449
		public static int tourn_licensed_lt_redcard_ban = -1;

		// Token: 0x04000D7A RID: 3450
		public static int tourn_licensed_lt_num_teams_per_group = -1;

		// Token: 0x04000D7B RID: 3451
		public static int tourn_licensed_lt_starting_subs = -1;

		// Token: 0x04000D7C RID: 3452
		public static int tourn_licensed_lt_assetid = -1;

		// Token: 0x04000D7D RID: 3453
		public static int tourn_licensed_lt_first_stage_is_KO = -1;

		// Token: 0x04000D7E RID: 3454
		public static int specialteams_teamtype = -1;

		// Token: 0x04000D7F RID: 3455
		public static int specialteams_originalteamid = -1;

		// Token: 0x04000D80 RID: 3456
		public static int specialteams_teamid = -1;

		// Token: 0x04000D81 RID: 3457
		public static int stadiumassignments_stadiumcustomname = -1;

		// Token: 0x04000D82 RID: 3458
		public static int stadiumassignments_teamid = -1;

		// Token: 0x04000D83 RID: 3459
		public static int factory_teams_assetid = -1;

		// Token: 0x04000D84 RID: 3460
		public static int factory_teams_balltype = -1;

		// Token: 0x04000D85 RID: 3461
		public static int factory_teams_teamcolor1g = -1;

		// Token: 0x04000D86 RID: 3462
		public static int factory_teams_teamcolor1r = -1;

		// Token: 0x04000D87 RID: 3463
		public static int factory_teams_teamcolor2b = -1;

		// Token: 0x04000D88 RID: 3464
		public static int factory_teams_teamcolor2r = -1;

		// Token: 0x04000D89 RID: 3465
		public static int factory_teams_teamcolor3r = -1;

		// Token: 0x04000D8A RID: 3466
		public static int factory_teams_teamcolor1b = -1;

		// Token: 0x04000D8B RID: 3467
		public static int factory_teams_latitude = -1;

		// Token: 0x04000D8C RID: 3468
		public static int factory_teams_teamcolor3g = -1;

		// Token: 0x04000D8D RID: 3469
		public static int factory_teams_teamcolor2g = -1;

		// Token: 0x04000D8E RID: 3470
		public static int factory_teams_teamname = -1;

		// Token: 0x04000D8F RID: 3471
		public static int factory_teams_adboardid = -1;

		// Token: 0x04000D90 RID: 3472
		public static int factory_teams_teamcolor3b = -1;

		// Token: 0x04000D91 RID: 3473
		public static int factory_teams_defmentality = -1;

		// Token: 0x04000D92 RID: 3474
		public static int factory_teams_powid = -1;

		// Token: 0x04000D93 RID: 3475
		public static int factory_teams_physioid_secondary = -1;

		// Token: 0x04000D94 RID: 3476
		public static int factory_teams_domesticprestige = -1;

		// Token: 0x04000D95 RID: 3477
		public static int factory_teams_genericint2 = -1;

		// Token: 0x04000D96 RID: 3478
		public static int factory_teams_jerseytype = -1;

		// Token: 0x04000D97 RID: 3479
		public static int factory_teams_rivalteam = -1;

		// Token: 0x04000D98 RID: 3480
		public static int factory_teams_midfieldrating = -1;

		// Token: 0x04000D99 RID: 3481
		public static int factory_teams_matchdayoverallrating = -1;

		// Token: 0x04000D9A RID: 3482
		public static int factory_teams_matchdaymidfieldrating = -1;

		// Token: 0x04000D9B RID: 3483
		public static int factory_teams_attackrating = -1;

		// Token: 0x04000D9C RID: 3484
		public static int factory_teams_physioid_primary = -1;

		// Token: 0x04000D9D RID: 3485
		public static int factory_teams_longitude = -1;

		// Token: 0x04000D9E RID: 3486
		public static int factory_teams_buspassing = -1;

		// Token: 0x04000D9F RID: 3487
		public static int factory_teams_matchdaydefenserating = -1;

		// Token: 0x04000DA0 RID: 3488
		public static int factory_teams_defenserating = -1;

		// Token: 0x04000DA1 RID: 3489
		public static int factory_teams_defteamwidth = -1;

		// Token: 0x04000DA2 RID: 3490
		public static int factory_teams_longkicktakerid = -1;

		// Token: 0x04000DA3 RID: 3491
		public static int factory_teams_bodytypeid = -1;

		// Token: 0x04000DA4 RID: 3492
		public static int factory_teams_rightcornerkicktakerid = -1;

		// Token: 0x04000DA5 RID: 3493
		public static int factory_teams_suitvariationid = -1;

		// Token: 0x04000DA6 RID: 3494
		public static int factory_teams_defaggression = -1;

		// Token: 0x04000DA7 RID: 3495
		public static int factory_teams_ethnicity = -1;

		// Token: 0x04000DA8 RID: 3496
		public static int factory_teams_leftcornerkicktakerid = -1;

		// Token: 0x04000DA9 RID: 3497
		public static int factory_teams_teamid = -1;

		// Token: 0x04000DAA RID: 3498
		public static int factory_teams_fancrowdhairskintexturecode = -1;

		// Token: 0x04000DAB RID: 3499
		public static int factory_teams_suittypeid = -1;

		// Token: 0x04000DAC RID: 3500
		public static int factory_teams_numtransfersin = -1;

		// Token: 0x04000DAD RID: 3501
		public static int factory_teams_captainid = -1;

		// Token: 0x04000DAE RID: 3502
		public static int factory_teams_personalityid = -1;

		// Token: 0x04000DAF RID: 3503
		public static int factory_teams_genericbanner = -1;

		// Token: 0x04000DB0 RID: 3504
		public static int factory_teams_buspositioning = -1;

		// Token: 0x04000DB1 RID: 3505
		public static int factory_teams_stafftracksuitcolorcode = -1;

		// Token: 0x04000DB2 RID: 3506
		public static int factory_teams_ccpositioning = -1;

		// Token: 0x04000DB3 RID: 3507
		public static int factory_teams_busbuildupspeed = -1;

		// Token: 0x04000DB4 RID: 3508
		public static int factory_teams_transferbudget = -1;

		// Token: 0x04000DB5 RID: 3509
		public static int factory_teams_ccshooting = -1;

		// Token: 0x04000DB6 RID: 3510
		public static int factory_teams_overallrating = -1;

		// Token: 0x04000DB7 RID: 3511
		public static int factory_teams_ccpassing = -1;

		// Token: 0x04000DB8 RID: 3512
		public static int factory_teams_utcoffset = -1;

		// Token: 0x04000DB9 RID: 3513
		public static int factory_teams_penaltytakerid = -1;

		// Token: 0x04000DBA RID: 3514
		public static int factory_teams_freekicktakerid = -1;

		// Token: 0x04000DBB RID: 3515
		public static int factory_teams_defdefenderline = -1;

		// Token: 0x04000DBC RID: 3516
		public static int factory_teams_internationalprestige = -1;

		// Token: 0x04000DBD RID: 3517
		public static int factory_teams_form = -1;

		// Token: 0x04000DBE RID: 3518
		public static int factory_teams_genericint1 = -1;

		// Token: 0x04000DBF RID: 3519
		public static int factory_teams_cccrossing = -1;

		// Token: 0x04000DC0 RID: 3520
		public static int factory_teams_matchdayattackrating = -1;

		// Token: 0x04000DC1 RID: 3521
		public static int temp_createplayer_cpmorphcomposite_noseprofile_protrusion_lsx = -1;

		// Token: 0x04000DC2 RID: 3522
		public static int temp_createplayer_cpmorphcomposite_eyedetail1_folds_lsy = -1;

		// Token: 0x04000DC3 RID: 3523
		public static int temp_createplayer_cpmorphcomposite_mouthposition_protrusion_rsx = -1;

		// Token: 0x04000DC4 RID: 3524
		public static int temp_createplayer_cpmorphcomposite_nostrildetail_height_lsy = -1;

		// Token: 0x04000DC5 RID: 3525
		public static int temp_createplayer_cpmorphcomposite_browshape_protrusion_rsx = -1;

		// Token: 0x04000DC6 RID: 3526
		public static int temp_createplayer_cpmorphcomposite_browshape_tilt_lsy = -1;

		// Token: 0x04000DC7 RID: 3527
		public static int temp_createplayer_cpmorphcomposite_earplacement_height_lsy = -1;

		// Token: 0x04000DC8 RID: 3528
		public static int temp_createplayer_cpmorphcomposite_cheekplacement_position_lsy = -1;

		// Token: 0x04000DC9 RID: 3529
		public static int temp_createplayer_cpmorphcomposite_eyeshape_shape_rsx = -1;

		// Token: 0x04000DCA RID: 3530
		public static int temp_createplayer_cpmorphcomposite_lips_upperlip_shape_lsx = -1;

		// Token: 0x04000DCB RID: 3531
		public static int temp_createplayer_cpmorphcomposite_eyeshape_height_lsy = -1;

		// Token: 0x04000DCC RID: 3532
		public static int temp_createplayer_cpmorphcomposite_mouthposition_bite_rsy = -1;

		// Token: 0x04000DCD RID: 3533
		public static int temp_createplayer_cpmorphcomposite_cheekstyle_blemishes_rsx = -1;

		// Token: 0x04000DCE RID: 3534
		public static int temp_createplayer_cpmorphcomposite_nostrils_height_lsy = -1;

		// Token: 0x04000DCF RID: 3535
		public static int temp_createplayer_cpmorphcomposite_mouthblemishes_lsx = -1;

		// Token: 0x04000DD0 RID: 3536
		public static int temp_createplayer_cpmorphcomposite_earstyle_lobe_lsx = -1;

		// Token: 0x04000DD1 RID: 3537
		public static int temp_createplayer_cpmorphcomposite_mouthposition_width_lsx = -1;

		// Token: 0x04000DD2 RID: 3538
		public static int temp_createplayer_cpmorphcomposite_eyeshape_tilt_rsy = -1;

		// Token: 0x04000DD3 RID: 3539
		public static int temp_createplayer_cpmorphcomposite_noseprofile_tipshape_rsy = -1;

		// Token: 0x04000DD4 RID: 3540
		public static int temp_createplayer_cpmorphcomposite_browplacement_thickness_rsy = -1;

		// Token: 0x04000DD5 RID: 3541
		public static int temp_createplayer_cpmorphcomposite_noseplacement_position_lsy = -1;

		// Token: 0x04000DD6 RID: 3542
		public static int temp_createplayer_cpmorphcomposite_eyeshape_seperation_lsx = -1;

		// Token: 0x04000DD7 RID: 3543
		public static int temp_createplayer_cpmorphcomposite_noseprofile_tipprotrusion_rsx = -1;

		// Token: 0x04000DD8 RID: 3544
		public static int temp_createplayer_cpmorphcomposite_cheekplacement_width_lsx = -1;

		// Token: 0x04000DD9 RID: 3545
		public static int temp_createplayer_cpmorphcomposite_laughlinedarkness_lsx = -1;

		// Token: 0x04000DDA RID: 3546
		public static int temp_createplayer_cpmorphcomposite_jaw_position_lsy = -1;

		// Token: 0x04000DDB RID: 3547
		public static int temp_createplayer_cpmorphcomposite_browplacement_protrusion_rsx = -1;

		// Token: 0x04000DDC RID: 3548
		public static int temp_createplayer_cpmorphcomposite_eyedetail2_lowerlid_lsx = -1;

		// Token: 0x04000DDD RID: 3549
		public static int temp_createplayer_cpmorphcomposite_lips_upperlip_thickness_lsy = -1;

		// Token: 0x04000DDE RID: 3550
		public static int temp_createplayer_cpmorphcomposite_noseprofile_shape_lsy = -1;

		// Token: 0x04000DDF RID: 3551
		public static int temp_createplayer_cpmorphcomposite_lips_lowerlip_thickness_rsy = -1;

		// Token: 0x04000DE0 RID: 3552
		public static int temp_createplayer_cpmorhpcomposite_chin_width_lsx = -1;

		// Token: 0x04000DE1 RID: 3553
		public static int temp_createplayer_cpmorphcomposite_nosestyle_nosestyle_lsx = -1;

		// Token: 0x04000DE2 RID: 3554
		public static int temp_createplayer_cpmorphcomposite_mouthposition_position_lsy = -1;

		// Token: 0x04000DE3 RID: 3555
		public static int temp_createplayer_cpmorphcomposite_earplacement_protrusion_lsx = -1;

		// Token: 0x04000DE4 RID: 3556
		public static int temp_createplayer_cpmorphcomposite_dimpledarkness_lsx = -1;

		// Token: 0x04000DE5 RID: 3557
		public static int temp_createplayer_cpmorphcomposite_noseplacement_width_rsx = -1;

		// Token: 0x04000DE6 RID: 3558
		public static int temp_createplayer_cpmorphcomposite_eyedetail2_protrusion_rsy = -1;

		// Token: 0x04000DE7 RID: 3559
		public static int temp_createplayer_cpmorphcomposite_lipstyle_corners_lipdimple_rsx = -1;

		// Token: 0x04000DE8 RID: 3560
		public static int temp_createplayer_cpmorphcomposite_lips_lowerlip_thickness_rsx = -1;

		// Token: 0x04000DE9 RID: 3561
		public static int temp_createplayer_cpmorphcomposite_browplacement_position_lsy = -1;

		// Token: 0x04000DEA RID: 3562
		public static int temp_createplayer_cpmorhpcomposite_chin_postion_lsy = -1;

		// Token: 0x04000DEB RID: 3563
		public static int temp_createplayer_cpmorphcomposite_lipstyle_corners_updown_lsy = -1;

		// Token: 0x04000DEC RID: 3564
		public static int temp_createplayer_cpmorphcomposite_eyedetail1_protrusion_rsx = -1;

		// Token: 0x04000DED RID: 3565
		public static int temp_createplayer_cpmorphcomposite_browshape_seperation_lsx = -1;

		// Token: 0x04000DEE RID: 3566
		public static int temp_createplayer_cpmorphcomposite_jaw_bulk_rsx = -1;

		// Token: 0x04000DEF RID: 3567
		public static int temp_createplayer_cpmorphcomposite_noseplacement_width_lsx = -1;

		// Token: 0x04000DF0 RID: 3568
		public static int temp_createplayer_cpmorphcomposite_eyedetail1_symmetry_lsx = -1;

		// Token: 0x04000DF1 RID: 3569
		public static int temp_createplayer_cpmorphcomposite_nostrils_width_lsx = -1;

		// Token: 0x04000DF2 RID: 3570
		public static int temp_createplayer_cpmorphcomposite_eyedetail2_upperlid_lsy = -1;

		// Token: 0x04000DF3 RID: 3571
		public static int temp_createplayer_cpmorphcomposite_lipstyle_corners_leftright_lsx = -1;

		// Token: 0x04000DF4 RID: 3572
		public static int temp_createplayer_cpmorphcomposite_browplacement_tilt_lsx = -1;

		// Token: 0x04000DF5 RID: 3573
		public static int temp_createplayer_cpmorphcomposite_jaw_width_lsx = -1;

		// Token: 0x04000DF6 RID: 3574
		public static int temp_createplayer_cpmorphcomposite_browshape_thickness_rsy = -1;

		// Token: 0x04000DF7 RID: 3575
		public static int temp_createplayer_cpmorhpcomposite_chin_protrusion_rsx = -1;

		// Token: 0x04000DF8 RID: 3576
		public static int temp_createplayer_cpmorphcomposite_noseplacement_position_rsy = -1;

		// Token: 0x04000DF9 RID: 3577
		public static int temp_createplayer_cpmorphcomposite_nostrildetail_width_lsx = -1;

		// Token: 0x04000DFA RID: 3578
		public static int temp_createplayer_cpmorphcomposite_cheekstyle_style_lsx = -1;

		// Token: 0x04000DFB RID: 3579
		public static int temp_createplayer_cpmorhpcomposite_chin_deatil_rsy = -1;

		// Token: 0x04000DFC RID: 3580
		public static int temp_createplayer_create_originalplayerid = -1;

		// Token: 0x04000DFD RID: 3581
		public static int temp_createplayer_create_playerid = -1;

		// Token: 0x04000DFE RID: 3582
		public static int temp_createplayer_cpattributename_hair_colour = -1;

		// Token: 0x04000DFF RID: 3583
		public static int temp_createplayer_cpattributename_hair_style = -1;

		// Token: 0x04000E00 RID: 3584
		public static int temp_createplayer_celebrationid = -1;

		// Token: 0x04000E01 RID: 3585
		public static int temp_createplayer_cpattributename_brow_style = -1;

		// Token: 0x04000E02 RID: 3586
		public static int temp_createplayer_cpattributename_eye_colour = -1;

		// Token: 0x04000E03 RID: 3587
		public static int temp_createplayer_create_artificialkey = -1;

		// Token: 0x04000E04 RID: 3588
		public static int temp_createplayer_commentaryid = -1;

		// Token: 0x04000E05 RID: 3589
		public static int temp_createplayer_cpattributename_facial_hair_style = -1;

		// Token: 0x04000E06 RID: 3590
		public static int temp_createplayer_cpattributename_brow_colour = -1;

		// Token: 0x04000E07 RID: 3591
		public static int temp_createplayer_cpattributename_facial_hair_colour = -1;

		// Token: 0x04000E08 RID: 3592
		public static int temp_arenacreateplayer_cpmorphcomposite_noseprofile_protrusion_lsx = -1;

		// Token: 0x04000E09 RID: 3593
		public static int temp_arenacreateplayer_cpmorphcomposite_eyedetail1_folds_lsy = -1;

		// Token: 0x04000E0A RID: 3594
		public static int temp_arenacreateplayer_cpmorphcomposite_mouthposition_protrusion_rsx = -1;

		// Token: 0x04000E0B RID: 3595
		public static int temp_arenacreateplayer_cpmorphcomposite_nostrildetail_height_lsy = -1;

		// Token: 0x04000E0C RID: 3596
		public static int temp_arenacreateplayer_cpmorphcomposite_browshape_protrusion_rsx = -1;

		// Token: 0x04000E0D RID: 3597
		public static int temp_arenacreateplayer_cpmorphcomposite_browshape_tilt_lsy = -1;

		// Token: 0x04000E0E RID: 3598
		public static int temp_arenacreateplayer_cpmorphcomposite_earplacement_height_lsy = -1;

		// Token: 0x04000E0F RID: 3599
		public static int temp_arenacreateplayer_cpmorphcomposite_cheekplacement_position_lsy = -1;

		// Token: 0x04000E10 RID: 3600
		public static int temp_arenacreateplayer_cpmorphcomposite_eyeshape_shape_rsx = -1;

		// Token: 0x04000E11 RID: 3601
		public static int temp_arenacreateplayer_cpmorphcomposite_lips_upperlip_shape_lsx = -1;

		// Token: 0x04000E12 RID: 3602
		public static int temp_arenacreateplayer_cpmorphcomposite_eyeshape_height_lsy = -1;

		// Token: 0x04000E13 RID: 3603
		public static int temp_arenacreateplayer_cpmorphcomposite_mouthposition_bite_rsy = -1;

		// Token: 0x04000E14 RID: 3604
		public static int temp_arenacreateplayer_cpmorphcomposite_cheekstyle_blemishes_rsx = -1;

		// Token: 0x04000E15 RID: 3605
		public static int temp_arenacreateplayer_cpmorphcomposite_nostrils_height_lsy = -1;

		// Token: 0x04000E16 RID: 3606
		public static int temp_arenacreateplayer_cpmorphcomposite_mouthblemishes_lsx = -1;

		// Token: 0x04000E17 RID: 3607
		public static int temp_arenacreateplayer_cpmorphcomposite_earstyle_lobe_lsx = -1;

		// Token: 0x04000E18 RID: 3608
		public static int temp_arenacreateplayer_cpmorphcomposite_mouthposition_width_lsx = -1;

		// Token: 0x04000E19 RID: 3609
		public static int temp_arenacreateplayer_cpmorphcomposite_eyeshape_tilt_rsy = -1;

		// Token: 0x04000E1A RID: 3610
		public static int temp_arenacreateplayer_cpmorphcomposite_noseprofile_tipshape_rsy = -1;

		// Token: 0x04000E1B RID: 3611
		public static int temp_arenacreateplayer_cpmorphcomposite_browplacement_thickness_rsy = -1;

		// Token: 0x04000E1C RID: 3612
		public static int temp_arenacreateplayer_cpmorphcomposite_noseplacement_position_lsy = -1;

		// Token: 0x04000E1D RID: 3613
		public static int temp_arenacreateplayer_cpmorphcomposite_eyeshape_seperation_lsx = -1;

		// Token: 0x04000E1E RID: 3614
		public static int temp_arenacreateplayer_cpmorphcomposite_noseprofile_tipprotrusion_rsx = -1;

		// Token: 0x04000E1F RID: 3615
		public static int temp_arenacreateplayer_cpmorphcomposite_cheekplacement_width_lsx = -1;

		// Token: 0x04000E20 RID: 3616
		public static int temp_arenacreateplayer_cpmorphcomposite_laughlinedarkness_lsx = -1;

		// Token: 0x04000E21 RID: 3617
		public static int temp_arenacreateplayer_cpmorphcomposite_jaw_position_lsy = -1;

		// Token: 0x04000E22 RID: 3618
		public static int temp_arenacreateplayer_cpmorphcomposite_browplacement_protrusion_rsx = -1;

		// Token: 0x04000E23 RID: 3619
		public static int temp_arenacreateplayer_cpmorphcomposite_eyedetail2_lowerlid_lsx = -1;

		// Token: 0x04000E24 RID: 3620
		public static int temp_arenacreateplayer_cpmorphcomposite_lips_upperlip_thickness_lsy = -1;

		// Token: 0x04000E25 RID: 3621
		public static int temp_arenacreateplayer_cpmorphcomposite_noseprofile_shape_lsy = -1;

		// Token: 0x04000E26 RID: 3622
		public static int temp_arenacreateplayer_cpmorphcomposite_lips_lowerlip_thickness_rsy = -1;

		// Token: 0x04000E27 RID: 3623
		public static int temp_arenacreateplayer_cpmorhpcomposite_chin_width_lsx = -1;

		// Token: 0x04000E28 RID: 3624
		public static int temp_arenacreateplayer_cpmorphcomposite_nosestyle_nosestyle_lsx = -1;

		// Token: 0x04000E29 RID: 3625
		public static int temp_arenacreateplayer_cpmorphcomposite_mouthposition_position_lsy = -1;

		// Token: 0x04000E2A RID: 3626
		public static int temp_arenacreateplayer_cpmorphcomposite_earplacement_protrusion_lsx = -1;

		// Token: 0x04000E2B RID: 3627
		public static int temp_arenacreateplayer_cpmorphcomposite_dimpledarkness_lsx = -1;

		// Token: 0x04000E2C RID: 3628
		public static int temp_arenacreateplayer_cpmorphcomposite_noseplacement_width_rsx = -1;

		// Token: 0x04000E2D RID: 3629
		public static int temp_arenacreateplayer_cpmorphcomposite_eyedetail2_protrusion_rsy = -1;

		// Token: 0x04000E2E RID: 3630
		public static int temp_arenacreateplayer_cpmorphcomposite_lipstyle_corners_lipdimple_rsx = -1;

		// Token: 0x04000E2F RID: 3631
		public static int temp_arenacreateplayer_cpmorphcomposite_lips_lowerlip_thickness_rsx = -1;

		// Token: 0x04000E30 RID: 3632
		public static int temp_arenacreateplayer_cpmorphcomposite_browplacement_position_lsy = -1;

		// Token: 0x04000E31 RID: 3633
		public static int temp_arenacreateplayer_cpmorhpcomposite_chin_postion_lsy = -1;

		// Token: 0x04000E32 RID: 3634
		public static int temp_arenacreateplayer_cpmorphcomposite_lipstyle_corners_updown_lsy = -1;

		// Token: 0x04000E33 RID: 3635
		public static int temp_arenacreateplayer_cpmorphcomposite_eyedetail1_protrusion_rsx = -1;

		// Token: 0x04000E34 RID: 3636
		public static int temp_arenacreateplayer_cpmorphcomposite_browshape_seperation_lsx = -1;

		// Token: 0x04000E35 RID: 3637
		public static int temp_arenacreateplayer_cpmorphcomposite_jaw_bulk_rsx = -1;

		// Token: 0x04000E36 RID: 3638
		public static int temp_arenacreateplayer_cpmorphcomposite_noseplacement_width_lsx = -1;

		// Token: 0x04000E37 RID: 3639
		public static int temp_arenacreateplayer_cpmorphcomposite_eyedetail1_symmetry_lsx = -1;

		// Token: 0x04000E38 RID: 3640
		public static int temp_arenacreateplayer_cpmorphcomposite_nostrils_width_lsx = -1;

		// Token: 0x04000E39 RID: 3641
		public static int temp_arenacreateplayer_cpmorphcomposite_eyedetail2_upperlid_lsy = -1;

		// Token: 0x04000E3A RID: 3642
		public static int temp_arenacreateplayer_cpmorphcomposite_lipstyle_corners_leftright_lsx = -1;

		// Token: 0x04000E3B RID: 3643
		public static int temp_arenacreateplayer_cpmorphcomposite_browplacement_tilt_lsx = -1;

		// Token: 0x04000E3C RID: 3644
		public static int temp_arenacreateplayer_cpmorphcomposite_jaw_width_lsx = -1;

		// Token: 0x04000E3D RID: 3645
		public static int temp_arenacreateplayer_cpmorphcomposite_browshape_thickness_rsy = -1;

		// Token: 0x04000E3E RID: 3646
		public static int temp_arenacreateplayer_cpmorhpcomposite_chin_protrusion_rsx = -1;

		// Token: 0x04000E3F RID: 3647
		public static int temp_arenacreateplayer_cpmorphcomposite_noseplacement_position_rsy = -1;

		// Token: 0x04000E40 RID: 3648
		public static int temp_arenacreateplayer_cpmorphcomposite_nostrildetail_width_lsx = -1;

		// Token: 0x04000E41 RID: 3649
		public static int temp_arenacreateplayer_cpmorphcomposite_cheekstyle_style_lsx = -1;

		// Token: 0x04000E42 RID: 3650
		public static int temp_arenacreateplayer_cpmorhpcomposite_chin_deatil_rsy = -1;

		// Token: 0x04000E43 RID: 3651
		public static int temp_arenacreateplayer_create_originalplayerid = -1;

		// Token: 0x04000E44 RID: 3652
		public static int temp_arenacreateplayer_create_playerid = -1;

		// Token: 0x04000E45 RID: 3653
		public static int temp_arenacreateplayer_cpattributename_hair_colour = -1;

		// Token: 0x04000E46 RID: 3654
		public static int temp_arenacreateplayer_cpattributename_hair_style = -1;

		// Token: 0x04000E47 RID: 3655
		public static int temp_arenacreateplayer_celebrationid = -1;

		// Token: 0x04000E48 RID: 3656
		public static int temp_arenacreateplayer_cpattributename_brow_style = -1;

		// Token: 0x04000E49 RID: 3657
		public static int temp_arenacreateplayer_cpattributename_eye_colour = -1;

		// Token: 0x04000E4A RID: 3658
		public static int temp_arenacreateplayer_create_artificialkey = -1;

		// Token: 0x04000E4B RID: 3659
		public static int temp_arenacreateplayer_commentaryid = -1;

		// Token: 0x04000E4C RID: 3660
		public static int temp_arenacreateplayer_cpattributename_facial_hair_style = -1;

		// Token: 0x04000E4D RID: 3661
		public static int temp_arenacreateplayer_cpattributename_brow_colour = -1;

		// Token: 0x04000E4E RID: 3662
		public static int temp_arenacreateplayer_cpattributename_facial_hair_colour = -1;

		// Token: 0x04000E4F RID: 3663
		public static int career_blacklist_permanent = -1;

		// Token: 0x04000E50 RID: 3664
		public static int career_blacklist_playerid = -1;

		// Token: 0x04000E51 RID: 3665
		public static int career_transferoffer_startdate = -1;

		// Token: 0x04000E52 RID: 3666
		public static int career_transferoffer_date = -1;

		// Token: 0x04000E53 RID: 3667
		public static int career_transferoffer_offerteamid = -1;

		// Token: 0x04000E54 RID: 3668
		public static int career_transferoffer_approachreason = -1;

		// Token: 0x04000E55 RID: 3669
		public static int career_transferoffer_offerid = -1;

		// Token: 0x04000E56 RID: 3670
		public static int career_transferoffer_stage = -1;

		// Token: 0x04000E57 RID: 3671
		public static int career_transferoffer_isCPUTransfer = -1;

		// Token: 0x04000E58 RID: 3672
		public static int career_transferoffer_exchangeplayerid = -1;

		// Token: 0x04000E59 RID: 3673
		public static int career_transferoffer_offeredfee = -1;

		// Token: 0x04000E5A RID: 3674
		public static int career_transferoffer_counteroffers = -1;

		// Token: 0x04000E5B RID: 3675
		public static int career_transferoffer_offeredwage = -1;

		// Token: 0x04000E5C RID: 3676
		public static int career_transferoffer_currentcontractlength = -1;

		// Token: 0x04000E5D RID: 3677
		public static int career_transferoffer_result = -1;

		// Token: 0x04000E5E RID: 3678
		public static int career_transferoffer_desiredFee = -1;

		// Token: 0x04000E5F RID: 3679
		public static int career_transferoffer_isloanbuy = -1;

		// Token: 0x04000E60 RID: 3680
		public static int career_transferoffer_teamid = -1;

		// Token: 0x04000E61 RID: 3681
		public static int career_transferoffer_offeredcontracttype = -1;

		// Token: 0x04000E62 RID: 3682
		public static int career_transferoffer_valuation = -1;

		// Token: 0x04000E63 RID: 3683
		public static int career_transferoffer_snipedteamid = -1;

		// Token: 0x04000E64 RID: 3684
		public static int career_transferoffer_playerid = -1;

		// Token: 0x04000E65 RID: 3685
		public static int career_transferoffer_squadrole = -1;

		// Token: 0x04000E66 RID: 3686
		public static int career_transferoffer_issnipe = -1;

		// Token: 0x04000E67 RID: 3687
		public static int career_transferoffer_transferwindow = -1;

		// Token: 0x04000E68 RID: 3688
		public static int career_transferoffer_isloan = -1;

		// Token: 0x04000E69 RID: 3689
		public static int career_transferoffer_offeredbonus = -1;

		// Token: 0x04000E6A RID: 3690
		public static int career_transferlist_leagueid = -1;

		// Token: 0x04000E6B RID: 3691
		public static int career_transferlist_preferredposition1 = -1;

		// Token: 0x04000E6C RID: 3692
		public static int career_transferlist_pitcharea = -1;

		// Token: 0x04000E6D RID: 3693
		public static int career_transferlist_teamid = -1;

		// Token: 0x04000E6E RID: 3694
		public static int career_transferlist_playerid = -1;

		// Token: 0x04000E6F RID: 3695
		public static int career_transferlist_overallrating = -1;

		// Token: 0x04000E70 RID: 3696
		public static int career_transferlist_potentialtype = -1;

		// Token: 0x04000E71 RID: 3697
		public static int career_playercontract_offered_wage = -1;

		// Token: 0x04000E72 RID: 3698
		public static int career_playercontract_salary_demand = -1;

		// Token: 0x04000E73 RID: 3699
		public static int career_playercontract_offered_bonus = -1;

		// Token: 0x04000E74 RID: 3700
		public static int career_playercontract_contract_status = -1;

		// Token: 0x04000E75 RID: 3701
		public static int career_playercontract_contract_status_change_date = -1;

		// Token: 0x04000E76 RID: 3702
		public static int career_playercontract_wage = -1;

		// Token: 0x04000E77 RID: 3703
		public static int career_playercontract_extension_years = -1;

		// Token: 0x04000E78 RID: 3704
		public static int career_playercontract_teamid = -1;

		// Token: 0x04000E79 RID: 3705
		public static int career_playercontract_negotiation_status = -1;

		// Token: 0x04000E7A RID: 3706
		public static int career_playercontract_bonus = -1;

		// Token: 0x04000E7B RID: 3707
		public static int career_playercontract_negotiation_date = -1;

		// Token: 0x04000E7C RID: 3708
		public static int career_playercontract_playerid = -1;

		// Token: 0x04000E7D RID: 3709
		public static int career_loanbuy_future_fee = -1;

		// Token: 0x04000E7E RID: 3710
		public static int career_loanbuy_stage = -1;

		// Token: 0x04000E7F RID: 3711
		public static int career_loanbuy_playerid = -1;

		// Token: 0x04000E80 RID: 3712
		public static int achievements_orderAchieved = -1;

		// Token: 0x04000E81 RID: 3713
		public static int achievements_isDisplayed = -1;

		// Token: 0x04000E82 RID: 3714
		public static int achievements_achievementID = -1;

		// Token: 0x04000E83 RID: 3715
		public static int achievements_isAchieved = -1;

		// Token: 0x04000E84 RID: 3716
		public static int fifaUnlockables_AccompString = -1;

		// Token: 0x04000E85 RID: 3717
		public static int fifaUnlockables_TournString = -1;

		// Token: 0x04000E86 RID: 3718
		public static int fifaUnlockables_TeamString = -1;

		// Token: 0x04000E87 RID: 3719
		public static int fifaUnlockables_UnlockableString = -1;

		// Token: 0x04000E88 RID: 3720
		public static int fifaUnlockables_ItemId = -1;

		// Token: 0x04000E89 RID: 3721
		public static int fifaUnlockables_ItemType = -1;

		// Token: 0x04000E8A RID: 3722
		public static int fifaUnlockables_AssetId = -1;

		// Token: 0x04000E8B RID: 3723
		public static int fifaUnlockables_KOTeams = -1;

		// Token: 0x04000E8C RID: 3724
		public static int fifaUnlockables_UnlockableID = -1;

		// Token: 0x04000E8D RID: 3725
		public static int fifaUnlockables_Price = -1;

		// Token: 0x04000E8E RID: 3726
		public static int fifaUnlockables_Locked = -1;

		// Token: 0x04000E8F RID: 3727
		public static int usability_title = -1;

		// Token: 0x04000E90 RID: 3728
		public static int usability_body_text = -1;

		// Token: 0x04000E91 RID: 3729
		public static int usability_usability_id = -1;

		// Token: 0x04000E92 RID: 3730
		public static int usability_button_3 = -1;

		// Token: 0x04000E93 RID: 3731
		public static int usability_button_4 = -1;

		// Token: 0x04000E94 RID: 3732
		public static int usability_button_1 = -1;

		// Token: 0x04000E95 RID: 3733
		public static int usability_difficulty = -1;

		// Token: 0x04000E96 RID: 3734
		public static int usability_button_2 = -1;

		// Token: 0x04000E97 RID: 3735
		public static int usability_type = -1;

		// Token: 0x04000E98 RID: 3736
		public static int usability_functions_funct_text = -1;

		// Token: 0x04000E99 RID: 3737
		public static int usability_functions_action_cnt = -1;

		// Token: 0x04000E9A RID: 3738
		public static int usability_functions_button_id = -1;

		// Token: 0x04000E9B RID: 3739
		public static int usability_functions_arrow = -1;

		// Token: 0x04000E9C RID: 3740
		public static int usability_functions_funct = -1;

		// Token: 0x04000E9D RID: 3741
		public static int virtualleagues_name = -1;

		// Token: 0x04000E9E RID: 3742
		public static int virtualleagues_id = -1;

		// Token: 0x04000E9F RID: 3743
		public static int virtualleagues_dbleagueid = -1;

		// Token: 0x04000EA0 RID: 3744
		public static int career_namesgroups_nationality = -1;

		// Token: 0x04000EA1 RID: 3745
		public static int career_namesgroups_groupid = -1;

		// Token: 0x04000EA2 RID: 3746
		public static int career_youthplayers_playertier = -1;

		// Token: 0x04000EA3 RID: 3747
		public static int career_youthplayers_playertype = -1;

		// Token: 0x04000EA4 RID: 3748
		public static int career_youthplayers_swinglowpotential = -1;

		// Token: 0x04000EA5 RID: 3749
		public static int career_youthplayers_potentialvariance = -1;

		// Token: 0x04000EA6 RID: 3750
		public static int career_youthplayers_playerid = -1;

		// Token: 0x04000EA7 RID: 3751
		public static int career_youthplayers_monthsinsquad = -1;

		// Token: 0x04000EA8 RID: 3752
		public static int career_youthplayerhistory_goals = -1;

		// Token: 0x04000EA9 RID: 3753
		public static int career_youthplayerhistory_appearances = -1;

		// Token: 0x04000EAA RID: 3754
		public static int career_youthplayerhistory_playerid = -1;

		// Token: 0x04000EAB RID: 3755
		public static int career_youthplayerattributes_playertier = -1;

		// Token: 0x04000EAC RID: 3756
		public static int career_youthplayerattributes_curve = -1;

		// Token: 0x04000EAD RID: 3757
		public static int career_youthplayerattributes_agility = -1;

		// Token: 0x04000EAE RID: 3758
		public static int career_youthplayerattributes_positioning = -1;

		// Token: 0x04000EAF RID: 3759
		public static int career_youthplayerattributes_playertype = -1;

		// Token: 0x04000EB0 RID: 3760
		public static int career_youthplayerattributes_standingtackle = -1;

		// Token: 0x04000EB1 RID: 3761
		public static int career_youthplayerattributes_longpassing = -1;

		// Token: 0x04000EB2 RID: 3762
		public static int career_youthplayerattributes_penalties = -1;

		// Token: 0x04000EB3 RID: 3763
		public static int career_youthplayerattributes_longshots = -1;

		// Token: 0x04000EB4 RID: 3764
		public static int career_youthplayerattributes_gkdiving = -1;

		// Token: 0x04000EB5 RID: 3765
		public static int career_youthplayerattributes_interceptions = -1;

		// Token: 0x04000EB6 RID: 3766
		public static int career_youthplayerattributes_crossing = -1;

		// Token: 0x04000EB7 RID: 3767
		public static int career_youthplayerattributes_potential = -1;

		// Token: 0x04000EB8 RID: 3768
		public static int career_youthplayerattributes_gkreflexes = -1;

		// Token: 0x04000EB9 RID: 3769
		public static int career_youthplayerattributes_reactions = -1;

		// Token: 0x04000EBA RID: 3770
		public static int career_youthplayerattributes_vision = -1;

		// Token: 0x04000EBB RID: 3771
		public static int career_youthplayerattributes_finishing = -1;

		// Token: 0x04000EBC RID: 3772
		public static int career_youthplayerattributes_dribbling = -1;

		// Token: 0x04000EBD RID: 3773
		public static int career_youthplayerattributes_slidingtackle = -1;

		// Token: 0x04000EBE RID: 3774
		public static int career_youthplayerattributes_sprintspeed = -1;

		// Token: 0x04000EBF RID: 3775
		public static int career_youthplayerattributes_age = -1;

		// Token: 0x04000EC0 RID: 3776
		public static int career_youthplayerattributes_strength = -1;

		// Token: 0x04000EC1 RID: 3777
		public static int career_youthplayerattributes_ballcontrol = -1;

		// Token: 0x04000EC2 RID: 3778
		public static int career_youthplayerattributes_shotpower = -1;

		// Token: 0x04000EC3 RID: 3779
		public static int career_youthplayerattributes_balance = -1;

		// Token: 0x04000EC4 RID: 3780
		public static int career_youthplayerattributes_gkkicking = -1;

		// Token: 0x04000EC5 RID: 3781
		public static int career_youthplayerattributes_shortpassing = -1;

		// Token: 0x04000EC6 RID: 3782
		public static int career_youthplayerattributes_freekickaccuracy = -1;

		// Token: 0x04000EC7 RID: 3783
		public static int career_youthplayerattributes_aggression = -1;

		// Token: 0x04000EC8 RID: 3784
		public static int career_youthplayerattributes_acceleration = -1;

		// Token: 0x04000EC9 RID: 3785
		public static int career_youthplayerattributes_headingaccuracy = -1;

		// Token: 0x04000ECA RID: 3786
		public static int career_youthplayerattributes_gkhandling = -1;

		// Token: 0x04000ECB RID: 3787
		public static int career_youthplayerattributes_jumping = -1;

		// Token: 0x04000ECC RID: 3788
		public static int career_youthplayerattributes_stamina = -1;

		// Token: 0x04000ECD RID: 3789
		public static int career_youthplayerattributes_marking = -1;

		// Token: 0x04000ECE RID: 3790
		public static int career_youthplayerattributes_gkpositioning = -1;

		// Token: 0x04000ECF RID: 3791
		public static int career_youthplayerattributes_volleys = -1;

		// Token: 0x04000ED0 RID: 3792
		public static int career_scouts_firstname = -1;

		// Token: 0x04000ED1 RID: 3793
		public static int career_scouts_lastname = -1;

		// Token: 0x04000ED2 RID: 3794
		public static int career_scouts_regionid = -1;

		// Token: 0x04000ED3 RID: 3795
		public static int career_scouts_state = -1;

		// Token: 0x04000ED4 RID: 3796
		public static int career_scouts_knowledge = -1;

		// Token: 0x04000ED5 RID: 3797
		public static int career_scouts_nationality = -1;

		// Token: 0x04000ED6 RID: 3798
		public static int career_scouts_scoutid = -1;

		// Token: 0x04000ED7 RID: 3799
		public static int career_scouts_experience = -1;

		// Token: 0x04000ED8 RID: 3800
		public static int career_scoutmission_playertype = -1;

		// Token: 0x04000ED9 RID: 3801
		public static int career_scoutmission_durationid = -1;

		// Token: 0x04000EDA RID: 3802
		public static int career_scoutmission_returningdate = -1;

		// Token: 0x04000EDB RID: 3803
		public static int career_scoutmission_nationality = -1;

		// Token: 0x04000EDC RID: 3804
		public static int career_scoutmission_scoutid = -1;

		// Token: 0x04000EDD RID: 3805
		public static int career_regenplayerattributes_curve = -1;

		// Token: 0x04000EDE RID: 3806
		public static int career_regenplayerattributes_agility = -1;

		// Token: 0x04000EDF RID: 3807
		public static int career_regenplayerattributes_positioning = -1;

		// Token: 0x04000EE0 RID: 3808
		public static int career_regenplayerattributes_standingtackle = -1;

		// Token: 0x04000EE1 RID: 3809
		public static int career_regenplayerattributes_longpassing = -1;

		// Token: 0x04000EE2 RID: 3810
		public static int career_regenplayerattributes_penalties = -1;

		// Token: 0x04000EE3 RID: 3811
		public static int career_regenplayerattributes_longshots = -1;

		// Token: 0x04000EE4 RID: 3812
		public static int career_regenplayerattributes_gkdiving = -1;

		// Token: 0x04000EE5 RID: 3813
		public static int career_regenplayerattributes_interceptions = -1;

		// Token: 0x04000EE6 RID: 3814
		public static int career_regenplayerattributes_crossing = -1;

		// Token: 0x04000EE7 RID: 3815
		public static int career_regenplayerattributes_gkreflexes = -1;

		// Token: 0x04000EE8 RID: 3816
		public static int career_regenplayerattributes_reactions = -1;

		// Token: 0x04000EE9 RID: 3817
		public static int career_regenplayerattributes_vision = -1;

		// Token: 0x04000EEA RID: 3818
		public static int career_regenplayerattributes_finishing = -1;

		// Token: 0x04000EEB RID: 3819
		public static int career_regenplayerattributes_dribbling = -1;

		// Token: 0x04000EEC RID: 3820
		public static int career_regenplayerattributes_slidingtackle = -1;

		// Token: 0x04000EED RID: 3821
		public static int career_regenplayerattributes_sprintspeed = -1;

		// Token: 0x04000EEE RID: 3822
		public static int career_regenplayerattributes_age = -1;

		// Token: 0x04000EEF RID: 3823
		public static int career_regenplayerattributes_strength = -1;

		// Token: 0x04000EF0 RID: 3824
		public static int career_regenplayerattributes_ballcontrol = -1;

		// Token: 0x04000EF1 RID: 3825
		public static int career_regenplayerattributes_shotpower = -1;

		// Token: 0x04000EF2 RID: 3826
		public static int career_regenplayerattributes_overall = -1;

		// Token: 0x04000EF3 RID: 3827
		public static int career_regenplayerattributes_balance = -1;

		// Token: 0x04000EF4 RID: 3828
		public static int career_regenplayerattributes_gkkicking = -1;

		// Token: 0x04000EF5 RID: 3829
		public static int career_regenplayerattributes_shortpassing = -1;

		// Token: 0x04000EF6 RID: 3830
		public static int career_regenplayerattributes_freekickaccuracy = -1;

		// Token: 0x04000EF7 RID: 3831
		public static int career_regenplayerattributes_aggression = -1;

		// Token: 0x04000EF8 RID: 3832
		public static int career_regenplayerattributes_acceleration = -1;

		// Token: 0x04000EF9 RID: 3833
		public static int career_regenplayerattributes_headingaccuracy = -1;

		// Token: 0x04000EFA RID: 3834
		public static int career_regenplayerattributes_gkhandling = -1;

		// Token: 0x04000EFB RID: 3835
		public static int career_regenplayerattributes_jumping = -1;

		// Token: 0x04000EFC RID: 3836
		public static int career_regenplayerattributes_stamina = -1;

		// Token: 0x04000EFD RID: 3837
		public static int career_regenplayerattributes_marking = -1;

		// Token: 0x04000EFE RID: 3838
		public static int career_regenplayerattributes_gkpositioning = -1;

		// Token: 0x04000EFF RID: 3839
		public static int career_regenplayerattributes_playerposgroup = -1;

		// Token: 0x04000F00 RID: 3840
		public static int career_regenplayerattributes_volleys = -1;
	}
}
