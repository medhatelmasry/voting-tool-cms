using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class M2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Selected",
                table: "Themes",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "ThemeName",
                table: "Themes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "StepTitle",
                table: "Steps",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StepNumber",
                table: "Steps",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "StepDescription",
                table: "Steps",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ElectionId",
                table: "Steps",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Steps",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "RunningElectionID",
                table: "StateSingleton",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "ManagedElectionID",
                table: "StateSingleton",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "StateId",
                table: "StateSingleton",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "SocialMedias",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MediaName",
                table: "SocialMedias",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Link",
                table: "SocialMedias",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "ElectionId",
                table: "SocialMedias",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "SocialMedias",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "PositionName",
                table: "Races",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "NumberNeeded",
                table: "Races",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "ElectionId",
                table: "Races",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Races",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BallotOrder",
                table: "Races",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "RaceId",
                table: "Races",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "WheelchairInfo",
                table: "PollingPlaces",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PollingStationName",
                table: "PollingPlaces",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PollingPlaceName",
                table: "PollingPlaces",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "PollingPlaces",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ParkingInfo",
                table: "PollingPlaces",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Longitude",
                table: "PollingPlaces",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<string>(
                name: "LocalArea",
                table: "PollingPlaces",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Latitude",
                table: "PollingPlaces",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "PollingPlaces",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ElectionId",
                table: "PollingPlaces",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<bool>(
                name: "AdvanceOnly",
                table: "PollingPlaces",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "PollingPlaces",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PollingPlaceId",
                table: "PollingPlaces",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "PollingPlaceDates",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "PollingPlaceId",
                table: "PollingPlaceDates",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PollingDate",
                table: "PollingPlaceDates",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "PollingPlaceDates",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "PollingDateId",
                table: "PollingPlaceDates",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Organizations",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Organizations",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrganizationId",
                table: "Organizations",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "URL",
                table: "OpenGraph",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "OpenGraph",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SiteName",
                table: "OpenGraph",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Locale",
                table: "OpenGraph",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "OpenGraph",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Determiner",
                table: "OpenGraph",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OpenGraphId",
                table: "OpenGraph",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Width",
                table: "OGVideo",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "OGVideo",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SecureURL",
                table: "OGVideo",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OpenGraphId",
                table: "OGVideo",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Height",
                table: "OGVideo",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "OGVideo",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OGVideoID",
                table: "OGVideo",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Width",
                table: "OGImage",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "OGImage",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SecureURL",
                table: "OGImage",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OpenGraphId",
                table: "OGImage",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Height",
                table: "OGImage",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "OGImage",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Alt",
                table: "OGImage",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OGImageId",
                table: "OGImage",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "OGAudio",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SecureURL",
                table: "OGAudio",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OpenGraphId",
                table: "OGAudio",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "OGAudio",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "OGAudio",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OGAudioID",
                table: "OGAudio",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "IssueOptionInfo",
                table: "IssueOptions",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BallotIssueId",
                table: "IssueOptions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "IssueOptionId",
                table: "IssueOptions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Images",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Images",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ThemeName",
                table: "Images",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Placement",
                table: "Images",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Format",
                table: "Images",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Images",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Images",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Elections",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Elections",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "ElectionName",
                table: "Elections",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Elections",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ElectionId",
                table: "Elections",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "ContactValue",
                table: "Contacts",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ContactMethod",
                table: "Contacts",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "CandidateId",
                table: "Contacts",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "ContactId",
                table: "Contacts",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                table: "Candidates",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "OrganizationId",
                table: "Candidates",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Candidates",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ElectionId",
                table: "Candidates",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "CandidateId",
                table: "Candidates",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "RaceId",
                table: "CandidateRaces",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "CandidateId",
                table: "CandidateRaces",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "BallotOrder",
                table: "CandidateRaces",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "CandidateRaceId",
                table: "CandidateRaces",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "CandidateDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "CandidateDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Lang",
                table: "CandidateDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Format",
                table: "CandidateDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "CandidateId",
                table: "CandidateDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "CandidateDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "ElectionId",
                table: "BallotIssues",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "BallotIssues",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BallotIssueTitle",
                table: "BallotIssues",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BallotIssueId",
                table: "BallotIssues",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "AspNetUserTokens",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "TwoFactorEnabled",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "SecurityStamp",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "LockoutEnabled",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<bool>(
                name: "EmailConfirmed",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ConcurrencyStamp",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AccessFailedCount",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "AspNetUserRoles",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserRoles",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderDisplayName",
                table: "AspNetUserLogins",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserClaims",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "ClaimValue",
                table: "AspNetUserClaims",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClaimType",
                table: "AspNetUserClaims",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AspNetUserClaims",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "AspNetRoles",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetRoles",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ConcurrencyStamp",
                table: "AspNetRoles",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AspNetRoles",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "AspNetRoleClaims",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "ClaimValue",
                table: "AspNetRoleClaims",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClaimType",
                table: "AspNetRoleClaims",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AspNetRoleClaims",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.UpdateData(
                table: "Elections",
                keyColumn: "ElectionId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Elections",
                keyColumn: "ElectionId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2019, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 1,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 2,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 3,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 4,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 5,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 6,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 7,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 8,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 9,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 10,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 11,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 12,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 13,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 14,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 15,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 16,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 17,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 18,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 19,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 20,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 21,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 22,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 23,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 24,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 25,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 26,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 27,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 28,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 29,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 30,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 31,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 32,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 33,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 34,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 35,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 36,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 37,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 38,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 39,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 7, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 40,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { new DateTime(2018, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 1,
                column: "AdvanceOnly",
                value: false);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 2,
                column: "AdvanceOnly",
                value: false);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 3,
                column: "AdvanceOnly",
                value: false);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 4,
                column: "AdvanceOnly",
                value: false);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 5,
                column: "AdvanceOnly",
                value: false);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 6,
                column: "AdvanceOnly",
                value: false);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 7,
                column: "AdvanceOnly",
                value: false);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 8,
                column: "AdvanceOnly",
                value: false);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 9,
                column: "AdvanceOnly",
                value: false);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 10,
                column: "AdvanceOnly",
                value: false);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 11,
                column: "AdvanceOnly",
                value: false);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 12,
                column: "AdvanceOnly",
                value: false);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 13,
                column: "AdvanceOnly",
                value: false);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 14,
                column: "AdvanceOnly",
                value: false);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 15,
                column: "AdvanceOnly",
                value: false);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 16,
                column: "AdvanceOnly",
                value: false);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 17,
                column: "AdvanceOnly",
                value: false);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 18,
                column: "AdvanceOnly",
                value: false);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 19,
                column: "AdvanceOnly",
                value: false);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 20,
                column: "AdvanceOnly",
                value: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Selected",
                table: "Themes",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "ThemeName",
                table: "Themes",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "StepTitle",
                table: "Steps",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StepNumber",
                table: "Steps",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "StepDescription",
                table: "Steps",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ElectionId",
                table: "Steps",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Steps",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "RunningElectionID",
                table: "StateSingleton",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ManagedElectionID",
                table: "StateSingleton",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "StateId",
                table: "StateSingleton",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "SocialMedias",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MediaName",
                table: "SocialMedias",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Link",
                table: "SocialMedias",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "ElectionId",
                table: "SocialMedias",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "SocialMedias",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "PositionName",
                table: "Races",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "NumberNeeded",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ElectionId",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Races",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BallotOrder",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "RaceId",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "WheelchairInfo",
                table: "PollingPlaces",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PollingStationName",
                table: "PollingPlaces",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PollingPlaceName",
                table: "PollingPlaces",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "PollingPlaces",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ParkingInfo",
                table: "PollingPlaces",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Longitude",
                table: "PollingPlaces",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "LocalArea",
                table: "PollingPlaces",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Latitude",
                table: "PollingPlaces",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "PollingPlaces",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ElectionId",
                table: "PollingPlaces",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AdvanceOnly",
                table: "PollingPlaces",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "PollingPlaces",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PollingPlaceId",
                table: "PollingPlaces",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "StartTime",
                table: "PollingPlaceDates",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "PollingPlaceId",
                table: "PollingPlaceDates",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "PollingDate",
                table: "PollingPlaceDates",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "EndTime",
                table: "PollingPlaceDates",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "PollingDateId",
                table: "PollingPlaceDates",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Organizations",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Organizations",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrganizationId",
                table: "Organizations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "URL",
                table: "OpenGraph",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "OpenGraph",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SiteName",
                table: "OpenGraph",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Locale",
                table: "OpenGraph",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "OpenGraph",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Determiner",
                table: "OpenGraph",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OpenGraphId",
                table: "OpenGraph",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Width",
                table: "OGVideo",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "OGVideo",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SecureURL",
                table: "OGVideo",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OpenGraphId",
                table: "OGVideo",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Height",
                table: "OGVideo",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "OGVideo",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OGVideoID",
                table: "OGVideo",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Width",
                table: "OGImage",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "OGImage",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SecureURL",
                table: "OGImage",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OpenGraphId",
                table: "OGImage",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Height",
                table: "OGImage",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "OGImage",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Alt",
                table: "OGImage",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OGImageId",
                table: "OGImage",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "OGAudio",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SecureURL",
                table: "OGAudio",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OpenGraphId",
                table: "OGAudio",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "OGAudio",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "OGAudio",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OGAudioID",
                table: "OGAudio",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "IssueOptionInfo",
                table: "IssueOptions",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BallotIssueId",
                table: "IssueOptions",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "IssueOptionId",
                table: "IssueOptions",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Images",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Images",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ThemeName",
                table: "Images",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Placement",
                table: "Images",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Format",
                table: "Images",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Images",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Images",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "StartDate",
                table: "Elections",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "EndDate",
                table: "Elections",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "ElectionName",
                table: "Elections",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Elections",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ElectionId",
                table: "Elections",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "ContactValue",
                table: "Contacts",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ContactMethod",
                table: "Contacts",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CandidateId",
                table: "Contacts",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ContactId",
                table: "Contacts",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                table: "Candidates",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "OrganizationId",
                table: "Candidates",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Candidates",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ElectionId",
                table: "Candidates",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CandidateId",
                table: "Candidates",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "RaceId",
                table: "CandidateRaces",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CandidateId",
                table: "CandidateRaces",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "BallotOrder",
                table: "CandidateRaces",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CandidateRaceId",
                table: "CandidateRaces",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "CandidateDetails",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "CandidateDetails",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Lang",
                table: "CandidateDetails",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Format",
                table: "CandidateDetails",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CandidateId",
                table: "CandidateDetails",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "CandidateDetails",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "ElectionId",
                table: "BallotIssues",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "BallotIssues",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BallotIssueTitle",
                table: "BallotIssues",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BallotIssueId",
                table: "BallotIssues",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "AspNetUserTokens",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "TEXT",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "TEXT",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserTokens",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "TEXT",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TwoFactorEnabled",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "SecurityStamp",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "AspNetUsers",
                type: "TEXT",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "AspNetUsers",
                type: "TEXT",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LockoutEnd",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LockoutEnabled",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "EmailConfirmed",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "TEXT",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ConcurrencyStamp",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AccessFailedCount",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "AspNetUserRoles",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserRoles",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserLogins",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderDisplayName",
                table: "AspNetUserLogins",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "TEXT",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "TEXT",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserClaims",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ClaimValue",
                table: "AspNetUserClaims",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClaimType",
                table: "AspNetUserClaims",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AspNetUserClaims",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "AspNetRoles",
                type: "TEXT",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetRoles",
                type: "TEXT",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ConcurrencyStamp",
                table: "AspNetRoles",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AspNetRoles",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "AspNetRoleClaims",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ClaimValue",
                table: "AspNetRoleClaims",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClaimType",
                table: "AspNetRoleClaims",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AspNetRoleClaims",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.UpdateData(
                table: "Elections",
                keyColumn: "ElectionId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { "2019-10-21 00:00:00", "2018-09-14 00:00:00" });

            migrationBuilder.UpdateData(
                table: "Elections",
                keyColumn: "ElectionId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { "2019-10-21 00:00:00", "2019-10-21 00:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 1,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 13:00:00", "2018-05-16 00:00:00", "2018-05-16 07:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 2,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 20:00:00", "2018-05-16 00:00:00", "2018-05-16 15:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 3,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 13:00:00", "2018-05-16 00:00:00", "2018-05-16 07:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 4,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 20:00:00", "2018-05-16 00:00:00", "2018-05-16 15:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 5,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 13:00:00", "2018-05-16 00:00:00", "2018-05-16 07:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 6,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 20:00:00", "2018-05-16 00:00:00", "2018-05-16 15:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 7,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 13:00:00", "2018-05-16 00:00:00", "2018-05-16 07:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 8,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 20:00:00", "2018-05-16 00:00:00", "2018-05-16 15:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 9,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 13:00:00", "2018-05-16 00:00:00", "2018-05-16 07:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 10,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 20:00:00", "2018-05-16 00:00:00", "2018-05-16 15:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 11,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 13:00:00", "2018-05-16 00:00:00", "2018-05-16 07:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 12,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 20:00:00", "2018-05-16 00:00:00", "2018-05-16 15:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 13,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 13:00:00", "2018-05-16 00:00:00", "2018-05-16 07:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 14,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 20:00:00", "2018-05-16 00:00:00", "2018-05-16 15:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 15,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 13:00:00", "2018-05-16 00:00:00", "2018-05-16 07:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 16,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 20:00:00", "2018-05-16 00:00:00", "2018-05-16 15:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 17,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 13:00:00", "2018-05-16 00:00:00", "2018-05-16 07:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 18,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 20:00:00", "2018-05-16 00:00:00", "2018-05-16 15:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 19,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 13:00:00", "2018-05-16 00:00:00", "2018-05-16 07:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 20,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 20:00:00", "2018-05-16 00:00:00", "2018-05-16 15:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 21,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 13:00:00", "2018-05-16 00:00:00", "2018-05-16 07:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 22,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 20:00:00", "2018-05-16 00:00:00", "2018-05-16 15:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 23,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 13:00:00", "2018-05-16 00:00:00", "2018-05-16 07:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 24,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 20:00:00", "2018-05-16 00:00:00", "2018-05-16 15:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 25,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 13:00:00", "2018-05-16 00:00:00", "2018-05-16 07:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 26,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 20:00:00", "2018-05-16 00:00:00", "2018-05-16 15:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 27,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 13:00:00", "2018-05-16 00:00:00", "2018-05-16 07:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 28,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 20:00:00", "2018-05-16 00:00:00", "2018-05-16 15:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 29,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 13:00:00", "2018-05-16 00:00:00", "2018-05-16 07:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 30,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 20:00:00", "2018-05-16 00:00:00", "2018-05-16 15:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 31,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 13:00:00", "2018-05-16 00:00:00", "2018-05-16 07:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 32,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 20:00:00", "2018-05-16 00:00:00", "2018-05-16 15:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 33,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 13:00:00", "2018-05-16 00:00:00", "2018-05-16 07:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 34,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 20:00:00", "2018-05-16 00:00:00", "2018-05-16 15:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 35,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 13:00:00", "2018-05-16 00:00:00", "2018-05-16 07:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 36,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 20:00:00", "2018-05-16 00:00:00", "2018-05-16 15:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 37,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 13:00:00", "2018-05-16 00:00:00", "2018-05-16 07:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 38,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 20:00:00", "2018-05-16 00:00:00", "2018-05-16 15:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 39,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 13:00:00", "2018-05-16 00:00:00", "2018-05-16 07:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaceDates",
                keyColumn: "PollingDateId",
                keyValue: 40,
                columns: new[] { "EndTime", "PollingDate", "StartTime" },
                values: new object[] { "2018-05-16 20:00:00", "2018-05-16 00:00:00", "2018-05-16 15:00:00" });

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 1,
                column: "AdvanceOnly",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 2,
                column: "AdvanceOnly",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 3,
                column: "AdvanceOnly",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 4,
                column: "AdvanceOnly",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 5,
                column: "AdvanceOnly",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 6,
                column: "AdvanceOnly",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 7,
                column: "AdvanceOnly",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 8,
                column: "AdvanceOnly",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 9,
                column: "AdvanceOnly",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 10,
                column: "AdvanceOnly",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 11,
                column: "AdvanceOnly",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 12,
                column: "AdvanceOnly",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 13,
                column: "AdvanceOnly",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 14,
                column: "AdvanceOnly",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 15,
                column: "AdvanceOnly",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 16,
                column: "AdvanceOnly",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 17,
                column: "AdvanceOnly",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 18,
                column: "AdvanceOnly",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 19,
                column: "AdvanceOnly",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PollingPlaces",
                keyColumn: "PollingPlaceId",
                keyValue: 20,
                column: "AdvanceOnly",
                value: 0);
        }
    }
}
