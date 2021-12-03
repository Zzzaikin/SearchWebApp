<template>
  <div>
    <v-card class="mx-auto" elevation="0" outlined>
      <v-card-text>
        <v-row class="ma-0 my-3" justify="space-between">
          <div class="application-title-wrapper">
            <span
              :title="title"
              class="text-h4 text--primary application-title"
              >{{ application.title }}</span
            >
            <p class="my-3 mt-7">
              <span class="parameter-title">Наличие пилотного проекта: </span>
              <span class="ml-2">{{ application.pilotProjectExists }}</span>
            </p>
            <p class="my-3 mt-7">
              <span class="parameter-title">Требуется ли сертификация: </span>
              <span class="ml-2">{{ application.certificationNeed }}</span>
            </p>
            <p class="my-3 mt-7">
              <span class="parameter-title">Есть ли пилотный проект: </span>
              <span class="ml-2">{{ application.pilotProjectExists }}</span>
            </p>
          </div>
          <div class="image image-pos">
            <v-img
              max-height="200"
              max-width="420"
              :src="
                application.imageSrc
                  ? application.imageSrc
                  : 'https://picsum.photos/id/11/500/300'
              "
            ></v-img>
          </div>
        </v-row>
        <div>
          <div class="parameters mt-1">
            <div class="mt-5">
              <p class="my-3">
                <CompleteStageSlider
                  class="mt-10"
                  :completeStage="application.completeStage"
                ></CompleteStageSlider>
              </p>
              <div class="wrapper">
                <div class="main-info">
                  <p class="my-3">
                    <span class="parameter-title">Краткое описание: </span>
                    <span class="ml-2">{{ application.shortDescription }}</span>
                  </p>
                  <p class="my-3">
                    <span class="parameter-title">Польза продукта: </span>
                    <span class="ml-2">{{ application.productBenefits }}</span>
                  </p>
                  <p>
                    <span class="parameter-title"
                      >Кейсы использования продукта:
                    </span>
                    <span class="ml-2">{{ application.useCases }}</span>
                  </p>
                  <h3 class="mt-10">Пилотный проект:</h3>
                  <p class="mt-5">
                    <span class="parameter-title">Название: </span>
                    <span class="ml-2">{{
                      application.pilotProject.title
                    }}</span>
                  </p>
                  <p class="mt-5">
                    <span class="parameter-title"
                      >Дата инициации проекта:
                    </span>
                    <span class="ml-2">{{
                      application.pilotProject.initDate
                    }}</span>
                  </p>
                  <p class="mt-5">
                    <span class="parameter-title"
                      >Команда пилотного проекта:
                    </span>
                    <span class="ml-2">{{
                      application.pilotProject.team
                    }}</span>
                  </p>
                  <p class="mt-5">
                    <span class="parameter-title"
                      >Субподрядная организация:
                    </span>
                    <span class="ml-2">{{
                      application.pilotProject.SubordinateOrganization
                    }}</span>
                  </p>
                  <p class="mt-5">
                    <span class="parameter-title">Стадия: </span>
                    <span class="ml-2">{{
                      application.pilotProject.state
                    }}</span>
                  </p>
                  <p class="mt-5">
                    <span class="parameter-title">Фаза: </span>
                    <span class="ml-2">{{
                      application.pilotProject.phase
                    }}</span>
                  </p>
                  <h3 class="mt-10">Юридическая информация:</h3>
                  <p class="mt-5">
                    <span class="parameter-title"
                      >Наименование юридического лица:
                    </span>
                    <span class="ml-2">{{ application.legalEntityName }}</span>
                  </p>
                  <p>
                    <span class="parameter-title">ИНН юридического лица: </span>
                    <span class="ml-2">{{ application.legalEntityINN }}</span>
                  </p>
                  <p>
                    <span class="parameter-title"
                      >Сколько человек в организации:
                    </span>
                    <span class="ml-2">{{ application.employeesCount }}</span>
                  </p>
                  <p>
                    <span class="parameter-title">Сайт: </span>
                    <span class="ml-2">{{ application.site }}</span>
                  </p>
                  <h3 class="mt-10">Контактная информация:</h3>
                  <p class="mt-5">
                    <span class="parameter-title"
                      >ФИО контактного лица по заявке:
                    </span>
                    <span class="ml-2">{{ application.contactFullName }}</span>
                  </p>
                  <p>
                    <span class="parameter-title"
                      >Должность контактного лица:
                    </span>
                    <span class="ml-2">{{ application.contactPosition }}</span>
                  </p>
                  <p>
                    <span class="parameter-title">Контактный телефон: </span>
                    <span class="ml-2">{{ application.contactPhone }}</span>
                  </p>
                  <p>
                    <span class="parameter-title">Контактная почта: </span>
                    <span class="ml-2">{{ application.contactEmail }}</span>
                  </p>
                  <p>
                    <span class="parameter-title">Контактная почта: </span>
                    <span class="ml-2">{{ application.contactEmail }}</span>
                  </p>
                </div>
              </div>
            </div>
          </div>
        </div>
      </v-card-text>
      <v-card-actions> </v-card-actions>
    </v-card>
  </div>
</template>

<script>
import CompleteStageSlider from "./CompleteStageSlider.vue";
import ContactCard from "./ContactCard.vue";
import Filters from "./Filters.vue";
export default {
  props: [
    "id",
    "title",
    "completeStage",
    "useCases",
    "certificationNeed",
    "pilotProjectExists",
    "productBenefits",
    "shortDescription",
    "application",
  ],
  components: { Filters, CompleteStageSlider },
  data: () => ({
    MAX_SYMBOLS: 120,
  }),
  methods: {
    goToApplication() {
      this.$router.push(`/application/${this.id}`);
    },
  },
};
</script>
<style scoped>
::v-deep .v-card__text {
  font-size: 18px !important;
  color: black !important;
}
.image {
  margin-left: 26px;
}
.wr {
  display: flex;
  flex-direction: row;
  margin-left: 12px;
}
.aa {
  max-height: 40px;
  max-width: 500px;
  text-overflow: ellipsis;
  white-space: nowrap;
  overflow: hidden;
}
.application-title {
  font-weight: 600;
}
.application-title-wrapper {
  width: 60%;
  text-overflow: ellipsis;
  white-space: nowrap;
  overflow: hidden;
}

.image-pos {
  float: left;
}
::v-deep .line {
  width: 200px !important ;
}

.main-info {
  margin-top: 50px;
}
</style>