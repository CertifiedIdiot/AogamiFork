﻿namespace Aogami.SMTV.GameData
{
    public record SMTVDemon(int Index, string CharacterName, short CharacterId, short DevilId, short SpriteId);

    public static class SMTVDemonCollection
    {
        public static readonly IReadOnlyDictionary<int, SMTVDemon> DemonList = new Dictionary<int, SMTVDemon>()
        {
            { 0, new(0, "Khonsu", 7, 7, 7) },
            { 1, new(1, "Zeus", 8, 8, 8) },
            { 2, new(2, "Odin", 9, 9, 9) },
            { 3, new(3, "Mitra", 11, 11, 11) },
            { 4, new(4, "Atavaka", 12, 12, 12) },
            { 5, new(5, "Horus", 13, 13, 13) },
            { 6, new(6, "Thoth", 14, 14, 14) },
            { 7, new(7, "Khonsu Ra", 15, 15, 15) },
            { 8, new(8, "Vishnu", 16, 16, 16) },
            { 9, new(9, "Baal", 17, 17, 17) },
            { 10, new(10, "Demeter", 19, 19, 19) },
            { 11, new(11, "Anahita", 20, 20, 20) },
            { 12, new(12, "Lakshmi", 21, 21, 21) },
            { 13, new(13, "Norn", 22, 22, 22) },
            { 14, new(14, "Idun", 23, 23, 23) },
            { 15, new(15, "Sarasvati", 24, 24, 24) },
            { 16, new(16, "Ishtar", 25, 25, 25) },
            { 17, new(17, "Scathach", 26, 26, 26) },
            { 18, new(18, "Parvati", 27, 27, 27) },
            { 19, new(19, "Ame-no-Uzume", 28, 28, 28) },
            { 20, new(20, "Fortuna", 29, 29, 29) },
            { 21, new(21, "Maria", 30, 30, 30) },
            { 22, new(22, "Artemis", 31, 31, 31) },
            { 23, new(23, "Hanuman", 34, 34, 34) },
            { 24, new(24, "Fionn mac Cumhaill", 35, 35, 35) },
            { 25, new(25, "Cu Chulainn", 36, 36, 36) },
            { 26, new(26, "Kurama Tengu", 37, 37, 37) },
            { 27, new(27, "Amanozako", 38, 38, 38) },
            { 28, new(28, "Koppa Tengu", 42, 42, 42) },
            { 29, new(29, "Apsaras", 43, 43, 43) },
            { 30, new(30, "Agathion", 44, 44, 44) },
            { 31, new(31, "Mandrake", 45, 45, 45) },
            { 32, new(32, "Titania", 51, 51, 51) },
            { 33, new(33, "Oberon", 52, 52, 52) },
            { 34, new(34, "Silky", 53, 53, 53) },
            { 35, new(35, "Setanta", 54, 54, 54) },
            { 36, new(36, "Kelpie", 55, 55, 55) },
            { 37, new(37, "High Pixie", 56, 56, 56) },
            { 38, new(38, "Jack-o'-Lantern", 57, 57, 57) },
            { 39, new(39, "Jack Frost", 58, 58, 58) },
            { 40, new(40, "Pixie", 59, 59, 59) },
            { 41, new(41, "Queen Medb", 64, 64, 64) },
            { 42, new(42, "Succubus", 65, 65, 65) },
            { 43, new(43, "Kaiwan", 66, 66, 66) },
            { 44, new(44, "Lilim", 67, 67, 67) },
            { 45, new(45, "Incubus", 68, 68, 68) },
            { 46, new(46, "Mokoi", 69, 69, 69) },
            { 47, new(47, "Sandman", 70, 70, 70) },
            { 48, new(48, "Lilith", 71, 71, 71) },
            { 49, new(49, "Black Frost", 72, 72, 72) },
            { 50, new(50, "Nuwa", 75, 75, 75) },
            { 51, new(51, "Amon", 76, 76, 76) },
            { 52, new(52, "Mara", 77, 77, 77) },
            { 53, new(53, "Mephisto", 78, 78, 78) },
            { 54, new(54, "Chi You", 79, 79, 79) },
            { 55, new(55, "Surt", 80, 80, 80) },
            { 56, new(56, "Beelzebub", 81, 81, 81) },
            { 57, new(57, "Arioch", 82, 82, 82) },
            { 58, new(58, "Belial", 83, 83, 83) },
            { 59, new(59, "Abaddon", 84, 84, 84) },
            { 60, new(60, "Moloch", 85, 85, 85) },
            { 61, new(61, "Belphegor", 86, 86, 86) },
            { 62, new(62, "King Frost", 87, 87, 87) },
            { 63, new(63, "Mithras", 88, 88, 88) },
            { 64, new(64, "Loki", 89, 89, 89) },
            { 65, new(65, "Huang Long", 94, 94, 94) },
            { 66, new(66, "Quetzalcoatl", 95, 95, 95) },
            { 67, new(67, "Qing Long", 96, 96, 96) },
            { 68, new(68, "Xuanwu", 97, 97, 97) },
            { 69, new(69, "Ananta", 98, 98, 98) },
            { 70, new(70, "Yamata-no-Orochi", 103, 103, 103) },
            { 71, new(71, "Naga Raja", 104, 104, 104) },
            { 72, new(72, "Yurlungur", 105, 105, 105) },
            { 73, new(73, "Naga", 106, 106, 106) },
            { 74, new(74, "Vasuki", 111, 111, 111) },
            { 75, new(75, "Seth", 112, 112, 112) },
            { 76, new(76, "Basilisk", 113, 113, 113) },
            { 77, new(77, "Aitvaras", 114, 114, 114) },
            { 78, new(78, "Hydra", 115, 115, 115) },
            { 79, new(79, "Fafnir", 116, 116, 116) },
            { 80, new(80, "Barong", 119, 119, 119) },
            { 81, new(81, "Anubis", 120, 120, 120) },
            { 82, new(82, "Makami", 121, 121, 121) },
            { 83, new(83, "Baihu", 126, 126, 126) },
            { 84, new(84, "Chimera", 127, 127, 127) },
            { 85, new(85, "Cironnup", 128, 128, 128) },
            { 86, new(86, "Shiisaa", 129, 129, 129) },
            { 87, new(87, "Cerberus", 134, 134, 134) },
            { 88, new(88, "Orthrus", 135, 135, 135) },
            { 89, new(89, "Loup-garou", 136, 136, 136) },
            { 90, new(90, "Nekomata", 137, 137, 137) },
            { 91, new(91, "Inugami", 138, 138, 138) },
            { 92, new(92, "Orobas", 139, 139, 139) },
            { 93, new(93, "Cait Sith", 140, 140, 140) },
            { 94, new(94, "Bugs", 144, 144, 144) },
            { 95, new(95, "Nue", 145, 145, 145) },
            { 96, new(96, "Bicorn", 146, 146, 146) },
            { 97, new(97, "Mothman", 147, 147, 147) },
            { 98, new(98, "Hayataro", 152, 152, 152) },
            { 99, new(99, "Flaemis", 155, 155, 155) },
            { 100, new(100, "Aquans", 156, 156, 156) },
            { 101, new(101, "Aeros", 157, 157, 157) },
            { 102, new(102, "Erthys", 158, 158, 158) },
            { 103, new(103, "Saki Mitama", 163, 163, 163) },
            { 104, new(104, "Kushi Mitama", 164, 164, 164) },
            { 105, new(105, "Nigi Mitama", 165, 165, 165) },
            { 106, new(106, "Ara Mitama", 166, 166, 166) },
            { 107, new(107, "Black Ooze", 171, 171, 171) },
            { 108, new(108, "Legion", 172, 172, 172) },
            { 109, new(109, "Slime", 173, 173, 173) },
            { 110, new(110, "Shiva", 178, 178, 178) },
            { 111, new(111, "Mot", 179, 179, 179) },
            { 112, new(112, "Zaou-Gongen", 180, 180, 180) },
            { 113, new(113, "Asura", 181, 181, 181) },
            { 114, new(114, "Chernobog", 182, 182, 182) },
            { 115, new(115, "Dionysus", 183, 183, 183) },
            { 116, new(116, "Danu", 188, 188, 188) },
            { 117, new(117, "Inanna", 189, 189, 189) },
            { 118, new(118, "Kali", 190, 190, 190) },
            { 119, new(119, "Cybele", 191, 191, 191) },
            { 120, new(120, "Skadi", 192, 192, 192) },
            { 121, new(121, "Isis", 193, 193, 193) },
            { 122, new(122, "Kikuri-Hime", 194, 194, 194) },
            { 123, new(123, "Hariti", 195, 195, 195) },
            { 124, new(124, "Nuwa", 197, 197, 197) },
            { 125, new(125, "Alilat", 198, 198, 198) },
            { 126, new(126, "Thor", 200, 200, 200) },
            { 127, new(127, "Futsunushi", 201, 201, 201) },
            { 128, new(128, "Attis", 202, 202, 202) },
            { 129, new(129, "Bishamonten", 203, 203, 203) },
            { 130, new(130, "Jikokuten", 204, 204, 204) },
            { 131, new(131, "Koumokuten", 205, 205, 205) },
            { 132, new(132, "Zouchouten", 206, 206, 206) },
            { 133, new(133, "Arahabaki", 211, 211, 211) },
            { 134, new(134, "Oyamatsumi", 212, 212, 212) },
            { 135, new(135, "Kushinada-Hime", 213, 213, 213) },
            { 136, new(136, "Sukuna-Hikona", 214, 214, 214) },
            { 137, new(137, "Okuninushi", 215, 215, 215) },
            { 138, new(138, "Take-Minakata", 216, 216, 216) },
            { 139, new(139, "Ganesha", 221, 221, 221) },
            { 140, new(140, "Siegfried", 222, 222, 222) },
            { 141, new(141, "Valkyrie", 223, 223, 223) },
            { 142, new(142, "Yoshitsune", 224, 224, 224) },
            { 143, new(143, "Neko Shogun", 225, 225, 225) },
            { 144, new(144, "Mada", 231, 231, 231) },
            { 145, new(145, "Girimekhala", 232, 232, 232) },
            { 146, new(146, "Pazuzu", 233, 233, 233) },
            { 147, new(147, "Mishaguji", 234, 234, 234) },
            { 148, new(148, "Baphomet", 235, 235, 235) },
            { 149, new(149, "Lahmu", 236, 236, 236) },
            { 150, new(150, "Abdiel", 240, 240, 240) },
            { 151, new(151, "Metatron", 241, 241, 241) },
            { 152, new(152, "Michael", 242, 242, 242) },
            { 153, new(153, "Gabriel", 243, 243, 243) },
            { 154, new(154, "Sraosha", 244, 244, 244) },
            { 155, new(155, "Raphael", 245, 245, 245) },
            { 156, new(156, "Sandalphon", 246, 246, 246) },
            { 157, new(157, "Uriel", 247, 247, 247) },
            { 158, new(158, "Camael", 248, 248, 248) },
            { 159, new(159, "Melchizedek", 249, 249, 249) },
            { 160, new(160, "Throne", 254, 254, 254) },
            { 161, new(161, "Dominion", 255, 255, 255) },
            { 162, new(162, "Power", 256, 256, 256) },
            { 163, new(163, "Principality", 257, 257, 257) },
            { 164, new(164, "Archangel", 258, 258, 258) },
            { 165, new(165, "Angel", 259, 259, 259) },
            { 166, new(166, "Abdiel", 264, 264, 264) },
            { 167, new(167, "Adramelech", 265, 265, 265) },
            { 168, new(168, "Flauros", 266, 266, 266) },
            { 169, new(169, "Nebiros", 267, 267, 267) },
            { 170, new(170, "Berith", 268, 268, 268) },
            { 171, new(171, "Ose", 269, 269, 269) },
            { 172, new(172, "Eligor", 270, 270, 270) },
            { 173, new(173, "Forneus", 271, 271, 271) },
            { 174, new(174, "Andras", 272, 272, 272) },
            { 175, new(175, "Decarabia", 273, 273, 273) },
            { 176, new(176, "Garuda", 278, 278, 278) },
            { 177, new(177, "Zhuque", 279, 279, 279) },
            { 178, new(178, "Yatagarasu", 280, 280, 280) },
            { 179, new(179, "Jatayu", 281, 281, 281) },
            { 180, new(180, "Feng Huang", 282, 282, 282) },
            { 181, new(181, "Thunderbird", 283, 283, 283) },
            { 182, new(182, "Anzu", 287, 287, 287) },
            { 183, new(183, "Zhen", 288, 288, 288) },
            { 184, new(184, "Muu Shuwuu", 289, 289, 289) },
            { 185, new(185, "Onmoraki", 290, 290, 290) },
            { 186, new(186, "Cleopatra", 295, 295, 295) },
            { 187, new(187, "Rangda", 296, 296, 296) },
            { 188, new(188, "Dakini", 297, 297, 297) },
            { 189, new(189, "Atropos", 298, 298, 298) },
            { 190, new(190, "Yakshini", 299, 299, 299) },
            { 191, new(191, "Lachesis", 300, 300, 300) },
            { 192, new(192, "Clotho", 301, 301, 301) },
            { 193, new(193, "Manananggal", 302, 302, 302) },
            { 194, new(194, "Lamia", 303, 303, 303) },
            { 195, new(195, "Mermaid", 304, 304, 304) },
            { 196, new(196, "Leanan Sidhe", 305, 305, 305) },
            { 197, new(197, "Ongyo-Ki", 310, 310, 310) },
            { 198, new(198, "Shiki-Ouji", 311, 311, 311) },
            { 199, new(199, "Sui-Ki", 312, 312, 312) },
            { 200, new(200, "Fuu-Ki", 313, 313, 313) },
            { 201, new(201, "Kin-Ki", 314, 314, 314) },
            { 202, new(202, "Azumi", 315, 315, 315) },
            { 203, new(203, "Ippon-Datara", 316, 316, 316) },
            { 204, new(204, "Daemon", 317, 317, 317) },
            { 205, new(205, "Oni", 318, 318, 318) },
            { 206, new(206, "Hecatoncheires", 322, 322, 322) },
            { 207, new(207, "Loa", 323, 323, 323) },
            { 208, new(208, "Rakshasa", 324, 324, 324) },
            { 209, new(209, "Turdak", 325, 325, 325) },
            { 210, new(210, "Macabre", 326, 326, 326) },
            { 211, new(211, "Kaya-no-Hime", 330, 330, 330) },
            { 212, new(212, "Tsuchigumo", 331, 331, 331) },
            { 213, new(213, "Narcissus", 332, 332, 332) },
            { 214, new(214, "Hua Po", 333, 333, 333) },
            { 215, new(215, "Koropokkur", 334, 334, 334) },
            { 216, new(216, "Sudama", 335, 335, 335) },
            { 217, new(217, "Kodama", 336, 336, 336) },
            { 218, new(218, "Pisaca", 341, 341, 341) },
            { 219, new(219, "Kumbhanda", 342, 342, 342) },
            { 220, new(220, "Poltergeist", 343, 343, 343) },
            { 221, new(221, "Obariyon", 344, 344, 344) },
            { 222, new(222, "Preta", 345, 345, 345) },
            { 223, new(223, "Trumpeter", 350, 350, 350) },
            { 224, new(224, "Mother Harlot", 351, 351, 351) },
            { 225, new(225, "Black Rider", 352, 352, 352) },
            { 226, new(226, "Red Rider", 353, 353, 353) },
            { 227, new(227, "White Rider", 354, 354, 354) },
            { 228, new(228, "Alice", 355, 355, 355) },
            { 229, new(229, "Hell Biker", 356, 356, 356) },
            { 230, new(230, "Daisoujou", 357, 357, 357) },
            { 231, new(231, "Pale Rider", 358, 358, 358) },
            { 232, new(232, "Matador", 359, 359, 359) },
            { 233, new(233, "Tao", 365, 365, 372 ) },
            { 234, new(234, "Shohei Yakumo", 465, 465, 377 ) },
            { 235, new(235, "Brimstone Star", 400, 531, 390) },
            { 236, new(236, "Cocytus Star", 401, 532, 391) },
            { 237, new(237, "Morning Star", 402, 533, 392) },
            { 238, new(238, "Lahmu's Tentacle", 403, 533, 394) },
            { 239, new(239, "Depraved Wing", 490, 527, 397) },
            { 240, new(240, "Depraved Arm", 491, 526, 396) },
            { 241, new(241, "Thunder Bit", 492, 521, 395) },
            { 242, new(242, "Tsukuyomi", 493, 528, 383 ) },
            { 243, new(243, "Lucifer", 494, 529, 385) },
            { 244, new(244, "Demi-fiend", 495, 536, 388) }
        };

        public static readonly IReadOnlyDictionary<int, string> DevilRaceNames = new Dictionary<int, string>()
        {
            { 0, "NOT USED:GROUP_ID_DUMMY" },
            { 1, "NOT USED:GROUP_ID_SHINREI" },
            { 2, "Herald" },
            { 3, "Megami" },
            { 4, "Avian" },
            { 5, "Divine" },
            { 6, "Yoma" },
            { 7, "Vile" },
            { 8, "Raptor" },
            { 9, "NOT USED:GROUP_ID_REIKEN" },
            { 10, "Deity" },
            { 11, "Wargod" },
            { 12, "Avatar" },
            { 13, "Holy" },
            { 14, "Genma" },
            { 15, "Element" },
            { 16, "Mitama" },
            { 17, "Fairy" },
            { 18, "Beast" },
            { 19, "Jirae" },
            { 20, "Fiend" },
            { 21, "Jaki" },
            { 22, "Wilder" },
            { 23, "Fury" },
            { 24, "Lady" },
            { 25, "Dragon" },
            { 26, "Kishin" },
            { 27, "Kunitsu" },
            { 28, "Femme" },
            { 29, "Brute" },
            { 30, "Fallen" },
            { 31, "Night" },
            { 32, "Snake" },
            { 33, "Tyrant" },
            { 34, "Drake" },
            { 35, "Haunt" },
            { 36, "Foul" },
            { 37, "King" },
            { 38, "NOT USED:GROUP_ID_DAIMAO" },
            { 39, "Meta" },
            { 40, "Nahobino" },
            { 41, "Proto-fiend" },
            { 42, "Matter" },
            { 43, "Panagia" }
        };
    }
}
