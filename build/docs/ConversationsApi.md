---
title: ConversationsApi
---
## PureCloudPlatform.Client.V2.Api.ConversationsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteAnalyticsConversationsDetailsJob**](ConversationsApi.html#deleteanalyticsconversationsdetailsjob) | **DELETE** /api/v2/analytics/conversations/details/jobs/{jobId} | Delete/cancel an async request |
| [**DeleteConversationParticipantCode**](ConversationsApi.html#deleteconversationparticipantcode) | **DELETE** /api/v2/conversations/{conversationId}/participants/{participantId}/codes/{addCommunicationCode} | Delete a code used to add a communication to this participant |
| [**DeleteConversationParticipantFlaggedreason**](ConversationsApi.html#deleteconversationparticipantflaggedreason) | **DELETE** /api/v2/conversations/{conversationId}/participants/{participantId}/flaggedreason | Remove flagged reason from conversation participant. |
| [**DeleteConversationsCallParticipantConsult**](ConversationsApi.html#deleteconversationscallparticipantconsult) | **DELETE** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult | Cancel the transfer |
| [**DeleteConversationsEmailMessagesDraftAttachment**](ConversationsApi.html#deleteconversationsemailmessagesdraftattachment) | **DELETE** /api/v2/conversations/emails/{conversationId}/messages/draft/attachments/{attachmentId} | Delete attachment from draft |
| [**DeleteConversationsMessagingIntegrationsFacebookIntegrationId**](ConversationsApi.html#deleteconversationsmessagingintegrationsfacebookintegrationid) | **DELETE** /api/v2/conversations/messaging/integrations/facebook/{integrationId} | Delete a Facebook messaging integration |
| [**DeleteConversationsMessagingIntegrationsLineIntegrationId**](ConversationsApi.html#deleteconversationsmessagingintegrationslineintegrationid) | **DELETE** /api/v2/conversations/messaging/integrations/line/{integrationId} | Delete a LINE messenger integration |
| [**DeleteConversationsMessagingIntegrationsTwitterIntegrationId**](ConversationsApi.html#deleteconversationsmessagingintegrationstwitterintegrationid) | **DELETE** /api/v2/conversations/messaging/integrations/twitter/{integrationId} | Delete a Twitter messaging integration |
| [**DeleteConversationsMessagingIntegrationsWhatsappIntegrationId**](ConversationsApi.html#deleteconversationsmessagingintegrationswhatsappintegrationid) | **DELETE** /api/v2/conversations/messaging/integrations/whatsapp/{integrationId} | Delete a WhatsApp messaging integration |
| [**GetAnalyticsConversationDetails**](ConversationsApi.html#getanalyticsconversationdetails) | **GET** /api/v2/analytics/conversations/{conversationId}/details | Get a conversation by id |
| [**GetAnalyticsConversationsDetails**](ConversationsApi.html#getanalyticsconversationsdetails) | **GET** /api/v2/analytics/conversations/details | Gets multiple conversations by id |
| [**GetAnalyticsConversationsDetailsJob**](ConversationsApi.html#getanalyticsconversationsdetailsjob) | **GET** /api/v2/analytics/conversations/details/jobs/{jobId} | Get status for async query for conversation details |
| [**GetAnalyticsConversationsDetailsJobResults**](ConversationsApi.html#getanalyticsconversationsdetailsjobresults) | **GET** /api/v2/analytics/conversations/details/jobs/{jobId}/results | Fetch a page of results for an async query |
| [**GetConversation**](ConversationsApi.html#getconversation) | **GET** /api/v2/conversations/{conversationId} | Get conversation |
| [**GetConversationParticipantSecureivrsession**](ConversationsApi.html#getconversationparticipantsecureivrsession) | **GET** /api/v2/conversations/{conversationId}/participants/{participantId}/secureivrsessions/{secureSessionId} | Fetch info on a secure session |
| [**GetConversationParticipantSecureivrsessions**](ConversationsApi.html#getconversationparticipantsecureivrsessions) | **GET** /api/v2/conversations/{conversationId}/participants/{participantId}/secureivrsessions | Get a list of secure sessions for this participant. |
| [**GetConversationParticipantWrapup**](ConversationsApi.html#getconversationparticipantwrapup) | **GET** /api/v2/conversations/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationParticipantWrapupcodes**](ConversationsApi.html#getconversationparticipantwrapupcodes) | **GET** /api/v2/conversations/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversations**](ConversationsApi.html#getconversations) | **GET** /api/v2/conversations | Get active conversations for the logged in user |
| [**GetConversationsCall**](ConversationsApi.html#getconversationscall) | **GET** /api/v2/conversations/calls/{conversationId} | Get call conversation |
| [**GetConversationsCallParticipantWrapup**](ConversationsApi.html#getconversationscallparticipantwrapup) | **GET** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationsCallParticipantWrapupcodes**](ConversationsApi.html#getconversationscallparticipantwrapupcodes) | **GET** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationsCallback**](ConversationsApi.html#getconversationscallback) | **GET** /api/v2/conversations/callbacks/{conversationId} | Get callback conversation |
| [**GetConversationsCallbackParticipantWrapup**](ConversationsApi.html#getconversationscallbackparticipantwrapup) | **GET** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationsCallbackParticipantWrapupcodes**](ConversationsApi.html#getconversationscallbackparticipantwrapupcodes) | **GET** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationsCallbacks**](ConversationsApi.html#getconversationscallbacks) | **GET** /api/v2/conversations/callbacks | Get active callback conversations for the logged in user |
| [**GetConversationsCalls**](ConversationsApi.html#getconversationscalls) | **GET** /api/v2/conversations/calls | Get active call conversations for the logged in user |
| [**GetConversationsCallsHistory**](ConversationsApi.html#getconversationscallshistory) | **GET** /api/v2/conversations/calls/history | Get call history |
| [**GetConversationsCallsMaximumconferenceparties**](ConversationsApi.html#getconversationscallsmaximumconferenceparties) | **GET** /api/v2/conversations/calls/maximumconferenceparties | Get the maximum number of participants that this user can have on a conference |
| [**GetConversationsChat**](ConversationsApi.html#getconversationschat) | **GET** /api/v2/conversations/chats/{conversationId} | Get chat conversation |
| [**GetConversationsChatMessage**](ConversationsApi.html#getconversationschatmessage) | **GET** /api/v2/conversations/chats/{conversationId}/messages/{messageId} | Get a web chat conversation message |
| [**GetConversationsChatMessages**](ConversationsApi.html#getconversationschatmessages) | **GET** /api/v2/conversations/chats/{conversationId}/messages | Get the messages of a chat conversation. |
| [**GetConversationsChatParticipantWrapup**](ConversationsApi.html#getconversationschatparticipantwrapup) | **GET** /api/v2/conversations/chats/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationsChatParticipantWrapupcodes**](ConversationsApi.html#getconversationschatparticipantwrapupcodes) | **GET** /api/v2/conversations/chats/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationsChats**](ConversationsApi.html#getconversationschats) | **GET** /api/v2/conversations/chats | Get active chat conversations for the logged in user |
| [**GetConversationsCobrowsesession**](ConversationsApi.html#getconversationscobrowsesession) | **GET** /api/v2/conversations/cobrowsesessions/{conversationId} | Get cobrowse conversation |
| [**GetConversationsCobrowsesessionParticipantWrapup**](ConversationsApi.html#getconversationscobrowsesessionparticipantwrapup) | **GET** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationsCobrowsesessionParticipantWrapupcodes**](ConversationsApi.html#getconversationscobrowsesessionparticipantwrapupcodes) | **GET** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationsCobrowsesessions**](ConversationsApi.html#getconversationscobrowsesessions) | **GET** /api/v2/conversations/cobrowsesessions | Get active cobrowse conversations for the logged in user |
| [**GetConversationsEmail**](ConversationsApi.html#getconversationsemail) | **GET** /api/v2/conversations/emails/{conversationId} | Get email conversation |
| [**GetConversationsEmailMessage**](ConversationsApi.html#getconversationsemailmessage) | **GET** /api/v2/conversations/emails/{conversationId}/messages/{messageId} | Get conversation message |
| [**GetConversationsEmailMessages**](ConversationsApi.html#getconversationsemailmessages) | **GET** /api/v2/conversations/emails/{conversationId}/messages | Get conversation messages |
| [**GetConversationsEmailMessagesDraft**](ConversationsApi.html#getconversationsemailmessagesdraft) | **GET** /api/v2/conversations/emails/{conversationId}/messages/draft | Get conversation draft reply |
| [**GetConversationsEmailParticipantWrapup**](ConversationsApi.html#getconversationsemailparticipantwrapup) | **GET** /api/v2/conversations/emails/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationsEmailParticipantWrapupcodes**](ConversationsApi.html#getconversationsemailparticipantwrapupcodes) | **GET** /api/v2/conversations/emails/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationsEmails**](ConversationsApi.html#getconversationsemails) | **GET** /api/v2/conversations/emails | Get active email conversations for the logged in user |
| [**GetConversationsMessage**](ConversationsApi.html#getconversationsmessage) | **GET** /api/v2/conversations/messages/{conversationId} | Get message conversation |
| [**GetConversationsMessageCommunicationMessagesMediaMediaId**](ConversationsApi.html#getconversationsmessagecommunicationmessagesmediamediaid) | **GET** /api/v2/conversations/messages/{conversationId}/communications/{communicationId}/messages/media/{mediaId} | Get media |
| [**GetConversationsMessageMessage**](ConversationsApi.html#getconversationsmessagemessage) | **GET** /api/v2/conversations/messages/{conversationId}/messages/{messageId} | Get message |
| [**GetConversationsMessageParticipantWrapup**](ConversationsApi.html#getconversationsmessageparticipantwrapup) | **GET** /api/v2/conversations/messages/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationsMessageParticipantWrapupcodes**](ConversationsApi.html#getconversationsmessageparticipantwrapupcodes) | **GET** /api/v2/conversations/messages/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationsMessages**](ConversationsApi.html#getconversationsmessages) | **GET** /api/v2/conversations/messages | Get active message conversations for the logged in user |
| [**GetConversationsMessagingFacebookApp**](ConversationsApi.html#getconversationsmessagingfacebookapp) | **GET** /api/v2/conversations/messaging/facebook/app | Get Genesys Facebook App Id |
| [**GetConversationsMessagingIntegrations**](ConversationsApi.html#getconversationsmessagingintegrations) | **GET** /api/v2/conversations/messaging/integrations | Get a list of Integrations |
| [**GetConversationsMessagingIntegrationsFacebook**](ConversationsApi.html#getconversationsmessagingintegrationsfacebook) | **GET** /api/v2/conversations/messaging/integrations/facebook | Get a list of Facebook Integrations |
| [**GetConversationsMessagingIntegrationsFacebookIntegrationId**](ConversationsApi.html#getconversationsmessagingintegrationsfacebookintegrationid) | **GET** /api/v2/conversations/messaging/integrations/facebook/{integrationId} | Get a Facebook messaging integration |
| [**GetConversationsMessagingIntegrationsLine**](ConversationsApi.html#getconversationsmessagingintegrationsline) | **GET** /api/v2/conversations/messaging/integrations/line | Get a list of LINE messenger Integrations |
| [**GetConversationsMessagingIntegrationsLineIntegrationId**](ConversationsApi.html#getconversationsmessagingintegrationslineintegrationid) | **GET** /api/v2/conversations/messaging/integrations/line/{integrationId} | Get a LINE messenger integration |
| [**GetConversationsMessagingIntegrationsTwitter**](ConversationsApi.html#getconversationsmessagingintegrationstwitter) | **GET** /api/v2/conversations/messaging/integrations/twitter | Get a list of Twitter Integrations |
| [**GetConversationsMessagingIntegrationsTwitterIntegrationId**](ConversationsApi.html#getconversationsmessagingintegrationstwitterintegrationid) | **GET** /api/v2/conversations/messaging/integrations/twitter/{integrationId} | Get a Twitter messaging integration |
| [**GetConversationsMessagingIntegrationsWhatsapp**](ConversationsApi.html#getconversationsmessagingintegrationswhatsapp) | **GET** /api/v2/conversations/messaging/integrations/whatsapp | Get a list of WhatsApp Integrations |
| [**GetConversationsMessagingIntegrationsWhatsappIntegrationId**](ConversationsApi.html#getconversationsmessagingintegrationswhatsappintegrationid) | **GET** /api/v2/conversations/messaging/integrations/whatsapp/{integrationId} | Get a WhatsApp messaging integration |
| [**GetConversationsMessagingSticker**](ConversationsApi.html#getconversationsmessagingsticker) | **GET** /api/v2/conversations/messaging/stickers/{messengerType} | Get a list of Messaging Stickers |
| [**PatchConversationParticipant**](ConversationsApi.html#patchconversationparticipant) | **PATCH** /api/v2/conversations/{conversationId}/participants/{participantId} | Update a participant. |
| [**PatchConversationParticipantAttributes**](ConversationsApi.html#patchconversationparticipantattributes) | **PATCH** /api/v2/conversations/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationsCall**](ConversationsApi.html#patchconversationscall) | **PATCH** /api/v2/conversations/calls/{conversationId} | Update a conversation by setting it&#39;s recording state, merging in other conversations to create a conference, or disconnecting all of the participants |
| [**PatchConversationsCallParticipant**](ConversationsApi.html#patchconversationscallparticipant) | **PATCH** /api/v2/conversations/calls/{conversationId}/participants/{participantId} | Update conversation participant |
| [**PatchConversationsCallParticipantAttributes**](ConversationsApi.html#patchconversationscallparticipantattributes) | **PATCH** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationsCallParticipantCommunication**](ConversationsApi.html#patchconversationscallparticipantcommunication) | **PATCH** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. |
| [**PatchConversationsCallParticipantConsult**](ConversationsApi.html#patchconversationscallparticipantconsult) | **PATCH** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult | Change who can speak |
| [**PatchConversationsCallback**](ConversationsApi.html#patchconversationscallback) | **PATCH** /api/v2/conversations/callbacks/{conversationId} | Update a conversation by disconnecting all of the participants |
| [**PatchConversationsCallbackParticipant**](ConversationsApi.html#patchconversationscallbackparticipant) | **PATCH** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId} | Update conversation participant |
| [**PatchConversationsCallbackParticipantAttributes**](ConversationsApi.html#patchconversationscallbackparticipantattributes) | **PATCH** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationsCallbackParticipantCommunication**](ConversationsApi.html#patchconversationscallbackparticipantcommunication) | **PATCH** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. |
| [**PatchConversationsChat**](ConversationsApi.html#patchconversationschat) | **PATCH** /api/v2/conversations/chats/{conversationId} | Update a conversation by disconnecting all of the participants |
| [**PatchConversationsChatParticipant**](ConversationsApi.html#patchconversationschatparticipant) | **PATCH** /api/v2/conversations/chats/{conversationId}/participants/{participantId} | Update conversation participant |
| [**PatchConversationsChatParticipantAttributes**](ConversationsApi.html#patchconversationschatparticipantattributes) | **PATCH** /api/v2/conversations/chats/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationsChatParticipantCommunication**](ConversationsApi.html#patchconversationschatparticipantcommunication) | **PATCH** /api/v2/conversations/chats/{conversationId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. |
| [**PatchConversationsCobrowsesession**](ConversationsApi.html#patchconversationscobrowsesession) | **PATCH** /api/v2/conversations/cobrowsesessions/{conversationId} | Update a conversation by disconnecting all of the participants |
| [**PatchConversationsCobrowsesessionParticipant**](ConversationsApi.html#patchconversationscobrowsesessionparticipant) | **PATCH** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId} | Update conversation participant |
| [**PatchConversationsCobrowsesessionParticipantAttributes**](ConversationsApi.html#patchconversationscobrowsesessionparticipantattributes) | **PATCH** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationsCobrowsesessionParticipantCommunication**](ConversationsApi.html#patchconversationscobrowsesessionparticipantcommunication) | **PATCH** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. |
| [**PatchConversationsEmail**](ConversationsApi.html#patchconversationsemail) | **PATCH** /api/v2/conversations/emails/{conversationId} | Update a conversation by disconnecting all of the participants |
| [**PatchConversationsEmailParticipant**](ConversationsApi.html#patchconversationsemailparticipant) | **PATCH** /api/v2/conversations/emails/{conversationId}/participants/{participantId} | Update conversation participant |
| [**PatchConversationsEmailParticipantAttributes**](ConversationsApi.html#patchconversationsemailparticipantattributes) | **PATCH** /api/v2/conversations/emails/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationsEmailParticipantCommunication**](ConversationsApi.html#patchconversationsemailparticipantcommunication) | **PATCH** /api/v2/conversations/emails/{conversationId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. |
| [**PatchConversationsMessage**](ConversationsApi.html#patchconversationsmessage) | **PATCH** /api/v2/conversations/messages/{conversationId} | Update a conversation by disconnecting all of the participants |
| [**PatchConversationsMessageParticipant**](ConversationsApi.html#patchconversationsmessageparticipant) | **PATCH** /api/v2/conversations/messages/{conversationId}/participants/{participantId} | Update conversation participant |
| [**PatchConversationsMessageParticipantAttributes**](ConversationsApi.html#patchconversationsmessageparticipantattributes) | **PATCH** /api/v2/conversations/messages/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationsMessageParticipantCommunication**](ConversationsApi.html#patchconversationsmessageparticipantcommunication) | **PATCH** /api/v2/conversations/messages/{conversationId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. |
| [**PatchConversationsMessagingIntegrationsWhatsappIntegrationId**](ConversationsApi.html#patchconversationsmessagingintegrationswhatsappintegrationid) | **PATCH** /api/v2/conversations/messaging/integrations/whatsapp/{integrationId} | Activate a WhatsApp messaging integration. |
| [**PostAnalyticsConversationDetailsProperties**](ConversationsApi.html#postanalyticsconversationdetailsproperties) | **POST** /api/v2/analytics/conversations/{conversationId}/details/properties | Index conversation properties |
| [**PostAnalyticsConversationsAggregatesQuery**](ConversationsApi.html#postanalyticsconversationsaggregatesquery) | **POST** /api/v2/analytics/conversations/aggregates/query | Query for conversation aggregates |
| [**PostAnalyticsConversationsDetailsJobs**](ConversationsApi.html#postanalyticsconversationsdetailsjobs) | **POST** /api/v2/analytics/conversations/details/jobs | Query for conversation details asynchronously |
| [**PostAnalyticsConversationsDetailsQuery**](ConversationsApi.html#postanalyticsconversationsdetailsquery) | **POST** /api/v2/analytics/conversations/details/query | Query for conversation details |
| [**PostConversationDisconnect**](ConversationsApi.html#postconversationdisconnect) | **POST** /api/v2/conversations/{conversationId}/disconnect | Performs a full conversation teardown. Issues disconnect requests for any connected media. Applies a system wrap-up code to any participants that are pending wrap-up. This is not intended to be the normal way of ending interactions but is available in the event of problems with the application to allow a resyncronization of state across all components. It is recommended that users submit a support case if they are relying on this endpoint systematically as there is likely something that needs investigation. |
| [**PostConversationParticipantCallbacks**](ConversationsApi.html#postconversationparticipantcallbacks) | **POST** /api/v2/conversations/{conversationId}/participants/{participantId}/callbacks | Create a new callback for the specified participant on the conversation. |
| [**PostConversationParticipantDigits**](ConversationsApi.html#postconversationparticipantdigits) | **POST** /api/v2/conversations/{conversationId}/participants/{participantId}/digits | Sends DTMF to the participant |
| [**PostConversationParticipantReplace**](ConversationsApi.html#postconversationparticipantreplace) | **POST** /api/v2/conversations/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationParticipantSecureivrsessions**](ConversationsApi.html#postconversationparticipantsecureivrsessions) | **POST** /api/v2/conversations/{conversationId}/participants/{participantId}/secureivrsessions | Create secure IVR session. Only a participant in the conversation can invoke a secure IVR. |
| [**PostConversationsCall**](ConversationsApi.html#postconversationscall) | **POST** /api/v2/conversations/calls/{conversationId} | Place a new call as part of a callback conversation. |
| [**PostConversationsCallParticipantConsult**](ConversationsApi.html#postconversationscallparticipantconsult) | **POST** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/consult | Initiate and update consult transfer |
| [**PostConversationsCallParticipantMonitor**](ConversationsApi.html#postconversationscallparticipantmonitor) | **POST** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/monitor | Listen in on the conversation from the point of view of a given participant. |
| [**PostConversationsCallParticipantReplace**](ConversationsApi.html#postconversationscallparticipantreplace) | **POST** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsCallParticipants**](ConversationsApi.html#postconversationscallparticipants) | **POST** /api/v2/conversations/calls/{conversationId}/participants | Add participants to a conversation |
| [**PostConversationsCallbackParticipantReplace**](ConversationsApi.html#postconversationscallbackparticipantreplace) | **POST** /api/v2/conversations/callbacks/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsCallbacks**](ConversationsApi.html#postconversationscallbacks) | **POST** /api/v2/conversations/callbacks | Create a Callback |
| [**PostConversationsCalls**](ConversationsApi.html#postconversationscalls) | **POST** /api/v2/conversations/calls | Create a call conversation |
| [**PostConversationsChatCommunicationMessages**](ConversationsApi.html#postconversationschatcommunicationmessages) | **POST** /api/v2/conversations/chats/{conversationId}/communications/{communicationId}/messages | Send a message on behalf of a communication in a chat conversation. |
| [**PostConversationsChatCommunicationTyping**](ConversationsApi.html#postconversationschatcommunicationtyping) | **POST** /api/v2/conversations/chats/{conversationId}/communications/{communicationId}/typing | Send a typing-indicator on behalf of a communication in a chat conversation. |
| [**PostConversationsChatParticipantReplace**](ConversationsApi.html#postconversationschatparticipantreplace) | **POST** /api/v2/conversations/chats/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsChats**](ConversationsApi.html#postconversationschats) | **POST** /api/v2/conversations/chats | Create a web chat conversation |
| [**PostConversationsCobrowsesessionParticipantReplace**](ConversationsApi.html#postconversationscobrowsesessionparticipantreplace) | **POST** /api/v2/conversations/cobrowsesessions/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsEmailInboundmessages**](ConversationsApi.html#postconversationsemailinboundmessages) | **POST** /api/v2/conversations/emails/{conversationId}/inboundmessages | Send an email to an external conversation. An external conversation is one where the provider is not PureCloud based. This endpoint allows the sender of the external email to reply or send a new message to the existing conversation. The new message will be treated as part of the existing conversation and chained to it. |
| [**PostConversationsEmailMessages**](ConversationsApi.html#postconversationsemailmessages) | **POST** /api/v2/conversations/emails/{conversationId}/messages | Send an email reply |
| [**PostConversationsEmailMessagesDraftAttachmentsCopy**](ConversationsApi.html#postconversationsemailmessagesdraftattachmentscopy) | **POST** /api/v2/conversations/emails/{conversationId}/messages/draft/attachments/copy | Copy attachments from an email message to the current draft. |
| [**PostConversationsEmailParticipantReplace**](ConversationsApi.html#postconversationsemailparticipantreplace) | **POST** /api/v2/conversations/emails/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsEmails**](ConversationsApi.html#postconversationsemails) | **POST** /api/v2/conversations/emails | Create an email conversation |
| [**PostConversationsFaxes**](ConversationsApi.html#postconversationsfaxes) | **POST** /api/v2/conversations/faxes | Create Fax Conversation |
| [**PostConversationsMessageCommunicationMessages**](ConversationsApi.html#postconversationsmessagecommunicationmessages) | **POST** /api/v2/conversations/messages/{conversationId}/communications/{communicationId}/messages | Send message |
| [**PostConversationsMessageCommunicationMessagesMedia**](ConversationsApi.html#postconversationsmessagecommunicationmessagesmedia) | **POST** /api/v2/conversations/messages/{conversationId}/communications/{communicationId}/messages/media | Create media |
| [**PostConversationsMessageMessagesBulk**](ConversationsApi.html#postconversationsmessagemessagesbulk) | **POST** /api/v2/conversations/messages/{conversationId}/messages/bulk | Get messages in batch |
| [**PostConversationsMessageParticipantReplace**](ConversationsApi.html#postconversationsmessageparticipantreplace) | **POST** /api/v2/conversations/messages/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsMessages**](ConversationsApi.html#postconversationsmessages) | **POST** /api/v2/conversations/messages | Create an outbound messaging conversation. |
| [**PostConversationsMessagesAgentless**](ConversationsApi.html#postconversationsmessagesagentless) | **POST** /api/v2/conversations/messages/agentless | Send an agentless outbound message |
| [**PostConversationsMessagingIntegrationsFacebook**](ConversationsApi.html#postconversationsmessagingintegrationsfacebook) | **POST** /api/v2/conversations/messaging/integrations/facebook | Create a Facebook Integration |
| [**PostConversationsMessagingIntegrationsLine**](ConversationsApi.html#postconversationsmessagingintegrationsline) | **POST** /api/v2/conversations/messaging/integrations/line | Create a LINE messenger Integration |
| [**PostConversationsMessagingIntegrationsTwitter**](ConversationsApi.html#postconversationsmessagingintegrationstwitter) | **POST** /api/v2/conversations/messaging/integrations/twitter | Create a Twitter Integration |
| [**PostConversationsMessagingIntegrationsWhatsapp**](ConversationsApi.html#postconversationsmessagingintegrationswhatsapp) | **POST** /api/v2/conversations/messaging/integrations/whatsapp | Create a WhatsApp Integration |
| [**PutConversationParticipantFlaggedreason**](ConversationsApi.html#putconversationparticipantflaggedreason) | **PUT** /api/v2/conversations/{conversationId}/participants/{participantId}/flaggedreason | Set flagged reason on conversation participant to indicate bad conversation quality. |
| [**PutConversationsCallParticipantCommunicationUuidata**](ConversationsApi.html#putconversationscallparticipantcommunicationuuidata) | **PUT** /api/v2/conversations/calls/{conversationId}/participants/{participantId}/communications/{communicationId}/uuidata | Set uuiData to be sent on future commands. |
| [**PutConversationsEmailMessagesDraft**](ConversationsApi.html#putconversationsemailmessagesdraft) | **PUT** /api/v2/conversations/emails/{conversationId}/messages/draft | Update conversation draft reply |
| [**PutConversationsMessagingIntegrationsLineIntegrationId**](ConversationsApi.html#putconversationsmessagingintegrationslineintegrationid) | **PUT** /api/v2/conversations/messaging/integrations/line/{integrationId} | Update a LINE messenger integration |
{: class="table table-striped"}

<a name="deleteanalyticsconversationsdetailsjob"></a>

## void DeleteAnalyticsConversationsDetailsJob (string jobId)



Delete/cancel an async request



Requires ANY permissions: 

* analytics:conversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteAnalyticsConversationsDetailsJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Delete/cancel an async request
                apiInstance.DeleteAnalyticsConversationsDetailsJob(jobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteAnalyticsConversationsDetailsJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteconversationparticipantcode"></a>

## void DeleteConversationParticipantCode (string conversationId, string participantId, string addCommunicationCode)



Delete a code used to add a communication to this participant



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationParticipantCodeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var addCommunicationCode = addCommunicationCode_example;  // string | addCommunicationCode

            try
            { 
                // Delete a code used to add a communication to this participant
                apiInstance.DeleteConversationParticipantCode(conversationId, participantId, addCommunicationCode);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationParticipantCode: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **addCommunicationCode** | **string**| addCommunicationCode |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteconversationparticipantflaggedreason"></a>

## void DeleteConversationParticipantFlaggedreason (string conversationId, string participantId)



Remove flagged reason from conversation participant.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationParticipantFlaggedreasonExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID

            try
            { 
                // Remove flagged reason from conversation participant.
                apiInstance.DeleteConversationParticipantFlaggedreason(conversationId, participantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationParticipantFlaggedreason: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteconversationscallparticipantconsult"></a>

## void DeleteConversationsCallParticipantConsult (string conversationId, string participantId)



Cancel the transfer



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationsCallParticipantConsultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId

            try
            { 
                // Cancel the transfer
                apiInstance.DeleteConversationsCallParticipantConsult(conversationId, participantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationsCallParticipantConsult: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteconversationsemailmessagesdraftattachment"></a>

## void DeleteConversationsEmailMessagesDraftAttachment (string conversationId, string attachmentId)



Delete attachment from draft



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationsEmailMessagesDraftAttachmentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var attachmentId = attachmentId_example;  // string | attachmentId

            try
            { 
                // Delete attachment from draft
                apiInstance.DeleteConversationsEmailMessagesDraftAttachment(conversationId, attachmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationsEmailMessagesDraftAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **attachmentId** | **string**| attachmentId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteconversationsmessagingintegrationsfacebookintegrationid"></a>

## void DeleteConversationsMessagingIntegrationsFacebookIntegrationId (string integrationId)



Delete a Facebook messaging integration



Requires ALL permissions: 

* messaging:integration:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationsMessagingIntegrationsFacebookIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID

            try
            { 
                // Delete a Facebook messaging integration
                apiInstance.DeleteConversationsMessagingIntegrationsFacebookIntegrationId(integrationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationsMessagingIntegrationsFacebookIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteconversationsmessagingintegrationslineintegrationid"></a>

## void DeleteConversationsMessagingIntegrationsLineIntegrationId (string integrationId)



Delete a LINE messenger integration



Requires ALL permissions: 

* messaging:integration:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationsMessagingIntegrationsLineIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID

            try
            { 
                // Delete a LINE messenger integration
                apiInstance.DeleteConversationsMessagingIntegrationsLineIntegrationId(integrationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationsMessagingIntegrationsLineIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteconversationsmessagingintegrationstwitterintegrationid"></a>

## void DeleteConversationsMessagingIntegrationsTwitterIntegrationId (string integrationId)



Delete a Twitter messaging integration



Requires ALL permissions: 

* messaging:integration:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationsMessagingIntegrationsTwitterIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID

            try
            { 
                // Delete a Twitter messaging integration
                apiInstance.DeleteConversationsMessagingIntegrationsTwitterIntegrationId(integrationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationsMessagingIntegrationsTwitterIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteconversationsmessagingintegrationswhatsappintegrationid"></a>

## [**WhatsAppIntegration**](WhatsAppIntegration.html) DeleteConversationsMessagingIntegrationsWhatsappIntegrationId (string integrationId)



Delete a WhatsApp messaging integration



Requires ALL permissions: 

* messaging:integration:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteConversationsMessagingIntegrationsWhatsappIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID

            try
            { 
                // Delete a WhatsApp messaging integration
                WhatsAppIntegration result = apiInstance.DeleteConversationsMessagingIntegrationsWhatsappIntegrationId(integrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationsMessagingIntegrationsWhatsappIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
{: class="table table-striped"}

### Return type

[**WhatsAppIntegration**](WhatsAppIntegration.html)

<a name="getanalyticsconversationdetails"></a>

## [**AnalyticsConversationWithoutAttributes**](AnalyticsConversationWithoutAttributes.html) GetAnalyticsConversationDetails (string conversationId)



Get a conversation by id



Requires ANY permissions: 

* analytics:conversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsConversationDetailsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            { 
                // Get a conversation by id
                AnalyticsConversationWithoutAttributes result = apiInstance.GetAnalyticsConversationDetails(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetAnalyticsConversationDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
{: class="table table-striped"}

### Return type

[**AnalyticsConversationWithoutAttributes**](AnalyticsConversationWithoutAttributes.html)

<a name="getanalyticsconversationsdetails"></a>

## [**AnalyticsConversationWithoutAttributesMultiGetResponse**](AnalyticsConversationWithoutAttributesMultiGetResponse.html) GetAnalyticsConversationsDetails (List<string> id = null)



Gets multiple conversations by id



Requires ANY permissions: 

* analytics:conversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsConversationsDetailsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var id = new List<string>(); // List<string> | Comma-separated conversation ids (optional) 

            try
            { 
                // Gets multiple conversations by id
                AnalyticsConversationWithoutAttributesMultiGetResponse result = apiInstance.GetAnalyticsConversationsDetails(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetAnalyticsConversationsDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | [**List<string>**](string.html)| Comma-separated conversation ids | [optional]  |
{: class="table table-striped"}

### Return type

[**AnalyticsConversationWithoutAttributesMultiGetResponse**](AnalyticsConversationWithoutAttributesMultiGetResponse.html)

<a name="getanalyticsconversationsdetailsjob"></a>

## [**AsyncQueryStatus**](AsyncQueryStatus.html) GetAnalyticsConversationsDetailsJob (string jobId)



Get status for async query for conversation details



Requires ANY permissions: 

* analytics:conversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsConversationsDetailsJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var jobId = jobId_example;  // string | jobId

            try
            { 
                // Get status for async query for conversation details
                AsyncQueryStatus result = apiInstance.GetAnalyticsConversationsDetailsJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetAnalyticsConversationsDetailsJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryStatus**](AsyncQueryStatus.html)

<a name="getanalyticsconversationsdetailsjobresults"></a>

## [**AnalyticsConversationAsyncQueryResponse**](AnalyticsConversationAsyncQueryResponse.html) GetAnalyticsConversationsDetailsJobResults (string jobId, string cursor = null, int? pageSize = null)



Fetch a page of results for an async query



Requires ANY permissions: 

* analytics:conversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAnalyticsConversationsDetailsJobResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var jobId = jobId_example;  // string | jobId
            var cursor = cursor_example;  // string | Indicates where to resume query results (not required for first page) (optional) 
            var pageSize = 56;  // int? | The desired maximum number of results (optional) 

            try
            { 
                // Fetch a page of results for an async query
                AnalyticsConversationAsyncQueryResponse result = apiInstance.GetAnalyticsConversationsDetailsJobResults(jobId, cursor, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetAnalyticsConversationsDetailsJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| jobId |  |
| **cursor** | **string**| Indicates where to resume query results (not required for first page) | [optional]  |
| **pageSize** | **int?**| The desired maximum number of results | [optional]  |
{: class="table table-striped"}

### Return type

[**AnalyticsConversationAsyncQueryResponse**](AnalyticsConversationAsyncQueryResponse.html)

<a name="getconversation"></a>

## [**Conversation**](Conversation.html) GetConversation (string conversationId)



Get conversation



Requires ANY permissions: 

* conversation:communication:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID

            try
            { 
                // Get conversation
                Conversation result = apiInstance.GetConversation(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="getconversationparticipantsecureivrsession"></a>

## [**SecureSession**](SecureSession.html) GetConversationParticipantSecureivrsession (string conversationId, string participantId, string secureSessionId)



Fetch info on a secure session



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationParticipantSecureivrsessionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var secureSessionId = secureSessionId_example;  // string | secure IVR session ID

            try
            { 
                // Fetch info on a secure session
                SecureSession result = apiInstance.GetConversationParticipantSecureivrsession(conversationId, participantId, secureSessionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationParticipantSecureivrsession: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **secureSessionId** | **string**| secure IVR session ID |  |
{: class="table table-striped"}

### Return type

[**SecureSession**](SecureSession.html)

<a name="getconversationparticipantsecureivrsessions"></a>

## [**SecureSessionEntityListing**](SecureSessionEntityListing.html) GetConversationParticipantSecureivrsessions (string conversationId, string participantId)



Get a list of secure sessions for this participant.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationParticipantSecureivrsessionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID

            try
            { 
                // Get a list of secure sessions for this participant.
                SecureSessionEntityListing result = apiInstance.GetConversationParticipantSecureivrsessions(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationParticipantSecureivrsessions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
{: class="table table-striped"}

### Return type

[**SecureSessionEntityListing**](SecureSessionEntityListing.html)

<a name="getconversationparticipantwrapup"></a>

## [**AssignedWrapupCode**](AssignedWrapupCode.html) GetConversationParticipantWrapup (string conversationId, string participantId, bool? provisional = null)



Get the wrap-up for this conversation participant. 



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationParticipantWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

            try
            { 
                // Get the wrap-up for this conversation participant. 
                AssignedWrapupCode result = apiInstance.GetConversationParticipantWrapup(conversationId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationParticipantWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode.html)

<a name="getconversationparticipantwrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) GetConversationParticipantWrapupcodes (string conversationId, string participantId)



Get list of wrapup codes for this conversation participant



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationParticipantWrapupcodesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID

            try
            { 
                // Get list of wrapup codes for this conversation participant
                List&lt;WrapupCode&gt; result = apiInstance.GetConversationParticipantWrapupcodes(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationParticipantWrapupcodes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
{: class="table table-striped"}

### Return type

[**List<WrapupCode>**](WrapupCode.html)

<a name="getconversations"></a>

## [**ConversationEntityListing**](ConversationEntityListing.html) GetConversations (string communicationType = null)



Get active conversations for the logged in user



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var communicationType = communicationType_example;  // string | Call or Chat communication filtering (optional) 

            try
            { 
                // Get active conversations for the logged in user
                ConversationEntityListing result = apiInstance.GetConversations(communicationType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **communicationType** | **string**| Call or Chat communication filtering | [optional]  |
{: class="table table-striped"}

### Return type

[**ConversationEntityListing**](ConversationEntityListing.html)

<a name="getconversationscall"></a>

## [**CallConversation**](CallConversation.html) GetConversationsCall (string conversationId)



Get call conversation



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            { 
                // Get call conversation
                CallConversation result = apiInstance.GetConversationsCall(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCall: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
{: class="table table-striped"}

### Return type

[**CallConversation**](CallConversation.html)

<a name="getconversationscallparticipantwrapup"></a>

## [**AssignedWrapupCode**](AssignedWrapupCode.html) GetConversationsCallParticipantWrapup (string conversationId, string participantId, bool? provisional = null)



Get the wrap-up for this conversation participant. 



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallParticipantWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

            try
            { 
                // Get the wrap-up for this conversation participant. 
                AssignedWrapupCode result = apiInstance.GetConversationsCallParticipantWrapup(conversationId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallParticipantWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode.html)

<a name="getconversationscallparticipantwrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) GetConversationsCallParticipantWrapupcodes (string conversationId, string participantId)



Get list of wrapup codes for this conversation participant



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallParticipantWrapupcodesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId

            try
            { 
                // Get list of wrapup codes for this conversation participant
                List&lt;WrapupCode&gt; result = apiInstance.GetConversationsCallParticipantWrapupcodes(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallParticipantWrapupcodes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
{: class="table table-striped"}

### Return type

[**List<WrapupCode>**](WrapupCode.html)

<a name="getconversationscallback"></a>

## [**CallbackConversation**](CallbackConversation.html) GetConversationsCallback (string conversationId)



Get callback conversation



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallbackExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            { 
                // Get callback conversation
                CallbackConversation result = apiInstance.GetConversationsCallback(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallback: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
{: class="table table-striped"}

### Return type

[**CallbackConversation**](CallbackConversation.html)

<a name="getconversationscallbackparticipantwrapup"></a>

## [**AssignedWrapupCode**](AssignedWrapupCode.html) GetConversationsCallbackParticipantWrapup (string conversationId, string participantId, bool? provisional = null)



Get the wrap-up for this conversation participant. 



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallbackParticipantWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

            try
            { 
                // Get the wrap-up for this conversation participant. 
                AssignedWrapupCode result = apiInstance.GetConversationsCallbackParticipantWrapup(conversationId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallbackParticipantWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode.html)

<a name="getconversationscallbackparticipantwrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) GetConversationsCallbackParticipantWrapupcodes (string conversationId, string participantId)



Get list of wrapup codes for this conversation participant



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallbackParticipantWrapupcodesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId

            try
            { 
                // Get list of wrapup codes for this conversation participant
                List&lt;WrapupCode&gt; result = apiInstance.GetConversationsCallbackParticipantWrapupcodes(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallbackParticipantWrapupcodes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
{: class="table table-striped"}

### Return type

[**List<WrapupCode>**](WrapupCode.html)

<a name="getconversationscallbacks"></a>

## [**CallbackConversationEntityListing**](CallbackConversationEntityListing.html) GetConversationsCallbacks ()



Get active callback conversations for the logged in user



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallbacksExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();

            try
            { 
                // Get active callback conversations for the logged in user
                CallbackConversationEntityListing result = apiInstance.GetConversationsCallbacks();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallbacks: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**CallbackConversationEntityListing**](CallbackConversationEntityListing.html)

<a name="getconversationscalls"></a>

## [**CallConversationEntityListing**](CallConversationEntityListing.html) GetConversationsCalls ()



Get active call conversations for the logged in user



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();

            try
            { 
                // Get active call conversations for the logged in user
                CallConversationEntityListing result = apiInstance.GetConversationsCalls();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCalls: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**CallConversationEntityListing**](CallConversationEntityListing.html)

<a name="getconversationscallshistory"></a>

## [**CallHistoryConversationEntityListing**](CallHistoryConversationEntityListing.html) GetConversationsCallsHistory (int? pageSize = null, int? pageNumber = null, string interval = null, List<string> expand = null)



Get call history



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallsHistoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var pageSize = 56;  // int? | Page size, maximum 50 (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var interval = interval_example;  // string | Interval string; format is ISO-8601. Separate start and end times with forward slash '/' (optional) 
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            { 
                // Get call history
                CallHistoryConversationEntityListing result = apiInstance.GetConversationsCallsHistory(pageSize, pageNumber, interval, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallsHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size, maximum 50 | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **interval** | **string**| Interval string; format is ISO-8601. Separate start and end times with forward slash &#39;/&#39; | [optional]  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional] <br />**Values**: externalorganization, externalcontact, user, queue, group |
{: class="table table-striped"}

### Return type

[**CallHistoryConversationEntityListing**](CallHistoryConversationEntityListing.html)

<a name="getconversationscallsmaximumconferenceparties"></a>

## [**MaxParticipants**](MaxParticipants.html) GetConversationsCallsMaximumconferenceparties ()



Get the maximum number of participants that this user can have on a conference



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCallsMaximumconferencepartiesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();

            try
            { 
                // Get the maximum number of participants that this user can have on a conference
                MaxParticipants result = apiInstance.GetConversationsCallsMaximumconferenceparties();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCallsMaximumconferenceparties: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**MaxParticipants**](MaxParticipants.html)

<a name="getconversationschat"></a>

## [**ChatConversation**](ChatConversation.html) GetConversationsChat (string conversationId)



Get chat conversation



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsChatExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            { 
                // Get chat conversation
                ChatConversation result = apiInstance.GetConversationsChat(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsChat: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
{: class="table table-striped"}

### Return type

[**ChatConversation**](ChatConversation.html)

<a name="getconversationschatmessage"></a>

## [**WebChatMessage**](WebChatMessage.html) GetConversationsChatMessage (string conversationId, string messageId)



Get a web chat conversation message

The current user must be involved with the conversation to get its messages.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsChatMessageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var messageId = messageId_example;  // string | messageId

            try
            { 
                // Get a web chat conversation message
                WebChatMessage result = apiInstance.GetConversationsChatMessage(conversationId, messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsChatMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **messageId** | **string**| messageId |  |
{: class="table table-striped"}

### Return type

[**WebChatMessage**](WebChatMessage.html)

<a name="getconversationschatmessages"></a>

## [**WebChatMessageEntityList**](WebChatMessageEntityList.html) GetConversationsChatMessages (string conversationId, string after = null, string before = null, string sortOrder = null, int? maxResults = null)



Get the messages of a chat conversation.

The current user must be involved with the conversation to get its messages.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsChatMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var after = after_example;  // string | If specified, get the messages chronologically after the id of this message (optional) 
            var before = before_example;  // string | If specified, get the messages chronologically before the id of this message (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ascending)
            var maxResults = 56;  // int? | Limit the returned number of messages, up to a maximum of 100 (optional)  (default to 100)

            try
            { 
                // Get the messages of a chat conversation.
                WebChatMessageEntityList result = apiInstance.GetConversationsChatMessages(conversationId, after, before, sortOrder, maxResults);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsChatMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **after** | **string**| If specified, get the messages chronologically after the id of this message | [optional]  |
| **before** | **string**| If specified, get the messages chronologically before the id of this message | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to ascending]<br />**Values**: ascending, descending |
| **maxResults** | **int?**| Limit the returned number of messages, up to a maximum of 100 | [optional] [default to 100] |
{: class="table table-striped"}

### Return type

[**WebChatMessageEntityList**](WebChatMessageEntityList.html)

<a name="getconversationschatparticipantwrapup"></a>

## [**AssignedWrapupCode**](AssignedWrapupCode.html) GetConversationsChatParticipantWrapup (string conversationId, string participantId, bool? provisional = null)



Get the wrap-up for this conversation participant. 



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsChatParticipantWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

            try
            { 
                // Get the wrap-up for this conversation participant. 
                AssignedWrapupCode result = apiInstance.GetConversationsChatParticipantWrapup(conversationId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsChatParticipantWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode.html)

<a name="getconversationschatparticipantwrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) GetConversationsChatParticipantWrapupcodes (string conversationId, string participantId)



Get list of wrapup codes for this conversation participant



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsChatParticipantWrapupcodesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId

            try
            { 
                // Get list of wrapup codes for this conversation participant
                List&lt;WrapupCode&gt; result = apiInstance.GetConversationsChatParticipantWrapupcodes(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsChatParticipantWrapupcodes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
{: class="table table-striped"}

### Return type

[**List<WrapupCode>**](WrapupCode.html)

<a name="getconversationschats"></a>

## [**ChatConversationEntityListing**](ChatConversationEntityListing.html) GetConversationsChats ()



Get active chat conversations for the logged in user



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsChatsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();

            try
            { 
                // Get active chat conversations for the logged in user
                ChatConversationEntityListing result = apiInstance.GetConversationsChats();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsChats: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**ChatConversationEntityListing**](ChatConversationEntityListing.html)

<a name="getconversationscobrowsesession"></a>

## [**CobrowseConversation**](CobrowseConversation.html) GetConversationsCobrowsesession (string conversationId)



Get cobrowse conversation



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCobrowsesessionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            { 
                // Get cobrowse conversation
                CobrowseConversation result = apiInstance.GetConversationsCobrowsesession(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCobrowsesession: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
{: class="table table-striped"}

### Return type

[**CobrowseConversation**](CobrowseConversation.html)

<a name="getconversationscobrowsesessionparticipantwrapup"></a>

## [**AssignedWrapupCode**](AssignedWrapupCode.html) GetConversationsCobrowsesessionParticipantWrapup (string conversationId, string participantId, bool? provisional = null)



Get the wrap-up for this conversation participant. 



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCobrowsesessionParticipantWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

            try
            { 
                // Get the wrap-up for this conversation participant. 
                AssignedWrapupCode result = apiInstance.GetConversationsCobrowsesessionParticipantWrapup(conversationId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCobrowsesessionParticipantWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode.html)

<a name="getconversationscobrowsesessionparticipantwrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) GetConversationsCobrowsesessionParticipantWrapupcodes (string conversationId, string participantId)



Get list of wrapup codes for this conversation participant



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCobrowsesessionParticipantWrapupcodesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId

            try
            { 
                // Get list of wrapup codes for this conversation participant
                List&lt;WrapupCode&gt; result = apiInstance.GetConversationsCobrowsesessionParticipantWrapupcodes(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCobrowsesessionParticipantWrapupcodes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
{: class="table table-striped"}

### Return type

[**List<WrapupCode>**](WrapupCode.html)

<a name="getconversationscobrowsesessions"></a>

## [**CobrowseConversationEntityListing**](CobrowseConversationEntityListing.html) GetConversationsCobrowsesessions ()



Get active cobrowse conversations for the logged in user



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsCobrowsesessionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();

            try
            { 
                // Get active cobrowse conversations for the logged in user
                CobrowseConversationEntityListing result = apiInstance.GetConversationsCobrowsesessions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsCobrowsesessions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**CobrowseConversationEntityListing**](CobrowseConversationEntityListing.html)

<a name="getconversationsemail"></a>

## [**EmailConversation**](EmailConversation.html) GetConversationsEmail (string conversationId)



Get email conversation



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsEmailExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            { 
                // Get email conversation
                EmailConversation result = apiInstance.GetConversationsEmail(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
{: class="table table-striped"}

### Return type

[**EmailConversation**](EmailConversation.html)

<a name="getconversationsemailmessage"></a>

## [**EmailMessage**](EmailMessage.html) GetConversationsEmailMessage (string conversationId, string messageId)



Get conversation message



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsEmailMessageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var messageId = messageId_example;  // string | messageId

            try
            { 
                // Get conversation message
                EmailMessage result = apiInstance.GetConversationsEmailMessage(conversationId, messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsEmailMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **messageId** | **string**| messageId |  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.html)

<a name="getconversationsemailmessages"></a>

## [**EmailMessageListing**](EmailMessageListing.html) GetConversationsEmailMessages (string conversationId)



Get conversation messages



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsEmailMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            { 
                // Get conversation messages
                EmailMessageListing result = apiInstance.GetConversationsEmailMessages(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsEmailMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
{: class="table table-striped"}

### Return type

[**EmailMessageListing**](EmailMessageListing.html)

<a name="getconversationsemailmessagesdraft"></a>

## [**EmailMessage**](EmailMessage.html) GetConversationsEmailMessagesDraft (string conversationId)



Get conversation draft reply



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsEmailMessagesDraftExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            { 
                // Get conversation draft reply
                EmailMessage result = apiInstance.GetConversationsEmailMessagesDraft(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsEmailMessagesDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.html)

<a name="getconversationsemailparticipantwrapup"></a>

## [**AssignedWrapupCode**](AssignedWrapupCode.html) GetConversationsEmailParticipantWrapup (string conversationId, string participantId, bool? provisional = null)



Get the wrap-up for this conversation participant. 



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsEmailParticipantWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

            try
            { 
                // Get the wrap-up for this conversation participant. 
                AssignedWrapupCode result = apiInstance.GetConversationsEmailParticipantWrapup(conversationId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsEmailParticipantWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode.html)

<a name="getconversationsemailparticipantwrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) GetConversationsEmailParticipantWrapupcodes (string conversationId, string participantId)



Get list of wrapup codes for this conversation participant



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsEmailParticipantWrapupcodesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId

            try
            { 
                // Get list of wrapup codes for this conversation participant
                List&lt;WrapupCode&gt; result = apiInstance.GetConversationsEmailParticipantWrapupcodes(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsEmailParticipantWrapupcodes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
{: class="table table-striped"}

### Return type

[**List<WrapupCode>**](WrapupCode.html)

<a name="getconversationsemails"></a>

## [**EmailConversationEntityListing**](EmailConversationEntityListing.html) GetConversationsEmails ()



Get active email conversations for the logged in user



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsEmailsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();

            try
            { 
                // Get active email conversations for the logged in user
                EmailConversationEntityListing result = apiInstance.GetConversationsEmails();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsEmails: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**EmailConversationEntityListing**](EmailConversationEntityListing.html)

<a name="getconversationsmessage"></a>

## [**MessageConversation**](MessageConversation.html) GetConversationsMessage (string conversationId)



Get message conversation



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            { 
                // Get message conversation
                MessageConversation result = apiInstance.GetConversationsMessage(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
{: class="table table-striped"}

### Return type

[**MessageConversation**](MessageConversation.html)

<a name="getconversationsmessagecommunicationmessagesmediamediaid"></a>

## [**MessageMediaData**](MessageMediaData.html) GetConversationsMessageCommunicationMessagesMediaMediaId (string conversationId, string communicationId, string mediaId)



Get media



Requires ANY permissions: 

* conversation:message:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessageCommunicationMessagesMediaMediaIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var communicationId = communicationId_example;  // string | communicationId
            var mediaId = mediaId_example;  // string | mediaId

            try
            { 
                // Get media
                MessageMediaData result = apiInstance.GetConversationsMessageCommunicationMessagesMediaMediaId(conversationId, communicationId, mediaId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessageCommunicationMessagesMediaMediaId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **communicationId** | **string**| communicationId |  |
| **mediaId** | **string**| mediaId |  |
{: class="table table-striped"}

### Return type

[**MessageMediaData**](MessageMediaData.html)

<a name="getconversationsmessagemessage"></a>

## [**MessageData**](MessageData.html) GetConversationsMessageMessage (string conversationId, string messageId)



Get message



Requires ANY permissions: 

* conversation:message:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessageMessageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var messageId = messageId_example;  // string | messageId

            try
            { 
                // Get message
                MessageData result = apiInstance.GetConversationsMessageMessage(conversationId, messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessageMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **messageId** | **string**| messageId |  |
{: class="table table-striped"}

### Return type

[**MessageData**](MessageData.html)

<a name="getconversationsmessageparticipantwrapup"></a>

## [**AssignedWrapupCode**](AssignedWrapupCode.html) GetConversationsMessageParticipantWrapup (string conversationId, string participantId, bool? provisional = null)



Get the wrap-up for this conversation participant. 



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessageParticipantWrapupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

            try
            { 
                // Get the wrap-up for this conversation participant. 
                AssignedWrapupCode result = apiInstance.GetConversationsMessageParticipantWrapup(conversationId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessageParticipantWrapup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AssignedWrapupCode**](AssignedWrapupCode.html)

<a name="getconversationsmessageparticipantwrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) GetConversationsMessageParticipantWrapupcodes (string conversationId, string participantId)



Get list of wrapup codes for this conversation participant



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessageParticipantWrapupcodesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string |  conversationId
            var participantId = participantId_example;  // string | participantId

            try
            { 
                // Get list of wrapup codes for this conversation participant
                List&lt;WrapupCode&gt; result = apiInstance.GetConversationsMessageParticipantWrapupcodes(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessageParticipantWrapupcodes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**|  conversationId |  |
| **participantId** | **string**| participantId |  |
{: class="table table-striped"}

### Return type

[**List<WrapupCode>**](WrapupCode.html)

<a name="getconversationsmessages"></a>

## [**MessageConversationEntityListing**](MessageConversationEntityListing.html) GetConversationsMessages ()



Get active message conversations for the logged in user



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();

            try
            { 
                // Get active message conversations for the logged in user
                MessageConversationEntityListing result = apiInstance.GetConversationsMessages();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**MessageConversationEntityListing**](MessageConversationEntityListing.html)

<a name="getconversationsmessagingfacebookapp"></a>

## [**FacebookAppCredentials**](FacebookAppCredentials.html) GetConversationsMessagingFacebookApp ()



Get Genesys Facebook App Id



Requires ALL permissions: 

* messaging:integration:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingFacebookAppExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();

            try
            { 
                // Get Genesys Facebook App Id
                FacebookAppCredentials result = apiInstance.GetConversationsMessagingFacebookApp();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingFacebookApp: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**FacebookAppCredentials**](FacebookAppCredentials.html)

<a name="getconversationsmessagingintegrations"></a>

## [**MessagingIntegrationEntityListing**](MessagingIntegrationEntityListing.html) GetConversationsMessagingIntegrations (int? pageSize = null, int? pageNumber = null)



Get a list of Integrations



Requires ALL permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIntegrationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of Integrations
                MessagingIntegrationEntityListing result = apiInstance.GetConversationsMessagingIntegrations(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**MessagingIntegrationEntityListing**](MessagingIntegrationEntityListing.html)

<a name="getconversationsmessagingintegrationsfacebook"></a>

## [**FacebookIntegrationEntityListing**](FacebookIntegrationEntityListing.html) GetConversationsMessagingIntegrationsFacebook (int? pageSize = null, int? pageNumber = null)



Get a list of Facebook Integrations



Requires ALL permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIntegrationsFacebookExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of Facebook Integrations
                FacebookIntegrationEntityListing result = apiInstance.GetConversationsMessagingIntegrationsFacebook(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrationsFacebook: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**FacebookIntegrationEntityListing**](FacebookIntegrationEntityListing.html)

<a name="getconversationsmessagingintegrationsfacebookintegrationid"></a>

## [**FacebookIntegration**](FacebookIntegration.html) GetConversationsMessagingIntegrationsFacebookIntegrationId (string integrationId)



Get a Facebook messaging integration



Requires ALL permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIntegrationsFacebookIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID

            try
            { 
                // Get a Facebook messaging integration
                FacebookIntegration result = apiInstance.GetConversationsMessagingIntegrationsFacebookIntegrationId(integrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrationsFacebookIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
{: class="table table-striped"}

### Return type

[**FacebookIntegration**](FacebookIntegration.html)

<a name="getconversationsmessagingintegrationsline"></a>

## [**LineIntegrationEntityListing**](LineIntegrationEntityListing.html) GetConversationsMessagingIntegrationsLine (int? pageSize = null, int? pageNumber = null)



Get a list of LINE messenger Integrations



Requires ALL permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIntegrationsLineExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of LINE messenger Integrations
                LineIntegrationEntityListing result = apiInstance.GetConversationsMessagingIntegrationsLine(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrationsLine: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**LineIntegrationEntityListing**](LineIntegrationEntityListing.html)

<a name="getconversationsmessagingintegrationslineintegrationid"></a>

## [**LineIntegration**](LineIntegration.html) GetConversationsMessagingIntegrationsLineIntegrationId (string integrationId)



Get a LINE messenger integration



Requires ALL permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIntegrationsLineIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID

            try
            { 
                // Get a LINE messenger integration
                LineIntegration result = apiInstance.GetConversationsMessagingIntegrationsLineIntegrationId(integrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrationsLineIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
{: class="table table-striped"}

### Return type

[**LineIntegration**](LineIntegration.html)

<a name="getconversationsmessagingintegrationstwitter"></a>

## [**TwitterIntegrationEntityListing**](TwitterIntegrationEntityListing.html) GetConversationsMessagingIntegrationsTwitter (int? pageSize = null, int? pageNumber = null)



Get a list of Twitter Integrations



Requires ALL permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIntegrationsTwitterExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of Twitter Integrations
                TwitterIntegrationEntityListing result = apiInstance.GetConversationsMessagingIntegrationsTwitter(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrationsTwitter: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**TwitterIntegrationEntityListing**](TwitterIntegrationEntityListing.html)

<a name="getconversationsmessagingintegrationstwitterintegrationid"></a>

## [**TwitterIntegration**](TwitterIntegration.html) GetConversationsMessagingIntegrationsTwitterIntegrationId (string integrationId)



Get a Twitter messaging integration



Requires ALL permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIntegrationsTwitterIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID

            try
            { 
                // Get a Twitter messaging integration
                TwitterIntegration result = apiInstance.GetConversationsMessagingIntegrationsTwitterIntegrationId(integrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrationsTwitterIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
{: class="table table-striped"}

### Return type

[**TwitterIntegration**](TwitterIntegration.html)

<a name="getconversationsmessagingintegrationswhatsapp"></a>

## [**WhatsAppIntegrationEntityListing**](WhatsAppIntegrationEntityListing.html) GetConversationsMessagingIntegrationsWhatsapp (int? pageSize = null, int? pageNumber = null)



Get a list of WhatsApp Integrations



Requires ALL permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIntegrationsWhatsappExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of WhatsApp Integrations
                WhatsAppIntegrationEntityListing result = apiInstance.GetConversationsMessagingIntegrationsWhatsapp(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrationsWhatsapp: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**WhatsAppIntegrationEntityListing**](WhatsAppIntegrationEntityListing.html)

<a name="getconversationsmessagingintegrationswhatsappintegrationid"></a>

## [**WhatsAppIntegration**](WhatsAppIntegration.html) GetConversationsMessagingIntegrationsWhatsappIntegrationId (string integrationId)



Get a WhatsApp messaging integration



Requires ALL permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingIntegrationsWhatsappIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID

            try
            { 
                // Get a WhatsApp messaging integration
                WhatsAppIntegration result = apiInstance.GetConversationsMessagingIntegrationsWhatsappIntegrationId(integrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingIntegrationsWhatsappIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
{: class="table table-striped"}

### Return type

[**WhatsAppIntegration**](WhatsAppIntegration.html)

<a name="getconversationsmessagingsticker"></a>

## [**MessagingStickerEntityListing**](MessagingStickerEntityListing.html) GetConversationsMessagingSticker (string messengerType, int? pageSize = null, int? pageNumber = null)



Get a list of Messaging Stickers



Requires ALL permissions: 

* conversation:message:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetConversationsMessagingStickerExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var messengerType = messengerType_example;  // string | Messenger Type
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of Messaging Stickers
                MessagingStickerEntityListing result = apiInstance.GetConversationsMessagingSticker(messengerType, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsMessagingSticker: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messengerType** | **string**| Messenger Type |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**MessagingStickerEntityListing**](MessagingStickerEntityListing.html)

<a name="patchconversationparticipant"></a>

## void PatchConversationParticipant (string conversationId, string participantId, MediaParticipantRequest body)



Update a participant.

Update conversation participant.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationParticipantExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Update request

            try
            { 
                // Update a participant.
                apiInstance.PatchConversationParticipant(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationParticipant: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Update request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationparticipantattributes"></a>

## void PatchConversationParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)



Update the attributes on a conversation participant.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationParticipantAttributesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new ParticipantAttributes(); // ParticipantAttributes | Participant attributes

            try
            { 
                // Update the attributes on a conversation participant.
                apiInstance.PatchConversationParticipantAttributes(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationParticipantAttributes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)| Participant attributes |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationscall"></a>

## [**Conversation**](Conversation.html) PatchConversationsCall (string conversationId, Conversation body)



Update a conversation by setting it's recording state, merging in other conversations to create a conference, or disconnecting all of the participants



Requires ANY permissions: 

* conversation:communication:disconnect

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new Conversation(); // Conversation | Conversation

            try
            { 
                // Update a conversation by setting it's recording state, merging in other conversations to create a conference, or disconnecting all of the participants
                Conversation result = apiInstance.PatchConversationsCall(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCall: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**Conversation**](Conversation.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="patchconversationscallparticipant"></a>

## void PatchConversationsCallParticipant (string conversationId, string participantId, MediaParticipantRequest body)



Update conversation participant



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallParticipantExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant request

            try
            { 
                // Update conversation participant
                apiInstance.PatchConversationsCallParticipant(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallParticipant: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationscallparticipantattributes"></a>

## void PatchConversationsCallParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)



Update the attributes on a conversation participant.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallParticipantAttributesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ParticipantAttributes(); // ParticipantAttributes | Participant attributes

            try
            { 
                // Update the attributes on a conversation participant.
                apiInstance.PatchConversationsCallParticipantAttributes(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallParticipantAttributes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)| Participant attributes |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationscallparticipantcommunication"></a>

## [**Empty**](Empty.html) PatchConversationsCallParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)



Update conversation participant's communication by disconnecting it.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallParticipantCommunicationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant

            try
            { 
                // Update conversation participant's communication by disconnecting it.
                Empty result = apiInstance.PatchConversationsCallParticipantCommunication(conversationId, participantId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallParticipantCommunication: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant |  |
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="patchconversationscallparticipantconsult"></a>

## [**ConsultTransferResponse**](ConsultTransferResponse.html) PatchConversationsCallParticipantConsult (string conversationId, string participantId, ConsultTransferUpdate body)



Change who can speak



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallParticipantConsultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ConsultTransferUpdate(); // ConsultTransferUpdate | new speak to

            try
            { 
                // Change who can speak
                ConsultTransferResponse result = apiInstance.PatchConversationsCallParticipantConsult(conversationId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallParticipantConsult: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ConsultTransferUpdate**](ConsultTransferUpdate.html)| new speak to |  |
{: class="table table-striped"}

### Return type

[**ConsultTransferResponse**](ConsultTransferResponse.html)

<a name="patchconversationscallback"></a>

## [**Conversation**](Conversation.html) PatchConversationsCallback (string conversationId, Conversation body)



Update a conversation by disconnecting all of the participants



Requires ANY permissions: 

* conversation:communication:disconnect

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallbackExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new Conversation(); // Conversation | Conversation

            try
            { 
                // Update a conversation by disconnecting all of the participants
                Conversation result = apiInstance.PatchConversationsCallback(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallback: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**Conversation**](Conversation.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="patchconversationscallbackparticipant"></a>

## void PatchConversationsCallbackParticipant (string conversationId, string participantId, MediaParticipantRequest body)



Update conversation participant



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallbackParticipantExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant

            try
            { 
                // Update conversation participant
                apiInstance.PatchConversationsCallbackParticipant(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallbackParticipant: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationscallbackparticipantattributes"></a>

## void PatchConversationsCallbackParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)



Update the attributes on a conversation participant.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallbackParticipantAttributesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ParticipantAttributes(); // ParticipantAttributes | Attributes

            try
            { 
                // Update the attributes on a conversation participant.
                apiInstance.PatchConversationsCallbackParticipantAttributes(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallbackParticipantAttributes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)| Attributes |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationscallbackparticipantcommunication"></a>

## [**Empty**](Empty.html) PatchConversationsCallbackParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)



Update conversation participant's communication by disconnecting it.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCallbackParticipantCommunicationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant

            try
            { 
                // Update conversation participant's communication by disconnecting it.
                Empty result = apiInstance.PatchConversationsCallbackParticipantCommunication(conversationId, participantId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCallbackParticipantCommunication: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant |  |
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="patchconversationschat"></a>

## [**Conversation**](Conversation.html) PatchConversationsChat (string conversationId, Conversation body)



Update a conversation by disconnecting all of the participants



Requires ANY permissions: 

* conversation:communication:disconnect

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsChatExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new Conversation(); // Conversation | Conversation

            try
            { 
                // Update a conversation by disconnecting all of the participants
                Conversation result = apiInstance.PatchConversationsChat(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsChat: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**Conversation**](Conversation.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="patchconversationschatparticipant"></a>

## void PatchConversationsChatParticipant (string conversationId, string participantId, MediaParticipantRequest body)



Update conversation participant



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsChatParticipantExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Update request

            try
            { 
                // Update conversation participant
                apiInstance.PatchConversationsChatParticipant(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsChatParticipant: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Update request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationschatparticipantattributes"></a>

## void PatchConversationsChatParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)



Update the attributes on a conversation participant.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsChatParticipantAttributesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ParticipantAttributes(); // ParticipantAttributes | Participant attributes

            try
            { 
                // Update the attributes on a conversation participant.
                apiInstance.PatchConversationsChatParticipantAttributes(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsChatParticipantAttributes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)| Participant attributes |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationschatparticipantcommunication"></a>

## [**Empty**](Empty.html) PatchConversationsChatParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)



Update conversation participant's communication by disconnecting it.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsChatParticipantCommunicationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant

            try
            { 
                // Update conversation participant's communication by disconnecting it.
                Empty result = apiInstance.PatchConversationsChatParticipantCommunication(conversationId, participantId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsChatParticipantCommunication: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant |  |
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="patchconversationscobrowsesession"></a>

## [**Conversation**](Conversation.html) PatchConversationsCobrowsesession (string conversationId, Conversation body)



Update a conversation by disconnecting all of the participants



Requires ANY permissions: 

* conversation:communication:disconnect

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCobrowsesessionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new Conversation(); // Conversation | Conversation

            try
            { 
                // Update a conversation by disconnecting all of the participants
                Conversation result = apiInstance.PatchConversationsCobrowsesession(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCobrowsesession: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**Conversation**](Conversation.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="patchconversationscobrowsesessionparticipant"></a>

## void PatchConversationsCobrowsesessionParticipant (string conversationId, string participantId, MediaParticipantRequest body = null)



Update conversation participant



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCobrowsesessionParticipantExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest |  (optional) 

            try
            { 
                // Update conversation participant
                apiInstance.PatchConversationsCobrowsesessionParticipant(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCobrowsesessionParticipant: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationscobrowsesessionparticipantattributes"></a>

## void PatchConversationsCobrowsesessionParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body = null)



Update the attributes on a conversation participant.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCobrowsesessionParticipantAttributesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ParticipantAttributes(); // ParticipantAttributes |  (optional) 

            try
            { 
                // Update the attributes on a conversation participant.
                apiInstance.PatchConversationsCobrowsesessionParticipantAttributes(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCobrowsesessionParticipantAttributes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationscobrowsesessionparticipantcommunication"></a>

## [**Empty**](Empty.html) PatchConversationsCobrowsesessionParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)



Update conversation participant's communication by disconnecting it.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsCobrowsesessionParticipantCommunicationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant

            try
            { 
                // Update conversation participant's communication by disconnecting it.
                Empty result = apiInstance.PatchConversationsCobrowsesessionParticipantCommunication(conversationId, participantId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsCobrowsesessionParticipantCommunication: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant |  |
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="patchconversationsemail"></a>

## [**Conversation**](Conversation.html) PatchConversationsEmail (string conversationId, Conversation body)



Update a conversation by disconnecting all of the participants



Requires ANY permissions: 

* conversation:communication:disconnect

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsEmailExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new Conversation(); // Conversation | Conversation

            try
            { 
                // Update a conversation by disconnecting all of the participants
                Conversation result = apiInstance.PatchConversationsEmail(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**Conversation**](Conversation.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="patchconversationsemailparticipant"></a>

## void PatchConversationsEmailParticipant (string conversationId, string participantId, MediaParticipantRequest body)



Update conversation participant



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsEmailParticipantExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Update request

            try
            { 
                // Update conversation participant
                apiInstance.PatchConversationsEmailParticipant(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsEmailParticipant: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Update request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationsemailparticipantattributes"></a>

## void PatchConversationsEmailParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)



Update the attributes on a conversation participant.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsEmailParticipantAttributesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ParticipantAttributes(); // ParticipantAttributes | Participant attributes

            try
            { 
                // Update the attributes on a conversation participant.
                apiInstance.PatchConversationsEmailParticipantAttributes(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsEmailParticipantAttributes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)| Participant attributes |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationsemailparticipantcommunication"></a>

## [**Empty**](Empty.html) PatchConversationsEmailParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)



Update conversation participant's communication by disconnecting it.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsEmailParticipantCommunicationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant

            try
            { 
                // Update conversation participant's communication by disconnecting it.
                Empty result = apiInstance.PatchConversationsEmailParticipantCommunication(conversationId, participantId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsEmailParticipantCommunication: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant |  |
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="patchconversationsmessage"></a>

## [**Conversation**](Conversation.html) PatchConversationsMessage (string conversationId, Conversation body)



Update a conversation by disconnecting all of the participants



Requires ANY permissions: 

* conversation:communication:disconnect

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsMessageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new Conversation(); // Conversation | Conversation

            try
            { 
                // Update a conversation by disconnecting all of the participants
                Conversation result = apiInstance.PatchConversationsMessage(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**Conversation**](Conversation.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="patchconversationsmessageparticipant"></a>

## void PatchConversationsMessageParticipant (string conversationId, string participantId, MediaParticipantRequest body = null)



Update conversation participant



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsMessageParticipantExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string |  conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest |  (optional) 

            try
            { 
                // Update conversation participant
                apiInstance.PatchConversationsMessageParticipant(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsMessageParticipant: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**|  conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationsmessageparticipantattributes"></a>

## void PatchConversationsMessageParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body = null)



Update the attributes on a conversation participant.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsMessageParticipantAttributesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string |  conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ParticipantAttributes(); // ParticipantAttributes |  (optional) 

            try
            { 
                // Update the attributes on a conversation participant.
                apiInstance.PatchConversationsMessageParticipantAttributes(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsMessageParticipantAttributes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**|  conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationsmessageparticipantcommunication"></a>

## [**Empty**](Empty.html) PatchConversationsMessageParticipantCommunication (string conversationId, string participantId, string communicationId, MediaParticipantRequest body)



Update conversation participant's communication by disconnecting it.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsMessageParticipantCommunicationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string |  conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant

            try
            { 
                // Update conversation participant's communication by disconnecting it.
                Empty result = apiInstance.PatchConversationsMessageParticipantCommunication(conversationId, participantId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsMessageParticipantCommunication: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**|  conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant |  |
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="patchconversationsmessagingintegrationswhatsappintegrationid"></a>

## [**WhatsAppIntegration**](WhatsAppIntegration.html) PatchConversationsMessagingIntegrationsWhatsappIntegrationId (string integrationId, WhatsAppIntegrationUpdateRequest body)



Activate a WhatsApp messaging integration.

The following steps are required in order to fully activate a Whatsapp Integration: Initially, you will need to get an activation code by sending: an action set to Activate, and an authenticationMethod choosing from Sms or Voice. Finally, once you have been informed of an activation code on selected authenticationMethod, you will need to confirm the code by sending: an action set to Confirm, and the confirmationCode you have received from Whatsapp.

Requires ALL permissions: 

* messaging:integration:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchConversationsMessagingIntegrationsWhatsappIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID
            var body = new WhatsAppIntegrationUpdateRequest(); // WhatsAppIntegrationUpdateRequest | WhatsAppIntegrationUpdateRequest

            try
            { 
                // Activate a WhatsApp messaging integration.
                WhatsAppIntegration result = apiInstance.PatchConversationsMessagingIntegrationsWhatsappIntegrationId(integrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationsMessagingIntegrationsWhatsappIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
| **body** | [**WhatsAppIntegrationUpdateRequest**](WhatsAppIntegrationUpdateRequest.html)| WhatsAppIntegrationUpdateRequest |  |
{: class="table table-striped"}

### Return type

[**WhatsAppIntegration**](WhatsAppIntegration.html)

<a name="postanalyticsconversationdetailsproperties"></a>

## [**PropertyIndexRequest**](PropertyIndexRequest.html) PostAnalyticsConversationDetailsProperties (string conversationId, PropertyIndexRequest body)



Index conversation properties



Requires ANY permissions: 

* analytics:conversationProperties:index

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsConversationDetailsPropertiesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new PropertyIndexRequest(); // PropertyIndexRequest | request

            try
            { 
                // Index conversation properties
                PropertyIndexRequest result = apiInstance.PostAnalyticsConversationDetailsProperties(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostAnalyticsConversationDetailsProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**PropertyIndexRequest**](PropertyIndexRequest.html)| request |  |
{: class="table table-striped"}

### Return type

[**PropertyIndexRequest**](PropertyIndexRequest.html)

<a name="postanalyticsconversationsaggregatesquery"></a>

## [**ConversationAggregateQueryResponse**](ConversationAggregateQueryResponse.html) PostAnalyticsConversationsAggregatesQuery (ConversationAggregationQuery body)



Query for conversation aggregates



Requires ANY permissions: 

* analytics:conversationAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsConversationsAggregatesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var body = new ConversationAggregationQuery(); // ConversationAggregationQuery | query

            try
            { 
                // Query for conversation aggregates
                ConversationAggregateQueryResponse result = apiInstance.PostAnalyticsConversationsAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostAnalyticsConversationsAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ConversationAggregationQuery**](ConversationAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**ConversationAggregateQueryResponse**](ConversationAggregateQueryResponse.html)

<a name="postanalyticsconversationsdetailsjobs"></a>

## [**AsyncQueryResponse**](AsyncQueryResponse.html) PostAnalyticsConversationsDetailsJobs (AsyncConversationQuery body)



Query for conversation details asynchronously



Requires ANY permissions: 

* analytics:conversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsConversationsDetailsJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var body = new AsyncConversationQuery(); // AsyncConversationQuery | query

            try
            { 
                // Query for conversation details asynchronously
                AsyncQueryResponse result = apiInstance.PostAnalyticsConversationsDetailsJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostAnalyticsConversationsDetailsJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AsyncConversationQuery**](AsyncConversationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AsyncQueryResponse**](AsyncQueryResponse.html)

<a name="postanalyticsconversationsdetailsquery"></a>

## [**AnalyticsConversationQueryResponse**](AnalyticsConversationQueryResponse.html) PostAnalyticsConversationsDetailsQuery (ConversationQuery body)



Query for conversation details



Requires ANY permissions: 

* analytics:conversationDetail:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsConversationsDetailsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var body = new ConversationQuery(); // ConversationQuery | query

            try
            { 
                // Query for conversation details
                AnalyticsConversationQueryResponse result = apiInstance.PostAnalyticsConversationsDetailsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostAnalyticsConversationsDetailsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ConversationQuery**](ConversationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AnalyticsConversationQueryResponse**](AnalyticsConversationQueryResponse.html)

<a name="postconversationdisconnect"></a>

## **string** PostConversationDisconnect (string conversationId)



Performs a full conversation teardown. Issues disconnect requests for any connected media. Applies a system wrap-up code to any participants that are pending wrap-up. This is not intended to be the normal way of ending interactions but is available in the event of problems with the application to allow a resyncronization of state across all components. It is recommended that users submit a support case if they are relying on this endpoint systematically as there is likely something that needs investigation.



Requires ANY permissions: 

* conversation:communication:disconnect

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationDisconnectExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID

            try
            { 
                // Performs a full conversation teardown. Issues disconnect requests for any connected media. Applies a system wrap-up code to any participants that are pending wrap-up. This is not intended to be the normal way of ending interactions but is available in the event of problems with the application to allow a resyncronization of state across all components. It is recommended that users submit a support case if they are relying on this endpoint systematically as there is likely something that needs investigation.
                string result = apiInstance.PostConversationDisconnect(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationDisconnect: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="postconversationparticipantcallbacks"></a>

## void PostConversationParticipantCallbacks (string conversationId, string participantId, CreateCallbackOnConversationCommand body = null)



Create a new callback for the specified participant on the conversation.



Requires ALL permissions: 

* conversation:callback:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationParticipantCallbacksExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new CreateCallbackOnConversationCommand(); // CreateCallbackOnConversationCommand |  (optional) 

            try
            { 
                // Create a new callback for the specified participant on the conversation.
                apiInstance.PostConversationParticipantCallbacks(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationParticipantCallbacks: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**CreateCallbackOnConversationCommand**](CreateCallbackOnConversationCommand.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationparticipantdigits"></a>

## void PostConversationParticipantDigits (string conversationId, string participantId, Digits body = null)



Sends DTMF to the participant



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationParticipantDigitsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new Digits(); // Digits | Digits (optional) 

            try
            { 
                // Sends DTMF to the participant
                apiInstance.PostConversationParticipantDigits(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationParticipantDigits: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**Digits**](Digits.html)| Digits | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationparticipantreplace"></a>

## void PostConversationParticipantReplace (string conversationId, string participantId, TransferRequest body)



Replace this participant with the specified user and/or address



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationParticipantReplaceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new TransferRequest(); // TransferRequest | Transfer request

            try
            { 
                // Replace this participant with the specified user and/or address
                apiInstance.PostConversationParticipantReplace(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationParticipantReplace: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**TransferRequest**](TransferRequest.html)| Transfer request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationparticipantsecureivrsessions"></a>

## [**SecureSession**](SecureSession.html) PostConversationParticipantSecureivrsessions (string conversationId, string participantId, CreateSecureSession body = null)



Create secure IVR session. Only a participant in the conversation can invoke a secure IVR.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationParticipantSecureivrsessionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new CreateSecureSession(); // CreateSecureSession |  (optional) 

            try
            { 
                // Create secure IVR session. Only a participant in the conversation can invoke a secure IVR.
                SecureSession result = apiInstance.PostConversationParticipantSecureivrsessions(conversationId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationParticipantSecureivrsessions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**CreateSecureSession**](CreateSecureSession.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**SecureSession**](SecureSession.html)

<a name="postconversationscall"></a>

## [**Conversation**](Conversation.html) PostConversationsCall (string conversationId, CallCommand body)



Place a new call as part of a callback conversation.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new CallCommand(); // CallCommand | Conversation

            try
            { 
                // Place a new call as part of a callback conversation.
                Conversation result = apiInstance.PostConversationsCall(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCall: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**CallCommand**](CallCommand.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="postconversationscallparticipantconsult"></a>

## [**ConsultTransferResponse**](ConsultTransferResponse.html) PostConversationsCallParticipantConsult (string conversationId, string participantId, ConsultTransfer body)



Initiate and update consult transfer



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallParticipantConsultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new ConsultTransfer(); // ConsultTransfer | Destination address & initial speak to

            try
            { 
                // Initiate and update consult transfer
                ConsultTransferResponse result = apiInstance.PostConversationsCallParticipantConsult(conversationId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallParticipantConsult: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ConsultTransfer**](ConsultTransfer.html)| Destination address &amp; initial speak to |  |
{: class="table table-striped"}

### Return type

[**ConsultTransferResponse**](ConsultTransferResponse.html)

<a name="postconversationscallparticipantmonitor"></a>

## void PostConversationsCallParticipantMonitor (string conversationId, string participantId)



Listen in on the conversation from the point of view of a given participant.



Requires ANY permissions: 

* conversation:call:monitor

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallParticipantMonitorExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId

            try
            { 
                // Listen in on the conversation from the point of view of a given participant.
                apiInstance.PostConversationsCallParticipantMonitor(conversationId, participantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallParticipantMonitor: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationscallparticipantreplace"></a>

## void PostConversationsCallParticipantReplace (string conversationId, string participantId, TransferRequest body)



Replace this participant with the specified user and/or address



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallParticipantReplaceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new TransferRequest(); // TransferRequest | Transfer request

            try
            { 
                // Replace this participant with the specified user and/or address
                apiInstance.PostConversationsCallParticipantReplace(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallParticipantReplace: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**TransferRequest**](TransferRequest.html)| Transfer request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationscallparticipants"></a>

## [**Conversation**](Conversation.html) PostConversationsCallParticipants (string conversationId, Conversation body)



Add participants to a conversation



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallParticipantsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new Conversation(); // Conversation | Conversation

            try
            { 
                // Add participants to a conversation
                Conversation result = apiInstance.PostConversationsCallParticipants(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallParticipants: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**Conversation**](Conversation.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="postconversationscallbackparticipantreplace"></a>

## void PostConversationsCallbackParticipantReplace (string conversationId, string participantId, TransferRequest body)



Replace this participant with the specified user and/or address



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallbackParticipantReplaceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new TransferRequest(); // TransferRequest | Transfer request

            try
            { 
                // Replace this participant with the specified user and/or address
                apiInstance.PostConversationsCallbackParticipantReplace(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallbackParticipantReplace: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**TransferRequest**](TransferRequest.html)| Transfer request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationscallbacks"></a>

## [**CreateCallbackResponse**](CreateCallbackResponse.html) PostConversationsCallbacks (CreateCallbackCommand body)



Create a Callback



Requires ALL permissions: 

* conversation:callback:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallbacksExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var body = new CreateCallbackCommand(); // CreateCallbackCommand | Callback

            try
            { 
                // Create a Callback
                CreateCallbackResponse result = apiInstance.PostConversationsCallbacks(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCallbacks: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateCallbackCommand**](CreateCallbackCommand.html)| Callback |  |
{: class="table table-striped"}

### Return type

[**CreateCallbackResponse**](CreateCallbackResponse.html)

<a name="postconversationscalls"></a>

## [**CreateCallResponse**](CreateCallResponse.html) PostConversationsCalls (CreateCallRequest body)



Create a call conversation



Requires ANY permissions: 

* conversation:conference:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCallsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var body = new CreateCallRequest(); // CreateCallRequest | Call request

            try
            { 
                // Create a call conversation
                CreateCallResponse result = apiInstance.PostConversationsCalls(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCalls: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateCallRequest**](CreateCallRequest.html)| Call request |  |
{: class="table table-striped"}

### Return type

[**CreateCallResponse**](CreateCallResponse.html)

<a name="postconversationschatcommunicationmessages"></a>

## [**WebChatMessage**](WebChatMessage.html) PostConversationsChatCommunicationMessages (string conversationId, string communicationId, CreateWebChatMessageRequest body)



Send a message on behalf of a communication in a chat conversation.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsChatCommunicationMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new CreateWebChatMessageRequest(); // CreateWebChatMessageRequest | Message

            try
            { 
                // Send a message on behalf of a communication in a chat conversation.
                WebChatMessage result = apiInstance.PostConversationsChatCommunicationMessages(conversationId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsChatCommunicationMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**CreateWebChatMessageRequest**](CreateWebChatMessageRequest.html)| Message |  |
{: class="table table-striped"}

### Return type

[**WebChatMessage**](WebChatMessage.html)

<a name="postconversationschatcommunicationtyping"></a>

## [**WebChatTyping**](WebChatTyping.html) PostConversationsChatCommunicationTyping (string conversationId, string communicationId)



Send a typing-indicator on behalf of a communication in a chat conversation.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsChatCommunicationTypingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var communicationId = communicationId_example;  // string | communicationId

            try
            { 
                // Send a typing-indicator on behalf of a communication in a chat conversation.
                WebChatTyping result = apiInstance.PostConversationsChatCommunicationTyping(conversationId, communicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsChatCommunicationTyping: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **communicationId** | **string**| communicationId |  |
{: class="table table-striped"}

### Return type

[**WebChatTyping**](WebChatTyping.html)

<a name="postconversationschatparticipantreplace"></a>

## void PostConversationsChatParticipantReplace (string conversationId, string participantId, TransferRequest body)



Replace this participant with the specified user and/or address



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsChatParticipantReplaceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new TransferRequest(); // TransferRequest | Transfer request

            try
            { 
                // Replace this participant with the specified user and/or address
                apiInstance.PostConversationsChatParticipantReplace(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsChatParticipantReplace: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**TransferRequest**](TransferRequest.html)| Transfer request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationschats"></a>

## [**ChatConversation**](ChatConversation.html) PostConversationsChats (CreateWebChatRequest body)



Create a web chat conversation



Requires ALL permissions: 

* conversation:webchat:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsChatsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var body = new CreateWebChatRequest(); // CreateWebChatRequest | Create web chat request

            try
            { 
                // Create a web chat conversation
                ChatConversation result = apiInstance.PostConversationsChats(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsChats: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateWebChatRequest**](CreateWebChatRequest.html)| Create web chat request |  |
{: class="table table-striped"}

### Return type

[**ChatConversation**](ChatConversation.html)

<a name="postconversationscobrowsesessionparticipantreplace"></a>

## void PostConversationsCobrowsesessionParticipantReplace (string conversationId, string participantId, TransferRequest body = null)



Replace this participant with the specified user and/or address



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsCobrowsesessionParticipantReplaceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new TransferRequest(); // TransferRequest |  (optional) 

            try
            { 
                // Replace this participant with the specified user and/or address
                apiInstance.PostConversationsCobrowsesessionParticipantReplace(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsCobrowsesessionParticipantReplace: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**TransferRequest**](TransferRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationsemailinboundmessages"></a>

## [**EmailConversation**](EmailConversation.html) PostConversationsEmailInboundmessages (string conversationId, InboundMessageRequest body)



Send an email to an external conversation. An external conversation is one where the provider is not PureCloud based. This endpoint allows the sender of the external email to reply or send a new message to the existing conversation. The new message will be treated as part of the existing conversation and chained to it.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsEmailInboundmessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new InboundMessageRequest(); // InboundMessageRequest | Send external email reply

            try
            { 
                // Send an email to an external conversation. An external conversation is one where the provider is not PureCloud based. This endpoint allows the sender of the external email to reply or send a new message to the existing conversation. The new message will be treated as part of the existing conversation and chained to it.
                EmailConversation result = apiInstance.PostConversationsEmailInboundmessages(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsEmailInboundmessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**InboundMessageRequest**](InboundMessageRequest.html)| Send external email reply |  |
{: class="table table-striped"}

### Return type

[**EmailConversation**](EmailConversation.html)

<a name="postconversationsemailmessages"></a>

## [**EmailMessage**](EmailMessage.html) PostConversationsEmailMessages (string conversationId, EmailMessage body)



Send an email reply



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsEmailMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new EmailMessage(); // EmailMessage | Reply

            try
            { 
                // Send an email reply
                EmailMessage result = apiInstance.PostConversationsEmailMessages(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsEmailMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**EmailMessage**](EmailMessage.html)| Reply |  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.html)

<a name="postconversationsemailmessagesdraftattachmentscopy"></a>

## [**EmailMessage**](EmailMessage.html) PostConversationsEmailMessagesDraftAttachmentsCopy (string conversationId, CopyAttachmentsRequest body)



Copy attachments from an email message to the current draft.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsEmailMessagesDraftAttachmentsCopyExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new CopyAttachmentsRequest(); // CopyAttachmentsRequest | Copy Attachment Request

            try
            { 
                // Copy attachments from an email message to the current draft.
                EmailMessage result = apiInstance.PostConversationsEmailMessagesDraftAttachmentsCopy(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsEmailMessagesDraftAttachmentsCopy: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**CopyAttachmentsRequest**](CopyAttachmentsRequest.html)| Copy Attachment Request |  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.html)

<a name="postconversationsemailparticipantreplace"></a>

## void PostConversationsEmailParticipantReplace (string conversationId, string participantId, TransferRequest body)



Replace this participant with the specified user and/or address



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsEmailParticipantReplaceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new TransferRequest(); // TransferRequest | Transfer request

            try
            { 
                // Replace this participant with the specified user and/or address
                apiInstance.PostConversationsEmailParticipantReplace(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsEmailParticipantReplace: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**TransferRequest**](TransferRequest.html)| Transfer request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationsemails"></a>

## [**EmailConversation**](EmailConversation.html) PostConversationsEmails (CreateEmailRequest body)



Create an email conversation

If the direction of the request is INBOUND, this will create an external conversation with a third party provider. If the direction of the the request is OUTBOUND, this will create a conversation to send outbound emails on behalf of a queue.

Requires ANY permissions: 

* conversation:email:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsEmailsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var body = new CreateEmailRequest(); // CreateEmailRequest | Create email request

            try
            { 
                // Create an email conversation
                EmailConversation result = apiInstance.PostConversationsEmails(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsEmails: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateEmailRequest**](CreateEmailRequest.html)| Create email request |  |
{: class="table table-striped"}

### Return type

[**EmailConversation**](EmailConversation.html)

<a name="postconversationsfaxes"></a>

## [**FaxSendResponse**](FaxSendResponse.html) PostConversationsFaxes (FaxSendRequest body)



Create Fax Conversation



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsFaxesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var body = new FaxSendRequest(); // FaxSendRequest | Fax

            try
            { 
                // Create Fax Conversation
                FaxSendResponse result = apiInstance.PostConversationsFaxes(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsFaxes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**FaxSendRequest**](FaxSendRequest.html)| Fax |  |
{: class="table table-striped"}

### Return type

[**FaxSendResponse**](FaxSendResponse.html)

<a name="postconversationsmessagecommunicationmessages"></a>

## [**MessageData**](MessageData.html) PostConversationsMessageCommunicationMessages (string conversationId, string communicationId, AdditionalMessage body)



Send message



Requires ALL permissions: 

* conversation:message:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessageCommunicationMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new AdditionalMessage(); // AdditionalMessage | Message

            try
            { 
                // Send message
                MessageData result = apiInstance.PostConversationsMessageCommunicationMessages(conversationId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessageCommunicationMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**AdditionalMessage**](AdditionalMessage.html)| Message |  |
{: class="table table-striped"}

### Return type

[**MessageData**](MessageData.html)

<a name="postconversationsmessagecommunicationmessagesmedia"></a>

## [**MessageMediaData**](MessageMediaData.html) PostConversationsMessageCommunicationMessagesMedia (string conversationId, string communicationId)



Create media



Requires ALL permissions: 

* conversation:message:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessageCommunicationMessagesMediaExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var communicationId = communicationId_example;  // string | communicationId

            try
            { 
                // Create media
                MessageMediaData result = apiInstance.PostConversationsMessageCommunicationMessagesMedia(conversationId, communicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessageCommunicationMessagesMedia: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **communicationId** | **string**| communicationId |  |
{: class="table table-striped"}

### Return type

[**MessageMediaData**](MessageMediaData.html)

<a name="postconversationsmessagemessagesbulk"></a>

## [**TextMessageListing**](TextMessageListing.html) PostConversationsMessageMessagesBulk (string conversationId, List<string> body = null)



Get messages in batch

The path parameter [conversationId] should contain the conversationId of the conversation being filtered. The body should contain the messageId(s) of messages being requested. For example: [\"a3069a33b-bbb1-4703-9d68-061d9e9db96e\", \"55bc6be3-078c-4a49-a4e6-1e05776ed7e8\"]

Requires ANY permissions: 

* conversation:message:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessageMessagesBulkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | 
            var body = ;  // List<string> | messageIds (optional) 

            try
            { 
                // Get messages in batch
                TextMessageListing result = apiInstance.PostConversationsMessageMessagesBulk(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessageMessagesBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**|  |  |
| **body** | **List<string>**| messageIds | [optional]  |
{: class="table table-striped"}

### Return type

[**TextMessageListing**](TextMessageListing.html)

<a name="postconversationsmessageparticipantreplace"></a>

## void PostConversationsMessageParticipantReplace (string conversationId, string participantId, TransferRequest body)



Replace this participant with the specified user and/or address



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessageParticipantReplaceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var body = new TransferRequest(); // TransferRequest | Transfer request

            try
            { 
                // Replace this participant with the specified user and/or address
                apiInstance.PostConversationsMessageParticipantReplace(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessageParticipantReplace: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**TransferRequest**](TransferRequest.html)| Transfer request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationsmessages"></a>

## [**MessageConversation**](MessageConversation.html) PostConversationsMessages (CreateOutboundMessagingConversationRequest body)



Create an outbound messaging conversation.

If there is an existing conversation between the remote address and the address associated with the queue specified in createOutboundRequest then the result of this request depends on the state of that conversation and the useExistingConversation field of createOutboundRequest. If the existing conversation is in alerting or connected state, then the request will fail. If the existing conversation is disconnected but still within the conversation window then the request will fail unless useExistingConversation is set to true.

Requires ALL permissions: 

* conversation:message:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var body = new CreateOutboundMessagingConversationRequest(); // CreateOutboundMessagingConversationRequest | Create outbound messaging conversation

            try
            { 
                // Create an outbound messaging conversation.
                MessageConversation result = apiInstance.PostConversationsMessages(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateOutboundMessagingConversationRequest**](CreateOutboundMessagingConversationRequest.html)| Create outbound messaging conversation |  |
{: class="table table-striped"}

### Return type

[**MessageConversation**](MessageConversation.html)

<a name="postconversationsmessagesagentless"></a>

## [**SendAgentlessOutboundMessageResponse**](SendAgentlessOutboundMessageResponse.html) PostConversationsMessagesAgentless (SendAgentlessOutboundMessageRequest body)



Send an agentless outbound message

Send an agentlesss (api participant) outbound message using a client credential grant. In order to call this endpoint you will need OAuth token generated using OAuth client credentials authorized with at least messaging scope. This will generate a new Conversation, if there is an existing active Conversation between the fromAddress and toAddress already, then this POST will fail.

Requires ALL permissions: 

* conversation:message:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessagesAgentlessExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var body = new SendAgentlessOutboundMessageRequest(); // SendAgentlessOutboundMessageRequest | Create agentless outbound messaging request

            try
            { 
                // Send an agentless outbound message
                SendAgentlessOutboundMessageResponse result = apiInstance.PostConversationsMessagesAgentless(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessagesAgentless: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SendAgentlessOutboundMessageRequest**](SendAgentlessOutboundMessageRequest.html)| Create agentless outbound messaging request |  |
{: class="table table-striped"}

### Return type

[**SendAgentlessOutboundMessageResponse**](SendAgentlessOutboundMessageResponse.html)

<a name="postconversationsmessagingintegrationsfacebook"></a>

## [**FacebookIntegration**](FacebookIntegration.html) PostConversationsMessagingIntegrationsFacebook (FacebookIntegrationRequest body)



Create a Facebook Integration



Requires ALL permissions: 

* messaging:integration:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessagingIntegrationsFacebookExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var body = new FacebookIntegrationRequest(); // FacebookIntegrationRequest | FacebookIntegrationRequest

            try
            { 
                // Create a Facebook Integration
                FacebookIntegration result = apiInstance.PostConversationsMessagingIntegrationsFacebook(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessagingIntegrationsFacebook: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**FacebookIntegrationRequest**](FacebookIntegrationRequest.html)| FacebookIntegrationRequest |  |
{: class="table table-striped"}

### Return type

[**FacebookIntegration**](FacebookIntegration.html)

<a name="postconversationsmessagingintegrationsline"></a>

## [**LineIntegration**](LineIntegration.html) PostConversationsMessagingIntegrationsLine (LineIntegrationRequest body)



Create a LINE messenger Integration



Requires ALL permissions: 

* messaging:integration:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessagingIntegrationsLineExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var body = new LineIntegrationRequest(); // LineIntegrationRequest | LineIntegrationRequest

            try
            { 
                // Create a LINE messenger Integration
                LineIntegration result = apiInstance.PostConversationsMessagingIntegrationsLine(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessagingIntegrationsLine: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**LineIntegrationRequest**](LineIntegrationRequest.html)| LineIntegrationRequest |  |
{: class="table table-striped"}

### Return type

[**LineIntegration**](LineIntegration.html)

<a name="postconversationsmessagingintegrationstwitter"></a>

## [**TwitterIntegration**](TwitterIntegration.html) PostConversationsMessagingIntegrationsTwitter (TwitterIntegrationRequest body)



Create a Twitter Integration



Requires ALL permissions: 

* messaging:integration:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessagingIntegrationsTwitterExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var body = new TwitterIntegrationRequest(); // TwitterIntegrationRequest | TwitterIntegrationRequest

            try
            { 
                // Create a Twitter Integration
                TwitterIntegration result = apiInstance.PostConversationsMessagingIntegrationsTwitter(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessagingIntegrationsTwitter: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TwitterIntegrationRequest**](TwitterIntegrationRequest.html)| TwitterIntegrationRequest |  |
{: class="table table-striped"}

### Return type

[**TwitterIntegration**](TwitterIntegration.html)

<a name="postconversationsmessagingintegrationswhatsapp"></a>

## [**WhatsAppIntegration**](WhatsAppIntegration.html) PostConversationsMessagingIntegrationsWhatsapp (WhatsAppIntegrationRequest body)



Create a WhatsApp Integration



Requires ALL permissions: 

* messaging:whatsappIntegration:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostConversationsMessagingIntegrationsWhatsappExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var body = new WhatsAppIntegrationRequest(); // WhatsAppIntegrationRequest | WhatsAppIntegrationRequest

            try
            { 
                // Create a WhatsApp Integration
                WhatsAppIntegration result = apiInstance.PostConversationsMessagingIntegrationsWhatsapp(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsMessagingIntegrationsWhatsapp: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WhatsAppIntegrationRequest**](WhatsAppIntegrationRequest.html)| WhatsAppIntegrationRequest |  |
{: class="table table-striped"}

### Return type

[**WhatsAppIntegration**](WhatsAppIntegration.html)

<a name="putconversationparticipantflaggedreason"></a>

## void PutConversationParticipantFlaggedreason (string conversationId, string participantId)



Set flagged reason on conversation participant to indicate bad conversation quality.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationParticipantFlaggedreasonExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID

            try
            { 
                // Set flagged reason on conversation participant to indicate bad conversation quality.
                apiInstance.PutConversationParticipantFlaggedreason(conversationId, participantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationParticipantFlaggedreason: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="putconversationscallparticipantcommunicationuuidata"></a>

## [**Empty**](Empty.html) PutConversationsCallParticipantCommunicationUuidata (string conversationId, string participantId, string communicationId, SetUuiDataRequest body)



Set uuiData to be sent on future commands.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsCallParticipantCommunicationUuidataExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new SetUuiDataRequest(); // SetUuiDataRequest | UUIData Request

            try
            { 
                // Set uuiData to be sent on future commands.
                Empty result = apiInstance.PutConversationsCallParticipantCommunicationUuidata(conversationId, participantId, communicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsCallParticipantCommunicationUuidata: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**SetUuiDataRequest**](SetUuiDataRequest.html)| UUIData Request |  |
{: class="table table-striped"}

### Return type

[**Empty**](Empty.html)

<a name="putconversationsemailmessagesdraft"></a>

## [**EmailMessage**](EmailMessage.html) PutConversationsEmailMessagesDraft (string conversationId, EmailMessage body)



Update conversation draft reply



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsEmailMessagesDraftExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new EmailMessage(); // EmailMessage | Draft

            try
            { 
                // Update conversation draft reply
                EmailMessage result = apiInstance.PutConversationsEmailMessagesDraft(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsEmailMessagesDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**EmailMessage**](EmailMessage.html)| Draft |  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.html)

<a name="putconversationsmessagingintegrationslineintegrationid"></a>

## [**LineIntegration**](LineIntegration.html) PutConversationsMessagingIntegrationsLineIntegrationId (string integrationId, LineIntegrationRequest body)



Update a LINE messenger integration



Requires ALL permissions: 

* messaging:integration:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutConversationsMessagingIntegrationsLineIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationsApi();
            var integrationId = integrationId_example;  // string | Integration ID
            var body = new LineIntegrationRequest(); // LineIntegrationRequest | LineIntegrationRequest

            try
            { 
                // Update a LINE messenger integration
                LineIntegration result = apiInstance.PutConversationsMessagingIntegrationsLineIntegrationId(integrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutConversationsMessagingIntegrationsLineIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
| **body** | [**LineIntegrationRequest**](LineIntegrationRequest.html)| LineIntegrationRequest |  |
{: class="table table-striped"}

### Return type

[**LineIntegration**](LineIntegration.html)

