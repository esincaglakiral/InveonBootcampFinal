import {createSlice} from "@reduxjs/toolkit";

const settingsSlice = createSlice({
    name :'settings',
    initialState : {
        cookie : false,
        stopCookie : false,
        promoCenter : false,
        promoStatus : false,
        stopPromo : false,
    },
    reducers
    : {
        stopPromo:(state)=> {
            state.stopPromo = true
        },
        //İşlevi: Bu reducer, stopPromo eylemi tetiklendiğinde çalışır.
        //Görevi: state içindeki stopPromo değerini true olarak ayarlar.
        //Kullanımı: Bu eylemi çağıran yer, promosyonları durdurma işlemi için kullanılır. 
        //Yani, kullanıcı bu ayarı etkinleştirdiğinde promosyonlar durdurulur.

        promoStatus :(state)=> {
            state.promoStatus = true
        },
        //Kullanıcının promosyon durumunu etkinleştirme amacını taşır. Belirli bir durumu temsil eder.

        promoCenter :(state) => {
            state.promoCenter = !state.promoCenter
        },
        //Görevi: state içindeki promoCenter değerini tersine çevirir (boolean değeri tersine çevirir).
        //Kullanımı: Kullanıcının promosyon merkezini açma veya kapama işlemi için kullanılır. Mevcut durumu tersine çevirir.
        
        
        stopCookie : (state) => {
            state.stopCookie = true
        },
        // Kullanıcı çerezleri durdurma ayarını etkinleştirdiğinde çalışır.

        cookie: (state) => {
            state.cookie = !state.cookie
        }
        //Kullanıcı çerezleri açma veya kapatma işlemi için kullanılır. Mevcut durumu tersine çevirir.
    }
})

const settingsReducer = settingsSlice.reducer  //Oluşturulan dilimi export ediyoruz ki bu dilimi Redux store'unun bir parçası yapabilelim.
export default settingsReducer