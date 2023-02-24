for docker you can use those commands:
docker build . -t myserver 
docker run -p 8085:8084 -d myserver
docker run -p 8086:8084 -d myserver
docker run -p 8087:8084 -d myserver
docker run -p 8088:8084 -d myserver