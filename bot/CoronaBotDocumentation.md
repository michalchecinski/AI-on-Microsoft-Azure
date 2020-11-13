# CoronaBot build on Azure Bot Service

This is a report from creating chat bot for help with coronavirus and medical cases during the pandemic. 

## Bot scenario

Bot was created to help recognise COVID-19 symptoms and to provide helpful and real data about the Sars-CoV-2 and COVID-19 based on WHO and CDC sources, and medical researches.

### Video demo



## Bot architecture

The bot was created using Azure Bot Framework Coposer. To recognize intents it uses LUIS (language Understanding) Azure service. For answering questions about COVID-19 it uses Azure QnA services, with knowledge base based on WHO and CDC sites and medical researches. Also to provide the current number of positive tested people in Poland, bot makes communication with Azure functions.

### Architecture diagram

![azure_ai_bot_arch](https://github.com/michalchecinski/AI-on-Microsoft-Azure/blob/main/bot/images/azure_ai_bot_arch.png)

## Steps taken to build the bot

The bot was created using Azure Bot Service Composer. The project in it was created. Dialogs was created by hand using the UI. The rest of the setup is described in the chapter ***How to reproduce bot*** below.

## How to reproduce bot

1. Download Azure Bo Service Composer from [GitHub releases page](https://github.com/microsoft/BotFramework-Composer/releases).

2. [Download Azure Bot Framework Emulator](https://github.com/Microsoft/BotFramework-Emulator/blob/master/README.md).

3. Create Language Understanding service in the West US region. This is important as the Bot Framework Composer works only with LUIS located in West US region.

4. Copy auth key from LUIS Authoring resource, and paste it in the appsettings in the Azure Bot Framework Composer under LUIS part of the JSON.

   Copy from Portal Azure:

   ![image-20201112193830050](https://github.com/michalchecinski/AI-on-Microsoft-Azure/blob/main/bot/images/luis_key_az_portal.png)

   Paste into the Bot Composer settings:

   ![image-20201112193414864](https://github.com/michalchecinski/AI-on-Microsoft-Azure/blob/main/bot/images/luis_appsettings_part.png)

6. Create Azure QnA service

7. Go to the https://www.qnamaker.ai/ website. Login and choose recently created QnA service.

8. Add WHO and CDC sites as source for knowledge base. eg. site: https://www.cdc.gov/coronavirus/2019-ncov/faq.html

9. Wait a while, as the whole knowledge will be extracted from the sites you provided. Check if the questions and answers are ok. If yes, click save and train button:

    ![save_train_qna](https://github.com/michalchecinski/AI-on-Microsoft-Azure/blob/main/bot/images/save_train_qna.png)

10. After successful training you need to copy the *knowledgebase id* (1) and *endpoint key* (2):

    ![image-20201112195132216](https://github.com/michalchecinski/AI-on-Microsoft-Azure/blob/main/bot/images/qna_auth.png)

    To the settings in the Bot Framework Composer:

    ![image-20201112195433477](https://github.com/michalchecinski/AI-on-Microsoft-Azure/blob/main/bot/images/qna_composer.png)

11. Now click the Start bot button in the upper-right corner of the Bot Framework Composer, and after successful load, click *Test bot in emulator*.

    

