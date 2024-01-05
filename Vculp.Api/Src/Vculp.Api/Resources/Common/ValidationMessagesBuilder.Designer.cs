﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vculp.Api.Resources.Common {
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ValidationMessagesBuilder {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ValidationMessagesBuilder() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Vculp.Api.Resources.Common.ValidationMessagesBuilder", typeof(ValidationMessagesBuilder).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} contains duplicated items.
        /// </summary>
        public static string Array_ContainsDuplicated_Items {
            get {
                return ResourceManager.GetString("Array_ContainsDuplicated_Items", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A customer with a business type of {0} must have at least {1} contacts..
        /// </summary>
        public static string BusinessType_RequiresMoreCotnacts_ToBeSpecified {
            get {
                return ResourceManager.GetString("BusinessType_RequiresMoreCotnacts_ToBeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} {1} is not valid for category {2}.
        /// </summary>
        public static string Category_DoesNotContain {
            get {
                return ResourceManager.GetString("Category_DoesNotContain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} should not be empty.
        /// </summary>
        public static string CollectionIsRequired {
            get {
                return ResourceManager.GetString("CollectionIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Company Name.
        /// </summary>
        public static string CompanyName {
            get {
                return ResourceManager.GetString("CompanyName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Contacts should contain one or zero secondary contacts.
        /// </summary>
        public static string ContactsShouldContainOneOrZeroSecondary {
            get {
                return ResourceManager.GetString("ContactsShouldContainOneOrZeroSecondary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Contacts should contain one primary contact.
        /// </summary>
        public static string ContactsShouldContainOnePrimary {
            get {
                return ResourceManager.GetString("ContactsShouldContainOnePrimary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An order cannot be created for a customer that is considered persona non grata.
        /// </summary>
        public static string CreateOrder_CustomerPersonaNonGrata {
            get {
                return ResourceManager.GetString("CreateOrder_CustomerPersonaNonGrata", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A customer must have at least one delivery site, the last delivery site for a customer cannot be deleted.
        /// </summary>
        public static string CustomerLastDeliverySite {
            get {
                return ResourceManager.GetString("CustomerLastDeliverySite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A delivery site must have at least one contact.
        /// </summary>
        public static string DeliverySiteContactsController_DeliverySiteContact_LastOne {
            get {
                return ResourceManager.GetString("DeliverySiteContactsController_DeliverySiteContact_LastOne", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A contact cannot have an email address if EmailToBeConfirmed is set to true..
        /// </summary>
        public static string EmailNotNullWithEmailToBeconfimed {
            get {
                return ResourceManager.GetString("EmailNotNullWithEmailToBeconfimed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} does not contain {1}.
        /// </summary>
        public static string EntityDoesNotContain {
            get {
                return ResourceManager.GetString("EntityDoesNotContain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Existing customer code {0} is already in use by another customer.
        /// </summary>
        public static string ExistingCustomerCodeInUse {
            get {
                return ResourceManager.GetString("ExistingCustomerCodeInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is already in use..
        /// </summary>
        public static string FieldIsAlreadyInUse {
            get {
                return ResourceManager.GetString("FieldIsAlreadyInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is required.
        /// </summary>
        public static string FieldIsRequired {
            get {
                return ResourceManager.GetString("FieldIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} length should be {1}.
        /// </summary>
        public static string FieldLengthIsRequired {
            get {
                return ResourceManager.GetString("FieldLengthIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} should be greater than or equal to {1}.
        /// </summary>
        public static string GreaterThanOrEqualTo {
            get {
                return ResourceManager.GetString("GreaterThanOrEqualTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is invalid.
        /// </summary>
        public static string Invalid {
            get {
                return ResourceManager.GetString("Invalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Email address.
        /// </summary>
        public static string InvalidEmailAddress {
            get {
                return ResourceManager.GetString("InvalidEmailAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Maximum {0} characters are allowed.
        /// </summary>
        public static string InvalidLengthMax {
            get {
                return ResourceManager.GetString("InvalidLengthMax", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified {0} is not valid for the {1}..
        /// </summary>
        public static string InvalidObjectForSpecifiedObjectForProduct {
            get {
                return ResourceManager.GetString("InvalidObjectForSpecifiedObjectForProduct", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} for the product must be a valid {1} in the Products module..
        /// </summary>
        public static string InvalidObjectInTheProductsModule {
            get {
                return ResourceManager.GetString("InvalidObjectInTheProductsModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Phone number.
        /// </summary>
        public static string InvalidPhoneNumber {
            get {
                return ResourceManager.GetString("InvalidPhoneNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The product code must be unique (e.g. no other product with the same code can already exist). The max length is {} and this field is mandatory..
        /// </summary>
        public static string InvalidProductCode {
            get {
                return ResourceManager.GetString("InvalidProductCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AssociatedStockTypes that are mandatory against the customers species are required.
        /// </summary>
        public static string MandatoryStockTypesNotCovered {
            get {
                return ResourceManager.GetString("MandatoryStockTypesNotCovered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An organic customer must be associated with an organic species.
        /// </summary>
        public static string ManipulationCustomerDtoValidator_SpeciesMatchesIsOrganic {
            get {
                return ResourceManager.GetString("ManipulationCustomerDtoValidator_SpeciesMatchesIsOrganic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A non-organic customer must be associated with a non-organic species.
        /// </summary>
        public static string ManipulationCustomerDtoValidator_SpeciesMatchesNonOrganic {
            get {
                return ResourceManager.GetString("ManipulationCustomerDtoValidator_SpeciesMatchesNonOrganic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} requires {1} or {2} to be defined.
        /// </summary>
        public static string ManipulationsOrderLineDtoValidator_Quantity_Requires_Pallets_Or_Bags {
            get {
                return ResourceManager.GetString("ManipulationsOrderLineDtoValidator_Quantity_Requires_Pallets_Or_Bags", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} requires {1} to be defined.
        /// </summary>
        public static string ManipulationsOrderLineDtoValidator_Quantity_Requires_Something {
            get {
                return ResourceManager.GetString("ManipulationsOrderLineDtoValidator_Quantity_Requires_Something", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The production code contains whitespace. A production code cannot contain whitespace..
        /// </summary>
        public static string ManipulationsProductConfigurationPriceDtoValidator_PriceIsNegativeError {
            get {
                return ResourceManager.GetString("ManipulationsProductConfigurationPriceDtoValidator_PriceIsNegativeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot be set for a product category that does not require categorisation.
        /// </summary>
        public static string ManipulationsProductDtoValidator_FieldMustBeEmpty {
            get {
                return ResourceManager.GetString("ManipulationsProductDtoValidator_FieldMustBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Product form with code {0} is not a valid text group for sub-group {1}.
        /// </summary>
        public static string ManipulationsProductDtoValidator_ProductFormIsNotValidForSubGroup {
            get {
                return ResourceManager.GetString("ManipulationsProductDtoValidator_ProductFormIsNotValidForSubGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An organic product must be associated with an organic species.
        /// </summary>
        public static string ManipulationsProductDtoValidator_SpeicesRequiresIsOrganic {
            get {
                return ResourceManager.GetString("ManipulationsProductDtoValidator_SpeicesRequiresIsOrganic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A non-organic product must be associated with a non-organic species.
        /// </summary>
        public static string ManipulationsProductDtoValidator_SpeicesRequiresNonOrganic {
            get {
                return ResourceManager.GetString("ManipulationsProductDtoValidator_SpeicesRequiresNonOrganic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sub species with code {0} is not a valid sub species for species {1}.
        /// </summary>
        public static string ManipulationsProductDtoValidator_SubSpeciesIsNotValidForSpecies {
            get {
                return ResourceManager.GetString("ManipulationsProductDtoValidator_SubSpeciesIsNotValidForSpecies", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Text group with code {0} is not a valid text group for sub species {1}.
        /// </summary>
        public static string ManipulationsProductDtoValidator_TextGroupIsNotValidForSubSpecies {
            get {
                return ResourceManager.GetString("ManipulationsProductDtoValidator_TextGroupIsNotValidForSubSpecies", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} with such {1} does not exist.
        /// </summary>
        public static string NotFound {
            get {
                return ResourceManager.GetString("NotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} should be NULL.
        /// </summary>
        public static string NullIsRequired {
            get {
                return ResourceManager.GetString("NullIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Notes cannot be added to a cancelled order.
        /// </summary>
        public static string OrderLineController_AddNoteToCanceledOrder {
            get {
                return ResourceManager.GetString("OrderLineController_AddNoteToCanceledOrder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Notes for a cancelled order cannot be deleted.
        /// </summary>
        public static string OrderLineController_DeleteNoteFromCanceledOrder {
            get {
                return ResourceManager.GetString("OrderLineController_DeleteNoteFromCanceledOrder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Notes for a cancelled order cannot be edited.
        /// </summary>
        public static string OrderLineController_UpdateNoteFromCanceledOrder {
            get {
                return ResourceManager.GetString("OrderLineController_UpdateNoteFromCanceledOrder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not valid ISO 8601 date string.
        /// </summary>
        public static string ParameterIsNotValidIso8601DateString {
            get {
                return ResourceManager.GetString("ParameterIsNotValidIso8601DateString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} should be in range from {1} to {2}.
        /// </summary>
        public static string Range {
            get {
                return ResourceManager.GetString("Range", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Customers with a species of {0} must have a VWD Email Address..
        /// </summary>
        public static string Species_Requires_VwdEmail {
            get {
                return ResourceManager.GetString("Species_Requires_VwdEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The species in the request must exist in the AssociatedStockTypes collection for the customers species..
        /// </summary>
        public static string SpeciesIsNotValidAssociatedStockType {
            get {
                return ResourceManager.GetString("SpeciesIsNotValidAssociatedStockType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The stock numbers object should contain a stock total entry for every sub-species that is linked to the species that is marked as a mandatory associated stock type..
        /// </summary>
        public static string SubspeciesForMandatoryStockTypeIsMissing {
            get {
                return ResourceManager.GetString("SubspeciesForMandatoryStockTypeIsMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is cancelled and cannot be updated.
        /// </summary>
        public static string UpdateCancelledObject {
            get {
                return ResourceManager.GetString("UpdateCancelledObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Customer Specific Product Prices do not exist for customer {0} and product {1}.
        /// </summary>
        public static string UpdateCustomerSpecificProductPricesDtoValidator_CustomerSpecificPricesNotExistError {
            get {
                return ResourceManager.GetString("UpdateCustomerSpecificProductPricesDtoValidator_CustomerSpecificPricesNotExistErr" +
                        "or", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Price List Prices do not exist for customer {0} and product {1}.
        /// </summary>
        public static string UpdateProductPriceListPricesDtoValidator_PriceListPricesDoesNotExistsError {
            get {
                return ResourceManager.GetString("UpdateProductPriceListPricesDtoValidator_PriceListPricesDoesNotExistsError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to VatNo is not required for customers in IRL.
        /// </summary>
        public static string VatNoIsNotRequiredForIRL {
            get {
                return ResourceManager.GetString("VatNoIsNotRequiredForIRL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PriceList Currency does not match Customer Currency.
        /// </summary>
        public static string WriteCustomerDtoValidator_PriceListCurrency_DoesNotMatch_CustomerCurrency {
            get {
                return ResourceManager.GetString("WriteCustomerDtoValidator_PriceListCurrency_DoesNotMatch_CustomerCurrency", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Customer Specific Product Prices already exists for customer {0} for product {1}.
        /// </summary>
        public static string WriteCustomerSpecificProductPricesDtoValidator_CustomerSpecificPricesExistsError {
            get {
                return ResourceManager.GetString("WriteCustomerSpecificProductPricesDtoValidator_CustomerSpecificPricesExistsError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delivery Option {0} does not exist..
        /// </summary>
        public static string WriteProductConfigurationDtoValidator_DeliveryOption_DoesNotExistError {
            get {
                return ResourceManager.GetString("WriteProductConfigurationDtoValidator_DeliveryOption_DoesNotExistError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Formulation {0} does not exist..
        /// </summary>
        public static string WriteProductConfigurationDtoValidator_Formulation_DoesNotExistError {
            get {
                return ResourceManager.GetString("WriteProductConfigurationDtoValidator_Formulation_DoesNotExistError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Physical Form {0} does not exist..
        /// </summary>
        public static string WriteProductConfigurationDtoValidator_PhysicalForm_DoesNotExistError {
            get {
                return ResourceManager.GetString("WriteProductConfigurationDtoValidator_PhysicalForm_DoesNotExistError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The production code for delivery option {0} contains whitespace. A production code cannot contain whitespace..
        /// </summary>
        public static string WriteProductConfigurationDtoValidator_ProductionCode_ContainsWhiteSpaceError {
            get {
                return ResourceManager.GetString("WriteProductConfigurationDtoValidator_ProductionCode_ContainsWhiteSpaceError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Product does not contain configuration with code {0}.
        /// </summary>
        public static string WriteProductConfigurationPriceDtoValidator_ConfigurationDoesNotExistError {
            get {
                return ResourceManager.GetString("WriteProductConfigurationPriceDtoValidator_ConfigurationDoesNotExistError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The price for product configuration code {0} is invalid. Prices cannot be less than zero..
        /// </summary>
        public static string WriteProductConfigurationPriceDtoValidator_PriceIsNegativeError {
            get {
                return ResourceManager.GetString("WriteProductConfigurationPriceDtoValidator_PriceIsNegativeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The price for {0} on price list {1} is invalid. Prices cannot be less than zero..
        /// </summary>
        public static string WriteProductCreationPriceListPriceDtoValidator_PriceIsNegativeError {
            get {
                return ResourceManager.GetString("WriteProductCreationPriceListPriceDtoValidator_PriceIsNegativeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No price list exists with code {0}.
        /// </summary>
        public static string WriteProductCreationPriceListPriceDtoValidator_PriceListDoesntExistError {
            get {
                return ResourceManager.GetString("WriteProductCreationPriceListPriceDtoValidator_PriceListDoesntExistError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No customer exists with customer code {0}.
        /// </summary>
        public static string WriteProductCustomerSpecificProductPriceDtoValidator_CustomerDoesNotExistError {
            get {
                return ResourceManager.GetString("WriteProductCustomerSpecificProductPriceDtoValidator_CustomerDoesNotExistError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The price for delivery option {0} for customer {1} is invalid. Prices cannot be less than zero..
        /// </summary>
        public static string WriteProductCustomerSpecificProductPriceDtoValidator_PriceLessThanZeroError {
            get {
                return ResourceManager.GetString("WriteProductCustomerSpecificProductPriceDtoValidator_PriceLessThanZeroError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are two or more Configurations with the same Delivery Option..
        /// </summary>
        public static string WriteProductDtoValidator_ConfigurationsContainDuplicatedDeliveryOption {
            get {
                return ResourceManager.GetString("WriteProductDtoValidator_ConfigurationsContainDuplicatedDeliveryOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Product {0} does not contain a delivery option {1}. Customer {2} can not have a specific price for this delivery option..
        /// </summary>
        public static string WriteProductDtoValidator_DeliveryOptionForCustomerSpecificPriceDoesNotExistError {
            get {
                return ResourceManager.GetString("WriteProductDtoValidator_DeliveryOptionForCustomerSpecificPriceDoesNotExistError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Product {0} does not contain a delivery option {1}. Pricelist {2} can not contain a price for this delivery option. .
        /// </summary>
        public static string WriteProductDtoValidator_DeliveryOptionForPriceListPriceDoesNotExistError {
            get {
                return ResourceManager.GetString("WriteProductDtoValidator_DeliveryOptionForPriceListPriceDoesNotExistError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Product code {0} is already in use by another product..
        /// </summary>
        public static string WriteProductDtoValidator_ProductCodeIsAlreadyInUse {
            get {
                return ResourceManager.GetString("WriteProductDtoValidator_ProductCodeIsAlreadyInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No Price List exists with code {0}.
        /// </summary>
        public static string WriteProductPriceListPricesDtoValidator_PriceListDoesNotExistError {
            get {
                return ResourceManager.GetString("WriteProductPriceListPricesDtoValidator_PriceListDoesNotExistError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Price List Prices already exists for customer {0} for product {1}.
        /// </summary>
        public static string WriteProductPriceListPricesDtoValidator_PriceListPricesExistsError {
            get {
                return ResourceManager.GetString("WriteProductPriceListPricesDtoValidator_PriceListPricesExistsError", resourceCulture);
            }
        }
    }
}