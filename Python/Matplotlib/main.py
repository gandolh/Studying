import matplotlib.pyplot as plt

seasons = ['Season1', 'Season2', 'Season3', 'Season4', 'Season5', 'Season6',
        'Season7', 'Season8', 'Season7', 'Season8', 'Season9', 'Season10',
        'Season11', 'Season12', 'Season13', 'Season14', 'Season15',
        'Season16', 'Season17', 'Season18', 'Season19', 'Season20',
        'Season21', 'Season22', 'Season23', 'Season24', 'Season25',
        'Season26', 'Season27', 'Season28']
years = [1989, 1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997, 1998, 1999,
           2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009,
           2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018]
ratings = [7.8, 8.1, 8.2, 8.3, 8.4, 8.4, 8.4, 8.3, 8.2, 8.1, 8.0, 7.9, 7.3,
            7.2, 7.1, 7.1, 6.9, 6.8, 6.7, 6.6, 6.5, 6.4, 6.3, 6.2, 6.1,
            5.3, 5.4, 5.2, 5.2, 5.1]

views = [27.8, 24.4, 21.8, 22.4, 18.9, 15.6, 15.1, 14.5,
         14.2, 13.3, 12.8, 12.3, 12.0, 11.7, 11.5, 11.3,
         11.1, 10.9, 10.7, 10.5, 10.3, 10.1, 9.9, 9.7,
         11.1, 10.9, 10.7, 10.5, 10.3, 10.1
         ]


# General
fig = plt.figure(figsize= (12,8))
font_style = {'color': 'tab:blue', 'family': 'fantasy', 'weight': 'bold'}
font_style_zombie = {'color': 'yellow', 'family': 'fantasy', 'weight': 'bold'}


# Ratings
ax_rating = fig.add_axes([0.05, 0.05, 0.9, 0.35] )
ax_rating.bar(x = seasons, height = ratings )
ax_rating.set_xticks([0,9,19,29])
ax_rating.set_ylim(5,9)
ax_rating.set_title('IMDB Ratings')
ax_rating.text(2, 7.5 , 'Golden Age', size = 16,   bbox={'fc':'yellow', 'ec': 'tab:blue' }, fontdict=font_style) 
ax_rating.text(19,7 , 'Zombie Simpsons', size = 16,   bbox={'fc':'tab:blue', 'ec': 'yellow'}, fontdict=font_style_zombie)


# Views
ax_views = fig.add_axes([0.05, 0.45, 0.9, 0.35] )
ax_views.plot(years, views, linewidth = 4, solid_capstyle = 'round')
ax_views.set_xticks([])
ax_views.set_title('Views in millions', fontdict=font_style)
ax_views.text(1989.2, 27.8, '1989', fontdict=font_style)
ax_views.text(2018.2, 10.1, '2018', fontdict=font_style)

# Styiling
fig.patch.set_facecolor('yellow')
for axes in [ax_views, ax_rating]:
    axes.set_facecolor('yellow')
    axes.tick_params(colors='tab:blue', labelsize=12, width = 2)
    for side in ['bottom', 'left', 'top', 'right']:
        axes.spines[side].set_color('tab:blue')
        axes.spines[side].set_linewidth(2)
    
# Show
plt.savefig('output',facecolor=fig.get_facecolor())