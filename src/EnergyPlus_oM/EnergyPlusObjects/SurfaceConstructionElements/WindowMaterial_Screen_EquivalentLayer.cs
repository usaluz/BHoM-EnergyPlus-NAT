using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Equivalent layer window screen physical properties. Can only be located on the ex" +
                 "terior side of a window construction.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Screen_EquivalentLayer : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description(@"The beam-beam transmittance of the screen material at normal incidence. This input field is the same as the material openness area fraction and can be autocalculated from the wire spacing and wire and diameter. Assumed to be the same for both sides of the screen.")]
        [JsonProperty(PropertyName="screen_beam_beam_solar_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> ScreenBeamBeamSolarTransmittance { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("The beam-diffuse solar transmittance of the screen material at normal incidence a" +
                     "veraged over the entire spectrum of solar radiation. Assumed to be the same for " +
                     "both sides of the screen.")]
        [JsonProperty(PropertyName="screen_beam_diffuse_solar_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ScreenBeamDiffuseSolarTransmittance { get; set; } = null;
        

        [Description("The beam-diffuse solar reflectance of the screen material at normal incidence ave" +
                     "raged over the entire spectrum of solar radiation. Assumed to be the same for bo" +
                     "th sides of the screen.")]
        [JsonProperty(PropertyName="screen_beam_diffuse_solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ScreenBeamDiffuseSolarReflectance { get; set; } = null;
        

        [Description("The beam-beam visible transmittance of the screen material at normal incidence av" +
                     "eraged over the visible spectrum range of solar radiation. Assumed to be the sam" +
                     "e for both sides of the screen.")]
        [JsonProperty(PropertyName="screen_beam_beam_visible_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ScreenBeamBeamVisibleTransmittance { get; set; } = null;
        

        [Description("The beam-diffuse visible transmittance of the screen material at normal incidence" +
                     " averaged over the visible spectrum range of solar radiation. Assumed to be the " +
                     "same for both sides of the screen.")]
        [JsonProperty(PropertyName="screen_beam_diffuse_visible_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ScreenBeamDiffuseVisibleTransmittance { get; set; } = null;
        

        [Description("Beam-diffuse visible reflectance of the screen material at normal incidence avera" +
                     "ged over the visible spectrum range of solar radiation. Assumed to be the same f" +
                     "or both sides of the screen.")]
        [JsonProperty(PropertyName="screen_beam_diffuse_visible_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ScreenBeamDiffuseVisibleReflectance { get; set; } = null;
        

        [Description("The long-wave hemispherical transmittance of the screen material. Assumed to be t" +
                     "he same for both sides of the screen.")]
        [JsonProperty(PropertyName="screen_infrared_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ScreenInfraredTransmittance { get; set; } = Double.Parse("0.02", CultureInfo.InvariantCulture);
        

        [Description("The long-wave hemispherical emissivity of the screen material. Assumed to be the " +
                     "same for both sides of the screen.")]
        [JsonProperty(PropertyName="screen_infrared_emissivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ScreenInfraredEmissivity { get; set; } = Double.Parse("0.93", CultureInfo.InvariantCulture);
        

        [Description("Spacing assumed to be the same in both directions.")]
        [JsonProperty(PropertyName="screen_wire_spacing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ScreenWireSpacing { get; set; } = Double.Parse("0.025", CultureInfo.InvariantCulture);
        

        [Description("Diameter assumed to be the same in both directions.")]
        [JsonProperty(PropertyName="screen_wire_diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ScreenWireDiameter { get; set; } = Double.Parse("0.005", CultureInfo.InvariantCulture);
    }
}