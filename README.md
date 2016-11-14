# What's My IP
A really simple IP address API


## API Usage

Only two options plain or JSON:

| URI | Response Type | Example |
------|---------------|---------|
http://whats-my-ip.azurewebsites.net | text | 127.0.0.1 
http://whats-my-ip.azurewebsites.net?format=json | json | {"ip":"127.0.0.1"}


## Examples

### Terminal
```
$ curl 'http://whats-my-ip.azurewebsites.net?format=json'
{"ip":"127.0.0.1"}
```