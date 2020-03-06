using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class M3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Elections",
                columns: table => new
                {
                    ElectionId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    ElectionName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elections", x => x.ElectionId);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ThemeName = table.Column<string>(nullable: false),
                    Placement = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: false),
                    Format = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OpenGraph",
                columns: table => new
                {
                    OpenGraphId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Determiner = table.Column<string>(nullable: true),
                    Locale = table.Column<string>(nullable: true),
                    SiteName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpenGraph", x => x.OpenGraphId);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.OrganizationId);
                });

            migrationBuilder.CreateTable(
                name: "Steps",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: false),
                    StepNumber = table.Column<int>(nullable: false),
                    StepTitle = table.Column<string>(nullable: true),
                    StepDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Steps", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    ThemeName = table.Column<string>(nullable: false),
                    Selected = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.ThemeName);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BallotIssues",
                columns: table => new
                {
                    BallotIssueId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: false),
                    BallotIssueTitle = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BallotIssues", x => x.BallotIssueId);
                    table.ForeignKey(
                        name: "FK_BallotIssues_Elections_ElectionId",
                        column: x => x.ElectionId,
                        principalTable: "Elections",
                        principalColumn: "ElectionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PollingPlaces",
                columns: table => new
                {
                    PollingPlaceId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: false),
                    PollingPlaceName = table.Column<string>(nullable: true),
                    PollingStationName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    WheelchairInfo = table.Column<string>(nullable: true),
                    ParkingInfo = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    AdvanceOnly = table.Column<bool>(nullable: false),
                    LocalArea = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PollingPlaces", x => x.PollingPlaceId);
                    table.ForeignKey(
                        name: "FK_PollingPlaces_Elections_ElectionId",
                        column: x => x.ElectionId,
                        principalTable: "Elections",
                        principalColumn: "ElectionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    RaceId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: false),
                    BallotOrder = table.Column<int>(nullable: false),
                    PositionName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    NumberNeeded = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.RaceId);
                    table.ForeignKey(
                        name: "FK_Races_Elections_ElectionId",
                        column: x => x.ElectionId,
                        principalTable: "Elections",
                        principalColumn: "ElectionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: false),
                    MediaName = table.Column<string>(nullable: false),
                    Message = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SocialMedias_Elections_ElectionId",
                        column: x => x.ElectionId,
                        principalTable: "Elections",
                        principalColumn: "ElectionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StateSingleton",
                columns: table => new
                {
                    StateId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RunningElectionID = table.Column<int>(nullable: false),
                    ManagedElectionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateSingleton", x => x.StateId);
                    table.ForeignKey(
                        name: "FK_StateSingleton_Elections_ManagedElectionID",
                        column: x => x.ManagedElectionID,
                        principalTable: "Elections",
                        principalColumn: "ElectionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StateSingleton_Elections_RunningElectionID",
                        column: x => x.RunningElectionID,
                        principalTable: "Elections",
                        principalColumn: "ElectionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OGAudio",
                columns: table => new
                {
                    OGAudioID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    SecureURL = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    OpenGraphId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OGAudio", x => x.OGAudioID);
                    table.ForeignKey(
                        name: "FK_OGAudio_OpenGraph_OpenGraphId",
                        column: x => x.OpenGraphId,
                        principalTable: "OpenGraph",
                        principalColumn: "OpenGraphId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OGImage",
                columns: table => new
                {
                    OGImageId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    SecureURL = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Width = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Alt = table.Column<string>(nullable: true),
                    OpenGraphId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OGImage", x => x.OGImageId);
                    table.ForeignKey(
                        name: "FK_OGImage_OpenGraph_OpenGraphId",
                        column: x => x.OpenGraphId,
                        principalTable: "OpenGraph",
                        principalColumn: "OpenGraphId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OGVideo",
                columns: table => new
                {
                    OGVideoID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    SecureURL = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Width = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    OpenGraphId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OGVideo", x => x.OGVideoID);
                    table.ForeignKey(
                        name: "FK_OGVideo_OpenGraph_OpenGraphId",
                        column: x => x.OpenGraphId,
                        principalTable: "OpenGraph",
                        principalColumn: "OpenGraphId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    CandidateId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Picture = table.Column<string>(nullable: false),
                    OrganizationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.CandidateId);
                    table.ForeignKey(
                        name: "FK_Candidates_Elections_ElectionId",
                        column: x => x.ElectionId,
                        principalTable: "Elections",
                        principalColumn: "ElectionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Candidates_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IssueOptions",
                columns: table => new
                {
                    IssueOptionId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IssueOptionInfo = table.Column<string>(nullable: true),
                    BallotIssueId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssueOptions", x => x.IssueOptionId);
                    table.ForeignKey(
                        name: "FK_IssueOptions_BallotIssues_BallotIssueId",
                        column: x => x.BallotIssueId,
                        principalTable: "BallotIssues",
                        principalColumn: "BallotIssueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PollingPlaceDates",
                columns: table => new
                {
                    PollingDateId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PollingPlaceId = table.Column<int>(nullable: false),
                    PollingDate = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PollingPlaceDates", x => x.PollingDateId);
                    table.ForeignKey(
                        name: "FK_PollingPlaceDates_PollingPlaces_PollingPlaceId",
                        column: x => x.PollingPlaceId,
                        principalTable: "PollingPlaces",
                        principalColumn: "PollingPlaceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CandidateDetails",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CandidateId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Format = table.Column<int>(nullable: false),
                    Lang = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CandidateDetails_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "CandidateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CandidateRaces",
                columns: table => new
                {
                    CandidateRaceId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CandidateId = table.Column<int>(nullable: false),
                    RaceId = table.Column<int>(nullable: false),
                    BallotOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateRaces", x => x.CandidateRaceId);
                    table.ForeignKey(
                        name: "FK_CandidateRaces_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "CandidateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidateRaces_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "RaceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ContactMethod = table.Column<int>(nullable: false),
                    ContactValue = table.Column<string>(nullable: true),
                    CandidateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_Contacts_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "CandidateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Elections",
                columns: new[] { "ElectionId", "Description", "ElectionName", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { 1, "City of Vancouver 2018 Municipal Election", "City of Vancouver 2018 Municipal Election", new DateTime(2019, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "The 2019 Canadian federal election is scheduled to take place on or before October 21, 2019. The October 21 date of the vote is determined by the fixed-date procedures in the Canada Elections Act", "Canadian Federal Election 2019", new DateTime(2019, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "OrganizationId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Party 1" },
                    { 2, null, "Party 2" },
                    { 3, null, "Party 3" },
                    { 4, null, "Party 4" },
                    { 5, null, "Party 5" }
                });

            migrationBuilder.InsertData(
                table: "Steps",
                columns: new[] { "ID", "ElectionId", "StepDescription", "StepNumber", "StepTitle" },
                values: new object[,]
                {
                    { 1, 1, "Add up to 1 mayor, 10 councillors, 7 Park Board commissioners, and 9 school trustees to your plan. Open a candidate to read their profile and add them to your plan. Change your choices in the selected candidates area above. A candidate’s profile expresses their views alone and these views aren’t endorsed by the City of Vancouver. Profiles are included exactly as candidates wrote them. If you live in the UBC Lands or University Endowment Lands, and you do not own property in Vancouver, you can only vote for school trustees in the election.", 1, "STEP 1: REVIEW AND SELECT CANDIDATES" },
                    { 2, 1, "Add your response to the Capital Plan borrowing questions to your plan. The ballot will have 3 \"yes\" or \"no\" questions on whether the City can borrow $300 million to help pay for projects in the Capital Plan. The 2019-2022 Capital Plan invests $300,000,000 in City facilities and infrastructure to provide services to the people of Vancouver. If a majority of voters vote yes, then City Council can borrow the funds for these projects.", 2, "STEP 2: REVIEW CAPITAL PLAN BORROWING QUESTIONS" },
                    { 3, 1, "Not sure when you want to vote yet? Don't worry - you're not committing to a particular day or place. If you live in the UBC Lands or University Endowment Lands, you can vote at 2 voting places only on October 20 Opens in new window. These 2 places are not shown on the map below. Skip this step to review your choices and create your plan.", 3, "STEP 3: CHOOSE YOUR VOTING DATE AND LOCATION" },
                    { 4, 1, "", 4, "STEP 4: REVIEW YOUR PLAN" }
                });

            migrationBuilder.InsertData(
                table: "BallotIssues",
                columns: new[] { "BallotIssueId", "BallotIssueTitle", "Description", "ElectionId" },
                values: new object[,]
                {
                    { 1, "1. TRANSPORTATION AND TECHNOLOGY", "This question seeks authority to borrow funds to be used in carrying out the basic capital works program with respect to transportation and technology. Are you in favour of Council having the authority, without further assent of the electors, to pass bylaws between January 1, 2019, and December 31, 2022, to borrow an aggregate $100,353,000 for the following purposes?", 1 },
                    { 2, "2. CAPITAL MAINTENANCE AND RENOVATION PROGRAMS FOR EXISTING COMMUNITY FACILITIES, CIVIC FACILITIES, AND PARKS", "This question seeks authority to borrow funds to be used in carrying out the basic capital works program with respect to capital maintenance and renovation programs for existing community facilities, civic facilities, and parks. Are you in favour of Council having the authority, without further assent of the electors, to pass bylaws between January 1, 2019, and December 31, 2022, to borrow an aggregate $99,557,000 for the following purposes?", 1 },
                    { 3, "3. REPLACEMENT OF EXISTING COMMUNITY FACILITIES AND CIVIC FACILITIES:", "This question seeks authority to borrow funds to be used in carrying out the basic capital works program with respect to replacement of existing community facilities and civic facilities. Are you in favour of Council having the authority, without further assent of the electors, to pass bylaws between January 1, 2019, and December 31, 2022, to borrow an aggregate $100,090,000 for the following purposes?", 1 }
                });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "CandidateId", "ElectionId", "Name", "OrganizationId", "Picture" },
                values: new object[,]
                {
                    { 36, 1, "Park Board Comissioner 6", 1, "images/default.jpg" },
                    { 35, 1, "Park Board Comissioner 5", 1, "images/default.jpg" },
                    { 34, 1, "Park Board Comissioner 4", 1, "images/default.jpg" },
                    { 33, 1, "Park Board Comissioner 3", 1, "images/default.jpg" },
                    { 32, 1, "Park Board Comissioner 2", 1, "images/default.jpg" },
                    { 31, 1, "Park Board Comissioner 1", 1, "images/default.jpg" },
                    { 30, 1, "Mayor 10", 1, "images/default.jpg" },
                    { 29, 1, "Mayor 9", 1, "images/default.jpg" },
                    { 27, 1, "Mayor 7", 1, "images/default.jpg" },
                    { 37, 1, "Park Board Comissioner 7", 1, "images/default.jpg" },
                    { 26, 1, "Mayor 6", 1, "images/default.jpg" },
                    { 25, 1, "Mayor 5", 1, "images/default.jpg" },
                    { 24, 1, "Mayor 4", 1, "images/default.jpg" },
                    { 23, 1, "Mayor 3", 1, "images/default.jpg" },
                    { 22, 1, "Mayor 2", 1, "images/default.jpg" },
                    { 21, 1, "Mayor 1", 1, "images/default.jpg" },
                    { 20, 1, "Councillor 20", 1, "images/default.jpg" },
                    { 28, 1, "Mayor 8", 1, "images/default.jpg" },
                    { 38, 1, "Park Board Comissioner 8", 1, "images/default.jpg" },
                    { 40, 1, "Park Board Comissioner 10", 1, "images/default.jpg" },
                    { 19, 1, "Councillor 19", 1, "images/default.jpg" },
                    { 58, 1, "School Trustee 13", 1, "images/default.jpg" },
                    { 57, 1, "School Trustee 12", 1, "images/default.jpg" },
                    { 56, 1, "School Trustee 11", 1, "images/default.jpg" },
                    { 55, 1, "School Trustee 10", 1, "images/default.jpg" },
                    { 54, 1, "School Trustee 9", 1, "images/default.jpg" },
                    { 53, 1, "School Trustee 8", 1, "images/default.jpg" },
                    { 52, 1, "School Trustee 7", 1, "images/default.jpg" },
                    { 51, 1, "School Trustee 6", 1, "images/default.jpg" },
                    { 39, 1, "Park Board Comissioner 9", 1, "images/default.jpg" },
                    { 50, 1, "School Trustee 5", 1, "images/default.jpg" },
                    { 48, 1, "School Trustee 3", 1, "images/default.jpg" },
                    { 47, 1, "School Trustee 2", 1, "images/default.jpg" },
                    { 46, 1, "School Trustee 1", 1, "images/default.jpg" },
                    { 45, 1, "Park Board Comissioner 15", 1, "images/default.jpg" },
                    { 44, 1, "Park Board Comissioner 14", 1, "images/default.jpg" },
                    { 43, 1, "Park Board Comissioner 13", 1, "images/default.jpg" },
                    { 42, 1, "Park Board Comissioner 12", 1, "images/default.jpg" },
                    { 41, 1, "Park Board Comissioner 11", 1, "images/default.jpg" },
                    { 49, 1, "School Trustee 4", 1, "images/default.jpg" },
                    { 18, 1, "Councillor 18", 1, "images/default.jpg" },
                    { 17, 1, "Councillor 17", 1, "images/default.jpg" },
                    { 16, 1, "Councillor 16", 1, "images/default.jpg" },
                    { 59, 1, "School Trustee 14", 1, "images/default.jpg" },
                    { 1, 1, "Councillor 1", 1, "images/default.jpg" },
                    { 2, 1, "Councillor 2", 1, "images/default.jpg" },
                    { 3, 1, "Councillor 3", 1, "images/default.jpg" },
                    { 4, 1, "Councillor 4", 1, "images/default.jpg" },
                    { 5, 1, "Councillor 5", 1, "images/default.jpg" },
                    { 6, 1, "Councillor 6", 1, "images/default.jpg" },
                    { 7, 1, "Councillor 7", 1, "images/default.jpg" },
                    { 60, 1, "School Trustee 15", 1, "images/default.jpg" },
                    { 9, 1, "Councillor 9", 1, "images/default.jpg" },
                    { 10, 1, "Councillor 10", 1, "images/default.jpg" },
                    { 11, 1, "Councillor 11", 1, "images/default.jpg" },
                    { 12, 1, "Councillor 12", 1, "images/default.jpg" },
                    { 13, 1, "Councillor 13", 1, "images/default.jpg" },
                    { 14, 1, "Councillor 14", 1, "images/default.jpg" },
                    { 8, 1, "Councillor 8", 1, "images/default.jpg" },
                    { 15, 1, "Councillor 15", 1, "images/default.jpg" }
                });

            migrationBuilder.InsertData(
                table: "PollingPlaces",
                columns: new[] { "PollingPlaceId", "Address", "AdvanceOnly", "ElectionId", "Email", "Latitude", "LocalArea", "Longitude", "ParkingInfo", "Phone", "PollingPlaceName", "PollingStationName", "WheelchairInfo" },
                values: new object[,]
                {
                    { 9, "999 W 19th Avenue", false, 1, "contact3@organization.com", 0.0, "Local Neighborhood", 0.0, "Parking Lot", "111-222-3333", "University 3", "Gymnasium", "Wheelchair accessible by ramp" },
                    { 8, "888 W 18th Avenue", false, 1, "contact1@organization.com", 0.0, "Downtown", 0.0, "Parking Lot", "111-222-3333", "University 2", "Cafeteria", "Wheelchair accessible by ramp" },
                    { 7, "777 W 17th Avenue", false, 1, "contact3@organization.com", 0.0, "Local Neighborhood", 0.0, "Parking Lot", "111-222-3333", "University 1", "Gymnasium", "Wheelchair accessible by ramp" },
                    { 6, "666 W 16th Avenue", false, 1, "contact2@organization.com", 0.0, "Local Neighbourhood", 0.0, "No Parking", "111-222-3333", "School 5", "Cafeteria", "No wheelchair access" },
                    { 4, "444 W 14th Avenue", false, 1, "contact1@organization.com", 0.0, "Downtown", 0.0, "Parking Lot", "111-222-3333", "School 3", "Auditorium", "Wheelchair accessible by ramp" },
                    { 10, "111 W 11th Avenue", false, 1, "contact3@organization.com", 0.0, "Local Neighborhood", 0.0, "Parking Lot", "111-222-3333", "University 4", "Gymnasium", "Wheelchair accessible by ramp" },
                    { 3, "333 W 13th Avenue", false, 1, "contact2@organization.com", 0.0, "Local Neighbourhood", 0.0, "No Parking", "111-222-3333", "School 2", "Cafeteria", "No wheelchair access" },
                    { 2, "222 W 12th Avenue", false, 1, "contact2@organization.com", 0.0, "Local Neighbourhood", 0.0, "No Parking", "111-222-3333", "School 1", "Cafeteria", "No wheelchair access" },
                    { 1, "111 W 11th Avenue", false, 1, "contact1@organization.com", 0.0, "Downtown", 0.0, "Parking Lot", "111-222-3333", "City Hall", "Town Hall Room", "Wheelchair accessible by ramp" },
                    { 5, "555 W 15th Avenue", false, 1, "contact2@organization.com", 0.0, "Local Neighbourhood", 0.0, "No Parking", "111-222-3333", "School 4", "Cafeteria", "No wheelchair access" },
                    { 11, "222 W 12th Avenue", false, 1, "contact1@organization.com", 0.0, "Downtown", 0.0, "Parking Lot", "111-222-3333", "University 5", "Cafeteria", "Wheelchair accessible by ramp" },
                    { 15, "666 W 16th Avenue", false, 1, "contact4@organization.com", 0.0, "Local Neighborhood", 0.0, "Parking Lot", "111-222-3333", "Community Centre 3", "Gymnasium", "Wheelchair accessible by ramp" },
                    { 13, "444 W 14th Avenue", false, 1, "contact4@organization.com", 0.0, "Local Neighborhood", 0.0, "Parking Lot", "111-222-3333", "Community Centre 1", "Gymnasium", "Wheelchair accessible by ramp" },
                    { 14, "555 W 15th Avenue", false, 1, "contact4@organization.com", 0.0, "Local Neighborhood", 0.0, "Parking Lot", "111-222-3333", "Community Centre 2", "Gymnasium", "Wheelchair accessible by ramp" },
                    { 16, "777 W 17th Avenue", false, 1, "contact4@organization.com", 0.0, "Local Neighborhood", 0.0, "Parking Lot", "111-222-3333", "Community Centre 4", "Gymnasium", "Wheelchair accessible by ramp" },
                    { 17, "888 W 18th Avenue", false, 1, "contact5@organization.com", 0.0, "Local Neighborhood", 0.0, "Parking Lot", "111-222-3333", "Church 1", "Gymnasium", "Wheelchair accessible by ramp" },
                    { 18, "999 W 19th Avenue", false, 1, "contact5@organization.com", 0.0, "Local Neighborhood", 0.0, "Parking Lot", "111-222-3333", "Church 2", "Gymnasium", "Wheelchair accessible by ramp" },
                    { 19, "111 W 11th Avenue", false, 1, "contact5@organization.com", 0.0, "Local Neighborhood", 0.0, "Parking Lot", "111-222-3333", "Church 3", "Gymnasium", "Wheelchair accessible by ramp" },
                    { 12, "333 W 13th Avenue", false, 1, "contact3@organization.com", 0.0, "Local Neighborhood", 0.0, "Parking Lot", "111-222-3333", "University 6", "Gymnasium", "Wheelchair accessible by ramp" },
                    { 20, "222 W 12th Avenue", false, 1, "contact5@organization.com", 0.0, "Local Neighborhood", 0.0, "Parking Lot", "111-222-3333", "Church 4", "Gymnasium", "Wheelchair accessible by ramp" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "RaceId", "BallotOrder", "Description", "ElectionId", "NumberNeeded", "PositionName" },
                values: new object[,]
                {
                    { 1, 2, null, 1, 10, "Councillor" },
                    { 2, 1, null, 1, 1, "Mayor" },
                    { 3, 3, null, 1, 7, "Park Board Commissioner" },
                    { 4, 4, null, 1, 9, "School Trustee" }
                });

            migrationBuilder.InsertData(
                table: "CandidateDetails",
                columns: new[] { "ID", "CandidateId", "Format", "Lang", "Text", "Title" },
                values: new object[,]
                {
                    { 143, 29, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 153, 31, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 241, 49, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 242, 49, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 243, 49, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 244, 49, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 80, 16, 0, 0, "Description of candidate's biography, background, and or who they are as a person.", "Biography" },
                    { 79, 16, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 78, 16, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 77, 16, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 76, 16, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 245, 49, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 154, 31, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 155, 31, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 202, 41, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 201, 41, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 75, 15, 0, 0, "Description of candidate's biography, background, and or who they are as a person.", "Biography" },
                    { 74, 15, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 152, 31, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 151, 31, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 81, 17, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 82, 17, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 92, 19, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 91, 19, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 236, 48, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 237, 48, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 238, 48, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 90, 18, 0, 0, "Description of candidate's biography, background, and or who they are as a person.", "Biography" },
                    { 89, 18, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 88, 18, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 73, 15, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 87, 18, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 239, 48, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 240, 48, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 205, 41, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 204, 41, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 203, 41, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 85, 17, 0, 0, "Description of candidate's biography, background, and or who they are as a person.", "Biography" },
                    { 84, 17, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 83, 17, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 86, 18, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 93, 19, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 72, 15, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 246, 50, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 255, 51, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 60, 12, 0, 0, "Description of candidate's biography, background, and or who they are as a person.", "Biography" },
                    { 59, 12, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 58, 12, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 57, 12, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 56, 12, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 160, 32, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 200, 40, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 199, 40, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 55, 11, 0, 0, "Description of candidate's biography, background, and or who they are as a person.", "Biography" },
                    { 54, 11, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 53, 11, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 52, 11, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 51, 11, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 256, 52, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 257, 52, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 258, 52, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 211, 43, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 253, 51, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 252, 51, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 251, 51, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 247, 50, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 248, 50, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 249, 50, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 250, 50, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 70, 14, 0, 0, "Description of candidate's biography, background, and or who they are as a person.", "Biography" },
                    { 69, 14, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 68, 14, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 67, 14, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 71, 15, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 66, 14, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 157, 32, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 158, 32, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 65, 13, 0, 0, "Description of candidate's biography, background, and or who they are as a person.", "Biography" },
                    { 64, 13, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 63, 13, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 62, 13, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 61, 13, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 159, 32, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 156, 32, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 259, 52, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 94, 19, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 150, 30, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 219, 44, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 220, 44, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 125, 25, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 124, 25, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 123, 25, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 122, 25, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 121, 25, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 210, 42, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 141, 29, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 120, 24, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 119, 24, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 118, 24, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 117, 24, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 116, 24, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 221, 45, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 222, 45, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 223, 45, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 218, 44, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 217, 44, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 216, 44, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 126, 26, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 212, 43, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 213, 43, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 214, 43, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 215, 43, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 135, 27, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 134, 27, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 133, 27, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 132, 27, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 224, 45, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 131, 27, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 137, 28, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 138, 28, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 139, 28, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 140, 28, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 130, 26, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 129, 26, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 128, 26, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 127, 26, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 136, 28, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 95, 19, 0, 0, "Description of candidate's biography, background, and or who they are as a person.", "Biography" },
                    { 225, 45, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 115, 23, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 103, 21, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 102, 21, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 101, 21, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 146, 30, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 147, 30, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 231, 47, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 232, 47, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 100, 20, 0, 0, "Description of candidate's biography, background, and or who they are as a person.", "Biography" },
                    { 99, 20, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 98, 20, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 97, 20, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 96, 20, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 233, 47, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 234, 47, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 235, 47, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 148, 30, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 149, 30, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 104, 21, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 105, 21, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 206, 42, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 230, 46, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 114, 23, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 113, 23, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 112, 23, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 111, 23, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 209, 42, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 144, 29, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 145, 29, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 208, 42, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 142, 29, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 207, 42, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 110, 22, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 109, 22, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 108, 22, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 107, 22, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 106, 22, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 227, 46, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 228, 46, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 229, 46, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 226, 46, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 260, 52, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 254, 51, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 198, 40, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 279, 56, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 15, 3, 0, 0, "Description of candidate's biography, background, and or who they are as a person.", "Biography" },
                    { 14, 3, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 13, 3, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 12, 3, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 11, 3, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 280, 56, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 278, 56, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 171, 35, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 173, 35, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 174, 35, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 175, 35, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 10, 2, 0, 0, "Description of candidate's biography, background, and or who they are as a person.", "Biography" },
                    { 9, 2, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 8, 2, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 7, 2, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 172, 35, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 6, 2, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 277, 56, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 191, 39, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 273, 55, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 25, 5, 0, 0, "Description of candidate's biography, background, and or who they are as a person.", "Biography" },
                    { 24, 5, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 23, 5, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 22, 5, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 21, 5, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 274, 55, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 276, 56, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 275, 55, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 194, 39, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 20, 4, 0, 0, "Description of candidate's biography, background, and or who they are as a person.", "Biography" },
                    { 19, 4, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 18, 4, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 17, 4, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 193, 39, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 192, 39, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 195, 39, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 281, 57, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 282, 57, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 283, 57, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 294, 59, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 295, 59, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 189, 38, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 188, 38, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 187, 38, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 186, 38, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 181, 37, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 293, 59, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 182, 37, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 297, 60, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 298, 60, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 299, 60, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 300, 60, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 183, 37, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 184, 37, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 185, 37, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 296, 60, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 292, 59, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 291, 59, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 190, 38, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 284, 57, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 285, 57, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 5, 1, 0, 0, "Description of candidate's biography, background, and or who they are as a person.", "Biography" },
                    { 4, 1, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 3, 1, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 2, 1, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 1, 1, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 176, 36, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 286, 58, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 287, 58, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 288, 58, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 289, 58, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 290, 58, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 177, 36, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 178, 36, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 179, 36, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 180, 36, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 272, 55, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 271, 55, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 16, 4, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 32, 7, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 269, 54, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 164, 33, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 268, 54, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 165, 33, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 31, 7, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 261, 53, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 36, 8, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 33, 7, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 34, 7, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 37, 8, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 265, 53, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 264, 53, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 263, 53, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 45, 9, 0, 0, "Description of candidate's biography, background, and or who they are as a person.", "Biography" },
                    { 262, 53, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 267, 54, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 266, 54, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 41, 9, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 44, 9, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 42, 9, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 35, 7, 0, 0, "Description of candidate's biography, background, and or who they are as a person.", "Biography" },
                    { 270, 54, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 163, 33, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 38, 8, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 169, 34, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 168, 34, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 26, 6, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 40, 8, 0, 0, "Description of candidate's biography, background, and or who they are as a person.", "Biography" },
                    { 27, 6, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 39, 8, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 28, 6, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 50, 10, 0, 0, "Description of candidate's biography, background, and or who they are as a person.", "Biography" },
                    { 29, 6, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 170, 34, 0, 0, "Candidate's biography, background, and or description of who they are as a person.", "Biography" },
                    { 49, 10, 0, 0, "Candidate's pitch and or description of their promises if elected.", "Platform" },
                    { 30, 6, 0, 0, "Description of candidate's biography, background, and or who they are as a person.", "Biography" },
                    { 162, 33, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 43, 9, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 48, 10, 2, 0, "Candidate's Third Priority", "Priority 3" },
                    { 47, 10, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 46, 10, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 166, 34, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 196, 40, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 197, 40, 2, 0, "Candidate's Second Priority", "Priority 2" },
                    { 161, 33, 2, 0, "Candidate's First Priority ", "Priority 1" },
                    { 167, 34, 2, 0, "Candidate's Second Priority", "Priority 2" }
                });

            migrationBuilder.InsertData(
                table: "CandidateRaces",
                columns: new[] { "CandidateRaceId", "BallotOrder", "CandidateId", "RaceId" },
                values: new object[,]
                {
                    { 45, 15, 45, 3 },
                    { 33, 3, 33, 3 },
                    { 23, 3, 23, 2 },
                    { 24, 4, 24, 2 },
                    { 57, 12, 57, 4 },
                    { 58, 13, 58, 4 },
                    { 53, 8, 53, 4 },
                    { 34, 4, 34, 3 },
                    { 42, 12, 42, 3 },
                    { 37, 7, 37, 3 },
                    { 10, 10, 10, 1 },
                    { 27, 7, 27, 2 },
                    { 60, 15, 60, 4 },
                    { 43, 13, 43, 3 },
                    { 11, 11, 11, 1 },
                    { 28, 8, 28, 2 },
                    { 26, 6, 26, 2 },
                    { 51, 6, 51, 4 },
                    { 40, 10, 40, 3 },
                    { 32, 2, 32, 3 },
                    { 8, 8, 8, 1 },
                    { 9, 9, 9, 1 },
                    { 44, 14, 44, 3 },
                    { 25, 5, 25, 2 },
                    { 38, 8, 38, 3 },
                    { 36, 6, 36, 3 },
                    { 12, 12, 12, 1 },
                    { 59, 14, 59, 4 },
                    { 13, 13, 13, 1 },
                    { 22, 2, 22, 2 },
                    { 1, 1, 1, 1 },
                    { 29, 9, 29, 2 },
                    { 3, 3, 3, 1 },
                    { 47, 2, 47, 4 },
                    { 15, 15, 15, 1 },
                    { 19, 19, 19, 1 },
                    { 52, 7, 52, 4 },
                    { 31, 1, 31, 3 },
                    { 54, 9, 54, 4 },
                    { 30, 10, 30, 2 },
                    { 20, 20, 20, 1 },
                    { 49, 4, 49, 4 },
                    { 18, 18, 18, 1 },
                    { 39, 9, 39, 3 },
                    { 55, 10, 55, 4 },
                    { 6, 6, 6, 1 },
                    { 48, 3, 48, 4 },
                    { 41, 11, 41, 3 },
                    { 16, 16, 16, 1 },
                    { 17, 17, 17, 1 },
                    { 5, 5, 5, 1 },
                    { 4, 4, 4, 1 },
                    { 56, 11, 56, 4 },
                    { 7, 7, 7, 1 },
                    { 46, 1, 46, 4 },
                    { 35, 5, 35, 3 },
                    { 21, 1, 21, 2 },
                    { 14, 14, 14, 1 },
                    { 2, 2, 2, 1 },
                    { 50, 5, 50, 4 }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CandidateId", "ContactMethod", "ContactValue" },
                values: new object[,]
                {
                    { 259, 37, 7, "newCommissioner.ca" },
                    { 281, 41, 2, "https://twitter.com" },
                    { 261, 38, 3, "https://www.facebook.com" },
                    { 262, 38, 4, "https://www.instagram.com" },
                    { 268, 39, 3, "https://www.facebook.com" },
                    { 267, 39, 2, "https://twitter.com" },
                    { 282, 41, 3, "https://www.facebook.com" },
                    { 278, 40, 0, "111-222-3333" },
                    { 264, 38, 0, "111-222-3333" },
                    { 265, 38, 1, "newCommissioner@gmail.com" },
                    { 266, 38, 7, "newCommissioner.ca" },
                    { 277, 40, 6, "https://www.youtube.com" },
                    { 276, 40, 4, "https://www.instagram.com" },
                    { 258, 37, 1, "newCommissioner@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CandidateId", "ContactMethod", "ContactValue" },
                values: new object[,]
                {
                    { 263, 38, 6, "https://www.youtube.com" },
                    { 283, 41, 4, "https://www.instagram.com" },
                    { 288, 42, 2, "https://twitter.com" },
                    { 285, 41, 0, "111-222-3333" },
                    { 289, 42, 3, "https://www.facebook.com" },
                    { 290, 42, 4, "https://www.instagram.com" },
                    { 291, 42, 6, "https://www.youtube.com" },
                    { 284, 41, 6, "https://www.youtube.com" },
                    { 269, 39, 4, "https://www.instagram.com" },
                    { 286, 41, 1, "newCommissioner@gmail.com" },
                    { 270, 39, 6, "https://www.youtube.com" },
                    { 260, 38, 2, "https://twitter.com" },
                    { 279, 40, 1, "newCommissioner@gmail.com" },
                    { 271, 39, 0, "111-222-3333" },
                    { 272, 39, 1, "newCommissioner@gmail.com" },
                    { 287, 41, 7, "newCommissioner.ca" },
                    { 292, 42, 0, "111-222-3333" },
                    { 273, 39, 7, "newCommissioner.ca" },
                    { 275, 40, 3, "https://www.facebook.com" },
                    { 274, 40, 2, "https://twitter.com" },
                    { 280, 40, 7, "newCommissioner.ca" },
                    { 293, 42, 1, "newCommissioner@gmail.com" },
                    { 332, 48, 4, "https://www.instagram.com" },
                    { 295, 43, 2, "https://twitter.com" },
                    { 386, 56, 2, "https://twitter.com" },
                    { 385, 55, 7, "newTrustee.ca" },
                    { 384, 55, 1, "newTrustee@gmail.com" },
                    { 383, 55, 0, "111-222-3333" },
                    { 382, 55, 6, "https://www.youtube.com" },
                    { 381, 55, 4, "https://www.instagram.com" },
                    { 380, 55, 3, "https://www.facebook.com" },
                    { 379, 55, 2, "https://twitter.com" },
                    { 378, 54, 7, "newTrustee.ca" },
                    { 377, 54, 1, "newTrustee@gmail.com" },
                    { 376, 54, 0, "111-222-3333" },
                    { 375, 54, 6, "https://www.youtube.com" },
                    { 374, 54, 4, "https://www.instagram.com" },
                    { 373, 54, 3, "https://www.facebook.com" },
                    { 372, 54, 2, "https://twitter.com" },
                    { 371, 53, 7, "newTrustee.ca" },
                    { 370, 53, 1, "newTrustee@gmail.com" },
                    { 369, 53, 0, "111-222-3333" },
                    { 368, 53, 6, "https://www.youtube.com" },
                    { 367, 53, 4, "https://www.instagram.com" },
                    { 366, 53, 3, "https://www.facebook.com" },
                    { 365, 53, 2, "https://twitter.com" },
                    { 364, 52, 7, "newTrustee.ca" },
                    { 363, 52, 1, "newTrustee@gmail.com" },
                    { 362, 52, 0, "111-222-3333" },
                    { 361, 52, 6, "https://www.youtube.com" },
                    { 360, 52, 4, "https://www.instagram.com" },
                    { 387, 56, 3, "https://www.facebook.com" },
                    { 388, 56, 4, "https://www.instagram.com" },
                    { 389, 56, 6, "https://www.youtube.com" },
                    { 390, 56, 0, "111-222-3333" },
                    { 418, 60, 0, "111-222-3333" },
                    { 417, 60, 6, "https://www.youtube.com" },
                    { 416, 60, 4, "https://www.instagram.com" },
                    { 415, 60, 3, "https://www.facebook.com" },
                    { 414, 60, 2, "https://twitter.com" },
                    { 413, 59, 7, "newTrustee.ca" },
                    { 412, 59, 1, "newTrustee@gmail.com" },
                    { 411, 59, 0, "111-222-3333" },
                    { 410, 59, 6, "https://www.youtube.com" },
                    { 409, 59, 4, "https://www.instagram.com" },
                    { 408, 59, 3, "https://www.facebook.com" },
                    { 407, 59, 2, "https://twitter.com" },
                    { 406, 58, 7, "newTrustee.ca" },
                    { 359, 52, 3, "https://www.facebook.com" },
                    { 405, 58, 1, "newTrustee@gmail.com" },
                    { 403, 58, 6, "https://www.youtube.com" },
                    { 402, 58, 4, "https://www.instagram.com" },
                    { 401, 58, 3, "https://www.facebook.com" },
                    { 400, 58, 2, "https://twitter.com" },
                    { 399, 57, 7, "newTrustee.ca" },
                    { 398, 57, 1, "newTrustee@gmail.com" },
                    { 397, 57, 0, "111-222-3333" },
                    { 396, 57, 6, "https://www.youtube.com" },
                    { 395, 57, 4, "https://www.instagram.com" },
                    { 394, 57, 3, "https://www.facebook.com" },
                    { 393, 57, 2, "https://twitter.com" },
                    { 392, 56, 7, "newTrustee.ca" },
                    { 391, 56, 1, "newTrustee@gmail.com" },
                    { 404, 58, 0, "111-222-3333" },
                    { 358, 52, 2, "https://twitter.com" },
                    { 357, 51, 7, "newTrustee.ca" },
                    { 356, 51, 1, "newTrustee@gmail.com" },
                    { 323, 47, 2, "https://twitter.com" },
                    { 322, 46, 7, "newTrustee.ca" },
                    { 321, 46, 1, "newTrustee@gmail.com" },
                    { 320, 46, 0, "111-222-3333" },
                    { 319, 46, 6, "https://www.youtube.com" },
                    { 318, 46, 4, "https://www.instagram.com" },
                    { 317, 46, 3, "https://www.facebook.com" },
                    { 316, 46, 2, "https://twitter.com" },
                    { 315, 45, 7, "newCommissioner.ca" },
                    { 314, 45, 1, "newCommissioner@gmail.com" },
                    { 313, 45, 0, "111-222-3333" },
                    { 312, 45, 6, "https://www.youtube.com" },
                    { 311, 45, 4, "https://www.instagram.com" },
                    { 324, 47, 3, "https://www.facebook.com" },
                    { 310, 45, 3, "https://www.facebook.com" },
                    { 308, 44, 7, "newCommissioner.ca" },
                    { 307, 44, 1, "newCommissioner@gmail.com" },
                    { 306, 44, 0, "111-222-3333" },
                    { 305, 44, 6, "https://www.youtube.com" },
                    { 304, 44, 4, "https://www.instagram.com" },
                    { 303, 44, 3, "https://www.facebook.com" },
                    { 302, 44, 2, "https://twitter.com" },
                    { 301, 43, 7, "newCommissioner.ca" },
                    { 300, 43, 1, "newCommissioner@gmail.com" },
                    { 299, 43, 0, "111-222-3333" },
                    { 298, 43, 6, "https://www.youtube.com" },
                    { 297, 43, 4, "https://www.instagram.com" },
                    { 296, 43, 3, "https://www.facebook.com" },
                    { 309, 45, 2, "https://twitter.com" },
                    { 294, 42, 7, "newCommissioner.ca" },
                    { 325, 47, 4, "https://www.instagram.com" },
                    { 327, 47, 0, "111-222-3333" },
                    { 355, 51, 0, "111-222-3333" },
                    { 354, 51, 6, "https://www.youtube.com" },
                    { 353, 51, 4, "https://www.instagram.com" },
                    { 352, 51, 3, "https://www.facebook.com" },
                    { 351, 51, 2, "https://twitter.com" },
                    { 350, 50, 7, "newTrustee.ca" },
                    { 349, 50, 1, "newTrustee@gmail.com" },
                    { 348, 50, 0, "111-222-3333" },
                    { 347, 50, 6, "https://www.youtube.com" },
                    { 346, 50, 4, "https://www.instagram.com" },
                    { 345, 50, 3, "https://www.facebook.com" },
                    { 344, 50, 2, "https://twitter.com" },
                    { 343, 49, 7, "newTrustee.ca" },
                    { 326, 47, 6, "https://www.youtube.com" },
                    { 342, 49, 1, "newTrustee@gmail.com" },
                    { 340, 49, 6, "https://www.youtube.com" },
                    { 339, 49, 4, "https://www.instagram.com" },
                    { 338, 49, 3, "https://www.facebook.com" },
                    { 337, 49, 2, "https://twitter.com" },
                    { 336, 48, 7, "newTrustee.ca" },
                    { 335, 48, 1, "newTrustee@gmail.com" },
                    { 334, 48, 0, "111-222-3333" },
                    { 333, 48, 6, "https://www.youtube.com" },
                    { 257, 37, 0, "111-222-3333" },
                    { 331, 48, 3, "https://www.facebook.com" },
                    { 330, 48, 2, "https://twitter.com" },
                    { 329, 47, 7, "newTrustee.ca" },
                    { 328, 47, 1, "newTrustee@gmail.com" },
                    { 341, 49, 0, "111-222-3333" },
                    { 256, 37, 6, "https://www.youtube.com" },
                    { 420, 60, 7, "newTrustee.ca" },
                    { 254, 37, 3, "https://www.facebook.com" },
                    { 93, 14, 3, "https://www.facebook.com" },
                    { 92, 14, 2, "https://twitter.com" },
                    { 91, 13, 7, "newCouncillor.ca" },
                    { 90, 13, 1, "newCouncillor@gmail.com" },
                    { 89, 13, 0, "111-222-3333" },
                    { 88, 13, 6, "https://www.youtube.com" },
                    { 87, 13, 4, "https://www.instagram.com" },
                    { 86, 13, 3, "https://www.facebook.com" },
                    { 85, 13, 2, "https://twitter.com" },
                    { 84, 12, 7, "newCouncillor.ca" },
                    { 83, 12, 1, "newCouncillor@gmail.com" },
                    { 82, 12, 0, "111-222-3333" },
                    { 81, 12, 6, "https://www.youtube.com" },
                    { 94, 14, 4, "https://www.instagram.com" },
                    { 80, 12, 4, "https://www.instagram.com" },
                    { 78, 12, 2, "https://twitter.com" },
                    { 77, 11, 7, "newCouncillor.ca" },
                    { 76, 11, 1, "newCouncillor@gmail.com" },
                    { 75, 11, 0, "111-222-3333" },
                    { 74, 11, 6, "https://www.youtube.com" },
                    { 73, 11, 4, "https://www.instagram.com" },
                    { 72, 11, 3, "https://www.facebook.com" },
                    { 71, 11, 2, "https://twitter.com" },
                    { 70, 10, 7, "newCouncillor.ca" },
                    { 69, 10, 1, "newCouncillor@gmail.com" },
                    { 68, 10, 0, "111-222-3333" },
                    { 67, 10, 6, "https://www.youtube.com" },
                    { 66, 10, 4, "https://www.instagram.com" },
                    { 79, 12, 3, "https://www.facebook.com" },
                    { 65, 10, 3, "https://www.facebook.com" },
                    { 95, 14, 6, "https://www.youtube.com" },
                    { 97, 14, 1, "newCouncillor@gmail.com" },
                    { 125, 18, 1, "newCouncillor@gmail.com" },
                    { 124, 18, 0, "111-222-3333" },
                    { 123, 18, 6, "https://www.youtube.com" },
                    { 122, 18, 4, "https://www.instagram.com" },
                    { 121, 18, 3, "https://www.facebook.com" },
                    { 120, 18, 2, "https://twitter.com" },
                    { 119, 17, 7, "newCouncillor.ca" },
                    { 118, 17, 1, "newCouncillor@gmail.com" },
                    { 117, 17, 0, "111-222-3333" },
                    { 116, 17, 6, "https://www.youtube.com" },
                    { 115, 17, 4, "https://www.instagram.com" },
                    { 114, 17, 3, "https://www.facebook.com" },
                    { 113, 17, 2, "https://twitter.com" },
                    { 96, 14, 0, "111-222-3333" },
                    { 112, 16, 7, "newCouncillor.ca" },
                    { 110, 16, 0, "111-222-3333" },
                    { 109, 16, 6, "https://www.youtube.com" },
                    { 108, 16, 4, "https://www.instagram.com" },
                    { 107, 16, 3, "https://www.facebook.com" },
                    { 106, 16, 2, "https://twitter.com" },
                    { 255, 37, 4, "https://www.instagram.com" },
                    { 104, 15, 1, "newCouncillor@gmail.com" },
                    { 103, 15, 0, "111-222-3333" },
                    { 102, 15, 6, "https://www.youtube.com" },
                    { 101, 15, 4, "https://www.instagram.com" },
                    { 100, 15, 3, "https://www.facebook.com" },
                    { 99, 15, 2, "https://twitter.com" },
                    { 98, 14, 7, "newCouncillor.ca" },
                    { 111, 16, 1, "newCouncillor@gmail.com" },
                    { 64, 10, 2, "https://twitter.com" },
                    { 63, 9, 7, "newCouncillor.ca" },
                    { 62, 9, 1, "newCouncillor@gmail.com" },
                    { 28, 4, 7, "newCouncillor.ca" },
                    { 27, 4, 1, "newCouncillor@gmail.com" },
                    { 26, 4, 0, "111-222-3333" },
                    { 25, 4, 6, "https://www.youtube.com" },
                    { 24, 4, 4, "https://www.instagram.com" },
                    { 23, 4, 3, "https://www.facebook.com" },
                    { 22, 4, 2, "https://twitter.com" },
                    { 21, 3, 7, "newCouncillor.ca" },
                    { 20, 3, 1, "newCouncillor@gmail.com" },
                    { 19, 3, 0, "111-222-3333" },
                    { 18, 3, 6, "https://www.youtube.com" },
                    { 17, 3, 4, "https://www.instagram.com" },
                    { 16, 3, 3, "https://www.facebook.com" },
                    { 29, 5, 2, "https://twitter.com" },
                    { 15, 3, 2, "https://twitter.com" },
                    { 13, 2, 1, "newCouncillor@gmail.com" },
                    { 12, 2, 0, "111-222-3333" },
                    { 11, 2, 6, "https://www.youtube.com" },
                    { 10, 2, 4, "https://www.instagram.com" },
                    { 9, 2, 3, "https://www.facebook.com" },
                    { 8, 2, 2, "https://twitter.com" },
                    { 7, 1, 7, "newCouncillor.ca" },
                    { 6, 1, 1, "newCouncillor@gmail.com" },
                    { 5, 1, 0, "111-222-3333" },
                    { 4, 1, 6, "https://www.youtube.com" },
                    { 3, 1, 4, "https://www.instagram.com" },
                    { 2, 1, 3, "https://www.facebook.com" },
                    { 1, 1, 2, "https://twitter.com" },
                    { 14, 2, 7, "newCouncillor.ca" },
                    { 30, 5, 3, "https://www.facebook.com" },
                    { 31, 5, 4, "https://www.instagram.com" },
                    { 32, 5, 6, "https://www.youtube.com" },
                    { 61, 9, 0, "111-222-3333" },
                    { 60, 9, 6, "https://www.youtube.com" },
                    { 59, 9, 4, "https://www.instagram.com" },
                    { 58, 9, 3, "https://www.facebook.com" },
                    { 57, 9, 2, "https://twitter.com" },
                    { 56, 8, 7, "newCouncillor.ca" },
                    { 55, 8, 1, "newCouncillor@gmail.com" },
                    { 54, 8, 0, "111-222-3333" },
                    { 53, 8, 6, "https://www.youtube.com" },
                    { 52, 8, 4, "https://www.instagram.com" },
                    { 51, 8, 3, "https://www.facebook.com" },
                    { 50, 8, 2, "https://twitter.com" },
                    { 49, 7, 7, "newCouncillor.ca" },
                    { 48, 7, 1, "newCouncillor@gmail.com" },
                    { 47, 7, 0, "111-222-3333" },
                    { 46, 7, 6, "https://www.youtube.com" },
                    { 45, 7, 4, "https://www.instagram.com" },
                    { 44, 7, 3, "https://www.facebook.com" },
                    { 43, 7, 2, "https://twitter.com" },
                    { 42, 6, 7, "newCouncillor.ca" },
                    { 41, 6, 1, "newCouncillor@gmail.com" },
                    { 40, 6, 0, "111-222-3333" },
                    { 39, 6, 6, "https://www.youtube.com" },
                    { 38, 6, 4, "https://www.instagram.com" },
                    { 37, 6, 3, "https://www.facebook.com" },
                    { 36, 6, 2, "https://twitter.com" },
                    { 35, 5, 7, "newCouncillor.ca" },
                    { 34, 5, 1, "newCouncillor@gmail.com" },
                    { 33, 5, 0, "111-222-3333" },
                    { 126, 18, 7, "newCouncillor.ca" },
                    { 127, 19, 2, "https://twitter.com" },
                    { 105, 15, 7, "newCouncillor.ca" },
                    { 129, 19, 4, "https://www.instagram.com" },
                    { 221, 32, 6, "https://www.youtube.com" },
                    { 220, 32, 4, "https://www.instagram.com" },
                    { 219, 32, 3, "https://www.facebook.com" },
                    { 218, 32, 2, "https://twitter.com" },
                    { 217, 31, 7, "newCommissioner.ca" },
                    { 216, 31, 1, "newCommissioner@gmail.com" },
                    { 215, 31, 0, "111-222-3333" },
                    { 128, 19, 3, "https://www.facebook.com" },
                    { 213, 31, 4, "https://www.instagram.com" },
                    { 212, 31, 3, "https://www.facebook.com" },
                    { 211, 31, 2, "https://twitter.com" },
                    { 210, 30, 7, "newMayor.ca" },
                    { 209, 30, 1, "newMayor@gmail.com" },
                    { 222, 32, 0, "111-222-3333" },
                    { 208, 30, 0, "111-222-3333" },
                    { 206, 30, 4, "https://www.instagram.com" },
                    { 205, 30, 3, "https://www.facebook.com" },
                    { 204, 30, 2, "https://twitter.com" },
                    { 203, 29, 7, "newMayor.ca" },
                    { 202, 29, 1, "newMayor@gmail.com" },
                    { 201, 29, 0, "111-222-3333" },
                    { 200, 29, 6, "https://www.youtube.com" },
                    { 199, 29, 4, "https://www.instagram.com" },
                    { 198, 29, 3, "https://www.facebook.com" },
                    { 197, 29, 2, "https://twitter.com" },
                    { 419, 60, 1, "newTrustee@gmail.com" },
                    { 196, 28, 7, "newMayor.ca" },
                    { 195, 28, 1, "newMayor@gmail.com" },
                    { 207, 30, 6, "https://www.youtube.com" },
                    { 194, 28, 0, "111-222-3333" },
                    { 223, 32, 1, "newCommissioner@gmail.com" },
                    { 225, 33, 2, "https://twitter.com" },
                    { 253, 37, 2, "https://twitter.com" },
                    { 252, 36, 7, "newCommissioner.ca" },
                    { 251, 36, 1, "newCommissioner@gmail.com" },
                    { 250, 36, 0, "111-222-3333" },
                    { 249, 36, 6, "https://www.youtube.com" },
                    { 248, 36, 4, "https://www.instagram.com" },
                    { 247, 36, 3, "https://www.facebook.com" },
                    { 246, 36, 2, "https://twitter.com" },
                    { 245, 35, 7, "newCommissioner.ca" },
                    { 244, 35, 1, "newCommissioner@gmail.com" },
                    { 243, 35, 0, "111-222-3333" },
                    { 242, 35, 6, "https://www.youtube.com" },
                    { 241, 35, 4, "https://www.instagram.com" },
                    { 224, 32, 7, "newCommissioner.ca" },
                    { 240, 35, 3, "https://www.facebook.com" },
                    { 238, 34, 7, "newCommissioner.ca" },
                    { 237, 34, 1, "newCommissioner@gmail.com" },
                    { 236, 34, 0, "111-222-3333" },
                    { 235, 34, 6, "https://www.youtube.com" },
                    { 234, 34, 4, "https://www.instagram.com" },
                    { 233, 34, 3, "https://www.facebook.com" },
                    { 232, 34, 2, "https://twitter.com" },
                    { 231, 33, 7, "newCommissioner.ca" },
                    { 230, 33, 1, "newCommissioner@gmail.com" },
                    { 229, 33, 0, "111-222-3333" },
                    { 228, 33, 6, "https://www.youtube.com" },
                    { 227, 33, 4, "https://www.instagram.com" },
                    { 226, 33, 3, "https://www.facebook.com" },
                    { 239, 35, 2, "https://twitter.com" },
                    { 193, 28, 6, "https://www.youtube.com" },
                    { 214, 31, 6, "https://www.youtube.com" },
                    { 191, 28, 3, "https://www.facebook.com" },
                    { 157, 23, 4, "https://www.instagram.com" },
                    { 156, 23, 3, "https://www.facebook.com" },
                    { 155, 23, 2, "https://twitter.com" },
                    { 154, 22, 7, "newMayor.ca" },
                    { 153, 22, 1, "newMayor@gmail.com" },
                    { 152, 22, 0, "111-222-3333" },
                    { 151, 22, 6, "https://www.youtube.com" },
                    { 150, 22, 4, "https://www.instagram.com" },
                    { 149, 22, 3, "https://www.facebook.com" },
                    { 148, 22, 2, "https://twitter.com" },
                    { 147, 21, 7, "newMayor.ca" },
                    { 146, 21, 1, "newMayor@gmail.com" },
                    { 145, 21, 0, "111-222-3333" },
                    { 158, 23, 6, "https://www.youtube.com" },
                    { 144, 21, 6, "https://www.youtube.com" },
                    { 142, 21, 3, "https://www.facebook.com" },
                    { 141, 21, 2, "https://twitter.com" },
                    { 140, 20, 7, "newCouncillor.ca" },
                    { 139, 20, 1, "newCouncillor@gmail.com" },
                    { 138, 20, 0, "111-222-3333" },
                    { 192, 28, 4, "https://www.instagram.com" },
                    { 136, 20, 4, "https://www.instagram.com" },
                    { 135, 20, 3, "https://www.facebook.com" },
                    { 134, 20, 2, "https://twitter.com" },
                    { 133, 19, 7, "newCouncillor.ca" },
                    { 132, 19, 1, "newCouncillor@gmail.com" },
                    { 131, 19, 0, "111-222-3333" },
                    { 130, 19, 6, "https://www.youtube.com" },
                    { 143, 21, 4, "https://www.instagram.com" },
                    { 159, 23, 0, "111-222-3333" },
                    { 137, 20, 6, "https://www.youtube.com" },
                    { 161, 23, 7, "newMayor.ca" },
                    { 190, 28, 2, "https://twitter.com" },
                    { 189, 27, 7, "newMayor.ca" },
                    { 188, 27, 1, "newMayor@gmail.com" },
                    { 187, 27, 0, "111-222-3333" },
                    { 186, 27, 6, "https://www.youtube.com" },
                    { 185, 27, 4, "https://www.instagram.com" },
                    { 184, 27, 3, "https://www.facebook.com" },
                    { 183, 27, 2, "https://twitter.com" },
                    { 182, 26, 7, "newMayor.ca" },
                    { 181, 26, 1, "newMayor@gmail.com" },
                    { 180, 26, 0, "111-222-3333" },
                    { 179, 26, 6, "https://www.youtube.com" },
                    { 177, 26, 3, "https://www.facebook.com" },
                    { 176, 26, 2, "https://twitter.com" },
                    { 178, 26, 4, "https://www.instagram.com" },
                    { 174, 25, 1, "newMayor@gmail.com" },
                    { 162, 24, 2, "https://twitter.com" },
                    { 163, 24, 3, "https://www.facebook.com" },
                    { 164, 24, 4, "https://www.instagram.com" },
                    { 165, 24, 6, "https://www.youtube.com" },
                    { 175, 25, 7, "newMayor.ca" },
                    { 167, 24, 1, "newMayor@gmail.com" },
                    { 166, 24, 0, "111-222-3333" },
                    { 169, 25, 2, "https://twitter.com" },
                    { 170, 25, 3, "https://www.facebook.com" },
                    { 171, 25, 4, "https://www.instagram.com" },
                    { 172, 25, 6, "https://www.youtube.com" },
                    { 173, 25, 0, "111-222-3333" },
                    { 168, 24, 7, "newMayor.ca" },
                    { 160, 23, 1, "newMayor@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "IssueOptions",
                columns: new[] { "IssueOptionId", "BallotIssueId", "IssueOptionInfo" },
                values: new object[,]
                {
                    { 6, 3, "No" },
                    { 2, 1, "No" },
                    { 3, 2, "Yes" },
                    { 4, 2, "No" },
                    { 5, 3, "Yes" },
                    { 1, 1, "Yes" }
                });

            migrationBuilder.InsertData(
                table: "PollingPlaceDates",
                columns: new[] { "PollingDateId", "EndTime", "PollingDate", "PollingPlaceId", "StartTime" },
                values: new object[,]
                {
                    { 33, new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BallotIssues_ElectionId",
                table: "BallotIssues",
                column: "ElectionId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateDetails_CandidateId",
                table: "CandidateDetails",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateRaces_CandidateId",
                table: "CandidateRaces",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateRaces_RaceId",
                table: "CandidateRaces",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_ElectionId",
                table: "Candidates",
                column: "ElectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_OrganizationId",
                table: "Candidates",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CandidateId",
                table: "Contacts",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_IssueOptions_BallotIssueId",
                table: "IssueOptions",
                column: "BallotIssueId");

            migrationBuilder.CreateIndex(
                name: "IX_OGAudio_OpenGraphId",
                table: "OGAudio",
                column: "OpenGraphId");

            migrationBuilder.CreateIndex(
                name: "IX_OGImage_OpenGraphId",
                table: "OGImage",
                column: "OpenGraphId");

            migrationBuilder.CreateIndex(
                name: "IX_OGVideo_OpenGraphId",
                table: "OGVideo",
                column: "OpenGraphId");

            migrationBuilder.CreateIndex(
                name: "IX_PollingPlaceDates_PollingPlaceId",
                table: "PollingPlaceDates",
                column: "PollingPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_PollingPlaces_ElectionId",
                table: "PollingPlaces",
                column: "ElectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_ElectionId",
                table: "Races",
                column: "ElectionId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_ElectionId",
                table: "SocialMedias",
                column: "ElectionId");

            migrationBuilder.CreateIndex(
                name: "IX_StateSingleton_ManagedElectionID",
                table: "StateSingleton",
                column: "ManagedElectionID");

            migrationBuilder.CreateIndex(
                name: "IX_StateSingleton_RunningElectionID",
                table: "StateSingleton",
                column: "RunningElectionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CandidateDetails");

            migrationBuilder.DropTable(
                name: "CandidateRaces");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "IssueOptions");

            migrationBuilder.DropTable(
                name: "OGAudio");

            migrationBuilder.DropTable(
                name: "OGImage");

            migrationBuilder.DropTable(
                name: "OGVideo");

            migrationBuilder.DropTable(
                name: "PollingPlaceDates");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "StateSingleton");

            migrationBuilder.DropTable(
                name: "Steps");

            migrationBuilder.DropTable(
                name: "Themes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "Candidates");

            migrationBuilder.DropTable(
                name: "BallotIssues");

            migrationBuilder.DropTable(
                name: "OpenGraph");

            migrationBuilder.DropTable(
                name: "PollingPlaces");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Elections");
        }
    }
}
