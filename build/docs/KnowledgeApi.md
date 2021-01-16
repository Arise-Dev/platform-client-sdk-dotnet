---
title: KnowledgeApi
---
## PureCloudPlatform.Client.V2.Api.KnowledgeApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteKnowledgeKnowledgebase**](KnowledgeApi.html#deleteknowledgeknowledgebase) | **DELETE** /api/v2/knowledge/knowledgebases/{knowledgeBaseId} | Delete knowledge base |
| [**DeleteKnowledgeKnowledgebaseLanguageCategory**](KnowledgeApi.html#deleteknowledgeknowledgebaselanguagecategory) | **DELETE** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/categories/{categoryId} | Delete category |
| [**DeleteKnowledgeKnowledgebaseLanguageDocument**](KnowledgeApi.html#deleteknowledgeknowledgebaselanguagedocument) | **DELETE** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents/{documentId} | Delete document |
| [**GetKnowledgeKnowledgebase**](KnowledgeApi.html#getknowledgeknowledgebase) | **GET** /api/v2/knowledge/knowledgebases/{knowledgeBaseId} | Get knowledge base |
| [**GetKnowledgeKnowledgebaseLanguageCategories**](KnowledgeApi.html#getknowledgeknowledgebaselanguagecategories) | **GET** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/categories | Get categories |
| [**GetKnowledgeKnowledgebaseLanguageCategory**](KnowledgeApi.html#getknowledgeknowledgebaselanguagecategory) | **GET** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/categories/{categoryId} | Get category |
| [**GetKnowledgeKnowledgebaseLanguageDocument**](KnowledgeApi.html#getknowledgeknowledgebaselanguagedocument) | **GET** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents/{documentId} | Get document |
| [**GetKnowledgeKnowledgebaseLanguageDocuments**](KnowledgeApi.html#getknowledgeknowledgebaselanguagedocuments) | **GET** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents | Get documents |
| [**GetKnowledgeKnowledgebaseLanguageTraining**](KnowledgeApi.html#getknowledgeknowledgebaselanguagetraining) | **GET** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/trainings/{trainingId} | Get training detail |
| [**GetKnowledgeKnowledgebaseLanguageTrainings**](KnowledgeApi.html#getknowledgeknowledgebaselanguagetrainings) | **GET** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/trainings | Get all trainings information for a knowledgebase |
| [**GetKnowledgeKnowledgebases**](KnowledgeApi.html#getknowledgeknowledgebases) | **GET** /api/v2/knowledge/knowledgebases | Get knowledge bases |
| [**PatchKnowledgeKnowledgebase**](KnowledgeApi.html#patchknowledgeknowledgebase) | **PATCH** /api/v2/knowledge/knowledgebases/{knowledgeBaseId} | Update knowledge base |
| [**PatchKnowledgeKnowledgebaseLanguageCategory**](KnowledgeApi.html#patchknowledgeknowledgebaselanguagecategory) | **PATCH** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/categories/{categoryId} | Update category |
| [**PatchKnowledgeKnowledgebaseLanguageDocument**](KnowledgeApi.html#patchknowledgeknowledgebaselanguagedocument) | **PATCH** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents/{documentId} | Update document |
| [**PatchKnowledgeKnowledgebaseLanguageDocuments**](KnowledgeApi.html#patchknowledgeknowledgebaselanguagedocuments) | **PATCH** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents | Update documents collection |
| [**PostKnowledgeKnowledgebaseLanguageCategories**](KnowledgeApi.html#postknowledgeknowledgebaselanguagecategories) | **POST** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/categories | Create new category |
| [**PostKnowledgeKnowledgebaseLanguageDocuments**](KnowledgeApi.html#postknowledgeknowledgebaselanguagedocuments) | **POST** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents | Create document |
| [**PostKnowledgeKnowledgebaseLanguageTrainingPromote**](KnowledgeApi.html#postknowledgeknowledgebaselanguagetrainingpromote) | **POST** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/trainings/{trainingId}/promote | Promote trained documents from draft state to active. |
| [**PostKnowledgeKnowledgebaseLanguageTrainings**](KnowledgeApi.html#postknowledgeknowledgebaselanguagetrainings) | **POST** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/trainings | Trigger training |
| [**PostKnowledgeKnowledgebaseSearch**](KnowledgeApi.html#postknowledgeknowledgebasesearch) | **POST** /api/v2/knowledge/knowledgebases/{knowledgeBaseId}/search | Search Documents |
| [**PostKnowledgeKnowledgebases**](KnowledgeApi.html#postknowledgeknowledgebases) | **POST** /api/v2/knowledge/knowledgebases | Create new knowledge base |
{: class="table table-striped"}

<a name="deleteknowledgeknowledgebase"></a>

## [**KnowledgeBase**](KnowledgeBase.html) DeleteKnowledgeKnowledgebase (string knowledgeBaseId)



Delete knowledge base



Requires ALL permissions: 

* knowledge:knowledgebase:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteKnowledgeKnowledgebaseExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID

            try
            { 
                // Delete knowledge base
                KnowledgeBase result = apiInstance.DeleteKnowledgeKnowledgebase(knowledgeBaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.DeleteKnowledgeKnowledgebase: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
{: class="table table-striped"}

### Return type

[**KnowledgeBase**](KnowledgeBase.html)

<a name="deleteknowledgeknowledgebaselanguagecategory"></a>

## [**KnowledgeCategory**](KnowledgeCategory.html) DeleteKnowledgeKnowledgebaseLanguageCategory (string categoryId, string knowledgeBaseId, string languageCode)



Delete category



Requires ALL permissions: 

* knowledge:category:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteKnowledgeKnowledgebaseLanguageCategoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KnowledgeApi();
            var categoryId = categoryId_example;  // string | Category ID
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE

            try
            { 
                // Delete category
                KnowledgeCategory result = apiInstance.DeleteKnowledgeKnowledgebaseLanguageCategory(categoryId, knowledgeBaseId, languageCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.DeleteKnowledgeKnowledgebaseLanguageCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **categoryId** | **string**| Category ID |  |
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, de-DE |
{: class="table table-striped"}

### Return type

[**KnowledgeCategory**](KnowledgeCategory.html)

<a name="deleteknowledgeknowledgebaselanguagedocument"></a>

## [**KnowledgeDocument**](KnowledgeDocument.html) DeleteKnowledgeKnowledgebaseLanguageDocument (string documentId, string knowledgeBaseId, string languageCode)



Delete document



Requires ALL permissions: 

* knowledge:document:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteKnowledgeKnowledgebaseLanguageDocumentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KnowledgeApi();
            var documentId = documentId_example;  // string | Document ID
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE

            try
            { 
                // Delete document
                KnowledgeDocument result = apiInstance.DeleteKnowledgeKnowledgebaseLanguageDocument(documentId, knowledgeBaseId, languageCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.DeleteKnowledgeKnowledgebaseLanguageDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, de-DE |
{: class="table table-striped"}

### Return type

[**KnowledgeDocument**](KnowledgeDocument.html)

<a name="getknowledgeknowledgebase"></a>

## [**KnowledgeBase**](KnowledgeBase.html) GetKnowledgeKnowledgebase (string knowledgeBaseId)



Get knowledge base



Requires ALL permissions: 

* knowledge:knowledgebase:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID

            try
            { 
                // Get knowledge base
                KnowledgeBase result = apiInstance.GetKnowledgeKnowledgebase(knowledgeBaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebase: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
{: class="table table-striped"}

### Return type

[**KnowledgeBase**](KnowledgeBase.html)

<a name="getknowledgeknowledgebaselanguagecategories"></a>

## [**CategoryListing**](CategoryListing.html) GetKnowledgeKnowledgebaseLanguageCategories (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string name = null)



Get categories



Requires ALL permissions: 

* knowledge:category:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseLanguageCategoriesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var limit = limit_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var name = name_example;  // string | Filter to return the categories that starts with the given category name. (optional) 

            try
            { 
                // Get categories
                CategoryListing result = apiInstance.GetKnowledgeKnowledgebaseLanguageCategories(knowledgeBaseId, languageCode, before, after, limit, pageSize, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseLanguageCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, de-DE |
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **limit** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **name** | **string**| Filter to return the categories that starts with the given category name. | [optional]  |
{: class="table table-striped"}

### Return type

[**CategoryListing**](CategoryListing.html)

<a name="getknowledgeknowledgebaselanguagecategory"></a>

## [**KnowledgeExtendedCategory**](KnowledgeExtendedCategory.html) GetKnowledgeKnowledgebaseLanguageCategory (string categoryId, string knowledgeBaseId, string languageCode)



Get category



Requires ALL permissions: 

* knowledge:category:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseLanguageCategoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KnowledgeApi();
            var categoryId = categoryId_example;  // string | Category ID
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE

            try
            { 
                // Get category
                KnowledgeExtendedCategory result = apiInstance.GetKnowledgeKnowledgebaseLanguageCategory(categoryId, knowledgeBaseId, languageCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseLanguageCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **categoryId** | **string**| Category ID |  |
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, de-DE |
{: class="table table-striped"}

### Return type

[**KnowledgeExtendedCategory**](KnowledgeExtendedCategory.html)

<a name="getknowledgeknowledgebaselanguagedocument"></a>

## [**KnowledgeDocument**](KnowledgeDocument.html) GetKnowledgeKnowledgebaseLanguageDocument (string documentId, string knowledgeBaseId, string languageCode)



Get document



Requires ALL permissions: 

* knowledge:document:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseLanguageDocumentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KnowledgeApi();
            var documentId = documentId_example;  // string | Document ID
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE

            try
            { 
                // Get document
                KnowledgeDocument result = apiInstance.GetKnowledgeKnowledgebaseLanguageDocument(documentId, knowledgeBaseId, languageCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseLanguageDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, de-DE |
{: class="table table-striped"}

### Return type

[**KnowledgeDocument**](KnowledgeDocument.html)

<a name="getknowledgeknowledgebaselanguagedocuments"></a>

## [**DocumentListing**](DocumentListing.html) GetKnowledgeKnowledgebaseLanguageDocuments (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string categories = null, string title = null)



Get documents



Requires ALL permissions: 

* knowledge:document:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseLanguageDocumentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var limit = limit_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var categories = categories_example;  // string | Filter by categories ids, comma separated values expected. (optional) 
            var title = title_example;  // string | Filter by document title. (optional) 

            try
            { 
                // Get documents
                DocumentListing result = apiInstance.GetKnowledgeKnowledgebaseLanguageDocuments(knowledgeBaseId, languageCode, before, after, limit, pageSize, categories, title);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseLanguageDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, de-DE |
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **limit** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **categories** | **string**| Filter by categories ids, comma separated values expected. | [optional]  |
| **title** | **string**| Filter by document title. | [optional]  |
{: class="table table-striped"}

### Return type

[**DocumentListing**](DocumentListing.html)

<a name="getknowledgeknowledgebaselanguagetraining"></a>

## [**KnowledgeTraining**](KnowledgeTraining.html) GetKnowledgeKnowledgebaseLanguageTraining (string knowledgeBaseId, string languageCode, string trainingId)



Get training detail



Requires ALL permissions: 

* knowledge:training:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseLanguageTrainingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var trainingId = trainingId_example;  // string | Training ID

            try
            { 
                // Get training detail
                KnowledgeTraining result = apiInstance.GetKnowledgeKnowledgebaseLanguageTraining(knowledgeBaseId, languageCode, trainingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseLanguageTraining: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, de-DE |
| **trainingId** | **string**| Training ID |  |
{: class="table table-striped"}

### Return type

[**KnowledgeTraining**](KnowledgeTraining.html)

<a name="getknowledgeknowledgebaselanguagetrainings"></a>

## [**TrainingListing**](TrainingListing.html) GetKnowledgeKnowledgebaseLanguageTrainings (string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string knowledgeDocumentsState = null)



Get all trainings information for a knowledgebase



Requires ALL permissions: 

* knowledge:training:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebaseLanguageTrainingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var limit = limit_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var knowledgeDocumentsState = knowledgeDocumentsState_example;  // string | Return the training with the specified state of the trained documents. (optional) 

            try
            { 
                // Get all trainings information for a knowledgebase
                TrainingListing result = apiInstance.GetKnowledgeKnowledgebaseLanguageTrainings(knowledgeBaseId, languageCode, before, after, limit, pageSize, knowledgeDocumentsState);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebaseLanguageTrainings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, de-DE |
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **limit** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **knowledgeDocumentsState** | **string**| Return the training with the specified state of the trained documents. | [optional] <br />**Values**: Draft, Active, Discarded, Archived |
{: class="table table-striped"}

### Return type

[**TrainingListing**](TrainingListing.html)

<a name="getknowledgeknowledgebases"></a>

## [**KnowledgeBaseListing**](KnowledgeBaseListing.html) GetKnowledgeKnowledgebases (string before = null, string after = null, string limit = null, string pageSize = null, string name = null)



Get knowledge bases



Requires ALL permissions: 

* knowledge:knowledgebase:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetKnowledgeKnowledgebasesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KnowledgeApi();
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var limit = limit_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var name = name_example;  // string | Name of the KnowledgeBase to filter. (optional) 

            try
            { 
                // Get knowledge bases
                KnowledgeBaseListing result = apiInstance.GetKnowledgeKnowledgebases(before, after, limit, pageSize, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.GetKnowledgeKnowledgebases: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **limit** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **name** | **string**| Name of the KnowledgeBase to filter. | [optional]  |
{: class="table table-striped"}

### Return type

[**KnowledgeBaseListing**](KnowledgeBaseListing.html)

<a name="patchknowledgeknowledgebase"></a>

## [**KnowledgeBase**](KnowledgeBase.html) PatchKnowledgeKnowledgebase (string knowledgeBaseId, KnowledgeBase body)



Update knowledge base



Requires ALL permissions: 

* knowledge:knowledgebase:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchKnowledgeKnowledgebaseExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var body = new KnowledgeBase(); // KnowledgeBase | 

            try
            { 
                // Update knowledge base
                KnowledgeBase result = apiInstance.PatchKnowledgeKnowledgebase(knowledgeBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PatchKnowledgeKnowledgebase: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **body** | [**KnowledgeBase**](KnowledgeBase.html)|  |  |
{: class="table table-striped"}

### Return type

[**KnowledgeBase**](KnowledgeBase.html)

<a name="patchknowledgeknowledgebaselanguagecategory"></a>

## [**KnowledgeExtendedCategory**](KnowledgeExtendedCategory.html) PatchKnowledgeKnowledgebaseLanguageCategory (string categoryId, string knowledgeBaseId, string languageCode, KnowledgeCategoryRequest body)



Update category



Requires ALL permissions: 

* knowledge:category:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchKnowledgeKnowledgebaseLanguageCategoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KnowledgeApi();
            var categoryId = categoryId_example;  // string | Category ID
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var body = new KnowledgeCategoryRequest(); // KnowledgeCategoryRequest | 

            try
            { 
                // Update category
                KnowledgeExtendedCategory result = apiInstance.PatchKnowledgeKnowledgebaseLanguageCategory(categoryId, knowledgeBaseId, languageCode, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PatchKnowledgeKnowledgebaseLanguageCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **categoryId** | **string**| Category ID |  |
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, de-DE |
| **body** | [**KnowledgeCategoryRequest**](KnowledgeCategoryRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**KnowledgeExtendedCategory**](KnowledgeExtendedCategory.html)

<a name="patchknowledgeknowledgebaselanguagedocument"></a>

## [**KnowledgeDocument**](KnowledgeDocument.html) PatchKnowledgeKnowledgebaseLanguageDocument (string documentId, string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body)



Update document



Requires ALL permissions: 

* knowledge:document:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchKnowledgeKnowledgebaseLanguageDocumentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KnowledgeApi();
            var documentId = documentId_example;  // string | Document ID
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var body = new KnowledgeDocumentRequest(); // KnowledgeDocumentRequest | 

            try
            { 
                // Update document
                KnowledgeDocument result = apiInstance.PatchKnowledgeKnowledgebaseLanguageDocument(documentId, knowledgeBaseId, languageCode, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PatchKnowledgeKnowledgebaseLanguageDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, de-DE |
| **body** | [**KnowledgeDocumentRequest**](KnowledgeDocumentRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**KnowledgeDocument**](KnowledgeDocument.html)

<a name="patchknowledgeknowledgebaselanguagedocuments"></a>

## [**DocumentListing**](DocumentListing.html) PatchKnowledgeKnowledgebaseLanguageDocuments (string knowledgeBaseId, string languageCode, List<KnowledgeDocumentBulkRequest> body)



Update documents collection



Requires ALL permissions: 

* knowledge:document:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchKnowledgeKnowledgebaseLanguageDocumentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var body = new List<KnowledgeDocumentBulkRequest>(); // List<KnowledgeDocumentBulkRequest> | 

            try
            { 
                // Update documents collection
                DocumentListing result = apiInstance.PatchKnowledgeKnowledgebaseLanguageDocuments(knowledgeBaseId, languageCode, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PatchKnowledgeKnowledgebaseLanguageDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, de-DE |
| **body** | [**List<KnowledgeDocumentBulkRequest>**](KnowledgeDocumentBulkRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**DocumentListing**](DocumentListing.html)

<a name="postknowledgeknowledgebaselanguagecategories"></a>

## [**KnowledgeExtendedCategory**](KnowledgeExtendedCategory.html) PostKnowledgeKnowledgebaseLanguageCategories (string knowledgeBaseId, string languageCode, KnowledgeCategoryRequest body)



Create new category



Requires ALL permissions: 

* knowledge:category:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseLanguageCategoriesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var body = new KnowledgeCategoryRequest(); // KnowledgeCategoryRequest | 

            try
            { 
                // Create new category
                KnowledgeExtendedCategory result = apiInstance.PostKnowledgeKnowledgebaseLanguageCategories(knowledgeBaseId, languageCode, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseLanguageCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, de-DE |
| **body** | [**KnowledgeCategoryRequest**](KnowledgeCategoryRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**KnowledgeExtendedCategory**](KnowledgeExtendedCategory.html)

<a name="postknowledgeknowledgebaselanguagedocuments"></a>

## [**KnowledgeDocument**](KnowledgeDocument.html) PostKnowledgeKnowledgebaseLanguageDocuments (string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body)



Create document



Requires ALL permissions: 

* knowledge:document:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseLanguageDocumentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var body = new KnowledgeDocumentRequest(); // KnowledgeDocumentRequest | 

            try
            { 
                // Create document
                KnowledgeDocument result = apiInstance.PostKnowledgeKnowledgebaseLanguageDocuments(knowledgeBaseId, languageCode, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseLanguageDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, de-DE |
| **body** | [**KnowledgeDocumentRequest**](KnowledgeDocumentRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**KnowledgeDocument**](KnowledgeDocument.html)

<a name="postknowledgeknowledgebaselanguagetrainingpromote"></a>

## [**KnowledgeTraining**](KnowledgeTraining.html) PostKnowledgeKnowledgebaseLanguageTrainingPromote (string knowledgeBaseId, string languageCode, string trainingId)



Promote trained documents from draft state to active.



Requires ALL permissions: 

* knowledge:training:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseLanguageTrainingPromoteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE
            var trainingId = trainingId_example;  // string | Training ID

            try
            { 
                // Promote trained documents from draft state to active.
                KnowledgeTraining result = apiInstance.PostKnowledgeKnowledgebaseLanguageTrainingPromote(knowledgeBaseId, languageCode, trainingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseLanguageTrainingPromote: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, de-DE |
| **trainingId** | **string**| Training ID |  |
{: class="table table-striped"}

### Return type

[**KnowledgeTraining**](KnowledgeTraining.html)

<a name="postknowledgeknowledgebaselanguagetrainings"></a>

## [**KnowledgeTraining**](KnowledgeTraining.html) PostKnowledgeKnowledgebaseLanguageTrainings (string knowledgeBaseId, string languageCode)



Trigger training



Requires ALL permissions: 

* knowledge:training:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseLanguageTrainingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var languageCode = en-US;  // string | Language code, format: iso2-LOCALE

            try
            { 
                // Trigger training
                KnowledgeTraining result = apiInstance.PostKnowledgeKnowledgebaseLanguageTrainings(knowledgeBaseId, languageCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseLanguageTrainings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **languageCode** | **string**| Language code, format: iso2-LOCALE | <br />**Values**: en-US, de-DE |
{: class="table table-striped"}

### Return type

[**KnowledgeTraining**](KnowledgeTraining.html)

<a name="postknowledgeknowledgebasesearch"></a>

## [**KnowledgeSearchResponse**](KnowledgeSearchResponse.html) PostKnowledgeKnowledgebaseSearch (string knowledgeBaseId, KnowledgeSearchRequest body = null)



Search Documents



Requires ALL permissions: 

* knowledge:knowledgebase:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebaseSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KnowledgeApi();
            var knowledgeBaseId = knowledgeBaseId_example;  // string | Knowledge base ID
            var body = new KnowledgeSearchRequest(); // KnowledgeSearchRequest |  (optional) 

            try
            { 
                // Search Documents
                KnowledgeSearchResponse result = apiInstance.PostKnowledgeKnowledgebaseSearch(knowledgeBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebaseSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **knowledgeBaseId** | **string**| Knowledge base ID |  |
| **body** | [**KnowledgeSearchRequest**](KnowledgeSearchRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**KnowledgeSearchResponse**](KnowledgeSearchResponse.html)

<a name="postknowledgeknowledgebases"></a>

## [**KnowledgeBase**](KnowledgeBase.html) PostKnowledgeKnowledgebases (KnowledgeBase body)



Create new knowledge base



Requires ALL permissions: 

* knowledge:knowledgebase:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostKnowledgeKnowledgebasesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KnowledgeApi();
            var body = new KnowledgeBase(); // KnowledgeBase | 

            try
            { 
                // Create new knowledge base
                KnowledgeBase result = apiInstance.PostKnowledgeKnowledgebases(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KnowledgeApi.PostKnowledgeKnowledgebases: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**KnowledgeBase**](KnowledgeBase.html)|  |  |
{: class="table table-striped"}

### Return type

[**KnowledgeBase**](KnowledgeBase.html)

