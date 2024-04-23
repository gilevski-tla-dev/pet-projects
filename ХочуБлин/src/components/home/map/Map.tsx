// import FillStar from '../../ui/FillStar'
// import Star from '../../ui/Star'
import styles from './map.module.css'

const Map = () => {
    return (
        <div className={styles.wrapper}>
            <div className={styles.content_wrapper}>
                <h2 className={styles.title}>Как нас найти?</h2>
                <div className={styles.map}>
                    {/* <div className={`${styles.star_wrapper} ${styles.star_1}`}>
                        <Star stroke="#FFE500" />
                    </div>
                    <div className={`${styles.star_wrapper} ${styles.star_2}`}>
                        <Star stroke="#FFE500" />
                    </div> */}
                    <iframe style={{ zIndex: 1 }} src="https://yandex.ru/map-widget/v1/?from=mapframe&ll=20.502066%2C54.669234&mode=poi&poi%5Buri%5D=ymapsbm1%3A%2F%2Fgeo%3Fdata%3DCgg1NjIxODY5NBJX0KDQvtGB0YHQuNGPLCDQmtCw0LvQuNC90LjQvdCz0YDQsNC0LCDQmNC90YLQtdGA0L3QsNGG0LjQvtC90LDQu9GM0L3QsNGPINGD0LvQuNGG0LAsIDQxIgoNFQikQRXvrVpC&source=mapframe&utm_source=mapframe&z=17"></iframe>
                </div>
                <div className={styles.link_wrapper}>
                    <div className={styles.link_block}>
                        <a target="_blank" href="https://yandex.ru/map-widget/v1/?from=mapframe&ll=20.502066%2C54.669234&mode=poi&poi%5Buri%5D=ymapsbm1%3A%2F%2Fgeo%3Fdata%3DCgg1NjIxODY5NBJX0KDQvtGB0YHQuNGPLCDQmtCw0LvQuNC90LjQvdCz0YDQsNC0LCDQmNC90YLQtdGA0L3QsNGG0LjQvtC90LDQu9GM0L3QsNGPINGD0LvQuNGG0LAsIDQxIgoNFQikQRXvrVpC&source=mapframe&utm_source=mapframe&z=17" className={styles.link}>
                            открыть карту &#8594;
                        </a>
                        {/* <div className={`${styles.link_star} ${styles.link_star_1}`}>
                            <FillStar stroke="black" fill="#C190FF" />
                        </div>
                        <div className={`${styles.link_star} ${styles.link_star_2}`}>
                            <FillStar stroke="black" fill="#C190FF" />
                        </div> */}
                    </div>
                </div>
            </div>
        </div>
    )
}
export default Map
