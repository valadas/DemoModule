// MIT License
// Copyright Dnn Summit
using DnnSummit.Modules.DemoModule.ViewModels;

namespace DnnSummit.Modules.DemoModule.Services
{
    /// <summary>
    /// Provides strongly typed localization services for this module.
    /// </summary>
    public interface ILocalizationService
    {
        /// <summary>
        /// Gets viewmodel that strongly types all resource keys.
        /// </summary>
        LocalizationViewModel ViewModel { get; }
    }
}