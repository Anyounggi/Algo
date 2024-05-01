def solution(genres, plays):
    ans = []
    dict1 = {}
    dict2 = {}

    for i in range(len(genres)):
        dict1[genres[i]] = dict1.get(genres[i], 0) + plays[i]
        dict2[genres[i]] = dict2.get(genres[i], []) + [(plays[i], i)]

    genre_dict = sorted(dict1.items(), key=lambda x: x[1], reverse=True)

    for (genre, dict1Play) in genre_dict:
        dict2[genre] = sorted(dict2[genre], key=lambda x: (-x[0], x[1]))
        ans += [idx for (play, idx) in dict2[genre][:2]]

    return ans