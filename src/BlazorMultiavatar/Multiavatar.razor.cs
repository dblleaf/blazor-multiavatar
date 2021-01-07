namespace BlazorMultiavatar
{
    using Microsoft.AspNetCore.Components;

    public partial class Multiavatar
    {
        [Parameter]
        public string AvatarId { get; set; }

        [Parameter]
        public string Width { get; set; }

        [Parameter]
        public string Height { get; set; }

        private string Svg => MultiAvatarBuilder.Build(this.AvatarId, width: this.Width, heigit: this.Height);
    }
}
