import styles from './black_card_sale.module.css'
import CardPopup from '../card_popup/CardPopup'

import { memo, useRef, useState } from 'react'

import useViewOnScroll from 'src/hooks/useViewOnScroll'

const Black_card_sale = () => {
    const img_ref = useRef(null)
    const [img_view] = useViewOnScroll(img_ref)
    const [isPopupOpen, setPopupOpen] = useState(false)
    return (
        <>
            <div className={styles.card} onClick={() => setPopupOpen(true)}>
                <h1 className={styles.title}>Блинчики с ягодами и инжиром </h1>
                <img ref={img_ref} className={`${styles.bookmark} ${img_view && styles.active}`} src="/акция2.svg" alt="" />
                <div className={styles.img_container}>
                    <div className={styles.img_border}>
                        <img className={styles.img_pancake} src="/pancake1.png" />
                    </div>
                </div>

                <div className={styles.info_container}>
                    <div className={styles.price_container}>
                        <span className={styles.price}>333</span>
                    </div>
                    <div className={styles.info_block}>
                        <h3 className={styles.kilos}>512</h3>
                        <h3 className={styles.gram}>300</h3>
                    </div>
                </div>
            </div>
            <CardPopup isPopupOpen={isPopupOpen} setPopupOpen={setPopupOpen}></CardPopup>
        </>
    )
}
// eslint-disable-next-line react-refresh/only-export-components
export default memo(Black_card_sale)
