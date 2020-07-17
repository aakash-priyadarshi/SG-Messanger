//Use DoughouzChecker last version 3.0 to 
//build your own certifcate 
//For Full Documention 
//https://paper.dropbox.com/doc/WoWonder-Messenger-2.0--ARqO4OoLf_KXGWT63gNm0pOuAQ-M6qrJYGQ0C0NZlhZ3PqI7
//CopyRight DoughouzLight
//For the accuracy of the icon and logo, please use this website " http://nsimage.brosteins.com " and add images according to size in folders " mipmap " 

using WoWonder.Helpers.Model;

namespace WoWonder
{
    public static class AppSettings
    {
        public static string TripleDesAppServiceProvider = "RAGzcFa2766TwHnA6YJ1LjOmK6c7JqPMvmpA7IhjlBbH0yDoUu4JH0KNkQzpkpz6Qduuco4q2Kqcfh6bjqUtlI1IaW/SCKnBlkPBYFi3NWc8+iOHFAB2FrJ/QvGmx1lSoRb2YlqUfl1jAVBOQOTn5VEV3iJUGjZ1epVLDsGmX5Sm1E8wLq4DH5KGS7RWlVDZcmF1HQTUuhQfd3xXI7HBb0bpI2Pz7fzzkzcDnParZDTNVgI2ruV82WR06WLFH4Ph";

        //Main Settings >>>>>
        //*********************************************************

        public static string Version = "1.0"; 
        public static string ApplicationName = "SG Messenger";

        // Friend system = 0 , follow system = 1
        public static int ConnectivitySystem = 1;
        
        public static SystemApiGetLastChat LastChatSystem = SystemApiGetLastChat.Old; //(Recommended)

        //Main Colors >>
        //*********************************************************
        public static string MainColor = "#a84849"; 
        public static string StoryReadColor = "#808080";

        //Language Settings >> http://www.lingoes.net/en/translator/langcode.htm
        //*********************************************************
        public static bool FlowDirectionRightToLeft = false; 
        public static string Lang = ""; //Default language ar_AE

        //Set Language User on site from phone 
        public static bool SetLangUser = true;  //#New

        //Notification Settings >>
        //*********************************************************
        public static bool ShowNotification = true;
        public static string OneSignalAppId = "ed3f5580-0087-4a3c-8885-0523989b68c8"; 
         
        //Error Report Mode
        //*********************************************************
        public static bool SetApisReportMode = false; 

        //Code Time Zone (true => Get from Internet , false => Get From #CodeTimeZone )
        //*********************************************************
        public static bool AutoCodeTimeZone = true;  
        public static string CodeTimeZone = "UTC";

        public static bool EnableRegisterSystem = true; //#New

        //Set Theme Full Screen App
        //*********************************************************
        public static bool EnableFullScreenApp = false;

        //AdMob >> Please add the code ad in the Here and analytic.xml 
        //*********************************************************
        public static bool ShowAdMobBanner = true;
        public static bool ShowAdMobInterstitial = false;
        public static bool ShowAdMobRewardVideo = false;
        public static bool ShowAdMobNative = false; 

        public static string AdInterstitialKey = "ca-app-pub-5135691635931982/4466434529";
        public static string AdRewardVideoKey = "ca-app-pub-5135691635931982/7731317149";
        public static string AdAdMobNativeKey = "ca-app-pub-5135691635931982/7916685759"; 

        //Three times after entering the ad is displayed
        public static int ShowAdMobInterstitialCount = 3;
        public static int ShowAdMobRewardedVideoCount = 3;

        //FaceBook Ads >> Please add the code ad in the Here and analytic.xml 
        //*********************************************************
        public static bool ShowFbBannerAds = false;  
        public static bool ShowFbInterstitialAds = false;  
        public static bool ShowFbRewardVideoAds = false;  
        public static bool ShowFbNativeAds = false;  

        //YOUR_PLACEMENT_ID
        public static string AdsFbBannerKey = "250485588986218_554026418632132";  
        public static string AdsFbInterstitialKey = "250485588986218_554026125298828";  
        public static string AdsFbRewardVideoKey = "250485588986218_554072818627492";  
        public static string AdsFbNativeKey = "250485588986218_554706301897477"; 

        //Social Logins >>
        //If you want login with facebook or google you should change id key in the analytic.xml file or AndroidManifest.xml
        //Facebook >> ../values/analytic.xml .. 
        //Google >> ../Properties/AndroidManifest.xml .. line 37
        //*********************************************************
        public static bool ShowFacebookLogin = false;
        public static bool ShowGoogleLogin = false;

        public static readonly string ClientId = "225381302146-ucsoa5oif9jtmkghlvvs5kelplcjj25v.apps.googleusercontent.com";
         
