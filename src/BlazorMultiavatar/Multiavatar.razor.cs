namespace BlazorMultiavatar
{
    using Microsoft.AspNetCore.Components;

    public partial class Multiavatar
    {
        [Parameter]
        public string AvatarId { get; set; }

        private string Svg => MultiAvatarBuilder.Build(this.AvatarId);
    }
}
