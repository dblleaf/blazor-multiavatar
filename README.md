# BlazorMultiavatar
### About
This is a [Multiavatar](https://github.com/multiavatar/Multiavatar) library packaged with Blazor.

### Installation
1. .NET CLI
```
dotnet add package BlazorMultiavatar
```
2. Nuget Package Manager
```
Install-Package BlazorMultiavatar
```

### Usage
```razor
@using BlazorMultiavatar
...
<AntDesign.Icon Style="font-size:50px;">
    <Component>
        <Multiavatar AvatarId="@this.avatarId" />
    </Component>
</AntDesign.Icon>
<Multiavatar AvatarId="@this.avatarId" />
<button class="btn btn-primary" @onclick="NewAvatar">Refresh</button>
...

@code{
    private string avatarId = Guid.NewGuid().ToString(@"N");
    void NewAvatar()
    {
        this.avatarId = Guid.NewGuid().ToString("N");
    }
}

```

### License
[License](https://multiavatar.com/license/)