import styles from './header.module.css'
import { Link, useLocation } from 'react-router-dom'
import { memo, useContext, useEffect, useRef, useState } from 'react'
import { IScrollContext, ScrollContext } from 'src/provider/ScrollProvider'

const Header = () => {
    const { scroll } = useContext(ScrollContext) as IScrollContext
    const [hide_header, setHideHeader] = useState(true)
    const scroll_ref = useRef<HTMLDivElement>(null)
    const [prev_scroll, setPrevScroll] = useState(0)

    useEffect(() => {
        setHideHeader(scroll > 114 && scroll > prev_scroll)
        setPrevScroll(scroll)
    }, [scroll])

    const check = (url: string) => localtion.pathname.includes(url)

    const localtion = useLocation()

    useEffect(() => {
        const scroll_current = scroll_ref.current
        const menuScroll = (e: WheelEvent) => {
            e.preventDefault()
            const scroll_x = e.deltaY || e.detail
            if (scroll_current) scroll_current.scrollBy({ left: scroll_x * 7, behavior: 'smooth' })
        }

        if (scroll_current) scroll_current.addEventListener('wheel', menuScroll, { passive: false })

        return () => {
            if (scroll_current) scroll_current.removeEventListener('wheel', menuScroll, { passive: false } as any)
        }
    }, [])

    return (
        <header className={`${hide_header && styles.hide} ${styles.header}`}>
            <div className={styles.content}>
                <div className={styles.top_part}>
                    <div>
                        <Link to="/">
                            <h1 className={styles.logo}>
                                Хочу Блин <span>ФРИ</span>
                            </h1>
                        </Link>
                    </div>

                    <div className={styles.menu}>
                        <img className={styles.icon1} src="/logo_orange.png" alt="" />
                    </div>
                </div>
                <div className={styles.bottom_part}>
                    <Link className={`${styles.menu_link} ${check('/menu') && styles.left}  ${localtion.pathname === '/' && styles.active} ${!check('/menu') && styles.all}`} to={'/'}>
                        Главная
                    </Link>
                    <Link className={`${styles.menu_link} ${check('/menu') && styles.active} ${check('/contacts') && styles.off}`} to={'/menu/all'}>
                        Меню
                    </Link>
                    <Link className={`${styles.menu_link} ${check('/contacts') && styles.active} ${check('/job') && styles.off} `} to={'/contacts'}>
                        Контакты
                    </Link>
                    <Link className={`${styles.menu_link} ${check('/contacts') && styles.right}  ${check('/job') && styles.active}`} to={'/job'}>
                        Вакансии
                    </Link>
                </div>
                {localtion.pathname.includes('/menu') && (
                    <div className={`${styles.bottom_part} ${styles.scroll}`} ref={scroll_ref} onScroll={event => event.stopPropagation()}>
                        <div className={styles.scroll_wrapper}>
                            <Link className={`${styles.menu_link} ${check('/crepe') && styles.left}  ${check('/all') && styles.active} ${!check('/crepe') && styles.all}`} to={'/menu/all'}>
                                Все
                            </Link>
                            <Link className={`${styles.menu_link} ${check('/drinks') && styles.off} ${check('/crepe') && styles.active}`} to={'/menu/crepe'}>
                                Блины
                            </Link>
                            <Link className={`${styles.menu_link} ${check('/buns') && styles.off} ${check('/drinks') && styles.active}`} to={'/menu/drinks'}>
                                Напитки
                            </Link>
                            <Link className={`${styles.menu_link} ${check('/kurasany') && styles.off} ${check('/buns') && styles.active}`} to={'/menu/buns'}>
                                Булочки
                            </Link>
                            <Link className={`${styles.menu_link} ${check('/pancakes') && styles.off} ${check('/kurasany') && styles.active} `} to={'/menu/kurasany'}>
                                Курасаны
                            </Link>
                            <Link className={`${styles.menu_link} ${check('/kurasany') && styles.right}  ${check('/pancakes') && styles.active}`} to={'/menu/pancakes'}>
                                Панкейки
                            </Link>
                        </div>
                    </div>
                )}
            </div>
        </header>
    )
}
export default memo(Header)
