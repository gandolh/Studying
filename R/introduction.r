# use package
library(datasets)

head(iris)
summary(iris)

# draw plot
plot(iris)

## Clean up

# unload package
detach("package:datasets", unload=TRUE)

# Clear plots
dev.off()

# clear console
cat("\014")
