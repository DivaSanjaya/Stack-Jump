#if ENABLE_PLAYFABSERVER_API
using PlayFab.ServerModels;

namespace PlayFab.Events
{
    public partial class PlayFabEvents
    {
        public event PlayFabRequestEvent<AddCharacterVirtualCurrencyRequest> OnServerAddCharacterVirtualCurrencyRequestEvent;
        public event PlayFabResultEvent<ModifyCharacterVirtualCurrencyResult> OnServerAddCharacterVirtualCurrencyResultEvent;
        public event PlayFabRequestEvent<AddFriendRequest> OnServerAddFriendRequestEvent;
        public event PlayFabResultEvent<EmptyResponse> OnServerAddFriendResultEvent;
        public event PlayFabRequestEvent<AddGenericIDRequest> OnServerAddGenericIDRequestEvent;
        public event PlayFabResultEvent<EmptyResult> OnServerAddGenericIDResultEvent;
        public event PlayFabRequestEvent<AddPlayerTagRequest> OnServerAddPlayerTagRequestEvent;
        public event PlayFabResultEvent<AddPlayerTagResult> OnServerAddPlayerTagResultEvent;
        public event PlayFabRequestEvent<AddSharedGroupMembersRequest> OnServerAddSharedGroupMembersRequestEvent;
        public event PlayFabResultEvent<AddSharedGroupMembersResult> OnServerAddSharedGroupMembersResultEvent;
        public event PlayFabRequestEvent<AddUserVirtualCurrencyRequest> OnServerAddUserVirtualCurrencyRequestEvent;
        public event PlayFabResultEvent<ModifyUserVirtualCurrencyResult> OnServerAddUserVirtualCurrencyResultEvent;
        public event PlayFabRequestEvent<AuthenticateSessionTicketRequest> OnServerAuthenticateSessionTicketRequestEvent;
        public event PlayFabResultEvent<AuthenticateSessionTicketResult> OnServerAuthenticateSessionTicketResultEvent;
        public event PlayFabRequestEvent<AwardSteamAchievementRequest> OnServerAwardSteamAchievementRequestEvent;
        public event PlayFabResultEvent<AwardSteamAchievementResult> OnServerAwardSteamAchievementResultEvent;
        public event PlayFabRequestEvent<BanUsersRequest> OnServerBanUsersRequestEvent;
        public event PlayFabResultEvent<BanUsersResult> OnServerBanUsersResultEvent;
        public event PlayFabRequestEvent<ConsumeItemRequest> OnServerConsumeItemRequestEvent;
        public event PlayFabResultEvent<ConsumeItemResult> OnServerConsumeItemResultEvent;
        public event PlayFabRequestEvent<CreateSharedGroupRequest> OnServerCreateSharedGroupRequestEvent;
        public event PlayFabResultEvent<CreateSharedGroupResult> OnServerCreateSharedGroupResultEvent;
        public event PlayFabRequestEvent<DeleteCharacterFromUserRequest> OnServerDeleteCharacterFromUserRequestEvent;
        public event PlayFabResultEvent<DeleteCharacterFromUserResult> OnServerDeleteCharacterFromUserResultEvent;
        public event PlayFabRequestEvent<DeletePlayerRequest> OnServerDeletePlayerRequestEvent;
        public event PlayFabResultEvent<DeletePlayerResult> OnServerDeletePlayerResultEvent;
        public event PlayFabRequestEvent<DeletePushNotificationTemplateRequest> OnServerDeletePushNotificationTemplateRequestEvent;
        public event PlayFabResultEvent<DeletePushNotificationTemplateResult> OnServerDeletePushNotificationTemplateResultEvent;
        public event PlayFabRequestEvent<DeleteSharedGroupRequest> OnServerDeleteSharedGroupRequestEvent;
        public event PlayFabResultEvent<EmptyResponse> OnServerDeleteSharedGroupResultEvent;
        public event PlayFabRequestEvent<DeregisterGameRequest> OnServerDeregisterGameRequestEvent;
        public event PlayFabResultEvent<DeregisterGameResponse> OnServerDeregisterGameResultEvent;
        public event PlayFabRequestEvent<EvaluateRandomResultTableRequest> OnServerEvaluateRandomResultTableRequestEvent;
        public event PlayFabResultEvent<EvaluateRandomResultTableResult> OnServerEvaluateRandomResultTableResultEvent;
        public event PlayFabRequestEvent<ExecuteCloudScriptServerRequest> OnServerExecuteCloudScriptRequestEvent;
        public event PlayFabResultEvent<ExecuteCloudScriptResult> OnServerExecuteCloudScriptResultEvent;
        public event PlayFabRequestEvent<GetAllSegmentsRequest> OnServerGetAllSegmentsRequestEvent;
        public event PlayFabResultEvent<GetAllSegmentsResult> OnServerGetAllSegmentsResultEvent;
        public event PlayFabRequestEvent<ListUsersCharactersRequest> OnServerGetAllUsersCharactersRequestEvent;
        public event PlayFabResultEvent<ListUsersCharactersResult> OnServerGetAllUsersCharactersResultEvent;
        public event PlayFabRequestEvent<GetCatalogItemsRequest> OnServerGetCatalogItemsRequestEvent;
        public event PlayFabResultEvent<GetCatalogItemsResult> OnServerGetCatalogItemsResultEvent;
        public event PlayFabRequestEvent<GetCharacterDataRequest> OnServerGetCharacterDataRequestEvent;
        public event PlayFabResultEvent<GetCharacterDataResult> OnServerGetCharacterDataResultEvent;
        public event PlayFabRequestEvent<GetCharacterDataRequest> OnServerGetCharacterInternalDataRequestEvent;
        public event PlayFabResultEvent<GetCharacterDataResult> OnServerGetCharacterInternalDataResultEvent;
        public event PlayFabRequestEvent<GetCharacterInventoryRequest> OnServerGetCharacterInventoryRequestEvent;
        public event PlayFabResultEvent<GetCharacterInventoryResult> OnServerGetCharacterInventoryResultEvent;
        public event PlayFabRequestEvent<GetCharacterLeaderboardRequest> OnServerGetCharacterLeaderboardRequestEvent;
        public event PlayFabResultEvent<GetCharacterLeaderboardResult> OnServerGetCharacterLeaderboardResultEvent;
        public event PlayFabRequestEvent<GetCharacterDataRequest> OnServerGetCharacterReadOnlyDataRequestEvent;
        public event PlayFabResultEvent<GetCharacterDataResult> OnServerGetCharacterReadOnlyDataResultEvent;
        public event PlayFabRequestEvent<GetCharacterStatisticsRequest> OnServerGetCharacterStatisticsRequestEvent;
        public event PlayFabResultEvent<GetCharacterStatisticsResult> OnServerGetCharacterStatisticsResultEvent;
        public event PlayFabRequestEvent<GetContentDownloadUrlRequest> OnServerGetContentDownloadUrlRequestEvent;
        public event PlayFabResultEvent<GetContentDownloadUrlResult> OnServerGetContentDownloadUrlResultEvent;
        public event PlayFabRequestEvent<GetFriendLeaderboardRequest> OnServerGetFriendLeaderboardRequestEvent;
        public event PlayFabResultEvent<GetLeaderboardResult> OnServerGetFriendLeaderboardResultEvent;
        public event PlayFabRequestEvent<GetFriendsListRequest> OnServerGetFriendsListRequestEvent;
        public event PlayFabResultEvent<GetFriendsListResult> OnServerGetFriendsListResultEvent;
        public event PlayFabRequestEvent<GetLeaderboardRequest> OnServerGetLeaderboardRequestEvent;
        public event PlayFabResultEvent<GetLeaderboardResult> OnServerGetLeaderboardResultEvent;
        public event PlayFabRequestEvent<GetLeaderboardAroundCharacterRequest> OnServerGetLeaderboardAroundCharacterRequestEvent;
        public event PlayFabResultEvent<GetLeaderboardAroundCharacterResult> OnServerGetLeaderboardAroundCharacterResultEvent;
        public event PlayFabRequestEvent<GetLeaderboardAroundUserRequest> OnServerGetLeaderboardAroundUserRequestEvent;
        public event PlayFabResultEvent<GetLeaderboardAroundUserResult> OnServerGetLeaderboardAroundUserResultEvent;
        public event PlayFabRequestEvent<GetLeaderboardForUsersCharactersRequest> OnServerGetLeaderboardForUserCharactersRequestEvent;
        public event PlayFabResultEvent<GetLeaderboardForUsersCharactersResult> OnServerGetLeaderboardForUserCharactersResultEvent;
        public event PlayFabRequestEvent<GetPlayerCombinedInfoRequest> OnServerGetPlayerCombinedInfoRequestEvent;
        public event PlayFabResultEvent<GetPlayerCombinedInfoResult> OnServerGetPlayerCombinedInfoResultEvent;
        public event PlayFabRequestEvent<GetPlayerProfileRequest> OnServerGetPlayerProfileRequestEvent;
        public event PlayFabResultEvent<GetPlayerProfileResult> OnServerGetPlayerProfileResultEvent;
        public event PlayFabRequestEvent<GetPlayersSegmentsRequest> OnServerGetPlayerSegmentsRequestEvent;
        public event PlayFabResultEvent<GetPlayerSegmentsResult> OnServerGetPlayerSegmentsResultEvent;
        public event PlayFabRequestEvent<GetPlayersInSegmentRequest> OnServerGetPlayersInSegmentRequestEvent;
        public event PlayFabResultEvent<GetPlayersInSegmentResult> OnServerGetPlayersInSegmentResultEvent;
        public event PlayFabRequestEvent<GetPlayerStatisticsRequest> OnServerGetPlayerStatisticsRequestEvent;
        public event PlayFabResultEvent<GetPlayerStatisticsResult> OnServerGetPlayerStatisticsResultEvent;
        public event PlayFabRequestEvent<GetPlayerStatisticVersionsRequest> OnServerGetPlayerStatisticVersionsRequestEvent;
        public event PlayFabResultEvent<GetPlayerStatisticVersionsResult> OnServerGetPlayerStatisticVersionsResultEvent;
        public event PlayFabRequestEvent<GetPlayerTagsRequest> OnServerGetPlayerTagsRequestEvent;
        public event PlayFabResultEvent<GetPlayerTagsResult> OnServerGetPlayerTagsResultEvent;
        public event PlayFabRequestEvent<GetPlayFabIDsFromFacebookIDsRequest> OnServerGetPlayFabIDsFromFacebookIDsRequestEvent;
        public event PlayFabResultEvent<GetPlayFabIDsFromFacebookIDsResult> OnServerGetPlayFabIDsFromFacebookIDsResultEvent;
        public event PlayFabRequestEvent<GetPlayFabIDsFromFacebookInstantGamesIdsRequest> OnServerGetPlayFabIDsFromFacebookInstantGamesIdsRequestEvent;
        public event PlayFabResultEvent<GetPlayFabIDsFromFacebookInstantGamesIdsResult> OnServerGetPlayFabIDsFromFacebookInstantGamesIdsResultEvent;
        public event PlayFabRequestEvent<GetPlayFabIDsFromGenericIDsRequest> OnServerGetPlayFabIDsFromGenericIDsRequestEvent;
        public event PlayFabResultEvent<GetPlayFabIDsFromGenericIDsResult> OnServerGetPlayFabIDsFromGenericIDsResultEvent;
        public event PlayFabRequestEvent<GetPlayFabIDsFromNintendoSwitchDeviceIdsRequest> OnServerGetPlayFabIDsFromNintendoSwitchDeviceIdsRequestEvent;
        public event PlayFabResultEvent<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult> OnServerGetPlayFabIDsFromNintendoSwitchDeviceIdsResultEvent;
        public event PlayFabRequestEvent<GetPlayFabIDsFromPSNAccountIDsRequest> OnServerGetPlayFabIDsFromPSNAccountIDsRequestEvent;
        public event PlayFabResultEvent<GetPlayFabIDsFromPSNAccountIDsResult> OnServerGetPlayFabIDsFromPSNAccountIDsResultEvent;
        public event PlayFabRequestEvent<GetPlayFabIDsFromSteamIDsRequest> OnServerGetPlayFabIDsFromSteamIDsRequestEvent;
        public event PlayFabResultEvent<GetPlayFabIDsFromSteamIDsResult> OnServerGetPlayFabIDsFromSteamIDsResultEvent;
        public event PlayFabRequestEvent<GetPlayFabIDsFromXboxLiveIDsRequest> OnServerGetPlayFabIDsFromXboxLiveIDsRequestEvent;
        public event PlayFabResultEvent<GetPlayFabIDsFromXboxLiveIDsResult> OnServerGetPlayFabIDsFromXboxLiveIDsResultEvent;
        public event PlayFabRequestEvent<GetPublisherDataRequest> OnServerGetPublisherDataRequestEvent;
        public event PlayFabResultEvent<GetPublisherDataResult> OnServerGetPublisherDataResultEvent;
        public event PlayFabRequestEvent<GetRandomResultTablesRequest> OnServerGetRandomResultTablesRequestEvent;
        public event PlayFabResultEvent<GetRandomResultTablesResult> OnServerGetRandomResultTablesResultEvent;
        public event PlayFabRequestEvent<GetServerCustomIDsFromPlayFabIDsRequest> OnServerGetServerCustomIDsFromPlayFabIDsRequestEvent;
        public event PlayFabResultEvent<GetServerCustomIDsFromPlayFabIDsResult> OnServerGetServerCustomIDsFromPlayFabIDsResultEvent;
        public event PlayFabRequestEvent<GetSharedGroupDataRequest> OnServerGetSharedGroupDataRequestEvent;
        public event PlayFabResultEvent<GetSharedGroupDataResult> OnServerGetSharedGroupDataResultEvent;
        public event PlayFabRequestEvent<GetStoreItemsServerRequest> OnServerGetStoreItemsRequestEvent;
        public event PlayFabResultEvent<GetStoreItemsResult> OnServerGetStoreItemsResultEvent;
        public event PlayFabRequestEvent<GetTimeRequest> OnServerGetTimeRequestEvent;
        public event PlayFabResultEvent<GetTimeResult> OnServerGetTimeResultEvent;
        public event PlayFabRequestEvent<GetTitleDataRequest> OnServerGetTitleDataRequestEvent;
        public event PlayFabResultEvent<GetTitleDataResult> OnServerGetTitleDataResultEvent;
        public event PlayFabRequestEvent<GetTitleDataRequest> OnServerGetTitleInternalDataRequestEvent;
        public event PlayFabResultEvent<GetTitleDataResult> OnServerGetTitleInternalDataResultEvent;
        public event PlayFabRequestEvent<GetTitleNewsRequest> OnServerGetTitleNewsRequestEvent;
        public event PlayFabResultEvent<GetTitleNewsResult> OnServerGetTitleNewsResultEvent;
        public event PlayFabRequestEvent<GetUserAccountInfoRequest> OnServerGetUserAccountInfoRequestEvent;
        public event PlayFabResultEvent<GetUserAccountInfoResult> OnServerGetUserAccountInfoResultEvent;
        public event PlayFabRequestEvent<GetUserBansRequest> OnServerGetUserBansRequestEvent;
        public event PlayFabResultEvent<GetUserBansResult> OnServerGetUserBansResultEvent;
        public event PlayFabRequestEvent<GetUserDataRequest> OnServerGetUserDataRequestEvent;
        public event PlayFabResultEvent<GetUserDataResult> OnServerGetUserDataResultEvent;
        public event PlayFabRequestEvent<GetUserDataRequest> OnServerGetUserInternalDataRequestEvent;
        public event PlayFabResultEvent<GetUserDataResult> OnServerGetUserInternalDataResultEvent;
        public event PlayFabRequestEvent<GetUserInventoryRequest> OnServerGetUserInventoryRequestEvent;
        public event PlayFabResultEvent<GetUserInventoryResult> OnServerGetUserInventoryResultEvent;
        public event PlayFabRequestEvent<GetUserDataRequest> OnServerGetUserPublisherDataRequestEvent;
        public event PlayFabResultEvent<GetUserDataResult> OnServerGetUserPublisherDataResultEvent;
        public event PlayFabRequestEvent<GetUserDataRequest> OnServerGetUserPublisherInternalDataRequestEvent;
        public event PlayFabResultEvent<GetUserDataResult> OnServerGetUserPublisherInternalDataResultEvent;
        public event PlayFabRequestEvent<GetUserDataRequest> OnServerGetUserPublisherReadOnlyDataRequestEvent;
        public event PlayFabResultEvent<GetUserDataResult> OnServerGetUserPublisherReadOnlyDataResultEvent;
        public event PlayFabRequestEvent<GetUserDataRequest> OnServerGetUserReadOnlyDataRequestEvent;
        public event PlayFabResultEvent<GetUserDataResult> OnServerGetUserReadOnlyDataResultEvent;
        public event PlayFabRequestEvent<GrantCharacterToUserRequest> OnServerGrantCharacterToUserRequestEvent;
        public event PlayFabResultEvent<GrantCharacterToUserResult> OnServerGrantCharacterToUserResultEvent;
        public event PlayFabRequestEvent<GrantItemsToCharacterRequest> OnServerGrantItemsToCharacterRequestEvent;
        public event PlayFabResultEvent<GrantItemsToCharacterResult> OnServerGrantItemsToCharacterResultEvent;
        public event PlayFabRequestEvent<GrantItemsToUserRequest> OnServerGrantItemsToUserRequestEvent;
        public event PlayFabResultEvent<GrantItemsToUserResult> OnServerGrantItemsToUserResultEvent;
        public event PlayFabRequestEvent<GrantItemsToUsersRequest> OnServerGrantItemsToUsersRequestEvent;
        public event PlayFabResultEvent<GrantItemsToUsersResult> OnServerGrantItemsToUsersResultEvent;
        public event PlayFabRequestEvent<LinkServerCustomIdRequest> OnServerLinkServerCustomIdRequestEvent;
        public event PlayFabResultEvent<LinkServerCustomIdResult> OnServerLinkServerCustomIdResultEvent;
        public event PlayFabRequestEvent<LinkXboxAccountRequest> OnServerLinkXboxAccountRequestEvent;
        public event PlayFabResultEvent<LinkXboxAccountResult> OnServerLinkXboxAccountResultEvent;
        public event PlayFabRequestEvent<LoginWithServerCustomIdRequest> OnServerLoginWithServerCustomIdRequestEvent;
        public event PlayFabResultEvent<ServerLoginResult> OnServerLoginWithServerCustomIdResultEvent;
        public event PlayFabRequestEvent<LoginWithXboxRequest> OnServerLoginWithXboxRequestEvent;
        public event PlayFabResultEvent<ServerLoginResult> OnServerLoginWithXboxResultEvent;
        public event PlayFabRequestEvent<LoginWithXboxIdRequest> OnServerLoginWithXboxIdRequestEvent;
        public event PlayFabResultEvent<ServerLoginResult> OnServerLoginWithXboxIdResultEvent;
        public event PlayFabRequestEvent<ModifyItemUsesRequest> OnServerModifyItemUsesRequestEvent;
        public event PlayFabResultEvent<ModifyItemUsesResult> OnServerModifyItemUsesResultEvent;
        public event PlayFabRequestEvent<MoveItemToCharacterFromCharacterRequest> OnServerMoveItemToCharacterFromCharacterRequestEvent;
        public event PlayFabResultEvent<MoveItemToCharacterFromCharacterResult> OnServerMoveItemToCharacterFromCharacterResultEvent;
        public event PlayFabRequestEvent<MoveItemToCharacterFromUserRequest> OnServerMoveItemToCharacterFromUserRequestEvent;
        public event PlayFabResultEvent<MoveItemToCharacterFromUserResult> OnServerMoveItemToCharacterFromUserResultEvent;
        public event PlayFabRequestEvent<MoveItemToUserFromCharacterRequest> OnServerMoveItemToUserFromCharacterRequestEvent;
        public event PlayFabResultEvent<MoveItemToUserFromCharacterResult> OnServerMoveItemToUserFromCharacterResultEvent;
        public event PlayFabRequestEvent<NotifyMatchmakerPlayerLeftRequest> OnServerNotifyMatchmakerPlayerLeftRequestEvent;
        public event PlayFabResultEvent<NotifyMatchmakerPlayerLeftResult> OnServerNotifyMatchmakerPlayerLeftResultEvent;
        public event PlayFabRequestEvent<RedeemCouponRequest> OnServerRedeemCouponRequestEvent;
        public event PlayFabResultEvent<RedeemCouponResult> OnServerRedeemCouponResultEvent;
        public event PlayFabRequestEvent<RedeemMatchmakerTicketRequest> OnServerRedeemMatchmakerTicketRequestEvent;
        public event PlayFabResultEvent<RedeemMatchmakerTicketResult> OnServerRedeemMatchmakerTicketResultEvent;
        public event PlayFabRequestEvent<RefreshGameServerInstanceHeartbeatRequest> OnServerRefreshGameServerInstanceHeartbeatRequestEvent;
        public event PlayFabResultEvent<RefreshGameServerInstanceHeartbeatResult> OnServerRefreshGameServerInstanceHeartbeatResultEvent;
        public event PlayFabRequestEvent<RegisterGameRequest> OnServerRegisterGameRequestEvent;
        public event PlayFabResultEvent<RegisterGameResponse> OnServerRegisterGameResultEvent;
        public event PlayFabRequestEvent<RemoveFriendRequest> OnServerRemoveFriendRequestEvent;
        public event PlayFabResultEvent<EmptyResponse> OnServerRemoveFriendResultEvent;
        public event PlayFabRequestEvent<RemoveGenericIDRequest> OnServerRemoveGenericIDRequestEvent;
        public event PlayFabResultEvent<EmptyResult> OnServerRemoveGenericIDResultEvent;
        public event PlayFabRequestEvent<RemovePlayerTagRequest> OnServerRemovePlayerTagRequestEvent;
        public event PlayFabResultEvent<RemovePlayerTagResult> OnServerRemovePlayerTagResultEvent;
        public event PlayFabRequestEvent<RemoveSharedGroupMembersRequest> OnServerRemoveSharedGroupMembersRequestEvent;
        public event PlayFabResultEvent<RemoveSharedGroupMembersResult> OnServerRemoveSharedGroupMembersResultEvent;
        public event PlayFabRequestEvent<ReportPlayerServerRequest> OnServerReportPlayerRequestEvent;
        public event PlayFabResultEvent<ReportPlayerServerResult> OnServerReportPlayerResultEvent;
        public event PlayFabRequestEvent<RevokeAllBansForUserRequest> OnServerRevokeAllBansForUserRequestEvent;
        public event PlayFabResultEvent<RevokeAllBansForUserResult> OnServerRevokeAllBansForUserResultEvent;
        public event PlayFabRequestEvent<RevokeBansRequest> OnServerRevokeBansRequestEvent;
        public event PlayFabResultEvent<RevokeBansResult> OnServerRevokeBansResultEvent;
        public event PlayFabRequestEvent<RevokeInventoryItemRequest> OnServerRevokeInventoryItemRequestEvent;
        public event PlayFabResultEvent<RevokeInventoryResult> OnServerRevokeInventoryItemResultEvent;
        public event PlayFabRequestEvent<RevokeInventoryItemsRequest> OnServerRevokeInventoryItemsRequestEvent;
        public event PlayFabResultEvent<RevokeInventoryItemsResult> OnServerRevokeInventoryItemsResultEvent;
        public event PlayFabRequestEvent<SavePushNotificationTemplateRequest> OnServerSavePushNotificationTemplateRequestEvent;
        public event PlayFabResultEvent<SavePushNotificationTemplateResult> OnServerSavePushNotificationTemplateResultEvent;
        public event PlayFabRequestEvent<SendCustomAccountRecoveryEmailRequest> OnServerSendCustomAccountRecoveryEmailRequestEvent;
        public event PlayFabResultEvent<SendCustomAccountRecoveryEmailResult> OnServerSendCustomAccountRecoveryEmailResultEvent;
        public event PlayFabRequestEvent<SendEmailFromTemplateRequest> OnServerSendEmailFromTemplateRequestEvent;
        public event PlayFabResultEvent<SendEmailFromTemplateResult> OnServerSendEmailFromTemplateResultEvent;
        public event PlayFabRequestEvent<SendPushNotificationRequest> OnServerSendPushNotificationRequestEvent;
        public event PlayFabResultEvent<SendPushNotificationResult> OnServerSendPushNotificationResultEvent;
        public event PlayFabRequestEvent<SendPushNotificationFromTemplateRequest> OnServerSendPushNotificationFromTemplateRequestEvent;
        public event PlayFabResultEvent<SendPushNotificationResult> OnServerSendPushNotificationFromTemplateResultEvent;
        public event PlayFabRequestEvent<SetFriendTagsRequest> OnServerSetFriendTagsRequestEvent;
        public event PlayFabResultEvent<EmptyResponse> OnServerSetFriendTagsResultEvent;
        public event PlayFabRequestEvent<SetGameServerInstanceDataRequest> OnServerSetGameServerInstanceDataRequestEvent;
        public event PlayFabResultEvent<SetGameServerInstanceDataResult> OnServerSetGameServerInstanceDataResultEvent;
        public event PlayFabRequestEvent<SetGameServerInstanceStateRequest> OnServerSetGameServerInstanceStateRequestEvent;
        public event PlayFabResultEvent<SetGameServerInstanceStateResult> OnServerSetGameServerInstanceStateResultEvent;
        public event PlayFabRequestEvent<SetGameServerInstanceTagsRequest> OnServerSetGameServerInstanceTagsRequestEvent;
        public event PlayFabResultEvent<SetGameServerInstanceTagsResult> OnServerSetGameServerInstanceTagsResultEvent;
        public event PlayFabRequestEvent<SetPlayerSecretRequest> OnServerSetPlayerSecretRequestEvent;
        public event PlayFabResultEvent<SetPlayerSecretResult> OnServerSetPlayerSecretResultEvent;
        public event PlayFabRequestEvent<SetPublisherDataRequest> OnServerSetPublisherDataRequestEvent;
        public event PlayFabResultEvent<SetPublisherDataResult> OnServerSetPublisherDataResultEvent;
        public event PlayFabRequestEvent<SetTitleDataRequest> OnServerSetTitleDataRequestEvent;
        public event PlayFabResultEvent<SetTitleDataResult> OnServerSetTitleDataResultEvent;
        public event PlayFabRequestEvent<SetTitleDataRequest> OnServerSetTitleInternalDataRequestEvent;
        public event PlayFabResultEvent<SetTitleDataResult> OnServerSetTitleInternalDataResultEvent;
        public event PlayFabRequestEvent<SubtractCharacterVirtualCurrencyRequest> OnServerSubtractCharacterVirtualCurrencyRequestEvent;
        public event PlayFabResultEvent<ModifyCharacterVirtualCurrencyResult> OnServerSubtractCharacterVirtualCurrencyResultEvent;
        public event PlayFabRequestEvent<SubtractUserVirtualCurrencyRequest> OnServerSubtractUserVirtualCurrencyRequestEvent;
        public event PlayFabResultEvent<ModifyUserVirtualCurrencyResult> OnServerSubtractUserVirtualCurrencyResultEvent;
        public event PlayFabRequestEvent<UnlinkServerCustomIdRequest> OnServerUnlinkServerCustomIdRequestEvent;
        public event PlayFabResultEvent<UnlinkServerCustomIdResult> OnServerUnlinkServerCustomIdResultEvent;
        public event PlayFabRequestEvent<UnlinkXboxAccountRequest> OnServerUnlinkXboxAccountRequestEvent;
        public event PlayFabResultEvent<UnlinkXboxAccountResult> OnServerUnlinkXboxAccountResultEvent;
        public event PlayFabRequestEvent<UnlockContainerInstanceRequest> OnServerUnlockContainerInstanceRequestEvent;
        public event PlayFabResultEvent<UnlockContainerItemResult> OnServerUnlockContainerInstanceResultEvent;
        public event PlayFabRequestEvent<UnlockContainerItemRequest> OnServerUnlockContainerItemRequestEvent;
        public event PlayFabResultEvent<UnlockContainerItemResult> OnServerUnlockContainerItemResultEvent;
        public event PlayFabRequestEvent<UpdateAvatarUrlRequest> OnServerUpdateAvatarUrlRequestEvent;
        public event PlayFabResultEvent<EmptyResponse> OnServerUpdateAvatarUrlResultEvent;
        public event PlayFabRequestEvent<UpdateBansRequest> OnServerUpdateBansRequestEvent;
        public event PlayFabResultEvent<UpdateBansResult> OnServerUpdateBansResultEvent;
        public event PlayFabRequestEvent<UpdateCharacterDataRequest> OnServerUpdateCharacterDataRequestEvent;
        public event PlayFabResultEvent<UpdateCharacterDataResult> OnServerUpdateCharacterDataResultEvent;
        public event PlayFabRequestEvent<UpdateCharacterDataRequest> OnServerUpdateCharacterInternalDataRequestEvent;
        public event PlayFabResultEvent<UpdateCharacterDataResult> OnServerUpdateCharacterInternalDataResultEvent;
        public event PlayFabRequestEvent<UpdateCharacterDataRequest> OnServerUpdateCharacterReadOnlyDataRequestEvent;
        public event PlayFabResultEvent<UpdateCharacterDataResult> OnServerUpdateCharacterReadOnlyDataResultEvent;
        public event PlayFabRequestEvent<UpdateCharacterStatisticsRequest> OnServerUpdateCharacterStatisticsRequestEvent;
        public event PlayFabResultEvent<UpdateCharacterStatisticsResult> OnServerUpdateCharacterStatisticsResultEvent;
        public event PlayFabRequestEvent<UpdatePlayerStatisticsRequest> OnServerUpdatePlayerStatisticsRequestEvent;
        public event PlayFabResultEvent<UpdatePlayerStatisticsResult> OnServerUpdatePlayerStatisticsResultEvent;
        public event PlayFabRequestEvent<UpdateSharedGroupDataRequest> OnServerUpdateSharedGroupDataRequestEvent;
        public event PlayFabResultEvent<UpdateSharedGroupDataResult> OnServerUpdateSharedGroupDataResultEvent;
        public event PlayFabRequestEvent<UpdateUserDataRequest> OnServerUpdateUserDataRequestEvent;
        public event PlayFabResultEvent<UpdateUserDataResult> OnServerUpdateUserDataResultEvent;
        public event PlayFabRequestEvent<UpdateUserInternalDataRequest> OnServerUpdateUserInternalDataRequestEvent;
        public event PlayFabResultEvent<UpdateUserDataResult> OnServerUpdateUserInternalDataResultEvent;
        public event PlayFabRequestEvent<UpdateUserInventoryItemDataRequest> OnServerUpdateUserInventoryItemCustomDataRequestEvent;
        public event PlayFabResultEvent<EmptyResponse> OnServerUpdateUserInventoryItemCustomDataResultEvent;
        public event PlayFabRequestEvent<UpdateUserDataRequest> OnServerUpdateUserPublisherDataRequestEvent;
        public event PlayFabResultEvent<UpdateUserDataResult> OnServerUpdateUserPublisherDataResultEvent;
        public event PlayFabRequestEvent<UpdateUserInternalDataRequest> OnServerUpdateUserPublisherInternalDataRequestEvent;
        public event PlayFabResultEvent<UpdateUserDataResult> OnServerUpdateUserPublisherInternalDataResultEvent;
        public event PlayFabRequestEvent<UpdateUserDataRequest> OnServerUpdateUserPublisherReadOnlyDataRequestEvent;
        public event PlayFabResultEvent<UpdateUserDataResult> OnServerUpdateUserPublisherReadOnlyDataResultEvent;
        public event PlayFabRequestEvent<UpdateUserDataRequest> OnServerUpdateUserReadOnlyDataRequestEvent;
        public event PlayFabResultEvent<UpdateUserDataResult> OnServerUpdateUserReadOnlyDataResultEvent;
        public event PlayFabRequestEvent<WriteServerCharacterEventRequest> OnServerWriteCharacterEventRequestEvent;
        public event PlayFabResultEvent<WriteEventResponse> OnServerWriteCharacterEventResultEvent;
        public event PlayFabRequestEvent<WriteServerPlayerEventRequest> OnServerWritePlayerEventRequestEvent;
        public event PlayFabResultEvent<WriteEventResponse> OnServerWritePlayerEventResultEvent;
        public event PlayFabRequestEvent<WriteTitleEventRequest> OnServerWriteTitleEventRequestEvent;
        public event PlayFabResultEvent<WriteEventResponse> OnServerWriteTitleEventResultEvent;
    }
}
#endif
