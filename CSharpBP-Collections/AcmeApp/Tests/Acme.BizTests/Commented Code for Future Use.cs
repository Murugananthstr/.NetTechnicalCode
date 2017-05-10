////Mapper.Initialize(cfg => {
////    cfg.CreateMap<Foo, Bar>();
////    cfg.AddProfile<FooProfile>();
////});

////var config = new MapperConfiguration(cfg => {
////    cfg.CreateMap<Foo, Bar>();
////    cfg.AddProfile<FooProfile>();
////});

////        Mapper.CreateMap<LibraryItem, LibraryItemModel>()
////.ForMember(
////    dest => dest.Categories,
////    opt => opt.MapFrom(src => src.LibraryItemCategories));  


////Mapper.Initialize(
////    cfg => cfg.CreateMap<ResourceDataModel.RMScheduleContactRequest, SCMDataModels.ScheduleContactRequest>()
////           .ForMember(dest => dest.ContactInfo, opt => opt.MapFrom(src => src.ContactInfo)));

////Mapper.Initialize( cfg => cfg.CreateMap<ResourceDataModel.RMScheduleContactRequest, SCMDataModels.ScheduleContactRequest>());

////cfg.CreateMap<InnerSource, InnerDest>();

//// SCMDataModels.ScheduleContactRequest dto = Mapper.Map<ScheduleContactRequest>(scheduleContactRequest);
////config.AssertConfigurationIsValid();


//var config = new MapperConfiguration(cfg => {
//    cfg.CreateMap<ResourceDataModel.RMScheduleContactRequest, SCMDataModels.ScheduleContactRequest>();
//    cfg.CreateMap<ResourceDataModel.ContactInformation, SCMDataModels.ContactInformation>();
//    cfg.CreateMap<ResourceDataModel.CustomerSite, SCMDataModels.CustomerSite>();
//});

//var mapper = config.CreateMapper();
//SCMDataModels.ScheduleContactRequest dest = mapper.Map<ResourceDataModel.RMScheduleContactRequest, SCMDataModels.ScheduleContactRequest>(scheduleContactRequest);
