<!DOCTYPE html>

<html>
<head>
    <meta charset="UTF-8" />
    <title>@ViewData("Title")</title>

    @Html.DevExpress().GetStyleSheets(
        New StyleSheet With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout },
        New StyleSheet With {.ExtensionSuite = ExtensionSuite.Editors }
    )
    @Html.DevExpress().GetScripts(
        New Script With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout },
        New Script With {.ExtensionSuite = ExtensionSuite.Editors }
    )
</head>

<body>
    @RenderBody()
</body>
</html>