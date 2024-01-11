var target = Argument("target", "default");

Task("default")
.Does(() => {
    Information("Hello World");
});

RunTarget(target);
