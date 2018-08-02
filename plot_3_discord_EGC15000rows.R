
start_outlier_points = c(10867, 13492, 3994);
N_LENGTH = 600
cols = c("red", "green", "magenta")
#read data
data=read.csv("C:\\Users\\chauuser_w10\\Downloads\\SAX__update\\SAX__update\\SAX_update\\SAX_update\\bin\\Debug\\Data\\ECG_15000.txt")[[1]]



plot(data, type="l", col="blue")
for (i in 1:length(start_outlier_points))
{
    sub_timeseries = c(start_outlier_points[i]:(start_outlier_points[i]+N_LENGTH-1))
    lines(sub_timeseries, data[sub_timeseries], type="l", col=cols[i], lwd=3)
}

legend('topright', c("1st Discord", "2nd Discord", "3rd Discord"), col = cols, lty=1, bty='n', cex=.75, lwd=3) # gives the legend lines the correct color and width

#colors()[450]: 
#colors: http://research.stowers-institute.org/efg/R/Color/Chart/index.htm



data=read.csv("C:\\Users\\chauuser_w10\\Downloads\\SAX__update\\SAX__update\\SAX_update\\SAX_update\\bin\\Debug\\Data\\ERP_data.dat", sep = "", skip = 0,header = F)
for (int)
plot(data,type="l")
