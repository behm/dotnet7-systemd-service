# dotnet7-systemd-service
.NET 7 service that works with Systemd on Linux

## Building

Run this command to build the application
```bash
dotnet publish -c Release -r linux-x64 --self-contained=true -p:PublishSingleFile=true -p:GenerateRuntimeConfigurationFiles=true -o artifacts
 ```

Copy the contents of the artfacts folder to the /usr/sbin/HelloLinux directory on a Linux machine

Make sure the code is executable by running this command
```bash
sudo chmod 0755 /usr/sbin/HelloLinux
```

Copy the hellolinux.service file to the /etc/systemd/system directory

Run the following command so Systemd loads the new configuration
```bash
sudo systemctl daemon-reload
```

Check the status of the HelloLinux service by running the following command
```bash
sudo systemctl status hellolinux.service
```

## How to use
...


## Resources
- https://blog.maartenballiauw.be/post/2021/05/25/running-a-net-application-as-a-service-on-linux-with-systemd.html
