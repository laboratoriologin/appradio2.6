﻿//configuration
OAS_url = 'http://ads.globo.com/RealMedia/ads/';
OAS_listpos = 'Top,Frame1,Right,x07,x08. Middle';
OAS_query = '';
OAS_sitepage = 'afcbnbahia/home';
OAS_target = '_blank';
//end of configuration
OAS_version = 10;
OAS_rn = '001234567890'; OAS_rns = '1234567890';
OAS_rn = new String(Math.random()); OAS_rns = OAS_rn.substring(2, 11);
function OAS_NORMAL(pos) {
    document.write('<A HREF="' + OAS_url + 'click_nx.ads/' + OAS_sitepage + '/1' + OAS_rns + '@' + OAS_listpos + '!' + pos + OAS_query + '" TARGET=_top>');
    document.write('<IMG SRC="' + OAS_url + 'adstream_nx.ads/' + OAS_sitepage + '/1' + OAS_rns + '@' + OAS_listpos + '!' + pos + OAS_query + '" BORDER=0></A>');
}

OAS_version = 11;
if (navigator.userAgent.indexOf('Mozilla/3') != -1)
    OAS_version = 10;
if (OAS_version >= 11)
    document.write('<SCR' + 'IPT LANGUAGE=JavaScript1.1 SRC="' + OAS_url + 'adstream_mjx.ads/' + OAS_sitepage + '/1' + OAS_rns + '@' + OAS_listpos + OAS_query + '"><\/SCRIPT>');


document.write('');
function OAS_AD(pos) {
    if (OAS_version >= 11)
        OAS_RICH(pos);
    else
        OAS_NORMAL(pos);
}