        //Chat Window Activity >>
        //*********************************************************
        //if you want this feature enabled go to Properties -> AndroidManefist.xml and remove comments from below code
        //Just replace it with this 5 lines of code
        /*
         <uses-permission android:name="android.permission.READ_CONTACTS" />
         <uses-permission android:name="android.permission.READ_PHONE_NUMBERS" /> 
         <uses-permission android:name="android.permission.GET_ACCOUNTS" />
         <uses-permission android:name="android.permission.SEND_SMS" />
         */
        public static bool ShowButtonContact = false;
        public static bool InvitationSystem = false;  //Invite friends section 
        /////////////////////////////////////

        public static bool ShowButtonCamera = true;  
        public static bool ShowButtonImage = true;
        public static bool ShowButtonVideo = true;
        public static bool ShowButtonAttachFile = true;
        public static bool ShowButtonColor = true;
        public static bool ShowButtonStickers = true;
        public static bool ShowButtonMusic = true;
        public static bool ShowButtonGif = true; 
        public static bool ShowButtonLocation = true; 

        public static bool ShowMusicBar = false; 


        public static bool OpenVideoFromApp = true;  

        //Set a story duration >> 10 Sec
        public static long StoryDuration = 10000L;  
        
        //Record Sound Style & Text
        //*********************************************************
        public static bool ShowButtonRecordSound = true;
         
        // Chat Group >>
        //*********************************************************
        public static bool EnableChatGroup = true;

        // Chat Page >>
        //*********************************************************
        public static bool EnableChatPage = false;  
         
        // User Profile >>
        //*********************************************************
        public static bool EnableShowPhoneNumber = true;

        //*********************************************************
        /// <summary>
        ///  Currency
        /// CurrencyStatic = true : get currency from app not api 
        /// CurrencyStatic = false : get currency from api (default)
        /// </summary>
        public static readonly bool CurrencyStatic = false; 
        public static readonly string CurrencyIconStatic = "$"; 
        public static readonly string CurrencyCodeStatic = "USD";  
         
        // Video/Audio Call Settings >>
        //*********************************************************
        public static bool EnableAudioVideoCall = false;

        public static bool EnableAudioCall = false;
        public static bool EnableVideoCall = false;

        public static SystemCall UseLibrary = SystemCall.Twilio; //#New

        // Walkthrough Settings >>
        //*********************************************************
        public static bool ShowWalkTroutPage = true;

        public static bool WalkThroughSetFlowAnimation = true;
        public static bool WalkThroughSetZoomAnimation = false;
        public static bool WalkThroughSetSlideOverAnimation = false;
        public static bool WalkThroughSetDepthAnimation = false;
        public static bool WalkThroughSetFadeAnimation = false;

        // Register Settings >>
        //*********************************************************
        public static bool ShowGenderOnRegister = true; 
          
        //Last_Messages Page >>
        //*********************************************************
        public static bool ShowOnlineOfflineMessage = true;
         
        public static int RefreshChatActivitiesSeconds = 3500; // 3 Seconds
        public static int MessageRequestSpeed = 3000; // 3 Seconds

        public static bool RenderPriorityFastPostLoad = true;

        //Bypass Web Erros 
        //*********************************************************
        public static bool TurnTrustFailureOnWebException = false;
        public static bool TurnSecurityProtocolType3072On = false;

        // Stickers Packs Settings >>
        //*********************************************************
        public static int StickersOnEachRow = 3;
        public static string StickersBarColor = "#efefef";
        public static string StickersBarColorDark = "#282828";

        public static bool ShowStickerStack0  = true;
        public static bool ShowStickerStack1 = true;
        public static bool ShowStickerStack2 = true;
        public static bool ShowStickerStack3 = true;
        public static bool ShowStickerStack4 = true;
        public static bool ShowStickerStack5 = true;
        public static bool ShowStickerStack6 = false;

        public static bool SetTabDarkTheme = false; 

        public static bool ShowSuggestedUsersOnRegister = true;  
        public static bool ImageCropping = true;

        //Settings Page >> General Account
        public static bool ShowSettingsAccount = true; 
        public static bool ShowSettingsPassword = true; 
        public static bool ShowSettingsBlockedUsers = true; 
        public static bool ShowSettingsDeleteAccount = true; 
        public static bool ShowSettingsTwoFactor = true; 
        public static bool ShowSettingsManageSessions = true; 

        //Options chat heads (Bubbles) 
        //*********************************************************
        //Always , Hide , FullScreen
        public static string DisplayModeSettings = "Always"; 

        //Default , Left  , Right , Nearest , Fix , Thrown
        public static string MoveDirectionSettings = "Right"; 

        //Circle , Rectangle
        public static string ShapeSettings = "Circle"; 

        // Last position
        public static bool IsUseLastPosition = true; 

    }
} 