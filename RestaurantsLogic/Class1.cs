namespace RestaurantsLogic;

    public class RestaurantSearchResponse
    {
        public string? Area { get; set; }
        public MetaData MetaData { get; set; }
        public List<Restaurant> Restaurants { get; set; }
        public List<object> RestaurantSets { get; set; }
        public List<CuisineSet> CuisineSets { get; set; }
        public List<object> Views { get; set; }
        public List<object> Dishes { get; set; }
        public string? ShortResultText { get; set; }
        public DeliveryFees deliveryFees { get; set; }
        public PromotedPlacement promotedPlacement { get; set; }
    }

    public class MetaData
    {
        public string? CanonicalName { get; set; }
        public string? District { get; set; }
        public string? Postcode { get; set; }
        public string? Area { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public List<CuisineDetail> CuisineDetails { get; set; }
        public int? ResultCount { get; set; }
        public object SearchedTerms { get; set; }
        public List<TagDetail> TagDetails { get; set; }
    }

    public class CuisineDetail
    {
        public string? Name { get; set; }
        public string? SeoName { get; set; }
        public int? Total { get; set; }
    }

    public class TagDetail
    {
        public string? BackgroundColour { get; set; }
        public string? Colour { get; set; }
        public string? DisplayName { get; set; }
        public string? Key { get; set; }
        public int? Priority { get; set; }
    }

    public class Restaurant
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? UniqueName { get; set; }
        public Address Address { get; set; }
        public string? City { get; set; }
        public string? Postcode { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public Rating Rating { get; set; }
        public decimal RatingStars { get; set; }
        public int? NumberOfRatings { get; set; }
        public decimal RatingAverage { get; set; }
        public string? Description { get; set; }
        public string? Url { get; set; }
        public string? LogoUrl { get; set; }
        public bool IsTestRestaurant { get; set; }
        public bool IsHalal { get; set; }
        public bool IsNew { get; set; }
        public string? ReasonWhyTemporarilyOffline { get; set; }
        public decimal DriveDistance { get; set; }
        public bool DriveInfoCalculated { get; set; }
        public bool IsCloseBy { get; set; }
        public decimal OfferPercent { get; set; }
        public DateTime? NewnessDate { get; set; }
        public DateTime? OpeningTime { get; set; }
        public object OpeningTimeUtc { get; set; }
        public DateTime? OpeningTimeIso { get; set; }
        public DateTime? OpeningTimeLocal { get; set; }
        public DateTime? DeliveryOpeningTimeLocal { get; set; }
        public DateTime? DeliveryOpeningTime { get; set; }
        public string? DeliveryOpeningTimeUtc { get; set; }
        public DateTime? DeliveryStartTime { get; set; }
        public string? DeliveryTime { get; set; }
        public string? DeliveryTimeMinutes { get; set; }
        public string? DeliveryWorkingTimeMinutes { get; set; }
        public DeliveryEtaMinutes DeliveryEtaMinutes { get; set; }
        public bool IsCollection { get; set; }
        public bool IsDelivery { get; set; }
        public bool IsFreeDelivery { get; set; }
        public bool IsOpenNowForCollection { get; set; }
        public bool IsOpenNowForDelivery { get; set; }
        public bool IsOpenNowForPreorder { get; set; }
        public bool IsOpenNow { get; set; }
        public bool IsTemporarilyOffline { get; set; }
        public int? DeliveryMenuId { get; set; }
        public int? CollectionMenuId { get; set; }
        public string? DeliveryZipcode { get; set; }
        public double? DeliveryCost { get; set; }
        public decimal? MinimumDeliveryValue { get; set; }
        public decimal? SecondDateRanking { get; set; }
        public int? DefaultDisplayRank { get; set; }
        public int? SponsoredPosition { get; set; }
        public decimal? SecondDateRank { get; set; }
        public decimal? Score { get; set; }
        public bool IsTemporaryBoost { get; set; }
        public bool IsSponsored { get; set; }
        public bool IsPremier { get; set; }
        public int? HygieneRating { get; set; }
        public bool ShowSmiley { get; set; }
        public DateTime? SmileyDate { get; set; }
        public bool SmileyElite { get; set; }
        public string? SmileyResult { get; set; }
        public string? SmileyUrl { get; set; }
        public bool SendsOnItsWayNotifications { get; set; }
        public string? BrandName { get; set; }
        public bool IsBrand { get; set; }
        public DateTime? LastUpdated { get; set; }
        public List<Deal> Deals { get; set; }
        public List<Offer> Offers { get; set; }
        public List<Logo> Logo { get; set; }
        public List<object> Tags { get; set; }
        public List<object> DeliveryChargeBands { get; set; }
        public List<CuisineType> CuisineTypes { get; set; }
        public List<Cuisine> Cuisines { get; set; }
        public List<ScoreMetaData> ScoreMetaData { get; set; }
        // empty arrays?
        public List<object> Badges { get; set; }
        public List<object> OpeningTimes { get; set; }
        public List<object> ServiceableAreas { get; set; }
    }


    public class Deal
    {
        public string? Description { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? QualifyingPrice { get; set; }
        public string? OfferType { get; set; }
    }

     public class Offer
    {
        public decimal? Amount { get; set; }
        public decimal? QualifyingValue { get; set; }
        public decimal? MaxQualifyingValue { get; set; }
        public string? Type { get; set; }
        public string? OfferId { get; set; }
    }

    public class Address
    {
        public string? City { get; set; }
        public string? FirstLine { get; set; }
        public string? Postcode { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
    public class Rating
    {
        public int? Count { get; set; }
        public decimal Average { get; set; }
        public decimal StarRating { get; set; }
    }

    public class DeliveryEtaMinutes
    {
        public object Approximate { get; set; }
        public int? RangeLower { get; set; }
        public int? RangeUpper { get; set; }
    }


    public class Logo
    {
        public string? StandardResolutionURL { get; set; }
    }

    public class CuisineType
    {
        public int? Id { get; set; }
        public bool IsTopCuisine { get; set; }
        public string? Name { get; set; }
        public string? SeoName { get; set; }
    }

    public class Cuisine
    {
        public string? Name { get; set; }
        public string? SeoName { get; set; }
    }

     public class ScoreMetaData
    {
        public string? Key { get; set; }
        public string? Value { get; set; }
    }

    public class CuisineSet
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public List<Cuisine> Cuisines { get; set; }
    }

    public class DeliveryFees
    {
        public Restaurants restaurants { get; set; }
    }

    public class Restaurants
    {
        public _102215 _102215 { get; set; }
        public _84335 _84335 { get; set; }
    }

    public class _102215
    {
        public string? restaurantId { get; set; }
        public int? minimumOrderValue { get; set; }
        public List<Band> bands { get; set; }
    }
     public class Band
    {
        public int? minimumAmount { get; set; }
        public int? fee { get; set; }
    }
     public class _84335
    {
        public string? restaurantId { get; set; }
        public bool defaultPromoted { get; set; }
    }

    public class PromotedPlacement
    {
        public int? filteredSearchPromotedLimit { get; set; }
        public Restaurants restaurants { get; set; }
        public List<int?> rankedIds { get; set; }
    }