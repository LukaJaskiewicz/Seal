using AutoMapper;
using Seal.Common.Dependiencies.Mappings;
using System;
using Xunit;

namespace Seal.Tests.Integration
{
    public class UnitTest1
    {
        [Fact]
        public void MappingTemplateProfile_VerifyMappings()
        {
            var mappingProfile = new TemplateProfile();
            var config  = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(mappingProfile);
            });

            var mapper = new Mapper(config);

            (mapper as IMapper).ConfigurationProvider.AssertConfigurationIsValid();
        }
    }
}
